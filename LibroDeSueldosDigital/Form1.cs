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
        string CarpetaBusqueda;
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
            OpenFileDialog Legajo = new OpenFileDialog();
            //si la carpeta fue elegida
            if (Legajo.ShowDialog()==DialogResult.OK)
            {
                //carpeta seleccionada
                CarpetaBusqueda = Legajo.FileName;
                TBlegajos.Text = CarpetaBusqueda;
                
                MetroFramework.MetroMessageBox.Show(this, "Seleccionado", "Informacion", MessageBoxButtons.OK);
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Rec_cpo = new OpenFileDialog();
            //si la carpeta fue elegida
            if (Rec_cpo.ShowDialog() == DialogResult.OK)
            {
                //carpeta seleccionada
                CarpetaBusqueda = Rec_cpo.FileName;
                TBREC_CPO.Text = CarpetaBusqueda;
               
                MetroFramework.MetroMessageBox.Show(this, "Seleccionado", "Informacion",MessageBoxButtons.OK);
            }
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    pnl1.Visible = false;
            //    string cadena = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = "+ TBlegajos.Text + ";Extended Properties = dBase IV; User ID=;Password=;";
            //    OleDbConnection con = new OleDbConnection();
            //    con.ConnectionString = cadena;
            //    con.Open();
            //    string consulta = "select * from legajos";
            //    OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, con);
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds);
            //    con.Close();
            //    this.dataGridView1.DataSource = ds.Tables[0];
            //    this.dataGridView1.Visible = true;
            //}
            //catch (OleDbException exp)
            //{

            //    MetroFramework.MetroMessageBox.Show(this, exp.Message, "Error", MessageBoxButtons.OK);
            //}

     
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=: C:\\Users\\emmanueljulio\\Desktop\\;Extended Properties=DBASE IV;");
        conn.Open();
     string sqlStr = "Select * from LEGAJOS.DBF";
    //Make a DataSet object
             DataSet myDataSet = new DataSet();
            //Using the OleDbDataAdapter execute the query
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlStr, conn);
            //Build the Update and Delete SQL Statements
            adapter.Fill(myDataSet);
            conn.Close();
            this.dataGridView1.DataSource = myDataSet.Tables[0];
           this.dataGridView1.Visible = true;
        }
    }
}
