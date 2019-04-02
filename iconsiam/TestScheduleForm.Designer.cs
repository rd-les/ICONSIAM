namespace iconsiam {
    partial class TestScheduleForm {
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
            this.TXT_TIME = new System.Windows.Forms.TextBox();
            this.TXT_STATUS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXT_TIME
            // 
            this.TXT_TIME.Location = new System.Drawing.Point(58, 35);
            this.TXT_TIME.Multiline = true;
            this.TXT_TIME.Name = "TXT_TIME";
            this.TXT_TIME.Size = new System.Drawing.Size(539, 444);
            this.TXT_TIME.TabIndex = 0;
            // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.Location = new System.Drawing.Point(673, 46);
            this.TXT_STATUS.Multiline = true;
            this.TXT_STATUS.Name = "TXT_STATUS";
            this.TXT_STATUS.Size = new System.Drawing.Size(336, 433);
            this.TXT_STATUS.TabIndex = 1;
            // 
            // TestScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 624);
            this.Controls.Add(this.TXT_STATUS);
            this.Controls.Add(this.TXT_TIME);
            this.Name = "TestScheduleForm";
            this.Text = "TestScheduleForm";
            this.Load += new System.EventHandler(this.TestScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_TIME;
        private System.Windows.Forms.TextBox TXT_STATUS;
    }
}