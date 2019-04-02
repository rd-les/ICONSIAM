namespace iconsiam {
    partial class GroupForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_LOG = new System.Windows.Forms.TextBox();
            this.GRIDVIEW_GROUP_LIST = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_ACTION_ON_OFF = new System.Windows.Forms.Button();
            this.RAD_OFF = new System.Windows.Forms.RadioButton();
            this.RAD_ON = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_ADD_GROUP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_ACTION = new System.Windows.Forms.TextBox();
            this.BTN_DELETE_GROUP = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.CHK_USABLE = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_ADD_RELAY = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TREEVIEW_LIST_RELAY = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_GROUP_ID = new System.Windows.Forms.TextBox();
            this.TXT_GROUP_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PANEL_GRID_RELAY = new System.Windows.Forms.Panel();
            this.CHK_SELECT_ALL = new System.Windows.Forms.CheckBox();
            this.LABEL_GROUP_NAME = new System.Windows.Forms.Label();
            this.ListComport = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BTN_RELAY_CANCEL = new System.Windows.Forms.Button();
            this.BTN_RELAY_SAVE = new System.Windows.Forms.Button();
            this.Grid_Relay = new System.Windows.Forms.DataGridView();
            this.BTN_CONTROL = new System.Windows.Forms.Button();
            this.BTN_SCHEDULE = new System.Windows.Forms.Button();
            this.BTN_HOME = new System.Windows.Forms.Button();
            this.BTN_GROUP = new System.Windows.Forms.Button();
            this.BTN_LOGOUT = new System.Windows.Forms.Button();
            this.BTN_LAYOUT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEW_GROUP_LIST)).BeginInit();
            this.panel2.SuspendLayout();
            this.PANEL_GRID_RELAY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Relay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(26, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 570);
            this.panel1.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.TXT_LOG);
            this.panel3.Controls.Add(this.GRIDVIEW_GROUP_LIST);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 555);
            this.panel3.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(9, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "ACTION LOG";
            // 
            // TXT_LOG
            // 
            this.TXT_LOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TXT_LOG.Location = new System.Drawing.Point(14, 358);
            this.TXT_LOG.Multiline = true;
            this.TXT_LOG.Name = "TXT_LOG";
            this.TXT_LOG.ReadOnly = true;
            this.TXT_LOG.Size = new System.Drawing.Size(626, 197);
            this.TXT_LOG.TabIndex = 3;
            // 
            // GRIDVIEW_GROUP_LIST
            // 
            this.GRIDVIEW_GROUP_LIST.AllowUserToAddRows = false;
            this.GRIDVIEW_GROUP_LIST.AllowUserToDeleteRows = false;
            this.GRIDVIEW_GROUP_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEW_GROUP_LIST.Location = new System.Drawing.Point(2, 70);
            this.GRIDVIEW_GROUP_LIST.Margin = new System.Windows.Forms.Padding(2);
            this.GRIDVIEW_GROUP_LIST.MultiSelect = false;
            this.GRIDVIEW_GROUP_LIST.Name = "GRIDVIEW_GROUP_LIST";
            this.GRIDVIEW_GROUP_LIST.ReadOnly = true;
            this.GRIDVIEW_GROUP_LIST.RowTemplate.Height = 24;
            this.GRIDVIEW_GROUP_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRIDVIEW_GROUP_LIST.Size = new System.Drawing.Size(626, 241);
            this.GRIDVIEW_GROUP_LIST.TabIndex = 2;
            this.GRIDVIEW_GROUP_LIST.TabStop = false;
            this.GRIDVIEW_GROUP_LIST.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEW_GROUP_LIST_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "GROUP LIST";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.BTN_ACTION_ON_OFF);
            this.panel2.Controls.Add(this.RAD_OFF);
            this.panel2.Controls.Add(this.RAD_ON);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BTN_ADD_GROUP);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TXT_ACTION);
            this.panel2.Controls.Add(this.BTN_DELETE_GROUP);
            this.panel2.Controls.Add(this.BTN_SAVE);
            this.panel2.Controls.Add(this.CHK_USABLE);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.BTN_ADD_RELAY);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TREEVIEW_LIST_RELAY);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TXT_GROUP_ID);
            this.panel2.Controls.Add(this.TXT_GROUP_NAME);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(664, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 555);
            this.panel2.TabIndex = 0;
            // 
            // BTN_ACTION_ON_OFF
            // 
            this.BTN_ACTION_ON_OFF.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_ACTION_ON_OFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ACTION_ON_OFF.Location = new System.Drawing.Point(314, 144);
            this.BTN_ACTION_ON_OFF.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ACTION_ON_OFF.Name = "BTN_ACTION_ON_OFF";
            this.BTN_ACTION_ON_OFF.Size = new System.Drawing.Size(71, 32);
            this.BTN_ACTION_ON_OFF.TabIndex = 36;
            this.BTN_ACTION_ON_OFF.Text = "ACTION";
            this.BTN_ACTION_ON_OFF.UseVisualStyleBackColor = false;
            this.BTN_ACTION_ON_OFF.Click += new System.EventHandler(this.BTN_ACTION_ON_OFF_Click);
            // 
            // RAD_OFF
            // 
            this.RAD_OFF.AutoSize = true;
            this.RAD_OFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_OFF.Location = new System.Drawing.Point(241, 152);
            this.RAD_OFF.Name = "RAD_OFF";
            this.RAD_OFF.Size = new System.Drawing.Size(67, 17);
            this.RAD_OFF.TabIndex = 35;
            this.RAD_OFF.TabStop = true;
            this.RAD_OFF.Text = "OFF ALL";
            this.RAD_OFF.UseVisualStyleBackColor = true;
            // 
            // RAD_ON
            // 
            this.RAD_ON.AutoSize = true;
            this.RAD_ON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_ON.Location = new System.Drawing.Point(147, 152);
            this.RAD_ON.Name = "RAD_ON";
            this.RAD_ON.Size = new System.Drawing.Size(63, 17);
            this.RAD_ON.TabIndex = 34;
            this.RAD_ON.TabStop = true;
            this.RAD_ON.Text = "ON ALL";
            this.RAD_ON.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(62, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "ACTION : ";
            // 
            // BTN_ADD_GROUP
            // 
            this.BTN_ADD_GROUP.BackColor = System.Drawing.Color.GreenYellow;
            this.BTN_ADD_GROUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_ADD_GROUP.Location = new System.Drawing.Point(335, 2);
            this.BTN_ADD_GROUP.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ADD_GROUP.Name = "BTN_ADD_GROUP";
            this.BTN_ADD_GROUP.Size = new System.Drawing.Size(151, 37);
            this.BTN_ADD_GROUP.TabIndex = 31;
            this.BTN_ADD_GROUP.Text = "ADD GROUP";
            this.BTN_ADD_GROUP.UseVisualStyleBackColor = false;
            this.BTN_ADD_GROUP.Click += new System.EventHandler(this.BTN_ADD_GROUP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Tomato;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(66, 210);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Double Right Click เพื่อลบ";
            // 
            // TXT_ACTION
            // 
            this.TXT_ACTION.Location = new System.Drawing.Point(25, 500);
            this.TXT_ACTION.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_ACTION.Name = "TXT_ACTION";
            this.TXT_ACTION.ReadOnly = true;
            this.TXT_ACTION.Size = new System.Drawing.Size(76, 20);
            this.TXT_ACTION.TabIndex = 31;
            this.TXT_ACTION.Visible = false;
            // 
            // BTN_DELETE_GROUP
            // 
            this.BTN_DELETE_GROUP.BackColor = System.Drawing.Color.Tomato;
            this.BTN_DELETE_GROUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DELETE_GROUP.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE_GROUP.Location = new System.Drawing.Point(295, 503);
            this.BTN_DELETE_GROUP.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DELETE_GROUP.Name = "BTN_DELETE_GROUP";
            this.BTN_DELETE_GROUP.Size = new System.Drawing.Size(90, 41);
            this.BTN_DELETE_GROUP.TabIndex = 30;
            this.BTN_DELETE_GROUP.Text = "DELETE";
            this.BTN_DELETE_GROUP.UseVisualStyleBackColor = false;
            this.BTN_DELETE_GROUP.Click += new System.EventHandler(this.BTN_DELETE_GROUP_Click);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_SAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SAVE.Location = new System.Drawing.Point(142, 503);
            this.BTN_SAVE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(90, 41);
            this.BTN_SAVE.TabIndex = 29;
            this.BTN_SAVE.Text = "SAVE";
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // CHK_USABLE
            // 
            this.CHK_USABLE.AutoSize = true;
            this.CHK_USABLE.Location = new System.Drawing.Point(146, 118);
            this.CHK_USABLE.Margin = new System.Windows.Forms.Padding(2);
            this.CHK_USABLE.Name = "CHK_USABLE";
            this.CHK_USABLE.Size = new System.Drawing.Size(15, 14);
            this.CHK_USABLE.TabIndex = 28;
            this.CHK_USABLE.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(56, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "USABLE : ";
            // 
            // BTN_ADD_RELAY
            // 
            this.BTN_ADD_RELAY.BackColor = System.Drawing.Color.LightYellow;
            this.BTN_ADD_RELAY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ADD_RELAY.Location = new System.Drawing.Point(292, 198);
            this.BTN_ADD_RELAY.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ADD_RELAY.Name = "BTN_ADD_RELAY";
            this.BTN_ADD_RELAY.Size = new System.Drawing.Size(93, 32);
            this.BTN_ADD_RELAY.TabIndex = 26;
            this.BTN_ADD_RELAY.Text = "ADD RELAY";
            this.BTN_ADD_RELAY.UseVisualStyleBackColor = false;
            this.BTN_ADD_RELAY.Click += new System.EventHandler(this.BTN_ADD_RELAY_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(60, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "DETAIL : ";
            // 
            // TREEVIEW_LIST_RELAY
            // 
            this.TREEVIEW_LIST_RELAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TREEVIEW_LIST_RELAY.FullRowSelect = true;
            this.TREEVIEW_LIST_RELAY.HideSelection = false;
            this.TREEVIEW_LIST_RELAY.HotTracking = true;
            this.TREEVIEW_LIST_RELAY.Indent = 25;
            this.TREEVIEW_LIST_RELAY.LineColor = System.Drawing.Color.Maroon;
            this.TREEVIEW_LIST_RELAY.Location = new System.Drawing.Point(142, 236);
            this.TREEVIEW_LIST_RELAY.Margin = new System.Windows.Forms.Padding(2);
            this.TREEVIEW_LIST_RELAY.Name = "TREEVIEW_LIST_RELAY";
            this.TREEVIEW_LIST_RELAY.Size = new System.Drawing.Size(243, 263);
            this.TREEVIEW_LIST_RELAY.TabIndex = 25;
            this.TREEVIEW_LIST_RELAY.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TREEVIEW_LIST_RELAY_NodeMouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(41, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "GROUP ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "GROUP NAME : ";
            // 
            // TXT_GROUP_ID
            // 
            this.TXT_GROUP_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TXT_GROUP_ID.Location = new System.Drawing.Point(142, 42);
            this.TXT_GROUP_ID.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_GROUP_ID.Name = "TXT_GROUP_ID";
            this.TXT_GROUP_ID.ReadOnly = true;
            this.TXT_GROUP_ID.Size = new System.Drawing.Size(265, 26);
            this.TXT_GROUP_ID.TabIndex = 4;
            // 
            // TXT_GROUP_NAME
            // 
            this.TXT_GROUP_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TXT_GROUP_NAME.Location = new System.Drawing.Point(142, 79);
            this.TXT_GROUP_NAME.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_GROUP_NAME.Name = "TXT_GROUP_NAME";
            this.TXT_GROUP_NAME.Size = new System.Drawing.Size(265, 26);
            this.TXT_GROUP_NAME.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "GROUP EDIT";
            // 
            // PANEL_GRID_RELAY
            // 
            this.PANEL_GRID_RELAY.BackColor = System.Drawing.Color.SeaShell;
            this.PANEL_GRID_RELAY.Controls.Add(this.CHK_SELECT_ALL);
            this.PANEL_GRID_RELAY.Controls.Add(this.LABEL_GROUP_NAME);
            this.PANEL_GRID_RELAY.Controls.Add(this.ListComport);
            this.PANEL_GRID_RELAY.Controls.Add(this.label7);
            this.PANEL_GRID_RELAY.Controls.Add(this.BTN_RELAY_CANCEL);
            this.PANEL_GRID_RELAY.Controls.Add(this.BTN_RELAY_SAVE);
            this.PANEL_GRID_RELAY.Controls.Add(this.Grid_Relay);
            this.PANEL_GRID_RELAY.Location = new System.Drawing.Point(121, 79);
            this.PANEL_GRID_RELAY.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_GRID_RELAY.Name = "PANEL_GRID_RELAY";
            this.PANEL_GRID_RELAY.Size = new System.Drawing.Size(910, 405);
            this.PANEL_GRID_RELAY.TabIndex = 3;
            this.PANEL_GRID_RELAY.Visible = false;
            // 
            // CHK_SELECT_ALL
            // 
            this.CHK_SELECT_ALL.AutoSize = true;
            this.CHK_SELECT_ALL.Location = new System.Drawing.Point(714, 15);
            this.CHK_SELECT_ALL.Margin = new System.Windows.Forms.Padding(2);
            this.CHK_SELECT_ALL.Name = "CHK_SELECT_ALL";
            this.CHK_SELECT_ALL.Size = new System.Drawing.Size(89, 17);
            this.CHK_SELECT_ALL.TabIndex = 8;
            this.CHK_SELECT_ALL.Text = "SELECT ALL";
            this.CHK_SELECT_ALL.UseVisualStyleBackColor = true;
            this.CHK_SELECT_ALL.CheckedChanged += new System.EventHandler(this.CHK_SELECT_ALL_CheckedChanged);
            // 
            // LABEL_GROUP_NAME
            // 
            this.LABEL_GROUP_NAME.AutoSize = true;
            this.LABEL_GROUP_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LABEL_GROUP_NAME.ForeColor = System.Drawing.Color.OliveDrab;
            this.LABEL_GROUP_NAME.Location = new System.Drawing.Point(189, 6);
            this.LABEL_GROUP_NAME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABEL_GROUP_NAME.Name = "LABEL_GROUP_NAME";
            this.LABEL_GROUP_NAME.Size = new System.Drawing.Size(250, 26);
            this.LABEL_GROUP_NAME.TabIndex = 7;
            this.LABEL_GROUP_NAME.Text = "LABEL_GROUP_NAME";
            // 
            // ListComport
            // 
            this.ListComport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
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
            this.ListComport.Location = new System.Drawing.Point(502, 6);
            this.ListComport.Margin = new System.Windows.Forms.Padding(2);
            this.ListComport.Name = "ListComport";
            this.ListComport.Size = new System.Drawing.Size(186, 30);
            this.ListComport.TabIndex = 6;
            this.ListComport.SelectedIndexChanged += new System.EventHandler(this.ListComport_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(24, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "GROUP NAME : ";
            // 
            // BTN_RELAY_CANCEL
            // 
            this.BTN_RELAY_CANCEL.BackColor = System.Drawing.Color.IndianRed;
            this.BTN_RELAY_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_RELAY_CANCEL.Location = new System.Drawing.Point(542, 304);
            this.BTN_RELAY_CANCEL.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_RELAY_CANCEL.Name = "BTN_RELAY_CANCEL";
            this.BTN_RELAY_CANCEL.Size = new System.Drawing.Size(205, 68);
            this.BTN_RELAY_CANCEL.TabIndex = 4;
            this.BTN_RELAY_CANCEL.Text = "CANCEL";
            this.BTN_RELAY_CANCEL.UseVisualStyleBackColor = false;
            this.BTN_RELAY_CANCEL.Click += new System.EventHandler(this.BTN_RELAY_CANCEL_Click);
            // 
            // BTN_RELAY_SAVE
            // 
            this.BTN_RELAY_SAVE.BackColor = System.Drawing.Color.OliveDrab;
            this.BTN_RELAY_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_RELAY_SAVE.Location = new System.Drawing.Point(217, 304);
            this.BTN_RELAY_SAVE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_RELAY_SAVE.Name = "BTN_RELAY_SAVE";
            this.BTN_RELAY_SAVE.Size = new System.Drawing.Size(205, 68);
            this.BTN_RELAY_SAVE.TabIndex = 3;
            this.BTN_RELAY_SAVE.Text = "INSERT RELAY";
            this.BTN_RELAY_SAVE.UseVisualStyleBackColor = false;
            this.BTN_RELAY_SAVE.Click += new System.EventHandler(this.BTN_RELAY_SAVE_Click);
            // 
            // Grid_Relay
            // 
            this.Grid_Relay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Relay.Location = new System.Drawing.Point(2, 42);
            this.Grid_Relay.Margin = new System.Windows.Forms.Padding(2);
            this.Grid_Relay.Name = "Grid_Relay";
            this.Grid_Relay.RowTemplate.Height = 24;
            this.Grid_Relay.Size = new System.Drawing.Size(902, 239);
            this.Grid_Relay.TabIndex = 0;
            // 
            // BTN_CONTROL
            // 
            this.BTN_CONTROL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_CONTROL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CONTROL.Location = new System.Drawing.Point(834, 20);
            this.BTN_CONTROL.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CONTROL.Name = "BTN_CONTROL";
            this.BTN_CONTROL.Size = new System.Drawing.Size(82, 32);
            this.BTN_CONTROL.TabIndex = 43;
            this.BTN_CONTROL.Text = "CONTROL";
            this.BTN_CONTROL.UseVisualStyleBackColor = false;
            this.BTN_CONTROL.Click += new System.EventHandler(this.BTN_CONTROL_Click_1);
            // 
            // BTN_SCHEDULE
            // 
            this.BTN_SCHEDULE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_SCHEDULE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SCHEDULE.Location = new System.Drawing.Point(1102, 20);
            this.BTN_SCHEDULE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SCHEDULE.Name = "BTN_SCHEDULE";
            this.BTN_SCHEDULE.Size = new System.Drawing.Size(82, 32);
            this.BTN_SCHEDULE.TabIndex = 42;
            this.BTN_SCHEDULE.Text = "SCHEDULE";
            this.BTN_SCHEDULE.UseVisualStyleBackColor = false;
            this.BTN_SCHEDULE.Click += new System.EventHandler(this.BTN_SCHEDULE_Click_1);
            // 
            // BTN_HOME
            // 
            this.BTN_HOME.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_HOME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_HOME.Location = new System.Drawing.Point(742, 20);
            this.BTN_HOME.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_HOME.Name = "BTN_HOME";
            this.BTN_HOME.Size = new System.Drawing.Size(82, 32);
            this.BTN_HOME.TabIndex = 39;
            this.BTN_HOME.Text = "BUILDING";
            this.BTN_HOME.UseVisualStyleBackColor = false;
            this.BTN_HOME.Click += new System.EventHandler(this.BTN_HOME_Click_1);
            // 
            // BTN_GROUP
            // 
            this.BTN_GROUP.BackColor = System.Drawing.Color.GreenYellow;
            this.BTN_GROUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_GROUP.Enabled = false;
            this.BTN_GROUP.Location = new System.Drawing.Point(924, 20);
            this.BTN_GROUP.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_GROUP.Name = "BTN_GROUP";
            this.BTN_GROUP.Size = new System.Drawing.Size(82, 32);
            this.BTN_GROUP.TabIndex = 40;
            this.BTN_GROUP.Text = "GROUP";
            this.BTN_GROUP.UseVisualStyleBackColor = false;
            // 
            // BTN_LOGOUT
            // 
            this.BTN_LOGOUT.BackColor = System.Drawing.Color.DarkOrange;
            this.BTN_LOGOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_LOGOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_LOGOUT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_LOGOUT.Location = new System.Drawing.Point(1086, 654);
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
            this.BTN_LAYOUT.Location = new System.Drawing.Point(1015, 20);
            this.BTN_LAYOUT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_LAYOUT.Name = "BTN_LAYOUT";
            this.BTN_LAYOUT.Size = new System.Drawing.Size(82, 32);
            this.BTN_LAYOUT.TabIndex = 50;
            this.BTN_LAYOUT.Text = "LAYOUT";
            this.BTN_LAYOUT.UseVisualStyleBackColor = false;
            this.BTN_LAYOUT.Click += new System.EventHandler(this.BTN_LAYOUT_Click);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::iconsiam.Properties.Resources.BG_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.BTN_LAYOUT);
            this.Controls.Add(this.BTN_LOGOUT);
            this.Controls.Add(this.PANEL_GRID_RELAY);
            this.Controls.Add(this.BTN_CONTROL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_SCHEDULE);
            this.Controls.Add(this.BTN_HOME);
            this.Controls.Add(this.BTN_GROUP);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICONSIAM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupForm_FormClosed);
            this.Load += new System.EventHandler(this.GroupForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEW_GROUP_LIST)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PANEL_GRID_RELAY.ResumeLayout(false);
            this.PANEL_GRID_RELAY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Relay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_GROUP_ID;
        private System.Windows.Forms.TextBox TXT_GROUP_NAME;
        private System.Windows.Forms.DataGridView GRIDVIEW_GROUP_LIST;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView TREEVIEW_LIST_RELAY;
        private System.Windows.Forms.Button BTN_ADD_RELAY;
        private System.Windows.Forms.Panel PANEL_GRID_RELAY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_RELAY_CANCEL;
        private System.Windows.Forms.Button BTN_RELAY_SAVE;
        private System.Windows.Forms.DataGridView Grid_Relay;
        private System.Windows.Forms.ComboBox ListComport;
        private System.Windows.Forms.Label LABEL_GROUP_NAME;
        private System.Windows.Forms.CheckBox CHK_USABLE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_DELETE_GROUP;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.TextBox TXT_ACTION;
        private System.Windows.Forms.CheckBox CHK_SELECT_ALL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTN_CONTROL;
        private System.Windows.Forms.Button BTN_SCHEDULE;
        private System.Windows.Forms.Button BTN_HOME;
        private System.Windows.Forms.Button BTN_GROUP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXT_LOG;
        private System.Windows.Forms.Button BTN_LOGOUT;
        private System.Windows.Forms.Button BTN_ACTION_ON_OFF;
        private System.Windows.Forms.RadioButton RAD_OFF;
        private System.Windows.Forms.RadioButton RAD_ON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_ADD_GROUP;
        private System.Windows.Forms.Button BTN_LAYOUT;
    }
}