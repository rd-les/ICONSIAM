namespace iconsiam {
    partial class LayoutForm {
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
            this.BTN_CHANGE_IMAGE = new System.Windows.Forms.Button();
            this.PANEL_CONTROL = new System.Windows.Forms.Panel();
            this.CHECKLIST_RELAY = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.COMBO_ADD_CONTROL = new System.Windows.Forms.ComboBox();
            this.BUTTON_CANCEL = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_RELOAD = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GRIDVIEW_CIRCLE = new System.Windows.Forms.DataGridView();
            this.LAYOUT_COMBO = new System.Windows.Forms.ComboBox();
            this.TXT_LAYOUT_PATH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_LAYOUT_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PICTUREBOX_MAIN = new System.Windows.Forms.PictureBox();
            this.BTN_LAYOUT = new System.Windows.Forms.Button();
            this.BTN_SCHEDULE = new System.Windows.Forms.Button();
            this.BTN_GROUP = new System.Windows.Forms.Button();
            this.BTN_HOME = new System.Windows.Forms.Button();
            this.BTN_LOGOUT = new System.Windows.Forms.Button();
            this.BTN_CONTROL = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PANEL_CONTROL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEW_CIRCLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICTUREBOX_MAIN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_LOGOUT);
            this.panel1.Controls.Add(this.BTN_CHANGE_IMAGE);
            this.panel1.Controls.Add(this.PANEL_CONTROL);
            this.panel1.Controls.Add(this.BTN_RELOAD);
            this.panel1.Controls.Add(this.BTN_DELETE);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.GRIDVIEW_CIRCLE);
            this.panel1.Controls.Add(this.LAYOUT_COMBO);
            this.panel1.Controls.Add(this.TXT_LAYOUT_PATH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TXT_LAYOUT_NAME);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(891, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 690);
            this.panel1.TabIndex = 49;
            // 
            // BTN_CHANGE_IMAGE
            // 
            this.BTN_CHANGE_IMAGE.BackColor = System.Drawing.Color.Gold;
            this.BTN_CHANGE_IMAGE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CHANGE_IMAGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_CHANGE_IMAGE.Location = new System.Drawing.Point(348, 92);
            this.BTN_CHANGE_IMAGE.Name = "BTN_CHANGE_IMAGE";
            this.BTN_CHANGE_IMAGE.Size = new System.Drawing.Size(115, 41);
            this.BTN_CHANGE_IMAGE.TabIndex = 58;
            this.BTN_CHANGE_IMAGE.Text = "เปลี่ยนรูป";
            this.BTN_CHANGE_IMAGE.UseVisualStyleBackColor = false;
            this.BTN_CHANGE_IMAGE.Click += new System.EventHandler(this.BTN_CHANGE_IMAGE_Click);
            // 
            // PANEL_CONTROL
            // 
            this.PANEL_CONTROL.BackColor = System.Drawing.Color.PapayaWhip;
            this.PANEL_CONTROL.Controls.Add(this.CHECKLIST_RELAY);
            this.PANEL_CONTROL.Controls.Add(this.label5);
            this.PANEL_CONTROL.Controls.Add(this.label4);
            this.PANEL_CONTROL.Controls.Add(this.COMBO_ADD_CONTROL);
            this.PANEL_CONTROL.Controls.Add(this.BUTTON_CANCEL);
            this.PANEL_CONTROL.Controls.Add(this.BTN_SAVE);
            this.PANEL_CONTROL.Location = new System.Drawing.Point(4, 139);
            this.PANEL_CONTROL.Name = "PANEL_CONTROL";
            this.PANEL_CONTROL.Size = new System.Drawing.Size(459, 432);
            this.PANEL_CONTROL.TabIndex = 56;
            this.PANEL_CONTROL.Visible = false;
            // 
            // CHECKLIST_RELAY
            // 
            this.CHECKLIST_RELAY.CheckOnClick = true;
            this.CHECKLIST_RELAY.FormattingEnabled = true;
            this.CHECKLIST_RELAY.Location = new System.Drawing.Point(132, 66);
            this.CHECKLIST_RELAY.Name = "CHECKLIST_RELAY";
            this.CHECKLIST_RELAY.Size = new System.Drawing.Size(256, 289);
            this.CHECKLIST_RELAY.TabIndex = 6;
            this.CHECKLIST_RELAY.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CHECKLIST_RELAY_ItemCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(32, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "RELAY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "CONTROL";
            // 
            // COMBO_ADD_CONTROL
            // 
            this.COMBO_ADD_CONTROL.FormattingEnabled = true;
            this.COMBO_ADD_CONTROL.Items.AddRange(new object[] {
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
            this.COMBO_ADD_CONTROL.Location = new System.Drawing.Point(132, 26);
            this.COMBO_ADD_CONTROL.Name = "COMBO_ADD_CONTROL";
            this.COMBO_ADD_CONTROL.Size = new System.Drawing.Size(214, 21);
            this.COMBO_ADD_CONTROL.TabIndex = 2;
            this.COMBO_ADD_CONTROL.SelectedIndexChanged += new System.EventHandler(this.COMBO_ADD_CONTROL_SelectedIndexChanged);
            // 
            // BUTTON_CANCEL
            // 
            this.BUTTON_CANCEL.Location = new System.Drawing.Point(271, 361);
            this.BUTTON_CANCEL.Name = "BUTTON_CANCEL";
            this.BUTTON_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_CANCEL.TabIndex = 1;
            this.BUTTON_CANCEL.Text = "CANCEL";
            this.BUTTON_CANCEL.UseVisualStyleBackColor = true;
            this.BUTTON_CANCEL.Click += new System.EventHandler(this.BUTTON_CANCEL_Click);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Location = new System.Drawing.Point(132, 361);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(75, 23);
            this.BTN_SAVE.TabIndex = 0;
            this.BTN_SAVE.Text = "SAVE";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_RELOAD
            // 
            this.BTN_RELOAD.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_RELOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_RELOAD.Location = new System.Drawing.Point(348, 7);
            this.BTN_RELOAD.Name = "BTN_RELOAD";
            this.BTN_RELOAD.Size = new System.Drawing.Size(115, 40);
            this.BTN_RELOAD.TabIndex = 57;
            this.BTN_RELOAD.Text = "RELOAD";
            this.BTN_RELOAD.UseVisualStyleBackColor = false;
            this.BTN_RELOAD.Click += new System.EventHandler(this.BTN_RELOAD_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.BackColor = System.Drawing.Color.LightSalmon;
            this.BTN_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTN_DELETE.Location = new System.Drawing.Point(348, 48);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(115, 44);
            this.BTN_DELETE.TabIndex = 56;
            this.BTN_DELETE.Text = "ลบทั้งหมด";
            this.BTN_DELETE.UseVisualStyleBackColor = false;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(38, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "LAYOUT  :";
            // 
            // GRIDVIEW_CIRCLE
            // 
            this.GRIDVIEW_CIRCLE.AllowUserToAddRows = false;
            this.GRIDVIEW_CIRCLE.AllowUserToResizeColumns = false;
            this.GRIDVIEW_CIRCLE.AllowUserToResizeRows = false;
            this.GRIDVIEW_CIRCLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEW_CIRCLE.Location = new System.Drawing.Point(4, 139);
            this.GRIDVIEW_CIRCLE.MultiSelect = false;
            this.GRIDVIEW_CIRCLE.Name = "GRIDVIEW_CIRCLE";
            this.GRIDVIEW_CIRCLE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GRIDVIEW_CIRCLE.Size = new System.Drawing.Size(469, 513);
            this.GRIDVIEW_CIRCLE.TabIndex = 55;
            this.GRIDVIEW_CIRCLE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEW_CIRCLE_CellClick);
            this.GRIDVIEW_CIRCLE.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEW_CIRCLE_CellDoubleClick);
            this.GRIDVIEW_CIRCLE.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEW_CIRCLE_CellValueChanged);
            this.GRIDVIEW_CIRCLE.SelectionChanged += new System.EventHandler(this.GRIDVIEW_CIRCLE_SelectionChanged);
            // 
            // LAYOUT_COMBO
            // 
            this.LAYOUT_COMBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LAYOUT_COMBO.FormattingEnabled = true;
            this.LAYOUT_COMBO.Location = new System.Drawing.Point(115, 21);
            this.LAYOUT_COMBO.Name = "LAYOUT_COMBO";
            this.LAYOUT_COMBO.Size = new System.Drawing.Size(211, 33);
            this.LAYOUT_COMBO.TabIndex = 51;
            this.LAYOUT_COMBO.SelectedIndexChanged += new System.EventHandler(this.LAYOUT_COMBO_SelectedIndexChanged);
            // 
            // TXT_LAYOUT_PATH
            // 
            this.TXT_LAYOUT_PATH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TXT_LAYOUT_PATH.Location = new System.Drawing.Point(115, 92);
            this.TXT_LAYOUT_PATH.Name = "TXT_LAYOUT_PATH";
            this.TXT_LAYOUT_PATH.Size = new System.Drawing.Size(211, 26);
            this.TXT_LAYOUT_PATH.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(1, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "LAYOUT NAME :";
            // 
            // TXT_LAYOUT_NAME
            // 
            this.TXT_LAYOUT_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TXT_LAYOUT_NAME.Location = new System.Drawing.Point(115, 59);
            this.TXT_LAYOUT_NAME.Name = "TXT_LAYOUT_NAME";
            this.TXT_LAYOUT_NAME.Size = new System.Drawing.Size(211, 26);
            this.TXT_LAYOUT_NAME.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(1, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "LAYOUT PATH :";
            // 
            // PICTUREBOX_MAIN
            // 
            this.PICTUREBOX_MAIN.Location = new System.Drawing.Point(13, 80);
            this.PICTUREBOX_MAIN.Name = "PICTUREBOX_MAIN";
            this.PICTUREBOX_MAIN.Size = new System.Drawing.Size(869, 690);
            this.PICTUREBOX_MAIN.TabIndex = 50;
            this.PICTUREBOX_MAIN.TabStop = false;
            this.PICTUREBOX_MAIN.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PICTUREBOX_MAIN_MouseDoubleClick);
            this.PICTUREBOX_MAIN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PICTUREBOX_MAIN_MouseDown);
            this.PICTUREBOX_MAIN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PICTUREBOX_MAIN_MouseMove);
            this.PICTUREBOX_MAIN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PICTUREBOX_MAIN_MouseUp);
            // 
            // BTN_LAYOUT
            // 
            this.BTN_LAYOUT.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_LAYOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_LAYOUT.Location = new System.Drawing.Point(1198, 24);
            this.BTN_LAYOUT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_LAYOUT.Name = "BTN_LAYOUT";
            this.BTN_LAYOUT.Size = new System.Drawing.Size(82, 32);
            this.BTN_LAYOUT.TabIndex = 55;
            this.BTN_LAYOUT.Text = "LAYOUT";
            this.BTN_LAYOUT.UseVisualStyleBackColor = false;
            this.BTN_LAYOUT.Click += new System.EventHandler(this.BTN_LAYOUT_Click);
            // 
            // BTN_SCHEDULE
            // 
            this.BTN_SCHEDULE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_SCHEDULE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SCHEDULE.Location = new System.Drawing.Point(1289, 24);
            this.BTN_SCHEDULE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SCHEDULE.Name = "BTN_SCHEDULE";
            this.BTN_SCHEDULE.Size = new System.Drawing.Size(82, 32);
            this.BTN_SCHEDULE.TabIndex = 53;
            this.BTN_SCHEDULE.Text = "SCHEDULE";
            this.BTN_SCHEDULE.UseVisualStyleBackColor = false;
            this.BTN_SCHEDULE.Click += new System.EventHandler(this.BTN_SCHEDULE_Click_1);
            // 
            // BTN_GROUP
            // 
            this.BTN_GROUP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_GROUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_GROUP.Location = new System.Drawing.Point(1106, 24);
            this.BTN_GROUP.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_GROUP.Name = "BTN_GROUP";
            this.BTN_GROUP.Size = new System.Drawing.Size(82, 32);
            this.BTN_GROUP.TabIndex = 52;
            this.BTN_GROUP.Text = "GROUP";
            this.BTN_GROUP.UseVisualStyleBackColor = false;
            this.BTN_GROUP.Click += new System.EventHandler(this.BTN_GROUP_Click_1);
            // 
            // BTN_HOME
            // 
            this.BTN_HOME.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_HOME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_HOME.Location = new System.Drawing.Point(920, 24);
            this.BTN_HOME.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_HOME.Name = "BTN_HOME";
            this.BTN_HOME.Size = new System.Drawing.Size(82, 32);
            this.BTN_HOME.TabIndex = 51;
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
            this.BTN_LOGOUT.Location = new System.Drawing.Point(363, 651);
            this.BTN_LOGOUT.Name = "BTN_LOGOUT";
            this.BTN_LOGOUT.Size = new System.Drawing.Size(100, 36);
            this.BTN_LOGOUT.TabIndex = 56;
            this.BTN_LOGOUT.Text = "LOGOUT";
            this.BTN_LOGOUT.UseVisualStyleBackColor = false;
            this.BTN_LOGOUT.Click += new System.EventHandler(this.BTN_LOGOUT_Click);
            // 
            // BTN_CONTROL
            // 
            this.BTN_CONTROL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_CONTROL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CONTROL.Location = new System.Drawing.Point(1016, 24);
            this.BTN_CONTROL.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CONTROL.Name = "BTN_CONTROL";
            this.BTN_CONTROL.Size = new System.Drawing.Size(81, 32);
            this.BTN_CONTROL.TabIndex = 56;
            this.BTN_CONTROL.Text = "CONTROL";
            this.BTN_CONTROL.UseVisualStyleBackColor = false;
            this.BTN_CONTROL.Click += new System.EventHandler(this.BTN_CONTROL_Click_2);
            // 
            // LayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::iconsiam.Properties.Resources.BG_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1455, 792);
            this.Controls.Add(this.BTN_CONTROL);
            this.Controls.Add(this.BTN_LAYOUT);
            this.Controls.Add(this.BTN_SCHEDULE);
            this.Controls.Add(this.BTN_GROUP);
            this.Controls.Add(this.BTN_HOME);
            this.Controls.Add(this.PICTUREBOX_MAIN);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "LayoutForm";
            this.Text = "LayoutForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LayoutForm_FormClosed);
            this.Load += new System.EventHandler(this.LayoutForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PANEL_CONTROL.ResumeLayout(false);
            this.PANEL_CONTROL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEW_CIRCLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICTUREBOX_MAIN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PICTUREBOX_MAIN;
        private System.Windows.Forms.TextBox TXT_LAYOUT_PATH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_LAYOUT_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LAYOUT_COMBO;
        private System.Windows.Forms.DataGridView GRIDVIEW_CIRCLE;
        private System.Windows.Forms.Panel PANEL_CONTROL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox COMBO_ADD_CONTROL;
        private System.Windows.Forms.Button BUTTON_CANCEL;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.CheckedListBox CHECKLIST_RELAY;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_RELOAD;
        private System.Windows.Forms.Button BTN_CHANGE_IMAGE;
        private System.Windows.Forms.Button BTN_LAYOUT;
        private System.Windows.Forms.Button BTN_SCHEDULE;
        private System.Windows.Forms.Button BTN_GROUP;
        private System.Windows.Forms.Button BTN_HOME;
        private System.Windows.Forms.Button BTN_LOGOUT;
        private System.Windows.Forms.Button BTN_CONTROL;
    }
}