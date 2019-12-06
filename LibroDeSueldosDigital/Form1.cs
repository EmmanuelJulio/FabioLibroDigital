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
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            MetroTabControl.TabPages[1].BackColor = Color.Gray;
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
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Rec_cpo = new FolderBrowserDialog();
            //si la carpeta fue elegida
            if (Rec_cpo.ShowDialog() == DialogResult.OK)
            {
                //carpeta seleccionada
                CarpetaBusquedaREC = Rec_cpo.SelectedPath;
                TBREC_CPO.Text = CarpetaBusquedaREC;
               
                MetroFramework.MetroMessageBox.Show(this, "Seleccionado", "Informacion",MessageBoxButtons.OK);
            }
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                pnl1.Visible = false;
                //legajos
                string cadena = "Provider=Microsoft.Jet.OLEDB.4.0"+"; Data Source ="+ CarpetaBusquedaLeg + ";Extended Properties=dBASE IV; User ID=;Password=;";
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = cadena;
                con.Open();
                string consulta = "select * from legajos";
                OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                con.Close();
                this.dataGridView1.DataSource = ds.Tables[0];
                //Rec_cpo
                string cadena2 = "Provider=Microsoft.Jet.OLEDB.4.0" + "; Data Source =" + CarpetaBusquedaREC + ";Extended Properties=dBASE IV; User ID=;Password=;";
                OleDbConnection con2 = new OleDbConnection();
                con.ConnectionString = cadena;
                con.Open();
                string consulta2 = "select * from REC_CPO";
                OleDbDataAdapter adapter2 = new OleDbDataAdapter(consulta, con);
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2);
                con.Close();
                this.dataGridView2.DataSource = ds2.Tables[0];

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
    }
}
