﻿namespace YBS.Forms
{
    partial class frmPublish
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.printButton = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.monthCombo = new System.Windows.Forms.ComboBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.otherAddressRadio = new System.Windows.Forms.RadioButton();
            this.privateAddressRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.addbtn = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.adressGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioUncheck = new System.Windows.Forms.RadioButton();
            this.radioCheck = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.regNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameinMag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adressGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.printButton);
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.Controls.Add(this.adressGrid);
            this.panelEx1.Controls.Add(this.groupBox2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(845, 556);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.printButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.printButton.Location = new System.Drawing.Point(759, 524);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(83, 29);
            this.printButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.printButton.TabIndex = 111;
            this.printButton.Text = "Print";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoryCombo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.monthCombo);
            this.groupBox1.Controls.Add(this.yearText);
            this.groupBox1.Controls.Add(this.otherAddressRadio);
            this.groupBox1.Controls.Add(this.privateAddressRadio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 59);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            // 
            // categoryCombo
            // 
            this.categoryCombo.Font = new System.Drawing.Font("Arial", 12F);
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "මාසික",
            "වාර්ෂික"});
            this.categoryCombo.Location = new System.Drawing.Point(526, 28);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(159, 26);
            this.categoryCombo.TabIndex = 110;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(525, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 18);
            this.label14.TabIndex = 109;
            this.label14.Text = "වර්ගය";
            // 
            // monthCombo
            // 
            this.monthCombo.Font = new System.Drawing.Font("Arial", 12F);
            this.monthCombo.FormattingEnabled = true;
            this.monthCombo.Items.AddRange(new object[] {
            "ජනවාරි",
            "පෙබරවාරි",
            "මාර්තු",
            "අප්‍රේල්",
            "මැයි",
            "ජූනි",
            "ජූලි",
            "අගෝස්තු",
            "සැප්තැම්බර්",
            "ඔක්තෝම්බර්",
            "නොවැම්බර්",
            "දෙසැම්බර්"});
            this.monthCombo.Location = new System.Drawing.Point(204, 21);
            this.monthCombo.Name = "monthCombo";
            this.monthCombo.Size = new System.Drawing.Size(143, 26);
            this.monthCombo.TabIndex = 106;
            this.monthCombo.TabStop = false;
            // 
            // yearText
            // 
            this.yearText.Font = new System.Drawing.Font("Arial", 12F);
            this.yearText.Location = new System.Drawing.Point(57, 21);
            this.yearText.Name = "yearText";
            this.yearText.ReadOnly = true;
            this.yearText.Size = new System.Drawing.Size(87, 26);
            this.yearText.TabIndex = 105;
            this.yearText.TabStop = false;
            // 
            // otherAddressRadio
            // 
            this.otherAddressRadio.AutoSize = true;
            this.otherAddressRadio.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherAddressRadio.Location = new System.Drawing.Point(362, 33);
            this.otherAddressRadio.Name = "otherAddressRadio";
            this.otherAddressRadio.Size = new System.Drawing.Size(141, 21);
            this.otherAddressRadio.TabIndex = 108;
            this.otherAddressRadio.Text = "අනෙකුත් ලිපිනයන්";
            this.otherAddressRadio.UseVisualStyleBackColor = true;
            // 
            // privateAddressRadio
            // 
            this.privateAddressRadio.AutoSize = true;
            this.privateAddressRadio.Checked = true;
            this.privateAddressRadio.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateAddressRadio.Location = new System.Drawing.Point(362, 9);
            this.privateAddressRadio.Name = "privateAddressRadio";
            this.privateAddressRadio.Size = new System.Drawing.Size(140, 21);
            this.privateAddressRadio.TabIndex = 108;
            this.privateAddressRadio.TabStop = true;
            this.privateAddressRadio.Text = "පුද්ගලික ලිපිනයන්";
            this.privateAddressRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 104;
            this.label1.Text = "වර්ෂය";
            // 
            // addbtn
            // 
            this.addbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addbtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.addbtn.Location = new System.Drawing.Point(697, 12);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(111, 41);
            this.addbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.addbtn.TabIndex = 107;
            this.addbtn.Text = "Select";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 103;
            this.label3.Text = "මාසය";
            // 
            // adressGrid
            // 
            this.adressGrid.AllowUserToAddRows = false;
            this.adressGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adressGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adressGrid.ColumnHeadersHeight = 30;
            this.adressGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.regNumber,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.NameinMag});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adressGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.adressGrid.Location = new System.Drawing.Point(18, 69);
            this.adressGrid.Name = "adressGrid";
            this.adressGrid.RowHeadersWidth = 60;
            this.adressGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adressGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adressGrid.Size = new System.Drawing.Size(824, 452);
            this.adressGrid.TabIndex = 110;
            this.adressGrid.TabStop = false;
            this.adressGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.adressGrid_CellMouseClick);
            this.adressGrid.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.adressGrid_ColumnHeaderMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioUncheck);
            this.groupBox2.Controls.Add(this.radioCheck);
            this.groupBox2.Location = new System.Drawing.Point(23, 527);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 28);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            // 
            // radioUncheck
            // 
            this.radioUncheck.AutoSize = true;
            this.radioUncheck.Location = new System.Drawing.Point(89, 9);
            this.radioUncheck.Name = "radioUncheck";
            this.radioUncheck.Size = new System.Drawing.Size(73, 17);
            this.radioUncheck.TabIndex = 1;
            this.radioUncheck.TabStop = true;
            this.radioUncheck.Text = "Un-Check";
            this.radioUncheck.UseVisualStyleBackColor = true;
            this.radioUncheck.CheckedChanged += new System.EventHandler(this.radioUncheck_CheckedChanged);
            // 
            // radioCheck
            // 
            this.radioCheck.AutoSize = true;
            this.radioCheck.Location = new System.Drawing.Point(6, 9);
            this.radioCheck.Name = "radioCheck";
            this.radioCheck.Size = new System.Drawing.Size(56, 17);
            this.radioCheck.TabIndex = 0;
            this.radioCheck.TabStop = true;
            this.radioCheck.Text = "Check";
            this.radioCheck.UseVisualStyleBackColor = true;
            this.radioCheck.CheckedChanged += new System.EventHandler(this.radioCheck_CheckedChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "checked";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = false;
            this.dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select All";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 90;
            // 
            // regNumber
            // 
            this.regNumber.DataPropertyName = "regNumber";
            this.regNumber.HeaderText = "අංකය";
            this.regNumber.Name = "regNumber";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Address";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.FillWeight = 149.2386F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ලිපිනය";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 490;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 490;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "numOfMag";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.FillWeight = 50.76142F;
            this.dataGridViewTextBoxColumn3.HeaderText = "ප්‍රමාණය";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // NameinMag
            // 
            this.NameinMag.DataPropertyName = "nameInMag";
            this.NameinMag.HeaderText = "NameinMag";
            this.NameinMag.Name = "NameinMag";
            this.NameinMag.Visible = false;
            // 
            // frmPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 556);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "frmPublish";
            this.Text = "frmPublish";
            this.Load += new System.EventHandler(this.frmPublish_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adressGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.ComboBox monthCombo;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX addbtn;
        private System.Windows.Forms.RadioButton otherAddressRadio;
        private System.Windows.Forms.RadioButton privateAddressRadio;
        private System.Windows.Forms.DataGridView adressGrid;
        private DevComponents.DotNetBar.ButtonX printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioUncheck;
        private System.Windows.Forms.RadioButton radioCheck;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameinMag;
    }
}