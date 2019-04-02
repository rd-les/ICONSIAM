namespace iconsiam {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ListComport = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RAD_FLOOR_7 = new System.Windows.Forms.RadioButton();
            this.RAD_FLOOR_8 = new System.Windows.Forms.RadioButton();
            this.RAD_UG = new System.Windows.Forms.RadioButton();
            this.RAD_FLOOR_6 = new System.Windows.Forms.RadioButton();
            this.RAD_FLOOR_4 = new System.Windows.Forms.RadioButton();
            this.RAD_FLOOR_3 = new System.Windows.Forms.RadioButton();
            this.RAD_FLOOR_2 = new System.Windows.Forms.RadioButton();
            this.groupBox_Board = new System.Windows.Forms.GroupBox();
            this.RAD_OFF = new System.Windows.Forms.RadioButton();
            this.RAD_ON = new System.Windows.Forms.RadioButton();
            this.Select_All = new System.Windows.Forms.CheckBox();
            this.BTN_Reload = new System.Windows.Forms.Button();
            this.BTN_SendPackage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LAB_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_LOG = new System.Windows.Forms.TextBox();
            this.Grid_Relay = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_HOME = new System.Windows.Forms.Button();
            this.BTN_GROUP = new System.Windows.Forms.Button();
            this.BTN_REFRESH = new System.Windows.Forms.Button();
            this.BTN_EDIT_NAME = new System.Windows.Forms.Button();
            this.BTN_SCHEDULE = new System.Windows.Forms.Button();
            this.BTN_CONTROL = new System.Windows.Forms.Button();
            this.BTN_LOGOUT = new System.Windows.Forms.Button();
            this.BTN_LAYOUT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Board.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Relay)).BeginInit();
            this.SuspendLayout();
            // 
            // ListComport
            // 
            this.ListComport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListComport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ListComport.FormattingEnabled = true;
            this.ListComport.Items.AddRange(new object[] {
            "PLEASE SELECT",
            "LPUGA-FC",
            "LP2AFC",
            "LP2AFC-1",
            "LP3AFC",
            "LP4AFC",
            "LP6AFC",
            "LP7AFC",
            "LP2BFC",
            "LP2BFC-1",
            "LP3BFC",
            "LP4BFC",
            "LP6MBFC",
            "LP8BFC",
            "LPUGCFC",
            "LP2CFC",
            "LP3CFC",
            "LP6CFC",
            "LP7CFC",
            "LP2DFC",
            "LP3DFC",
            "LP6DFC",
            "LP7DFC"});
            this.ListComport.Location = new System.Drawing.Point(3, 18);
            this.ListComport.Name = "ListComport";
            this.ListComport.Size = new System.Drawing.Size(224, 32);
            this.ListComport.TabIndex = 10;
            this.ListComport.SelectedIndexChanged += new System.EventHandler(this.ListComport_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox_Board);
            this.panel1.Controls.Add(this.Select_All);
            this.panel1.Controls.Add(this.ListComport);
            this.panel1.Location = new System.Drawing.Point(2, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 54);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RAD_FLOOR_7);
            this.groupBox1.Controls.Add(this.RAD_FLOOR_8);
            this.groupBox1.Controls.Add(this.RAD_UG);
            this.groupBox1.Controls.Add(this.RAD_FLOOR_6);
            this.groupBox1.Controls.Add(this.RAD_FLOOR_4);
            this.groupBox1.Controls.Add(this.RAD_FLOOR_3);
            this.groupBox1.Controls.Add(this.RAD_FLOOR_2);
            this.groupBox1.Location = new System.Drawing.Point(592, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(487, 42);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FLOOR";
            // 
            // RAD_FLOOR_7
            // 
            this.RAD_FLOOR_7.AutoSize = true;
            this.RAD_FLOOR_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_FLOOR_7.Location = new System.Drawing.Point(361, 18);
            this.RAD_FLOOR_7.Margin = new System.Windows.Forms.Padding(2);
            this.RAD_FLOOR_7.Name = "RAD_FLOOR_7";
            this.RAD_FLOOR_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RAD_FLOOR_7.Size = new System.Drawing.Size(57, 17);
            this.RAD_FLOOR_7.TabIndex = 6;
            this.RAD_FLOOR_7.TabStop = true;
            this.RAD_FLOOR_7.Text = "Floor 7";
            this.RAD_FLOOR_7.UseVisualStyleBackColor = true;
            this.RAD_FLOOR_7.CheckedChanged += new System.EventHandler(this.RAD_FLOOR_7_CheckedChanged);
            // 
            // RAD_FLOOR_8
            // 
            this.RAD_FLOOR_8.AutoSize = true;
            this.RAD_FLOOR_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_FLOOR_8.Location = new System.Drawing.Point(425, 18);
            this.RAD_FLOOR_8.Margin = new System.Windows.Forms.Padding(2);
            this.RAD_FLOOR_8.Name = "RAD_FLOOR_8";
            this.RAD_FLOOR_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RAD_FLOOR_8.Size = new System.Drawing.Size(57, 17);
            this.RAD_FLOOR_8.TabIndex = 5;
            this.RAD_FLOOR_8.TabStop = true;
            this.RAD_FLOOR_8.Text = "Floor 8";
            this.RAD_FLOOR_8.UseVisualStyleBackColor = true;
            this.RAD_FLOOR_8.CheckedChanged += new System.EventHandler(this.RAD_FLOOR_8_CheckedChanged);
            // 
            // RAD_UG
            // 
            this.RAD_UG.AutoSize = true;
            this.RAD_UG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_UG.Location = new System.Drawing.Point(20, 19);
            this.RAD_UG.Margin = new System.Windows.Forms.Padding(2);
            this.RAD_UG.Name = "RAD_UG";
            this.RAD_UG.Size = new System.Drawing.Size(41, 17);
            this.RAD_UG.TabIndex = 4;
            this.RAD_UG.TabStop = true;
            this.RAD_UG.Text = "UG";
            this.RAD_UG.UseVisualStyleBackColor = true;
            this.RAD_UG.CheckedChanged += new System.EventHandler(this.RAD_UG_CheckedChanged);
            // 
            // RAD_FLOOR_6
            // 
            this.RAD_FLOOR_6.AutoSize = true;
            this.RAD_FLOOR_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_FLOOR_6.Location = new System.Drawing.Point(298, 19);
            this.RAD_FLOOR_6.Margin = new System.Windows.Forms.Padding(2);
            this.RAD_FLOOR_6.Name = "RAD_FLOOR_6";
            this.RAD_FLOOR_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RAD_FLOOR_6.Size = new System.Drawing.Size(57, 17);
            this.RAD_FLOOR_6.TabIndex = 3;
            this.RAD_FLOOR_6.TabStop = true;
            this.RAD_FLOOR_6.Text = "Floor 6";
            this.RAD_FLOOR_6.UseVisualStyleBackColor = true;
            this.RAD_FLOOR_6.CheckedChanged += new System.EventHandler(this.RAD_FLOOR_6_CheckedChanged);
            // 
            // RAD_FLOOR_4
            // 
            this.RAD_FLOOR_4.AutoSize = true;
            this.RAD_FLOOR_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_FLOOR_4.Location = new System.Drawing.Point(226, 19);
            this.RAD_FLOOR_4.Margin = new System.Windows.Forms.Padding(2);
            this.RAD_FLOOR_4.Name = "RAD_FLOOR_4";
            this.RAD_FLOOR_4.Size = new System.Drawing.Size(57, 17);
            this.RAD_FLOOR_4.TabIndex = 2;
            this.RAD_FLOOR_4.TabStop = true;
            this.RAD_FLOOR_4.Text = "Floor 4";
            this.RAD_FLOOR_4.UseVisualStyleBackColor = true;
            this.RAD_FLOOR_4.CheckedChanged += new System.EventHandler(this.RAD_FLOOR_4_CheckedChanged);
            // 
            // RAD_FLOOR_3
            // 
            this.RAD_FLOOR_3.AutoSize = true;
            this.RAD_FLOOR_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_FLOOR_3.Location = new System.Drawing.Point(154, 19);
            this.RAD_FLOOR_3.Margin = new System.Windows.Forms.Padding(2);
            this.RAD_FLOOR_3.Name = "RAD_FLOOR_3";
            this.RAD_FLOOR_3.Size = new System.Drawing.Size(57, 17);
            this.RAD_FLOOR_3.TabIndex = 1;
            this.RAD_FLOOR_3.TabStop = true;
            this.RAD_FLOOR_3.Text = "Floor 3";
            this.RAD_FLOOR_3.UseVisualStyleBackColor = true;
            this.RAD_FLOOR_3.CheckedChanged += new System.EventHandler(this.RAD_FLOOR_3_CheckedChanged);
            // 
            // RAD_FLOOR_2
            // 
            this.RAD_FLOOR_2.AutoSize = true;
            this.RAD_FLOOR_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_FLOOR_2.Location = new System.Drawing.Point(90, 19);
            this.RAD_FLOOR_2.Margin = new System.Windows.Forms.Padding(2);
            this.RAD_FLOOR_2.Name = "RAD_FLOOR_2";
            this.RAD_FLOOR_2.Size = new System.Drawing.Size(57, 17);
            this.RAD_FLOOR_2.TabIndex = 0;
            this.RAD_FLOOR_2.TabStop = true;
            this.RAD_FLOOR_2.Text = "Floor 2";
            this.RAD_FLOOR_2.UseVisualStyleBackColor = true;
            this.RAD_FLOOR_2.CheckedChanged += new System.EventHandler(this.RAD_FLOOR_2_CheckedChanged);
            // 
            // groupBox_Board
            // 
            this.groupBox_Board.Controls.Add(this.RAD_OFF);
            this.groupBox_Board.Controls.Add(this.RAD_ON);
            this.groupBox_Board.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox_Board.Location = new System.Drawing.Point(233, 3);
            this.groupBox_Board.Name = "groupBox_Board";
            this.groupBox_Board.Size = new System.Drawing.Size(223, 56);
            this.groupBox_Board.TabIndex = 23;
            this.groupBox_Board.TabStop = false;
            this.groupBox_Board.Text = "SELECT";
            // 
            // RAD_OFF
            // 
            this.RAD_OFF.AutoSize = true;
            this.RAD_OFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_OFF.Location = new System.Drawing.Point(100, 26);
            this.RAD_OFF.Name = "RAD_OFF";
            this.RAD_OFF.Size = new System.Drawing.Size(92, 24);
            this.RAD_OFF.TabIndex = 1;
            this.RAD_OFF.TabStop = true;
            this.RAD_OFF.Text = "OFF ALL";
            this.RAD_OFF.UseVisualStyleBackColor = true;
            this.RAD_OFF.CheckedChanged += new System.EventHandler(this.RAD_OFF_CheckedChanged);
            // 
            // RAD_ON
            // 
            this.RAD_ON.AutoSize = true;
            this.RAD_ON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_ON.Location = new System.Drawing.Point(6, 26);
            this.RAD_ON.Name = "RAD_ON";
            this.RAD_ON.Size = new System.Drawing.Size(83, 24);
            this.RAD_ON.TabIndex = 0;
            this.RAD_ON.TabStop = true;
            this.RAD_ON.Text = "ON ALL";
            this.RAD_ON.UseVisualStyleBackColor = true;
            this.RAD_ON.CheckedChanged += new System.EventHandler(this.RAD_ON_CheckedChanged);
            // 
            // Select_All
            // 
            this.Select_All.AutoSize = true;
            this.Select_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Select_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Select_All.Location = new System.Drawing.Point(471, 26);
            this.Select_All.Name = "Select_All";
            this.Select_All.Size = new System.Drawing.Size(90, 24);
            this.Select_All.TabIndex = 21;
            this.Select_All.Text = "SelectAll";
            this.Select_All.UseVisualStyleBackColor = true;
            this.Select_All.Visible = false;
            this.Select_All.Click += new System.EventHandler(this.Select_All_Click);
            // 
            // BTN_Reload
            // 
            this.BTN_Reload.BackColor = System.Drawing.Color.Gold;
            this.BTN_Reload.Location = new System.Drawing.Point(223, 603);
            this.BTN_Reload.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Reload.Name = "BTN_Reload";
            this.BTN_Reload.Size = new System.Drawing.Size(117, 33);
            this.BTN_Reload.TabIndex = 24;
            this.BTN_Reload.Text = "Reload";
            this.BTN_Reload.UseVisualStyleBackColor = false;
            this.BTN_Reload.Visible = false;
            this.BTN_Reload.Click += new System.EventHandler(this.BTN_Reload_Click);
            // 
            // BTN_SendPackage
            // 
            this.BTN_SendPackage.BackColor = System.Drawing.Color.Honeydew;
            this.BTN_SendPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SendPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_SendPackage.Location = new System.Drawing.Point(374, 601);
            this.BTN_SendPackage.Name = "BTN_SendPackage";
            this.BTN_SendPackage.Size = new System.Drawing.Size(216, 59);
            this.BTN_SendPackage.TabIndex = 22;
            this.BTN_SendPackage.Text = "บันทึก";
            this.BTN_SendPackage.UseVisualStyleBackColor = false;
            this.BTN_SendPackage.Click += new System.EventHandler(this.BTN_SendPackage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TXT_LOG);
            this.panel2.Controls.Add(this.Grid_Relay);
            this.panel2.Location = new System.Drawing.Point(5, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 447);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.LAB_status);
            this.panel3.Location = new System.Drawing.Point(853, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 197);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(74, 171);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(160, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Manual (เปิด/ปิด ที่ Breaker)";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(74, 136);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CURRENT  (  กำลังทำงาน )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(74, 96);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "OFF ( ปิด )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(74, 54);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ON ( เปิด )";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Location = new System.Drawing.Point(19, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 20);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(19, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 20);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Location = new System.Drawing.Point(19, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 20);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Location = new System.Drawing.Point(19, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 20);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // LAB_status
            // 
            this.LAB_status.AutoSize = true;
            this.LAB_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LAB_status.Location = new System.Drawing.Point(14, 9);
            this.LAB_status.Name = "LAB_status";
            this.LAB_status.Size = new System.Drawing.Size(144, 25);
            this.LAB_status.TabIndex = 0;
            this.LAB_status.Text = "STATUS TAG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(3, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ACTION LOG";
            // 
            // TXT_LOG
            // 
            this.TXT_LOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TXT_LOG.Location = new System.Drawing.Point(149, 236);
            this.TXT_LOG.Multiline = true;
            this.TXT_LOG.Name = "TXT_LOG";
            this.TXT_LOG.ReadOnly = true;
            this.TXT_LOG.Size = new System.Drawing.Size(626, 197);
            this.TXT_LOG.TabIndex = 1;
            // 
            // Grid_Relay
            // 
            this.Grid_Relay.AllowUserToAddRows = false;
            this.Grid_Relay.AllowUserToDeleteRows = false;
            this.Grid_Relay.AllowUserToResizeColumns = false;
            this.Grid_Relay.AllowUserToResizeRows = false;
            this.Grid_Relay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Relay.Location = new System.Drawing.Point(3, 3);
            this.Grid_Relay.Name = "Grid_Relay";
            this.Grid_Relay.Size = new System.Drawing.Size(1145, 227);
            this.Grid_Relay.TabIndex = 0;
            this.Grid_Relay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Relay_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(864, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 49);
            this.button1.TabIndex = 23;
            this.button1.Text = "รีเช็ท";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_HOME
            // 
            this.BTN_HOME.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_HOME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_HOME.Location = new System.Drawing.Point(731, 17);
            this.BTN_HOME.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_HOME.Name = "BTN_HOME";
            this.BTN_HOME.Size = new System.Drawing.Size(82, 32);
            this.BTN_HOME.TabIndex = 24;
            this.BTN_HOME.Text = "BUILDING";
            this.BTN_HOME.UseVisualStyleBackColor = false;
            this.BTN_HOME.Click += new System.EventHandler(this.BTN_HOME_Click);
            // 
            // BTN_GROUP
            // 
            this.BTN_GROUP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_GROUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_GROUP.Location = new System.Drawing.Point(917, 17);
            this.BTN_GROUP.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_GROUP.Name = "BTN_GROUP";
            this.BTN_GROUP.Size = new System.Drawing.Size(82, 32);
            this.BTN_GROUP.TabIndex = 25;
            this.BTN_GROUP.Text = "GROUP";
            this.BTN_GROUP.UseVisualStyleBackColor = false;
            this.BTN_GROUP.Click += new System.EventHandler(this.BTN_GROUP_Click);
            // 
            // BTN_REFRESH
            // 
            this.BTN_REFRESH.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_REFRESH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_REFRESH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_REFRESH.Location = new System.Drawing.Point(2, 602);
            this.BTN_REFRESH.Name = "BTN_REFRESH";
            this.BTN_REFRESH.Size = new System.Drawing.Size(216, 59);
            this.BTN_REFRESH.TabIndex = 27;
            this.BTN_REFRESH.Text = "รีโหลด";
            this.BTN_REFRESH.UseVisualStyleBackColor = false;
            this.BTN_REFRESH.Click += new System.EventHandler(this.BTN_REFRESH_Click);
            // 
            // BTN_EDIT_NAME
            // 
            this.BTN_EDIT_NAME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_EDIT_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_EDIT_NAME.Location = new System.Drawing.Point(743, 603);
            this.BTN_EDIT_NAME.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_EDIT_NAME.Name = "BTN_EDIT_NAME";
            this.BTN_EDIT_NAME.Size = new System.Drawing.Size(116, 49);
            this.BTN_EDIT_NAME.TabIndex = 4;
            this.BTN_EDIT_NAME.Text = "บันทึกเปลี่ยนชื่อ";
            this.BTN_EDIT_NAME.UseVisualStyleBackColor = true;
            this.BTN_EDIT_NAME.Click += new System.EventHandler(this.BTN_EDIT_NAME_Click);
            // 
            // BTN_SCHEDULE
            // 
            this.BTN_SCHEDULE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_SCHEDULE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SCHEDULE.Location = new System.Drawing.Point(1094, 17);
            this.BTN_SCHEDULE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SCHEDULE.Name = "BTN_SCHEDULE";
            this.BTN_SCHEDULE.Size = new System.Drawing.Size(82, 32);
            this.BTN_SCHEDULE.TabIndex = 32;
            this.BTN_SCHEDULE.Text = "SCHEDULE";
            this.BTN_SCHEDULE.UseVisualStyleBackColor = false;
            this.BTN_SCHEDULE.Click += new System.EventHandler(this.BTN_SCHEDULE_Click);
            // 
            // BTN_CONTROL
            // 
            this.BTN_CONTROL.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_CONTROL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CONTROL.Enabled = false;
            this.BTN_CONTROL.Location = new System.Drawing.Point(826, 17);
            this.BTN_CONTROL.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CONTROL.Name = "BTN_CONTROL";
            this.BTN_CONTROL.Size = new System.Drawing.Size(82, 32);
            this.BTN_CONTROL.TabIndex = 33;
            this.BTN_CONTROL.Text = "CONTROL";
            this.BTN_CONTROL.UseVisualStyleBackColor = false;
            this.BTN_CONTROL.Click += new System.EventHandler(this.BTN_CONTROL_Click);
            // 
            // BTN_LOGOUT
            // 
            this.BTN_LOGOUT.BackColor = System.Drawing.Color.DarkOrange;
            this.BTN_LOGOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_LOGOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_LOGOUT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_LOGOUT.Location = new System.Drawing.Point(1076, 624);
            this.BTN_LOGOUT.Name = "BTN_LOGOUT";
            this.BTN_LOGOUT.Size = new System.Drawing.Size(100, 36);
            this.BTN_LOGOUT.TabIndex = 48;
            this.BTN_LOGOUT.Text = "LOGOUT";
            this.BTN_LOGOUT.UseVisualStyleBackColor = false;
            this.BTN_LOGOUT.Click += new System.EventHandler(this.BTN_LOGOUT_Click);
            // 
            // BTN_LAYOUT
            // 
            this.BTN_LAYOUT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_LAYOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_LAYOUT.Location = new System.Drawing.Point(1008, 17);
            this.BTN_LAYOUT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_LAYOUT.Name = "BTN_LAYOUT";
            this.BTN_LAYOUT.Size = new System.Drawing.Size(82, 32);
            this.BTN_LAYOUT.TabIndex = 49;
            this.BTN_LAYOUT.Text = "LAYOUT";
            this.BTN_LAYOUT.UseVisualStyleBackColor = false;
            this.BTN_LAYOUT.Click += new System.EventHandler(this.BTN_LAYOUT_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iconsiam.Properties.Resources.BG_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.BTN_LAYOUT);
            this.Controls.Add(this.BTN_LOGOUT);
            this.Controls.Add(this.BTN_CONTROL);
            this.Controls.Add(this.BTN_SCHEDULE);
            this.Controls.Add(this.BTN_EDIT_NAME);
            this.Controls.Add(this.BTN_REFRESH);
            this.Controls.Add(this.BTN_Reload);
            this.Controls.Add(this.BTN_GROUP);
            this.Controls.Add(this.BTN_HOME);
            this.Controls.Add(this.BTN_SendPackage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICONSIAM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Board.ResumeLayout(false);
            this.groupBox_Board.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Relay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox ListComport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Grid_Relay;
        private System.Windows.Forms.CheckBox Select_All;
        private System.Windows.Forms.Button BTN_SendPackage;
        private System.Windows.Forms.GroupBox groupBox_Board;
        private System.Windows.Forms.RadioButton RAD_OFF;
        private System.Windows.Forms.RadioButton RAD_ON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_LOG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LAB_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_Reload;
        private System.Windows.Forms.Button BTN_HOME;
        private System.Windows.Forms.Button BTN_GROUP;
        private System.Windows.Forms.Button BTN_REFRESH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RAD_FLOOR_6;
        private System.Windows.Forms.RadioButton RAD_FLOOR_4;
        private System.Windows.Forms.RadioButton RAD_FLOOR_3;
        private System.Windows.Forms.RadioButton RAD_FLOOR_2;
        private System.Windows.Forms.Button BTN_EDIT_NAME;
        private System.Windows.Forms.Button BTN_SCHEDULE;
        private System.Windows.Forms.Button BTN_CONTROL;
        private System.Windows.Forms.Button BTN_LOGOUT;
        private System.Windows.Forms.RadioButton RAD_FLOOR_8;
        private System.Windows.Forms.RadioButton RAD_UG;
        private System.Windows.Forms.RadioButton RAD_FLOOR_7;
        private System.Windows.Forms.Button BTN_LAYOUT;
    }
}