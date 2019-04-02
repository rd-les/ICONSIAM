namespace iconsiam {
    partial class ScheduleForm {
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
            this.GRIDVIEW_SCHEDULE = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CHECKLISTBOX_GROUP = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_SCHEDULE_NAME = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_ACTION = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CHK_USABLE = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RAD_OFF = new System.Windows.Forms.RadioButton();
            this.RAD_ON = new System.Windows.Forms.RadioButton();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_ADD_SCHEDULE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TIME_STOP = new System.Windows.Forms.DateTimePicker();
            this.TIME_START = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.COMBO_GROUP = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TXT_SCHEDULE_ID = new System.Windows.Forms.TextBox();
            this.BTN_CONTROL = new System.Windows.Forms.Button();
            this.BTN_SCHEDULE = new System.Windows.Forms.Button();
            this.BTN_GROUP = new System.Windows.Forms.Button();
            this.BTN_HOME = new System.Windows.Forms.Button();
            this.BTN_LOGOUT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_LAYOUT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEW_SCHEDULE)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.GRIDVIEW_SCHEDULE);
            this.panel1.Location = new System.Drawing.Point(10, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 505);
            this.panel1.TabIndex = 45;
            // 
            // GRIDVIEW_SCHEDULE
            // 
            this.GRIDVIEW_SCHEDULE.AllowUserToAddRows = false;
            this.GRIDVIEW_SCHEDULE.AllowUserToDeleteRows = false;
            this.GRIDVIEW_SCHEDULE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEW_SCHEDULE.Location = new System.Drawing.Point(3, 11);
            this.GRIDVIEW_SCHEDULE.Margin = new System.Windows.Forms.Padding(2);
            this.GRIDVIEW_SCHEDULE.MultiSelect = false;
            this.GRIDVIEW_SCHEDULE.Name = "GRIDVIEW_SCHEDULE";
            this.GRIDVIEW_SCHEDULE.ReadOnly = true;
            this.GRIDVIEW_SCHEDULE.RowTemplate.Height = 24;
            this.GRIDVIEW_SCHEDULE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRIDVIEW_SCHEDULE.Size = new System.Drawing.Size(668, 485);
            this.GRIDVIEW_SCHEDULE.TabIndex = 0;
            this.GRIDVIEW_SCHEDULE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEW_SCHEDULE_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.CHECKLISTBOX_GROUP);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TXT_SCHEDULE_NAME);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TXT_ACTION);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CHK_USABLE);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.RAD_OFF);
            this.panel2.Controls.Add(this.RAD_ON);
            this.panel2.Controls.Add(this.BTN_DELETE);
            this.panel2.Controls.Add(this.BTN_SAVE);
            this.panel2.Controls.Add(this.BTN_ADD_SCHEDULE);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TIME_STOP);
            this.panel2.Controls.Add(this.TIME_START);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.COMBO_GROUP);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.TXT_SCHEDULE_ID);
            this.panel2.Location = new System.Drawing.Point(687, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 505);
            this.panel2.TabIndex = 46;
            // 
            // CHECKLISTBOX_GROUP
            // 
            this.CHECKLISTBOX_GROUP.FormattingEnabled = true;
            this.CHECKLISTBOX_GROUP.Location = new System.Drawing.Point(201, 154);
            this.CHECKLISTBOX_GROUP.Name = "CHECKLISTBOX_GROUP";
            this.CHECKLISTBOX_GROUP.Size = new System.Drawing.Size(181, 109);
            this.CHECKLISTBOX_GROUP.TabIndex = 38;
            this.CHECKLISTBOX_GROUP.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(32, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "SCHEDULE NAME : ";
            // 
            // TXT_SCHEDULE_NAME
            // 
            this.TXT_SCHEDULE_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TXT_SCHEDULE_NAME.Location = new System.Drawing.Point(200, 85);
            this.TXT_SCHEDULE_NAME.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_SCHEDULE_NAME.Name = "TXT_SCHEDULE_NAME";
            this.TXT_SCHEDULE_NAME.Size = new System.Drawing.Size(194, 26);
            this.TXT_SCHEDULE_NAME.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(197, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "EVERYDAY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(112, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "ACTIVE : ";
            // 
            // TXT_ACTION
            // 
            this.TXT_ACTION.Location = new System.Drawing.Point(105, 406);
            this.TXT_ACTION.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_ACTION.Name = "TXT_ACTION";
            this.TXT_ACTION.ReadOnly = true;
            this.TXT_ACTION.Size = new System.Drawing.Size(76, 20);
            this.TXT_ACTION.TabIndex = 32;
            this.TXT_ACTION.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(61, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "SCHEDULE ID : ";
            // 
            // CHK_USABLE
            // 
            this.CHK_USABLE.AutoSize = true;
            this.CHK_USABLE.Location = new System.Drawing.Point(201, 377);
            this.CHK_USABLE.Margin = new System.Windows.Forms.Padding(2);
            this.CHK_USABLE.Name = "CHK_USABLE";
            this.CHK_USABLE.Size = new System.Drawing.Size(15, 14);
            this.CHK_USABLE.TabIndex = 30;
            this.CHK_USABLE.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(106, 372);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "USABLE : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(107, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "STATUS : ";
            // 
            // RAD_OFF
            // 
            this.RAD_OFF.AutoSize = true;
            this.RAD_OFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_OFF.Location = new System.Drawing.Point(261, 343);
            this.RAD_OFF.Name = "RAD_OFF";
            this.RAD_OFF.Size = new System.Drawing.Size(45, 17);
            this.RAD_OFF.TabIndex = 15;
            this.RAD_OFF.Text = "OFF";
            this.RAD_OFF.UseVisualStyleBackColor = true;
            this.RAD_OFF.Visible = false;
            // 
            // RAD_ON
            // 
            this.RAD_ON.AutoSize = true;
            this.RAD_ON.Checked = true;
            this.RAD_ON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAD_ON.Location = new System.Drawing.Point(201, 343);
            this.RAD_ON.Name = "RAD_ON";
            this.RAD_ON.Size = new System.Drawing.Size(41, 17);
            this.RAD_ON.TabIndex = 14;
            this.RAD_ON.TabStop = true;
            this.RAD_ON.Text = "ON";
            this.RAD_ON.UseVisualStyleBackColor = true;
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.BackColor = System.Drawing.Color.Crimson;
            this.BTN_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_DELETE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_DELETE.Location = new System.Drawing.Point(265, 447);
            this.BTN_DELETE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(136, 49);
            this.BTN_DELETE.TabIndex = 13;
            this.BTN_DELETE.Text = "DELETE";
            this.BTN_DELETE.UseVisualStyleBackColor = false;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_SAVE.Location = new System.Drawing.Point(104, 447);
            this.BTN_SAVE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(136, 49);
            this.BTN_SAVE.TabIndex = 12;
            this.BTN_SAVE.Text = "SAVE";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_ADD_SCHEDULE
            // 
            this.BTN_ADD_SCHEDULE.BackColor = System.Drawing.Color.GreenYellow;
            this.BTN_ADD_SCHEDULE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_ADD_SCHEDULE.Location = new System.Drawing.Point(331, 11);
            this.BTN_ADD_SCHEDULE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ADD_SCHEDULE.Name = "BTN_ADD_SCHEDULE";
            this.BTN_ADD_SCHEDULE.Size = new System.Drawing.Size(156, 36);
            this.BTN_ADD_SCHEDULE.TabIndex = 11;
            this.BTN_ADD_SCHEDULE.Text = "ADD SCHEDULE";
            this.BTN_ADD_SCHEDULE.UseVisualStyleBackColor = false;
            this.BTN_ADD_SCHEDULE.Click += new System.EventHandler(this.BTN_ADD_SCHEDULE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(297, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "-";
            // 
            // TIME_STOP
            // 
            this.TIME_STOP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TIME_STOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TIME_STOP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TIME_STOP.Location = new System.Drawing.Point(321, 273);
            this.TIME_STOP.Margin = new System.Windows.Forms.Padding(2);
            this.TIME_STOP.Name = "TIME_STOP";
            this.TIME_STOP.ShowUpDown = true;
            this.TIME_STOP.Size = new System.Drawing.Size(84, 26);
            this.TIME_STOP.TabIndex = 9;
            this.TIME_STOP.Value = new System.DateTime(2018, 10, 3, 22, 0, 0, 0);
            // 
            // TIME_START
            // 
            this.TIME_START.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TIME_START.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TIME_START.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TIME_START.Location = new System.Drawing.Point(201, 273);
            this.TIME_START.Margin = new System.Windows.Forms.Padding(2);
            this.TIME_START.Name = "TIME_START";
            this.TIME_START.ShowUpDown = true;
            this.TIME_START.Size = new System.Drawing.Size(87, 26);
            this.TIME_START.TabIndex = 8;
            this.TIME_START.Value = new System.DateTime(2018, 10, 3, 9, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(133, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "TIME : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(112, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "GROUP : ";
            // 
            // COMBO_GROUP
            // 
            this.COMBO_GROUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.COMBO_GROUP.FormattingEnabled = true;
            this.COMBO_GROUP.Items.AddRange(new object[] {
            "Please Select"});
            this.COMBO_GROUP.Location = new System.Drawing.Point(201, 121);
            this.COMBO_GROUP.Margin = new System.Windows.Forms.Padding(2);
            this.COMBO_GROUP.Name = "COMBO_GROUP";
            this.COMBO_GROUP.Size = new System.Drawing.Size(189, 28);
            this.COMBO_GROUP.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox4.Location = new System.Drawing.Point(196, 406);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 26);
            this.textBox4.TabIndex = 4;
            // 
            // TXT_SCHEDULE_ID
            // 
            this.TXT_SCHEDULE_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TXT_SCHEDULE_ID.Location = new System.Drawing.Point(201, 48);
            this.TXT_SCHEDULE_ID.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_SCHEDULE_ID.Name = "TXT_SCHEDULE_ID";
            this.TXT_SCHEDULE_ID.ReadOnly = true;
            this.TXT_SCHEDULE_ID.Size = new System.Drawing.Size(154, 26);
            this.TXT_SCHEDULE_ID.TabIndex = 3;
            // 
            // BTN_CONTROL
            // 
            this.BTN_CONTROL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_CONTROL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CONTROL.Location = new System.Drawing.Point(827, 20);
            this.BTN_CONTROL.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CONTROL.Name = "BTN_CONTROL";
            this.BTN_CONTROL.Size = new System.Drawing.Size(82, 32);
            this.BTN_CONTROL.TabIndex = 38;
            this.BTN_CONTROL.Text = "CONTROL";
            this.BTN_CONTROL.UseVisualStyleBackColor = false;
            this.BTN_CONTROL.Click += new System.EventHandler(this.BTN_CONTROL_Click_1);
            // 
            // BTN_SCHEDULE
            // 
            this.BTN_SCHEDULE.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_SCHEDULE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SCHEDULE.Enabled = false;
            this.BTN_SCHEDULE.Location = new System.Drawing.Point(1100, 20);
            this.BTN_SCHEDULE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SCHEDULE.Name = "BTN_SCHEDULE";
            this.BTN_SCHEDULE.Size = new System.Drawing.Size(82, 32);
            this.BTN_SCHEDULE.TabIndex = 37;
            this.BTN_SCHEDULE.Text = "SCHEDULE";
            this.BTN_SCHEDULE.UseVisualStyleBackColor = false;
            // 
            // BTN_GROUP
            // 
            this.BTN_GROUP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_GROUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_GROUP.Location = new System.Drawing.Point(919, 20);
            this.BTN_GROUP.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_GROUP.Name = "BTN_GROUP";
            this.BTN_GROUP.Size = new System.Drawing.Size(82, 32);
            this.BTN_GROUP.TabIndex = 35;
            this.BTN_GROUP.Text = "GROUP";
            this.BTN_GROUP.UseVisualStyleBackColor = false;
            this.BTN_GROUP.Click += new System.EventHandler(this.BTN_GROUP_Click_1);
            // 
            // BTN_HOME
            // 
            this.BTN_HOME.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_HOME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_HOME.Location = new System.Drawing.Point(732, 20);
            this.BTN_HOME.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_HOME.Name = "BTN_HOME";
            this.BTN_HOME.Size = new System.Drawing.Size(82, 32);
            this.BTN_HOME.TabIndex = 34;
            this.BTN_HOME.Text = "BUILDING";
            this.BTN_HOME.UseVisualStyleBackColor = false;
            this.BTN_HOME.Click += new System.EventHandler(this.BTN_HOME_Click_1);
            // 
            // BTN_LOGOUT
            // 
            this.BTN_LOGOUT.BackColor = System.Drawing.Color.DarkOrange;
            this.BTN_LOGOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_LOGOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_LOGOUT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_LOGOUT.Location = new System.Drawing.Point(1082, 645);
            this.BTN_LOGOUT.Name = "BTN_LOGOUT";
            this.BTN_LOGOUT.Size = new System.Drawing.Size(100, 36);
            this.BTN_LOGOUT.TabIndex = 47;
            this.BTN_LOGOUT.Text = "LOGOUT";
            this.BTN_LOGOUT.UseVisualStyleBackColor = false;
            this.BTN_LOGOUT.Click += new System.EventHandler(this.BTN_LOGOUT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_LAYOUT
            // 
            this.BTN_LAYOUT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_LAYOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_LAYOUT.Location = new System.Drawing.Point(1010, 20);
            this.BTN_LAYOUT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_LAYOUT.Name = "BTN_LAYOUT";
            this.BTN_LAYOUT.Size = new System.Drawing.Size(82, 32);
            this.BTN_LAYOUT.TabIndex = 50;
            this.BTN_LAYOUT.Text = "LAYOUT";
            this.BTN_LAYOUT.UseVisualStyleBackColor = false;
            this.BTN_LAYOUT.Click += new System.EventHandler(this.BTN_LAYOUT_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iconsiam.Properties.Resources.BG_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.BTN_LAYOUT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_LOGOUT);
            this.Controls.Add(this.BTN_CONTROL);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BTN_SCHEDULE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_HOME);
            this.Controls.Add(this.BTN_GROUP);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScheduleForm_FormClosed);
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEW_SCHEDULE)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GRIDVIEW_SCHEDULE;
        private System.Windows.Forms.DateTimePicker TIME_STOP;
        private System.Windows.Forms.DateTimePicker TIME_START;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox COMBO_GROUP;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TXT_SCHEDULE_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_ADD_SCHEDULE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RAD_OFF;
        private System.Windows.Forms.RadioButton RAD_ON;
        private System.Windows.Forms.CheckBox CHK_USABLE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_CONTROL;
        private System.Windows.Forms.Button BTN_SCHEDULE;
        private System.Windows.Forms.Button BTN_GROUP;
        private System.Windows.Forms.Button BTN_HOME;
        private System.Windows.Forms.TextBox TXT_ACTION;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_LOGOUT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_SCHEDULE_NAME;
        private System.Windows.Forms.CheckedListBox CHECKLISTBOX_GROUP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_LAYOUT;
    }
}