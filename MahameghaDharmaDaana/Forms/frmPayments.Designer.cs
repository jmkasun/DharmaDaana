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
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.monthCombo = new System.Windows.Forms.ComboBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountText = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.extraAmountText = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraAmountText)).BeginInit();
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
            this.panelEx1.Size = new System.Drawing.Size(887, 420);
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
            this.statusText.Location = new System.Drawing.Point(8, 388);
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
            this.deleteBtn.Location = new System.Drawing.Point(398, 388);
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
            this.cancelbtn.Location = new System.Drawing.Point(494, 388);
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
            this.addbtn.Location = new System.Drawing.Point(302, 388);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 25);
            this.addbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.addbtn.TabIndex = 4;
            this.addbtn.Text = "Insert";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.panel2);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Controls.Add(this.panel1);
            this.groupPanel1.Controls.Add(this.label8);
            this.groupPanel1.Controls.Add(this.label7);
            this.groupPanel1.Controls.Add(this.monthCombo);
            this.groupPanel1.Controls.Add(this.yearText);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.extraAmountText);
            this.groupPanel1.Controls.Add(this.amountText);
            this.groupPanel1.Location = new System.Drawing.Point(7, 30);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(868, 355);
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
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.monthslbl);
            this.panel2.Location = new System.Drawing.Point(312, 200);
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
            this.label6.Location = new System.Drawing.Point(309, 178);
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
            this.groupBox1.Size = new System.Drawing.Size(534, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "සාමාජික විස්තර";
            // 
            // findButton
            // 
            this.findButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.findButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.findButton.Location = new System.Drawing.Point(474, 12);
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
            this.initialAmountTxt.Location = new System.Drawing.Point(133, 134);
            this.initialAmountTxt.Name = "initialAmountTxt";
            this.initialAmountTxt.Size = new System.Drawing.Size(0, 20);
            this.initialAmountTxt.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 101;
            this.label5.Text = "දායකත්ව මුදල";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 95);
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
            this.homeTpText.Location = new System.Drawing.Point(313, 95);
            this.homeTpText.Name = "homeTpText";
            this.homeTpText.Size = new System.Drawing.Size(170, 26);
            this.homeTpText.TabIndex = 4;
            this.homeTpText.TabStop = false;
            this.homeTpText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameText_KeyUp);
            // 
            // mobileText
            // 
            this.mobileText.Font = new System.Drawing.Font("Arial", 12F);
            this.mobileText.Location = new System.Drawing.Point(137, 95);
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
            this.label2.Location = new System.Drawing.Point(78, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "නම";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Arial", 12F);
            this.nameText.Location = new System.Drawing.Point(137, 60);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(376, 26);
            this.nameText.TabIndex = 2;
            this.nameText.TabStop = false;
            this.nameText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameText_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(552, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 343);
            this.panel1.TabIndex = 104;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.amount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UN-Emanee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(301, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // month
            // 
            this.month.FillWeight = 131.9797F;
            this.month.HeaderText = "මාසය";
            this.month.Name = "month";
            this.month.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.FillWeight = 68.0203F;
            this.amount.HeaderText = "ගෙවූ මුදල";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 224);
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
            this.monthCombo.Location = new System.Drawing.Point(153, 268);
            this.monthCombo.Name = "monthCombo";
            this.monthCombo.Size = new System.Drawing.Size(143, 26);
            this.monthCombo.TabIndex = 3;
            this.monthCombo.SelectedIndexChanged += new System.EventHandler(this.monthCombo_SelectedIndexChanged);
            // 
            // yearText
            // 
            this.yearText.Font = new System.Drawing.Font("Arial", 12F);
            this.yearText.Location = new System.Drawing.Point(153, 181);
            this.yearText.Name = "yearText";
            this.yearText.ReadOnly = true;
            this.yearText.Size = new System.Drawing.Size(87, 26);
            this.yearText.TabIndex = 1;
            this.yearText.TabStop = false;
            this.yearText.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.yearText_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 98;
            this.label3.Text = "ආරම්භක මාසය ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 182);
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
            this.amountText.Location = new System.Drawing.Point(153, 224);
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
            // extraAmountText
            // 
            this.extraAmountText.Font = new System.Drawing.Font("Arial", 12F);
            this.extraAmountText.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.extraAmountText.Location = new System.Drawing.Point(153, 309);
            this.extraAmountText.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.extraAmountText.Name = "extraAmountText";
            this.extraAmountText.Size = new System.Drawing.Size(87, 26);
            this.extraAmountText.TabIndex = 4;
            this.extraAmountText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.extraAmountText.Leave += new System.EventHandler(this.amountText_Leave);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("UN-Emanee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-5, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 18);
            this.label8.TabIndex = 103;
            this.label8.Text = "අමතර දායකත්ව මුදල";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 420);
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
            ((System.ComponentModel.ISupportInitialize)(this.extraAmountText)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Label monthslbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown extraAmountText;
    }
}