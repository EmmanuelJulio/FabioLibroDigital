using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Data.OleDb;

namespace LibroDeSueldosDigital
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
       public string CarpetaBusquedaLeg;
        public string CarpetaBusquedaREC;
       // List<int> ListaLegajos = new List<int>;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            MetroTabControl.TabPages[1].BackColor = Color.Gray;
            MetroTabControl.SelectedTab = MetroTabControl.TabPages[0];
        }

        private void MetroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            //creo cuadro de selecion
            FolderBrowserDialog Legajo = new FolderBrowserDialog();
            //si la carpeta fue elegida
            if (Legajo.ShowDialog()==DialogResult.OK)
            {
                //carpeta seleccionada
                CarpetaBusquedaLeg = Legajo.SelectedPath;
                TBlegajos.Text = CarpetaBusquedaLeg;
                
                MetroFramework.MetroMessageBox.Show(this, "Seleccionado", "Informacion", MessageBoxButtons.OK);
                try
                {

                    //legajos
                    string cadena = "Provider=Microsoft.Jet.OLEDB.4.0" + "; Data Source =" + CarpetaBusquedaLeg + ";Extended Properties=dBASE IV; User ID=;Password=;";
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = cadena;
                    con.Open();
                    string consulta = "select * from legajos order by legajo ";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, con);
                    //DataSet ds = new DataSet();
                    adapter.Fill(Legajos);
                    con.Close();
                    dataGridView1.DataSource = Legajos.Tables[0];
                    //Rec_cpo
                    string cadena2 = "Provider=Microsoft.Jet.OLEDB.4.0" + "; Data Source =" + CarpetaBusquedaLeg + ";Extended Properties=dBASE IV; User ID=;Password=;";
                    OleDbConnection con2 = new OleDbConnection();
                    con.ConnectionString = cadena;
                    con.Open();
                    string consulta2 = "select * from REC_CPO order by legajo ";
                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(consulta2, con);
                    //DataSet ds2 = new DataSet();
                    adapter2.Fill(REC_CPO);
                    con.Close();
                    dataGridView2.DataSource = REC_CPO.Tables[0];

                    metroTabControl1.Visible = true;
                    salirverif.Visible = true;
                    NextStep1.Visible = true;
                }
                catch (OleDbException exp)
                {
                    pnl1.Visible = true;
                    MetroFramework.MetroMessageBox.Show(this, exp.Message, "Error", MessageBoxButtons.OK);
                }



            }
        }

        

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                
                //legajos
                string cadena = "Provider=Microsoft.Jet.OLEDB.4.0"+"; Data Source ="+ CarpetaBusquedaLeg + ";Extended Properties=dBASE IV; User ID=;Password=;";
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = cadena;
                con.Open();
                string consulta = "select * from legajos order by legajo ";
                OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, con);
                //DataSet ds = new DataSet();
                adapter.Fill(Legajos);
                con.Close();
                dataGridView1.DataSource = Legajos.Tables[0];
                //Rec_cpo
                string cadena2 = "Provider=Microsoft.Jet.OLEDB.4.0" + "; Data Source =" + CarpetaBusquedaLeg + ";Extended Properties=dBASE IV; User ID=;Password=;";
                OleDbConnection con2 = new OleDbConnection();
                con.ConnectionString = cadena;
                con.Open();
                string consulta2 = "select * from REC_CPO order by legajo ";
                OleDbDataAdapter adapter2 = new OleDbDataAdapter(consulta2, con);
                //DataSet ds2 = new DataSet();
                adapter2.Fill(REC_CPO);
                con.Close();
                dataGridView2.DataSource = REC_CPO.Tables[0];

                metroTabControl1.Visible = true;
                salirverif.Visible = true;
                NextStep1.Visible = true;
            }
            catch (OleDbException exp)
            {
                pnl1.Visible = true;
                MetroFramework.MetroMessageBox.Show(this, exp.Message, "Error", MessageBoxButtons.OK);
            }


          
        }
        public void corregirString(string Corregir)
        {
            //foreach (char Letra in Corregir)
            //{
            //    if(Letra.)
            //}
        }

        private void Salirverif_Click(object sender, EventArgs e)
        {
            metroTabControl1.Visible = false;
            TBlegajos.Text = "";
            pnl1.Visible = true;
        }

        private void TBlegajos_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NextStep1_Click(object sender, EventArgs e)
        {
            MetroTabControl.SelectedTab = MetroTabControl.TabPages[1];
            DataTable _legajos = Legajos.Tables["legajos"];
            metroTabControl2.SelectedTab = metroTabControl2.TabPages[0];
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyyMM";

        }
        

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Registro1 Reg = new Registro1(Tbx_cuit.Text, comboBox1.SelectedItem.ToString(), año.Text + mes.Text, comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString());
             
            }
            catch (Exception er)
            {

               MetroFramework.MetroMessageBox.Show(this,"Recuerde completar todos los campos ,Error:"+ er.Message);
            }
           
        }
        public void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {

                    if (char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }

                    
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void ControlTexto(MetroFramework.Controls.MetroTextBox TBox,int cantidad,KeyPressEventArgs e)
        {
            if (TBox.Text.Length == cantidad)
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MetroFramework.MetroMessageBox.Show(this, "Se alcanzo el limite maximo :"+cantidad.ToString(), "Aviso de Desbordamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                
            }

            
        }
        private void Tbx_cuit_KeyPress(object sender, KeyPressEventArgs e)
       {
            SoloNumeros(e);
            ControlTexto(Tbx_cuit, 11, e);
        }

        private void Mes_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
            ControlTexto(mes, 2, e);
        }

        private void Año_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
            ControlTexto(año, 4, e);
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Registro1 Reg = new Registro1(Tbx_cuit.Text, comboBox1.SelectedItem.ToString(), año.Text + mes.Text, comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString());
                TXT_Final.Text += Reg.VerCadena() + "\r\n";
                DataSet ds = GetLegajos();
                var result = from legajos in ds.Tables["legajos"].AsEnumerable()
                             select new
                             {
                                 Nlegajo = legajos[1]
                             };

                foreach (var p in result)
                {

                    //ListaLegajos.Add(Convert.ToInt32(p.Nlegajo));
                    comboBox7.Items.Add(p.Nlegajo);
                }
                metroTabControl2.SelectedTab = metroTabControl2.TabPages[1];


            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Recuerde completar todos los campos ", "Complete los campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           

        }
        DataSet GetLegajos()
        {
            string cadena = "Provider=Microsoft.Jet.OLEDB.4.0" + "; Data Source =" + CarpetaBusquedaLeg + ";Extended Properties=dBASE IV; User ID=;Password=;";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = cadena;
            con.Open();
            string consulta = "select * from legajos order by legajo ";
            OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, con);
            //DataSet ds = new DataSet();
            adapter.Fill(Legajos,"Legajos");
            con.Close();
            return Legajos;
        }
        DataSet GetConceptos()
        {
            string cadena2 = "Provider=Microsoft.Jet.OLEDB.4.0" + "; Data Source =" + CarpetaBusquedaLeg + ";Extended Properties=dBASE IV; User ID=;Password=;";
            OleDbConnection con2 = new OleDbConnection();
            con2.ConnectionString = cadena2;
            con2.Open();
            string consulta2 = "select * from REC_CPO order by legajo ";
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(consulta2, con2);
            //DataSet ds2 = new DataSet();
            adapter2.Fill(REC_CPO);
            con2.Close();
            return REC_CPO;
        }
        private void MetroButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void TraerDatosPersona(int numero)
        {
            if (dataGridView3.Rows.Count > 0)
            {
                
                dataGridView3.Rows.Clear();
                dataGridView3.Refresh();
            }
            double valor = Convert.ToDouble(numero);


            DataSet ds = Legajos;
            var query = from legajos in ds.Tables["Legajos"].AsEnumerable()
                        where legajos.Field<double>("legajo") == valor 
                        select new
                        {
                            Nlegajo = legajos[1],
                            nombre = legajos[2],
                            cuil = legajos[6],
                            dire = legajos[9],
                            Categoria = legajos[20],
                        };


            DataSet ds2 = REC_CPO;

            var query2 = from legajos in ds2.Tables[0].AsEnumerable()
                         where legajos.Field<double>("LEGAJO") == valor && legajos.Field<String>("LIQ") == comboBox4.Text
                         select new
                         {


                             Concepto = legajos[3],//codigo de concepto
                             Detalle = legajos[4],//detalle de concepto
                             Unidad = legajos[5],//unidades de concepto
                             Remuneracion = legajos[7],//remuneracion
                            Descuento = legajos[8]//descuento
                        };
            foreach (var leg in query)
            {
                Legajo_txt.Text = leg.Nlegajo.ToString();
                CUIT_txt.Text = leg.cuil.ToString();
                Nombre_TXT.Text = leg.nombre.ToString();
                direccion_txt.Text = leg.dire.ToString();
                Ocupacion_txt.Text = leg.Categoria.ToString();
            }
          
            
           
            int fila = 0;
            foreach (var concepto in query2)
            {
                dataGridView3.Rows.Add();
                dataGridView3.Rows[fila].Cells[0].Value = CUIT_txt.Text;
                dataGridView3.Rows[fila].Cells[1].Value = concepto.Concepto;
                dataGridView3.Rows[fila].Cells[2].Value = concepto.Detalle;
                dataGridView3.Rows[fila].Cells[3].Value = concepto.Unidad;
                dataGridView3.Rows[fila].Cells[5].Value = concepto.Remuneracion;
                dataGridView3.Rows[fila].Cells[6].Value = concepto.Descuento;
                fila++;

            }
            fila = 0;

            
        }
        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            TraerDatosPersona(Convert.ToInt32(comboBox7.SelectedItem));
        }

        private void MetroButton6_Click(object sender, EventArgs e)
        {
            comboBox7.SelectedIndex = comboBox7.SelectedIndex + 1;
        }

        private void MetroButton5_Click(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex>0)
            {
                comboBox7.SelectedIndex = comboBox7.SelectedIndex - 1;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "No se puede ir mas atras");
            }
            
        }

        private void Direccion_txt_Click(object sender, EventArgs e)
        {

        }

       

        private void MetroButton9_Click(object sender, EventArgs e)
        {
            Tbx_cuit.Text = "30506269845";
            comboBox1.SelectedIndex = 1;
            mes.Text = (11).ToString();
            año.Text = (2019).ToString();
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 1;
        }

        private void MetroButton7_Click_1(object sender, EventArgs e)
        {
            try
            {
                Registro2 Reg2 = new Registro2(Convert.ToInt64(CUIT_txt.Text), Convert.ToInt32(Legajo_txt.Text), metroDateTime1.Value.Year.ToString() + metroDateTime1.Value.Month.ToString() + metroDateTime1.Value.Day.ToString(), metroDateTime2.Value.Year.ToString() + metroDateTime2.Value.Month.ToString() + metroDateTime2.Value.Day.ToString());
                TXT_Final.Text += Reg2.Cadena2;
                label15.Text = Reg2.Cadena2.Length.ToString();
                int fila = 1;
                int Columna = 0;
                foreach (DataGridViewRow Datos in dataGridView3.Rows)
                {
                    int valor;
                    if (Convert.ToInt32(Datos.Cells["Importe"].Value) != 0)
                    {
                        valor = Convert.ToInt32(Datos.Cells["Importe"].Value);
                    }
                    else
                    {
                        valor = Math.Abs(Convert.ToInt32(Datos.Cells["Descuentos"].Value));
                    }

                    Registro3 Reg3 = new Registro3(Convert.ToInt64(Datos.Cells["Cuil"].Value), Datos.Cells["CodigoConcepto"].Value.ToString(), Math.Abs(Convert.ToInt32(Datos.Cells["Cantidad"].Value.ToString())), Datos.Cells["Unidades"].Value.ToString(), Math.Abs(valor), Datos.Cells["DebitoCredito"].Value.ToString(), año.Text + mes.Text);
                    TXT_Final.Text += Reg3.Cadena3 + "\r\n";


                }
                MetroFramework.MetroMessageBox.Show(this, "Reguistro de " + Nombre_TXT.Text + " Fue procesado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox7.SelectedIndex += 1;
                while (dataGridView3.Rows.Count == 0)
                {
                    comboBox7.SelectedIndex += 1;
                }
                metroTabControl2.SelectedTab = metroTabControl2.TabPages[2];
            }
            catch (Exception er)
            {

                MetroFramework.MetroMessageBox.Show(this, "Reguistro de " + Nombre_TXT.Text + "No fue procesado Error: "+er.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void MetroDateTime2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text != "")
            {
                comboBox7.Enabled = true;
                metroButton5.Enabled = true;
                metroButton6.Enabled = true; 
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Seleccione primero el periodo que va a liquidar pls ", "Recuerde...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            Registro4 reg4 = new Registro4();
            reg4.Cuil = r2.Text;
            reg4.Conyugue = r3.Text;
            reg4.CantHijos = r4.Text;
            reg4.MarcaCCT1 = r5.Text;
            reg4.MarcaSCVO1 = r6.Text;
            reg4.MarcaCorrespondeReduccion1 = r6.Text;
            reg4.TipoEmpresa1 = r7.Text;
            reg4.TipoOperacion1 = r8.Text;
            reg4.CodigoSituacion1 = r9.Text;
            reg4.CodigoCondicion1 = r10.Text;
            reg4.CodigoActividad1 = r11.Text;
            reg4.CodigoModalidadDeContratacion1 = r12.Text;
            reg4.CodigoSiniestrado1 = r13.Text;
            reg4.CodigoDeLocalidad1 = r14.Text;
            reg4.SituacionDeRevista11 = r15.Text;
            reg4.DiaInicioSituacionDeRevista11 = r16.Text;
            reg4.SituacionDeRevista21 = r17.Text;
            reg4.DiaInicioSituacionDeRevista21 = r18.Text;
            reg4.SituacionDeRevista31 = r19.Text;
            reg4.DiaInicioSituacionDeRevista31 = r20.Text;
            reg4.CantDiasTrabajados1 = r21.Text;
            reg4.HorasTrabajadas1 = r22.Text;
            reg4.Porcentajeaporteadiccionalss = r23.Text;
            reg4.Contribuciondiferencial = r24.Text;
            reg4.Codigoobrasocial1 = r25.Text;
            reg4.Cantidadahderentes = r26.Text;
            reg4.AporteadicionalOs = r27.Text;
            reg4.ContribucionadicionalOS = r28.Text;
            reg4.BasecalculodiferencialaportesOSyFSR1 = r29.Text;
            reg4.BaseCalculoDiferencialLRT1 = r30.Text;
            reg4.RemuneracionMaternidadANSES1 = r31.Text;
            reg4.RemuneracionBruta1 = r32.Text;
            reg4.BaseImponible11 = r33.Text;
            reg4.BaseImponible21 = r34.Text;
            reg4.BaseImponible31 = r35.Text;
            reg4.BaseImponible41 = r36.Text;
            reg4.BaseImponible51 = r37.Text;
            reg4.BaseImponible61 = r38.Text;
            reg4.BaseImponible71 = r39.Text;
            reg4.BaseImponible81 = r40.Text;
            reg4.BaseImponible91 = r41.Text;
            reg4.BaseParaElcalculodifdeaportesDeSegSocial1 = r42.Text;
            reg4.BaseParaElcalculodifDeContribucionesDeSegSocial1 = r43.Text;
            reg4.BaseImponible101 = r44.Text;
            reg4.ImporteAdetraer1 = r45.Text;
            reg4.CrearCadena();
            label61.Text = reg4.Cadena04;

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            r2.Text ="1";
            r3.Text = "2";
            r4.Text = "3";
            r5.Text = "4";
            r6.Text = "5";
            r6.Text = "6";
            r7.Text = "7";
            r8.Text = "8";
            r9.Text = "9";
            r10.Text = "10";
            r11.Text = "11";
            r12.Text = "12";
            r13.Text = "13";
            r14.Text = "14";
            r15.Text = "15";
            r16.Text = "16";
            r17.Text = "17";
            r18.Text = "18";
            r19.Text = "19";
            r20.Text = "20";
            r21.Text = "21";
            r22.Text = "22";
            r23.Text = "23";
            r24.Text = "24";
            r25.Text = "25";
            r26.Text = "26";
            r27.Text = "27";
            r28.Text = "28";
            r29.Text = "29";
            r30.Text = "30";
            r31.Text = "31";
            r32.Text = "32";
            r33.Text = "33";
            r34.Text = "34";
            r35.Text = "35";
            r36.Text = "36";
            r37.Text = "37";
            r38.Text = "38";
            r39.Text = "39";
            r40.Text="40";
            r41.Text = "41";
            r42.Text = "42";
            r43.Text = "43";
            r44.Text = "44";
            r45.Text = "45";
        }
    }
}

