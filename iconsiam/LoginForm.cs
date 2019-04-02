using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconsiam {
    public partial class LoginForm : Form {

        
        ClassDataBase classDataBase = new ClassDataBase();
        public LoginForm() {
            InitializeComponent();
        }

        private void BTN_LOGIN_Click(object sender, EventArgs e) {
            checkLogin(); 

        }

        private void checkLogin() {
            string sql = "SELECT * FROM personal WHERE personal_username = '" + TXT_USERNAME.Text + "' AND personal_password='" + TXT_PASSWORD.Text + "'";
            DataRow dataRow = classDataBase.getDataRow(sql);
            if (dataRow != null && !dataRow["personal_id"].ToString().Equals("")) {
                
                this.Hide();
                BuildingForm buildingForm = new BuildingForm();
                buildingForm.ShowDialog();
                
            }
            else {
                MessageBox.Show("Username OR Password Incorrect !!!");
            }
           // this.Hide();
            //MainForm mainForm = new MainForm();
            //mainForm.ShowDialog();
        }

        private void TXT_PASSWORD_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                checkLogin();
            }
        }
    }
}
