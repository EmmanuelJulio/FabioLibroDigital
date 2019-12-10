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
                
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Recuerde completar todos los campos ", "Complete los campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
                            legajo = legajos[0],
                            Recibo=legajos[1],
                            Quincena = legajos[2],
                            Concepto = legajos[3],
                            Detalle = legajos[4],
                            Unidad = legajos[5],
                            Valor = legajos[6],
                            Remuneracion = legajos[7]
                        };
            foreach (var leg in query)
            {
                Legajo_txt.Text = leg.Nlegajo.ToString();
                CUIT_txt.Text = leg.cuil.ToString();
                Nombre_TXT.Text = leg.nombre.ToString();
                direccion_txt.Text = leg.dire.ToString();
                Ocupacion_txt.Text = leg.Categoria.ToString();
            }
            //int fila = 1;
            //int columna = 0;
            //foreach (var concepto in query2)
            //{
            //    dataGridView3.Rows.Add();
            //    dataGridView3.
            //}

            dataGridView3.DataSource = query2.ToList();
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
            Registro2 Reg2 = new Registro2(Convert.ToInt64(CUIT_txt.Text), Convert.ToInt32(Legajo_txt.Text), metroDateTime1.Value.Year.ToString()+ metroDateTime1.Value.Month.ToString()+ metroDateTime1.Value.Day.ToString(), metroDateTime2.Value.Year.ToString() + metroDateTime2.Value.Month.ToString() + metroDateTime2.Value.Day.ToString());
            TXT_Final.Text += Reg2.Cadena2;
            label15.Text = Reg2.Cadena2.Length.ToString();
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
    }
}
