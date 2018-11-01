namespace YBS.Forms
{
    partial class frmPayments
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayments));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.statusText = new System.Windows.Forms.Label();
            this.deleteBtn = new DevComponents.DotNetBar.ButtonX();
            this.cancelbtn = new DevComponents.DotNetBar.ButtonX();
            this.addbtn = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.adhiPohoyaTick = new System.Windows.Forms.CheckBox();
            this.paidDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthslbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.findButton = new DevComponents.DotNetBar.ButtonX();
            this.initialAmountTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.homeTpText = new System.Windows.Forms.TextBox();
            this.mobileText = new System.Windows.Forms.TextBox();
            this.regNumText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.monthCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountText = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.extraAmountNum = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.paymentTypeCombo = new System.Windows.Forms.ComboBox();
            this.receptNum = new System.Windows.Forms.TextBox();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraAmountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.statusText);
            this.panelEx1.Controls.Add(this.deleteBtn);
            this.panelEx1.Controls.Add(this.cancelbtn);
            this.panelEx1.Controls.Add(this.addbtn);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(887, 450);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.ForeColor = System.Drawing.Color.Green;
            this.statusText.Location = new System.Drawing.Point(8, 419);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(113, 16);
            this.statusText.TabIndex = 96;
            this.statusText.Text = "Successfully Added";
            this.statusText.Visible = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.deleteBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(398, 419);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 25);
            this.deleteBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.deleteBtn.TabIndex = 42;
            this.deleteBtn.TabStop = false;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelbtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelbtn.Location = new System.Drawing.Point(494, 419);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 25);
            this.cancelbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelbtn.TabIndex = 41;
            this.cancelbtn.TabStop = false;
            this.cancelbtn.Text = "Clear";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addbtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.addbtn.Location = new System.Drawing.Point(302, 419);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 25);
            this.addbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Insert";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.adhiPohoyaTick);
            this.groupPanel1.Controls.Add(this.paidDate);
            this.groupPanel1.Controls.Add(this.panel2);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Controls.Add(this.panel1);
            this.groupPanel1.Controls.Add(this.label11);
            this.groupPanel1.Controls.Add(this.label7);
            this.groupPanel1.Controls.Add(this.paymentTypeCombo);
            this.groupPanel1.Controls.Add(this.monthCombo);
            this.groupPanel1.Controls.Add(this.label8);
            this.groupPanel1.Controls.Add(this.receptNum);
            this.groupPanel1.Controls.Add(this.yearText);
            this.groupPanel1.Controls.Add(this.label9);
            this.groupPanel1.Controls.Add(this.label12);
            this.groupPanel1.Controls.Add(this.extraAmountNum);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.amountText);
            this.groupPanel1.Location = new System.Drawing.Point(7, 30);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(868, 383);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.TabIndex = 1;
            // 
            // adhiPohoyaTick
            // 
            this.adhiPohoyaTick.Enabled = false;
            this.adhiPohoyaTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adhiPohoyaTick.Location = new System.Drawing.Point(131, 249);
            this.adhiPohoyaTick.Name = "adhiPohoyaTick";
            this.adhiPohoyaTick.Size = new System.Drawing.Size(28, 25);
            this.adhiPohoyaTick.TabIndex = 4;
            this.adhiPohoyaTick.UseVisualStyleBackColor = true;
            // 
            // paidDate
            // 
            this.paidDate.CustomFormat = "yyy-MMM-dd";
            this.paidDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.paidDate.Location = new System.Drawing.Point(131, 312);
            this.paidDate.Name = "paidDate";
            this.paidDate.Size = new System.Drawing.Size(143, 26);
            this.paidDate.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.monthslbl);
            this.panel2.Location = new System.Drawing.Point(312, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 148);
            this.panel2.TabIndex = 106;
            // 
            // monthslbl
            // 
            this.monthslbl.AutoSize = true;
            this.monthslbl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthslbl.Location = new System.Drawing.Point(3, 7);
            this.monthslbl.Name = "monthslbl";
            this.monthslbl.Size = new System.Drawing.Size(0, 20);
            this.monthslbl.TabIndex = 105;
            this.monthslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("UN-Emanee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 105;
            this.label6.Text = "ගෙවීම් සිදුකරන මාස ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Controls.Add(this.initialAmountTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.homeTpText);
            this.groupBox1.Controls.Add(this.mobileText);
            this.groupBox1.Controls.Add(this.regNumText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "සාමාජික විස්තර";
            // 
            // findButton
            // 
            this.findButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.findButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.findButton.Location = new System.Drawing.Point(387, 16);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(54, 24);
            this.findButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.findButton.TabIndex = 97;
            this.findButton.TabStop = false;
            this.findButton.Text = "Find";
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // initialAmountTxt
            // 
            this.initialAmountTxt.AutoSize = true;
            this.initialAmountTxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.initialAmountTxt.Location = new System.Drawing.Point(137, 122);
            this.initialAmountTxt.Name = "initialAmountTxt";
            this.initialAmountTxt.Size = new System.Drawing.Size(0, 20);
            this.initialAmountTxt.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 101;
            this.label5.Text = "දායකත්ව මුදල";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 101;
            this.label4.Text = "දුරකථන අංක";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-1, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 18);
            this.label10.TabIndex = 101;
            this.label10.Text = "සාමාජික අංකය";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // homeTpText
            // 
            this.homeTpText.Font = new System.Drawing.Font("Arial", 12F);
            this.homeTpText.Location = new System.Drawing.Point(313, 86);
            this.homeTpText.Name = "homeTpText";
            this.homeTpText.Size = new System.Drawing.Size(170, 26);
            this.homeTpText.TabIndex = 4;
            this.homeTpText.TabStop = false;
            this.homeTpText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameText_KeyUp);
            // 
            // mobileText
            // 
            this.mobileText.Font = new System.Drawing.Font("Arial", 12F);
            this.mobileText.Location = new System.Drawing.Point(137, 86);
            this.mobileText.Name = "mobileText";
            this.mobileText.Size = new System.Drawing.Size(170, 26);
            this.mobileText.TabIndex = 3;
            this.mobileText.TabStop = false;
            this.mobileText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameText_KeyUp);
            // 
            // regNumText
            // 
            this.regNumText.Font = new System.Drawing.Font("Arial", 12F);
            this.regNumText.Location = new System.Drawing.Point(137, 22);
            this.regNumText.Name = "regNumText";
            this.regNumText.Size = new System.Drawing.Size(87, 26);
            this.regNumText.TabIndex = 1;
            this.regNumText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.regNumText_KeyUp);
            this.regNumText.Leave += new System.EventHandler(this.regNumText_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "නම";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Arial", 12F);
            this.nameText.Location = new System.Drawing.Point(137, 54);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(346, 26);
            this.nameText.TabIndex = 2;
            this.nameText.TabStop = false;
            this.nameText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameText_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(510, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 371);
            this.panel1.TabIndex = 104;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("UN-Emanee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month,
            this.amount,
            this.extraAmount,
            this.id,
            this.dateMonth,
            this.paidDateTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UN-Emanee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 103;
            this.label7.Text = "දායකත්ව මුදල";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.monthCombo.Location = new System.Drawing.Point(131, 220);
            this.monthCombo.Name = "monthCombo";
            this.monthCombo.Size = new System.Drawing.Size(143, 26);
            this.monthCombo.TabIndex = 3;
            this.monthCombo.SelectedIndexChanged += new System.EventHandler(this.monthCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 98;
            this.label8.Text = "ගෙවන ලද දිනය ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yearText
            // 
            this.yearText.Font = new System.Drawing.Font("Arial", 12F);
            this.yearText.Location = new System.Drawing.Point(131, 158);
            this.yearText.Name = "yearText";
            this.yearText.ReadOnly = true;
            this.yearText.Size = new System.Drawing.Size(87, 26);
            this.yearText.TabIndex = 1;
            this.yearText.TabStop = false;
            this.yearText.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.yearText_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 27);
            this.label9.TabIndex = 98;
            this.label9.Text = "අධි පොහොය ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 98;
            this.label3.Text = "ආරම්භක මාසය ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "වර්ෂය";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountText
            // 
            this.amountText.Font = new System.Drawing.Font("Arial", 12F);
            this.amountText.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.amountText.Location = new System.Drawing.Point(131, 189);
            this.amountText.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(87, 26);
            this.amountText.TabIndex = 2;
            this.amountText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountText.Leave += new System.EventHandler(this.amountText_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // extraAmountNum
            // 
            this.extraAmountNum.Font = new System.Drawing.Font("Arial", 12F);
            this.extraAmountNum.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.extraAmountNum.Location = new System.Drawing.Point(131, 278);
            this.extraAmountNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.extraAmountNum.Name = "extraAmountNum";
            this.extraAmountNum.Size = new System.Drawing.Size(87, 26);
            this.extraAmountNum.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-3, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 18);
            this.label11.TabIndex = 103;
            this.label11.Text = "අමතර ආධාර මුදල";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // month
            // 
            this.month.HeaderText = "මාසය";
            this.month.MinimumWidth = 100;
            this.month.Name = "month";
            this.month.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.FillWeight = 70F;
            this.amount.HeaderText = "ගෙවූ මුදල";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // extraAmount
            // 
            this.extraAmount.FillWeight = 70F;
            this.extraAmount.HeaderText = "අමතර මුදල";
            this.extraAmount.MinimumWidth = 65;
            this.extraAmount.Name = "extraAmount";
            this.extraAmount.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dateMonth
            // 
            this.dateMonth.HeaderText = "dateMonth";
            this.dateMonth.Name = "dateMonth";
            this.dateMonth.ReadOnly = true;
            this.dateMonth.Visible = false;
            // 
            // paidDateTime
            // 
            this.paidDateTime.HeaderText = "paidDate";
            this.paidDateTime.Name = "paidDateTime";
            this.paidDateTime.ReadOnly = true;
            this.paidDateTime.Visible = false;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 27);
            this.label12.TabIndex = 98;
            this.label12.Text = "ගෙවූ ආකාරය";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paymentTypeCombo
            // 
            this.paymentTypeCombo.Font = new System.Drawing.Font("Arial", 12F);
            this.paymentTypeCombo.FormattingEnabled = true;
            this.paymentTypeCombo.Items.AddRange(new object[] {
            "කාර්යාලය",
            "BOC",
            "HNB",
            "Sampath"});
            this.paymentTypeCombo.Location = new System.Drawing.Point(131, 346);
            this.paymentTypeCombo.Name = "paymentTypeCombo";
            this.paymentTypeCombo.Size = new System.Drawing.Size(143, 26);
            this.paymentTypeCombo.TabIndex = 3;
            this.paymentTypeCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // receptNum
            // 
            this.receptNum.Font = new System.Drawing.Font("Arial", 12F);
            this.receptNum.Location = new System.Drawing.Point(280, 346);
            this.receptNum.Name = "receptNum";
            this.receptNum.ReadOnly = true;
            this.receptNum.Size = new System.Drawing.Size(109, 26);
            this.receptNum.TabIndex = 1;
            this.receptNum.TabStop = false;
            this.receptNum.Visible = false;
            this.receptNum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.yearText_MouseDoubleClick);
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "මාසික තැන්පතු";
            this.Load += new System.EventHandler(this.frmOccupatition_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraAmountNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX deleteBtn;
        private DevComponents.DotNetBar.ButtonX cancelbtn;
        private DevComponents.DotNetBar.ButtonX addbtn;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown amountText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox regNumText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox monthCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mobileText;
        private DevComponents.DotNetBar.ButtonX findButton;
        private System.Windows.Forms.Label initialAmountTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox homeTpText;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label monthslbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker paidDate;
        private System.Windows.Forms.CheckBox adhiPohoyaTick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown extraAmountNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDateTime;
        private System.Windows.Forms.ComboBox paymentTypeCombo;
        private System.Windows.Forms.TextBox receptNum;
        private System.Windows.Forms.Label label12;
    }
}