using System.Collections.Generic;
using System.Windows.Forms;


namespace Project_DB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>


        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.readButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.ascRadio = new System.Windows.Forms.RadioButton();
            this.descRadio = new System.Windows.Forms.RadioButton();
            this.insertRadioButton = new System.Windows.Forms.RadioButton();
            this.updateRadioButton = new System.Windows.Forms.RadioButton();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.operationsButton = new System.Windows.Forms.Button();
            this.updateDataButton = new System.Windows.Forms.Button();
            this.deleteDataButton = new System.Windows.Forms.Button();
            this.insertDataButton = new System.Windows.Forms.Button();
            this.viewDataButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(326, 149);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // readButton
            // 
            this.readButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readButton.Enabled = false;
            this.readButton.Location = new System.Drawing.Point(1138, 121);
            this.readButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(88, 30);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView.Location = new System.Drawing.Point(326, 303);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(459, 290);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // checkedListBox
            // 
            this.checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(471, 129);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(183, 140);
            this.checkedListBox.TabIndex = 4;
            this.checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // ascRadio
            // 
            this.ascRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ascRadio.AutoSize = true;
            this.ascRadio.Enabled = false;
            this.ascRadio.Location = new System.Drawing.Point(326, 241);
            this.ascRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ascRadio.Name = "ascRadio";
            this.ascRadio.Size = new System.Drawing.Size(92, 20);
            this.ascRadio.TabIndex = 5;
            this.ascRadio.TabStop = true;
            this.ascRadio.Text = "Ascending";
            this.ascRadio.UseVisualStyleBackColor = true;
            // 
            // descRadio
            // 
            this.descRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descRadio.AutoSize = true;
            this.descRadio.Enabled = false;
            this.descRadio.Location = new System.Drawing.Point(326, 265);
            this.descRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descRadio.Name = "descRadio";
            this.descRadio.Size = new System.Drawing.Size(101, 20);
            this.descRadio.TabIndex = 6;
            this.descRadio.TabStop = true;
            this.descRadio.Text = "Descending";
            this.descRadio.UseVisualStyleBackColor = true;
            // 
            // insertRadioButton
            // 
            this.insertRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertRadioButton.AutoSize = true;
            this.insertRadioButton.Location = new System.Drawing.Point(1148, 265);
            this.insertRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertRadioButton.Name = "insertRadioButton";
            this.insertRadioButton.Size = new System.Drawing.Size(60, 20);
            this.insertRadioButton.TabIndex = 5;
            this.insertRadioButton.TabStop = true;
            this.insertRadioButton.Text = "insert";
            this.insertRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(1148, 289);
            this.updateRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(70, 20);
            this.updateRadioButton.TabIndex = 5;
            this.updateRadioButton.TabStop = true;
            this.updateRadioButton.Text = "update";
            this.updateRadioButton.UseVisualStyleBackColor = true;
            // 
            // orderBox
            // 
            this.orderBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderBox.Enabled = false;
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Location = new System.Drawing.Point(326, 203);
            this.orderBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(121, 24);
            this.orderBox.TabIndex = 7;
            this.orderBox.SelectedIndexChanged += new System.EventHandler(this.orderBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Table";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(1138, 155);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 30);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Location = new System.Drawing.Point(812, 129);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(4);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(319, 464);
            this.inputPanel.TabIndex = 10;
            this.inputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.inputPanel_Paint);
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButton.Location = new System.Drawing.Point(1138, 189);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(88, 30);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(1138, 229);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 30);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.operationsButton);
            this.panel1.Controls.Add(this.updateDataButton);
            this.panel1.Controls.Add(this.deleteDataButton);
            this.panel1.Controls.Add(this.insertDataButton);
            this.panel1.Controls.Add(this.viewDataButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 800);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.BackColor = System.Drawing.Color.SteelBlue;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logOutButton.Location = new System.Drawing.Point(0, 639);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(130, 30);
            this.logOutButton.TabIndex = 17;
            this.logOutButton.Text = "LogOut";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click_1);
            // 
            // operationsButton
            // 
            this.operationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.operationsButton.FlatAppearance.BorderSize = 0;
            this.operationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operationsButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.operationsButton.Location = new System.Drawing.Point(0, 508);
            this.operationsButton.Name = "operationsButton";
            this.operationsButton.Size = new System.Drawing.Size(130, 59);
            this.operationsButton.TabIndex = 14;
            this.operationsButton.Text = "Extra Operations";
            this.operationsButton.UseVisualStyleBackColor = false;
            // 
            // updateDataButton
            // 
            this.updateDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateDataButton.BackColor = System.Drawing.Color.SteelBlue;
            this.updateDataButton.FlatAppearance.BorderSize = 0;
            this.updateDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateDataButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDataButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateDataButton.Location = new System.Drawing.Point(-1, 301);
            this.updateDataButton.Name = "updateDataButton";
            this.updateDataButton.Size = new System.Drawing.Size(130, 59);
            this.updateDataButton.TabIndex = 16;
            this.updateDataButton.Text = "Update";
            this.updateDataButton.UseVisualStyleBackColor = false;
            // 
            // deleteDataButton
            // 
            this.deleteDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteDataButton.BackColor = System.Drawing.Color.SteelBlue;
            this.deleteDataButton.FlatAppearance.BorderSize = 0;
            this.deleteDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDataButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDataButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteDataButton.Location = new System.Drawing.Point(0, 404);
            this.deleteDataButton.Name = "deleteDataButton";
            this.deleteDataButton.Size = new System.Drawing.Size(130, 59);
            this.deleteDataButton.TabIndex = 15;
            this.deleteDataButton.Text = "Delete";
            this.deleteDataButton.UseVisualStyleBackColor = false;
            // 
            // insertDataButton
            // 
            this.insertDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertDataButton.BackColor = System.Drawing.Color.SteelBlue;
            this.insertDataButton.FlatAppearance.BorderSize = 0;
            this.insertDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertDataButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertDataButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insertDataButton.Location = new System.Drawing.Point(0, 200);
            this.insertDataButton.Name = "insertDataButton";
            this.insertDataButton.Size = new System.Drawing.Size(130, 59);
            this.insertDataButton.TabIndex = 14;
            this.insertDataButton.Text = "Insert";
            this.insertDataButton.UseVisualStyleBackColor = false;
            this.insertDataButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewDataButton
            // 
            this.viewDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDataButton.BackColor = System.Drawing.Color.SteelBlue;
            this.viewDataButton.FlatAppearance.BorderSize = 0;
            this.viewDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDataButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDataButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewDataButton.Location = new System.Drawing.Point(0, 100);
            this.viewDataButton.Name = "viewDataButton";
            this.viewDataButton.Size = new System.Drawing.Size(130, 59);
            this.viewDataButton.TabIndex = 13;
            this.viewDataButton.Text = "View Data";
            this.viewDataButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.ExitButton);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1234, 63);
            this.panel3.TabIndex = 13;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Enabled = false;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1143, 18);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(88, 30);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "D\'Companion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Lavender;
            this.mainPanel.Location = new System.Drawing.Point(128, 62);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1106, 607);
            this.mainPanel.TabIndex = 14;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1234, 667);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.insertRadioButton);
            this.Controls.Add(this.updateRadioButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.descRadio);
            this.Controls.Add(this.ascRadio);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Panel inputPanel;
        private RadioButton insertRadioButton;
        private RadioButton updateRadioButton;
        private RadioButton deleteRadioButton;

        private RadioButton ascRadio;
        private RadioButton descRadio;
        private ComboBox orderBox;
        private Label label1;
        private Label label2;
        private Button deleteButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button insertButton;
        private Button updateButton;




        private Panel panel1;
        private Panel panel2;
        private Button viewDataButton;
        private Button deleteDataButton;
        private Button insertDataButton;
        private Button logOutButton;
        private Button operationsButton;
        private Button updateDataButton;
        private Panel panel3;
        private Label label3;
        private Panel mainPanel;
        private Button ExitButton;
    }
}

