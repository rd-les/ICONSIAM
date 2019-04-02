using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconsiam {
    public partial class ScheduleForm : Form {

        ClassDataBase classDataBase = new ClassDataBase();
        public ScheduleForm() {
            InitializeComponent();
        }

        private void BTN_HOME_Click(object sender, EventArgs e) {
            this.Hide();
            BuildingForm buildingForm = new BuildingForm();
            buildingForm.ShowDialog();
        }

        private void BTN_CONTROL_Click(object sender, EventArgs e) {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void BTN_GROUP_Click(object sender, EventArgs e) {
            this.Hide();
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog();
        }

        private void ScheduleForm_Load(object sender, EventArgs e) {
            this.loadGroupCombo();
            this.loadGroupCheckboxList(); 
            this.loadGridViewSchedule();
            COMBO_GROUP.SelectedIndex = 0;

        }

        private void loadGridViewSchedule() {
            GRIDVIEW_SCHEDULE.DataSource = null;
            GRIDVIEW_SCHEDULE.Rows.Clear();
            GRIDVIEW_SCHEDULE.Refresh();
            //GRIDVIEW_SCHEDULE
            string sql = @" SELECT TB1.schedule_group_id AS `#` , TB1.schedule_group_name AS SCHEDULE_NAME , TB2.group_name AS GROUP_NAME  , TB1.TIME_START , TB1.TIME_STOP , TB1.USABLE , 'ON' AS `STATUS`
                            FROM `schedule_group`  TB1
                            INNER JOIN  grouping TB2 ON (TB1.group_id = TB2.group_id) ";
            DataTable dataTable = classDataBase.getDataTable(sql);
            
            GRIDVIEW_SCHEDULE.DataSource = dataTable;

            GRIDVIEW_SCHEDULE.Columns[0].Width = 50;
            GRIDVIEW_SCHEDULE.Columns[1].Width = 200;
            GRIDVIEW_SCHEDULE.Columns[2].Width = 60;
            GRIDVIEW_SCHEDULE.Columns[3].Width = 60;

            GRIDVIEW_SCHEDULE.ClearSelection(); 



        }


        private void loadGroupCheckboxList() {
            //CHECKLISTBOX_GROUP
            string sql = @"SELECT * FROM grouping WHERE usable = 1 ";
            DataTable dataTable = classDataBase.getDataTable(sql);

            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (DataRow dataRow in dataTable.Rows) {
                comboSource.Add(dataRow["group_id"].ToString(), dataRow["group_name"].ToString());
                //COMBO_GROUP.Items.Add(new { Text = dataRow["group_name"].ToString(), Value= dataRow["group_id"].ToString() }  ); 
            }
            CHECKLISTBOX_GROUP.DataSource = new BindingSource(comboSource, null);
            CHECKLISTBOX_GROUP.DisplayMember = "Value";
            CHECKLISTBOX_GROUP.ValueMember = "Key";
        }

       
        private void loadGroupCombo() {
            string sql = @"SELECT * FROM grouping WHERE usable = 1 ";
            DataTable dataTable = classDataBase.getDataTable(sql);
            
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("0", "Please Select");
            foreach (DataRow dataRow in dataTable.Rows) {
                comboSource.Add(dataRow["group_id"].ToString() , dataRow["group_name"].ToString() ); 
                //COMBO_GROUP.Items.Add(new { Text = dataRow["group_name"].ToString(), Value= dataRow["group_id"].ToString() }  ); 
            }
            COMBO_GROUP.DataSource = new BindingSource(comboSource,null); 
            COMBO_GROUP.DisplayMember = "Value";
            COMBO_GROUP.ValueMember = "Key";
        }

        private void GRIDVIEW_SCHEDULE_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                TXT_SCHEDULE_ID.Text = GRIDVIEW_SCHEDULE.Rows[e.RowIndex].Cells[0].Value.ToString();
                TXT_SCHEDULE_NAME.Text = GRIDVIEW_SCHEDULE.Rows[e.RowIndex].Cells[1].Value.ToString();
                COMBO_GROUP.Text = GRIDVIEW_SCHEDULE.Rows[e.RowIndex].Cells[2].Value.ToString();
                COMBO_GROUP.Enabled = false; 
                TIME_START.Text = GRIDVIEW_SCHEDULE.Rows[e.RowIndex].Cells[3].Value.ToString() ;
                TIME_STOP.Text = GRIDVIEW_SCHEDULE.Rows[e.RowIndex].Cells[4].Value.ToString();
                CHK_USABLE.Checked = Convert.ToBoolean(GRIDVIEW_SCHEDULE.Rows[e.RowIndex].Cells[5].Value);
                TXT_ACTION.Text = "EDIT"; 
            }

        }

        private void BTN_HOME_Click_1(object sender, EventArgs e) {
            this.Hide();
            BuildingForm buildingForm = new BuildingForm();
            buildingForm.ShowDialog();
        }

        private void BTN_GROUP_Click_1(object sender, EventArgs e) {
            this.Hide();
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog();
        }

        private void BTN_CONTROL_Click_1(object sender, EventArgs e) {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private bool validateFormSubmit() {

            bool returnValue = true ;

            if (TXT_SCHEDULE_NAME.Text.Equals("")) {
                MessageBox.Show(" กรุณาเลือกกรอกชื่อ SCHEDULE ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                returnValue = false;
            }           
            if (COMBO_GROUP.SelectedIndex == 0) {
                MessageBox.Show(" กรุณาเลือก GROUP " , "แจ้งเตือน" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                returnValue = false; 
            }
            

            return returnValue;

        }



        private void BTN_SAVE_Click(object sender, EventArgs e) {

            string keyCombo = ((KeyValuePair<string, string>)COMBO_GROUP.SelectedItem).Key;
            string valueCombo = ((KeyValuePair<string, string>)COMBO_GROUP.SelectedItem).Value;


            Dictionary<string, string> fields = new Dictionary<string, string>();
            fields.Add("schedule_group_name", TXT_SCHEDULE_NAME.Text); 
            fields.Add("group_id" , keyCombo );
            fields.Add("time_start", TIME_START.Text);
            fields.Add("time_stop", TIME_STOP.Text);
            fields.Add("usable", (CHK_USABLE.Checked ? "1" : "0"));

            if (validateFormSubmit()) {
                if (TXT_ACTION.Text.Equals("ADD")) {
                    classDataBase.insertData(fields, "schedule_group");
                }
                else if (TXT_ACTION.Text.Equals("EDIT")) {
                    classDataBase.updateData(fields, "schedule_group", " schedule_group_id =" + TXT_SCHEDULE_ID.Text);
                }
                else{
                    MessageBox.Show("ไม่สามารถทำรายการได้"); 
                }

                //##################################################################################### INSERT SCHEDULE.
                /*
                StringBuilder sqlInsertSchedule = new StringBuilder();

                sqlInsertSchedule.Append(" INSERT INTO  `schedule_group_list` ");
                sqlInsertSchedule.Append(" ( schedule_group_id , group_id  ) ");
                sqlInsertSchedule.Append(" VALUES ");

                int countGroup = 0;

                for (int index = 0; index < CHECKLISTBOX_GROUP.Items.Count; index++) {

                    if (CHECKLISTBOX_GROUP.GetItemCheckState(index) == CheckState.Checked) {

                        string key = ((KeyValuePair<string, string>)CHECKLISTBOX_GROUP.Items[index]).Key;
                        string value = ((KeyValuePair<string, string>)CHECKLISTBOX_GROUP.Items[index]).Value;
                        if (countGroup > 0) {
                            sqlInsertSchedule.Append(" , ");
                        }
                        sqlInsertSchedule.Append("(  " + TXT_SCHEDULE_ID.Text + "  ,   " + key + " ) ");
                        Debug.WriteLine(key + " ----- " + value);
                    }
                }

                string whereSql = "";
                string scheduleId = ""; 

                if (!TXT_ACTION.Text.Equals("ADD")) {

                    whereSql = " schedule_group_id =" + TXT_SCHEDULE_ID.Text;
                    classDataBase.deleteData("grouping_list", whereSql);
                }
                

                Debug.WriteLine(sqlInsertSchedule);
                */
                //##################################################################################### END INSERT SCHEDULE.
            }
            
            loadGridViewSchedule();
        }

        private void BTN_ADD_SCHEDULE_Click(object sender, EventArgs e) {
            
            TXT_ACTION.Text = "ADD";
            TXT_SCHEDULE_ID.Text = "";
            TXT_SCHEDULE_NAME.Text = "";
            CHK_USABLE.Checked = true;
            COMBO_GROUP.SelectedIndex = 0;
            COMBO_GROUP.Enabled = true; 
            TIME_START.Text = "17:00:00";
            TIME_STOP.Text = "22:00:00"; 
        }

        private void ScheduleForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e) {
            if (!TXT_ACTION.Text.Equals("EDIT")) {

            }
            DialogResult dialogResult = MessageBox.Show("ต้องการที่จะลบ " + COMBO_GROUP.Text +" เวลา "+TIME_START.Text+" - "+TIME_STOP.Text +" ใช่หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult== DialogResult.Yes) {
                classDataBase.deleteData("schedule_group", "schedule_group_id = "+TXT_SCHEDULE_ID.Text);
                loadGridViewSchedule();
            }
        }

        private void BTN_LOGOUT_Click(object sender, EventArgs e) {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Hide(); 
            TestScheduleForm testScheduleForm = new TestScheduleForm();
            testScheduleForm.ShowDialog(); 


        }

        private void BTN_LAYOUT_Click(object sender, EventArgs e) {
            this.Hide();
            LayoutForm layoutForm = new LayoutForm();
            layoutForm.ShowDialog();
        }
    }



    
}
