﻿namespace LibroDeSueldosDigital
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MetroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.NextStep1 = new MetroFramework.Controls.MetroButton();
            this.salirverif = new MetroFramework.Controls.MetroButton();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.Edicion = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.Legajos = new System.Data.DataSet();
            this.REC_CPO = new System.Data.DataSet();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.TBlegajos = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.Tbx_cuit = new MetroFramework.Controls.MetroTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.MetroTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.Edicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Legajos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REC_CPO)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetroTabControl
            // 
            this.MetroTabControl.Controls.Add(this.metroTabPage1);
            this.MetroTabControl.Controls.Add(this.Edicion);
            this.MetroTabControl.Controls.Add(this.metroTabPage3);
            this.MetroTabControl.Location = new System.Drawing.Point(23, 63);
            this.MetroTabControl.Name = "MetroTabControl";
            this.MetroTabControl.SelectedIndex = 1;
            this.MetroTabControl.Size = new System.Drawing.Size(1199, 560);
            this.MetroTabControl.Style = MetroFramework.MetroColorStyle.Black;
            this.MetroTabControl.TabIndex = 1;
            this.MetroTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroTabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTabPage1.Controls.Add(this.pnl1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1191, 518);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Seleccion";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.MetroTabPage1_Click);
            // 
            // NextStep1
            // 
            this.NextStep1.Location = new System.Drawing.Point(957, 481);
            this.NextStep1.Name = "NextStep1";
            this.NextStep1.Size = new System.Drawing.Size(221, 28);
            this.NextStep1.TabIndex = 8;
            this.NextStep1.Text = "Los datos son correctos";
            this.NextStep1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NextStep1.UseSelectable = true;
            this.NextStep1.Visible = false;
            this.NextStep1.Click += new System.EventHandler(this.NextStep1_Click);
            // 
            // salirverif
            // 
            this.salirverif.Location = new System.Drawing.Point(730, 481);
            this.salirverif.Name = "salirverif";
            this.salirverif.Size = new System.Drawing.Size(221, 28);
            this.salirverif.TabIndex = 7;
            this.salirverif.Text = "Los datos son incorrectos";
            this.salirverif.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.salirverif.UseSelectable = true;
            this.salirverif.Visible = false;
            this.salirverif.Click += new System.EventHandler(this.Salirverif_Click);
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.metroTabControl1);
            this.pnl1.Controls.Add(this.metroButton3);
            this.pnl1.Controls.Add(this.NextStep1);
            this.pnl1.Controls.Add(this.TBlegajos);
            this.pnl1.Controls.Add(this.salirverif);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.metroButton1);
            this.pnl1.Location = new System.Drawing.Point(3, 3);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1185, 512);
            this.pnl1.TabIndex = 5;
            // 
            // Edicion
            // 
            this.Edicion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Edicion.CausesValidation = false;
            this.Edicion.Controls.Add(this.metroTabControl2);
            this.Edicion.HorizontalScrollbarBarColor = true;
            this.Edicion.HorizontalScrollbarHighlightOnWheel = false;
            this.Edicion.HorizontalScrollbarSize = 10;
            this.Edicion.Location = new System.Drawing.Point(4, 38);
            this.Edicion.Name = "Edicion";
            this.Edicion.Size = new System.Drawing.Size(1191, 518);
            this.Edicion.Style = MetroFramework.MetroColorStyle.Black;
            this.Edicion.TabIndex = 1;
            this.Edicion.Text = "Edicion";
            this.Edicion.UseVisualStyleBackColor = true;
            this.Edicion.UseWaitCursor = true;
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
            this.metroTabPage3.Size = new System.Drawing.Size(1191, 518);
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
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(1036, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(146, 25);
            this.metroButton3.TabIndex = 14;
            this.metroButton3.Text = "Hecho!";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.MetroButton3_Click);
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
            this.TBlegajos.Location = new System.Drawing.Point(493, 3);
            this.TBlegajos.MaxLength = 32767;
            this.TBlegajos.Name = "TBlegajos";
            this.TBlegajos.PasswordChar = '\0';
            this.TBlegajos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBlegajos.SelectedText = "";
            this.TBlegajos.SelectionLength = 0;
            this.TBlegajos.SelectionStart = 0;
            this.TBlegajos.ShortcutsEnabled = true;
            this.TBlegajos.Size = new System.Drawing.Size(380, 23);
            this.TBlegajos.TabIndex = 13;
            this.TBlegajos.Text = "Buscar";
            this.TBlegajos.UseSelectable = true;
            this.TBlegajos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBlegajos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBlegajos.Click += new System.EventHandler(this.TBlegajos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione la ubicacion de los archivos \"Legajos\" y \"REC_CPO\" ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(879, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(151, 25);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Buscar legajos";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 34);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1179, 441);
            this.metroTabControl1.TabIndex = 15;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.metroTabPage2.Size = new System.Drawing.Size(1171, 399);
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
            this.metroTabPage4.Size = new System.Drawing.Size(1171, 399);
            this.metroTabPage4.TabIndex = 1;
            this.metroTabPage4.Text = "Conseptos";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 393);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1165, 393);
            this.dataGridView2.TabIndex = 3;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage5);
            this.metroTabControl2.Controls.Add(this.metroTabPage6);
            this.metroTabControl2.Controls.Add(this.metroTabPage7);
            this.metroTabControl2.Controls.Add(this.metroTabPage8);
            this.metroTabControl2.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(1185, 560);
            this.metroTabControl2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl2.UseSelectable = true;
            this.metroTabControl2.UseWaitCursor = true;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.dateTimePicker1);
            this.metroTabPage5.Controls.Add(this.comboBox1);
            this.metroTabPage5.Controls.Add(this.Tbx_cuit);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(1177, 518);
            this.metroTabPage5.TabIndex = 0;
            this.metroTabPage5.Text = "Registro Tipo 1";
            this.metroTabPage5.UseWaitCursor = true;
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(1177, 518);
            this.metroTabPage6.TabIndex = 1;
            this.metroTabPage6.Text = "Registro Tipo 2";
            this.metroTabPage6.UseWaitCursor = true;
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(1177, 518);
            this.metroTabPage7.TabIndex = 2;
            this.metroTabPage7.Text = "Registro Tipo 3";
            this.metroTabPage7.UseWaitCursor = true;
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // metroTabPage8
            // 
            this.metroTabPage8.HorizontalScrollbarBarColor = true;
            this.metroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.HorizontalScrollbarSize = 10;
            this.metroTabPage8.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage8.Name = "metroTabPage8";
            this.metroTabPage8.Size = new System.Drawing.Size(1177, 518);
            this.metroTabPage8.TabIndex = 3;
            this.metroTabPage8.Text = "metroTabPage8";
            this.metroTabPage8.UseWaitCursor = true;
            this.metroTabPage8.VerticalScrollbarBarColor = true;
            this.metroTabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.VerticalScrollbarSize = 10;
            // 
            // Tbx_cuit
            // 
            // 
            // 
            // 
            this.Tbx_cuit.CustomButton.Image = null;
            this.Tbx_cuit.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.Tbx_cuit.CustomButton.Name = "";
            this.Tbx_cuit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Tbx_cuit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tbx_cuit.CustomButton.TabIndex = 1;
            this.Tbx_cuit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Tbx_cuit.CustomButton.UseSelectable = true;
            this.Tbx_cuit.CustomButton.Visible = false;
            this.Tbx_cuit.Lines = new string[] {
        "Cuit"};
            this.Tbx_cuit.Location = new System.Drawing.Point(4, 3);
            this.Tbx_cuit.MaxLength = 32767;
            this.Tbx_cuit.Name = "Tbx_cuit";
            this.Tbx_cuit.PasswordChar = '\0';
            this.Tbx_cuit.PromptText = "Cuit";
            this.Tbx_cuit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Tbx_cuit.SelectedText = "";
            this.Tbx_cuit.SelectionLength = 0;
            this.Tbx_cuit.SelectionStart = 0;
            this.Tbx_cuit.ShortcutsEnabled = true;
            this.Tbx_cuit.Size = new System.Drawing.Size(200, 21);
            this.Tbx_cuit.TabIndex = 2;
            this.Tbx_cuit.Text = "Cuit";
            this.Tbx_cuit.UseSelectable = true;
            this.Tbx_cuit.WaterMark = "Cuit";
            this.Tbx_cuit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Tbx_cuit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SJ",
            "RE"});
            this.comboBox1.Location = new System.Drawing.Point(4, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 646);
            this.Controls.Add(this.MetroTabControl);
            this.Name = "Form1";
            this.Text = "Archivo Libro de sueldo digital";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MetroTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.Edicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Legajos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REC_CPO)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MetroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel pnl1;
        private MetroFramework.Controls.MetroTabPage Edicion;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Data.DataSet Legajos;
        private System.Data.DataSet REC_CPO;
        private MetroFramework.Controls.MetroButton NextStep1;
        private MetroFramework.Controls.MetroButton salirverif;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox TBlegajos;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroTabPage metroTabPage8;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroTextBox Tbx_cuit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

