namespace LibroDeSueldosDigital
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MetroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.TBREC_CPO = new MetroFramework.Controls.MetroTextBox();
            this.TBlegajos = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Edicion = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.Legajos = new System.Data.DataSet();
            this.REC_CPO = new System.Data.DataSet();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.salirverif = new MetroFramework.Controls.MetroButton();
            this.NextStep1 = new MetroFramework.Controls.MetroButton();
            this.MetroTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Legajos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REC_CPO)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // MetroTabControl
            // 
            this.MetroTabControl.Controls.Add(this.metroTabPage1);
            this.MetroTabControl.Controls.Add(this.Edicion);
            this.MetroTabControl.Controls.Add(this.metroTabPage3);
            this.MetroTabControl.Location = new System.Drawing.Point(23, 63);
            this.MetroTabControl.Name = "MetroTabControl";
            this.MetroTabControl.SelectedIndex = 0;
            this.MetroTabControl.Size = new System.Drawing.Size(1199, 523);
            this.MetroTabControl.TabIndex = 1;
            this.MetroTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroTabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTabPage1.Controls.Add(this.NextStep1);
            this.metroTabPage1.Controls.Add(this.salirverif);
            this.metroTabPage1.Controls.Add(this.metroTabControl1);
            this.metroTabPage1.Controls.Add(this.pnl1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1191, 481);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Seleccion";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.MetroTabPage1_Click);
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.metroButton3);
            this.pnl1.Controls.Add(this.TBREC_CPO);
            this.pnl1.Controls.Add(this.TBlegajos);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.metroButton2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.metroButton1);
            this.pnl1.Location = new System.Drawing.Point(205, 142);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(780, 197);
            this.pnl1.TabIndex = 5;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(298, 159);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(151, 25);
            this.metroButton3.TabIndex = 10;
            this.metroButton3.Text = "Hecho!";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.MetroButton3_Click);
            // 
            // TBREC_CPO
            // 
            // 
            // 
            // 
            this.TBREC_CPO.CustomButton.Image = null;
            this.TBREC_CPO.CustomButton.Location = new System.Drawing.Point(358, 1);
            this.TBREC_CPO.CustomButton.Name = "";
            this.TBREC_CPO.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBREC_CPO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBREC_CPO.CustomButton.TabIndex = 1;
            this.TBREC_CPO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBREC_CPO.CustomButton.UseSelectable = true;
            this.TBREC_CPO.CustomButton.Visible = false;
            this.TBREC_CPO.Lines = new string[] {
        "Buscar"};
            this.TBREC_CPO.Location = new System.Drawing.Point(26, 109);
            this.TBREC_CPO.MaxLength = 32767;
            this.TBREC_CPO.Name = "TBREC_CPO";
            this.TBREC_CPO.PasswordChar = '\0';
            this.TBREC_CPO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBREC_CPO.SelectedText = "";
            this.TBREC_CPO.SelectionLength = 0;
            this.TBREC_CPO.SelectionStart = 0;
            this.TBREC_CPO.ShortcutsEnabled = true;
            this.TBREC_CPO.Size = new System.Drawing.Size(380, 23);
            this.TBREC_CPO.TabIndex = 9;
            this.TBREC_CPO.Text = "Buscar";
            this.TBREC_CPO.UseSelectable = true;
            this.TBREC_CPO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBREC_CPO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TBlegajos
            // 
            // 
            // 
            // 
            this.TBlegajos.CustomButton.Image = null;
            this.TBlegajos.CustomButton.Location = new System.Drawing.Point(358, 1);
            this.TBlegajos.CustomButton.Name = "";
            this.TBlegajos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBlegajos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBlegajos.CustomButton.TabIndex = 1;
            this.TBlegajos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBlegajos.CustomButton.UseSelectable = true;
            this.TBlegajos.CustomButton.Visible = false;
            this.TBlegajos.Lines = new string[] {
        "Buscar"};
            this.TBlegajos.Location = new System.Drawing.Point(26, 48);
            this.TBlegajos.MaxLength = 32767;
            this.TBlegajos.Name = "TBlegajos";
            this.TBlegajos.PasswordChar = '\0';
            this.TBlegajos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBlegajos.SelectedText = "";
            this.TBlegajos.SelectionLength = 0;
            this.TBlegajos.SelectionStart = 0;
            this.TBlegajos.ShortcutsEnabled = true;
            this.TBlegajos.Size = new System.Drawing.Size(380, 23);
            this.TBlegajos.TabIndex = 8;
            this.TBlegajos.Text = "Buscar";
            this.TBlegajos.UseSelectable = true;
            this.TBlegajos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBlegajos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione el archivo \"REC_CPO\"";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(467, 108);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(151, 25);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Buscar REC_CPO";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione el archivo \"legajos\"";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(467, 47);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(151, 25);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Buscar legajos";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // Edicion
            // 
            this.Edicion.CausesValidation = false;
            this.Edicion.HorizontalScrollbarBarColor = true;
            this.Edicion.HorizontalScrollbarHighlightOnWheel = false;
            this.Edicion.HorizontalScrollbarSize = 10;
            this.Edicion.Location = new System.Drawing.Point(4, 38);
            this.Edicion.Name = "Edicion";
            this.Edicion.Size = new System.Drawing.Size(1191, 481);
            this.Edicion.TabIndex = 1;
            this.Edicion.Text = "Edicion";
            this.Edicion.VerticalScrollbarBarColor = true;
            this.Edicion.VerticalScrollbarHighlightOnWheel = false;
            this.Edicion.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1191, 481);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Exportacion";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // Legajos
            // 
            this.Legajos.DataSetName = "NewDataSet";
            // 
            // REC_CPO
            // 
            this.REC_CPO.DataSetName = "NewDataSet";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1185, 441);
            this.metroTabControl1.TabIndex = 6;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Visible = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dataGridView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1177, 399);
            this.metroTabPage2.TabIndex = 0;
            this.metroTabPage2.Text = "Legajos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.dataGridView2);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1177, 406);
            this.metroTabPage4.TabIndex = 1;
            this.metroTabPage4.Text = "REC_CPO";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1170, 338);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 10);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1170, 387);
            this.dataGridView2.TabIndex = 3;
            // 
            // salirverif
            // 
            this.salirverif.Location = new System.Drawing.Point(319, 429);
            this.salirverif.Name = "salirverif";
            this.salirverif.Size = new System.Drawing.Size(221, 40);
            this.salirverif.TabIndex = 7;
            this.salirverif.Text = "Los datos son incorrectos";
            this.salirverif.UseSelectable = true;
            this.salirverif.Visible = false;
            // 
            // NextStep1
            // 
            this.NextStep1.Location = new System.Drawing.Point(614, 429);
            this.NextStep1.Name = "NextStep1";
            this.NextStep1.Size = new System.Drawing.Size(221, 40);
            this.NextStep1.TabIndex = 8;
            this.NextStep1.Text = "Los datos son correctos";
            this.NextStep1.UseSelectable = true;
            this.NextStep1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 609);
            this.Controls.Add(this.MetroTabControl);
            this.Name = "Form1";
            this.Text = "Archivo Libro de sueldo digital";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MetroTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Legajos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REC_CPO)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MetroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel pnl1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox TBREC_CPO;
        private MetroFramework.Controls.MetroTextBox TBlegajos;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabPage Edicion;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Data.DataSet Legajos;
        private System.Data.DataSet REC_CPO;
        private MetroFramework.Controls.MetroButton NextStep1;
        private MetroFramework.Controls.MetroButton salirverif;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

