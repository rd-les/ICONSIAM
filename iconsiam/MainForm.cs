using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconsiam {
    public partial class MainForm : Form {
        private string getCurrentIpControl { get; set; }
        ClassDataBase classDataBase = new ClassDataBase();


        public MainForm() {
            InitializeComponent();
            groupBox_Board.Enabled = false;
            BTN_SendPackage.Enabled = false;
            ListComport.SelectedIndex = 0;
        }
        public MainForm(string floorValue) {
            InitializeComponent();
            groupBox_Board.Enabled = false;
            BTN_SendPackage.Enabled = false;
            ListComport.SelectedIndex = 0;

            setListComportFloor(floorValue);
            if (floorValue.Equals("0")) {
                RAD_UG.Checked = true;
            }
            else if (floorValue.Equals("2")) {
                RAD_FLOOR_2.Checked = true; 
            }
            else if (floorValue.Equals("3")) {
                RAD_FLOOR_3.Checked = true;
            }
            else if (floorValue.Equals("4")) {
                RAD_FLOOR_4.Checked = true;
            }
            else if (floorValue.Equals("6")) {
                RAD_FLOOR_6.Checked = true;
            }
            else if (floorValue.Equals("7")) {
                RAD_FLOOR_7.Checked = true;
            }
            else if (floorValue.Equals("8")) {
                RAD_FLOOR_8.Checked = true;
            }
        }

        private void ListComport_SelectedIndexChanged(object sender, EventArgs e) {
            resetMainForm(); 
            if (ListComport.SelectedIndex != 0) {

                //MessageBox.Show(ListComport.SelectedIndex + "---" + ListComport.Text);
                // this.loadExcelDataList(ListComport.Text);
                
                //Select_All.Text = "Select All -> " + ListComport.Text;
                groupBox_Board.Text = "SELECT => " + ListComport.Text ;
                groupBox_Board.Enabled = true;
                BTN_SendPackage.Enabled = true;
                this.loadDataGrid(ListComport.Text);
            }
            else {
                //Grid_Relay.remo
                Grid_Relay.DataSource = null; 
                Grid_Relay.Rows.Clear();
                Grid_Relay.Refresh(); 
                groupBox_Board.Enabled = false;
                BTN_SendPackage.Enabled = false;
            }
        }

        private void resetMainForm() {
            //Select_All.Checked = false;
            RAD_ON.Checked = false;
            RAD_OFF.Checked = false; 
        }


        private void loadDataGrid(string boardRelayName) {

            if (ListComport.SelectedIndex == 0 ) {
                return;
            }
            string sql = "SELECT * FROM `"+ boardRelayName+"`";
            DataTable dataTable = classDataBase.getDataTable(sql);
            dataTable.PrimaryKey = null; 
            //dataTable.Columns.Remove("id");
            dataTable.Columns.RemoveAt(0); 
            Grid_Relay.DataSource = dataTable;

            int columnWidth = 25;
            Grid_Relay.Columns[0].Width = 80;
            Grid_Relay.Columns[0].HeaderText = "Board Name";
            for (int indexHeader = 1; indexHeader <=15; indexHeader = indexHeader+2) {
                Grid_Relay.Columns[indexHeader].Width = columnWidth;
                Grid_Relay.Columns[indexHeader].HeaderText = "#";
            }
            /*
            Grid_Relay.Columns[1].Width = columnWidth;
            Grid_Relay.Columns[1].HeaderText = "#";
            Grid_Relay.Columns[3].Width = columnWidth;
            Grid_Relay.Columns[5].Width = columnWidth;
            Grid_Relay.Columns[7].Width = columnWidth;
            Grid_Relay.Columns[9].Width = columnWidth;
            Grid_Relay.Columns[11].Width = columnWidth;
            Grid_Relay.Columns[13].Width = columnWidth;
            Grid_Relay.Columns[15].Width = columnWidth;
            */
            //############################################################# END SET GRIDVIEW.
            int dataIndex = 0;
            string getIpConfig = classDataBase.selectOnceData("config_ip", "control_ip", "control_name='" + boardRelayName + "'" );
            ClassModBus classModBus = new ClassModBus();
            bool[] readCommands = classModBus.Read_Command(getIpConfig, 1);
            ///bool[] readCommandsRealStatus = classModBus.Read_CommandRealStatus(getIpConfig, 1);

            if (readCommands.Length > 2 ) {


                foreach (DataGridViewRow gridRow in Grid_Relay.Rows) {

                    for (int index = 1; index <= 15; index = index + 2) {

                        if (gridRow.Cells[index + 1].Value != null && !String.IsNullOrWhiteSpace(gridRow.Cells[index + 1].Value.ToString())) {
                            gridRow.Cells[index].Value = readCommands[dataIndex];
                            if (readCommands[dataIndex] == true) {
                                gridRow.Cells[index + 1].Style.BackColor = getStyleBackColorGridView(true);
                            }
                            else {
                                gridRow.Cells[index + 1].Style.BackColor = getStyleBackColorGridView(false);
                            }
                            //################################################   SET MANUAL BREAKER.

                           // if (readCommandsRealStatus[dataIndex] == true) {
                                //gridRow.Cells[index + 1].Style.BackColor = Color.RoyalBlue; 
                            //}

                            //gridRow.Cells[index + 1].ReadOnly = true;
                            dataIndex++;
                        }
                        else {
                            gridRow.Cells[index].ReadOnly = true;
                            gridRow.Cells[index].Style.BackColor = Color.LightGray;
                            gridRow.Cells[index + 1].Style.BackColor = Color.LightGray;
                        }
                    }
                }
            }
            else if (readCommands.Length == 2 ) {
                MessageBox.Show("ระบบไม่สามารถ อ่านข้อมูล Board ตู้ IP " + getIpConfig + " ชื่อตู้ " + boardRelayName + " ได้ ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
               
                MessageBox.Show("ระบบไม่สามารถค้นหา IP " + getIpConfig + " ชื่อตู้ " + boardRelayName + " ได้ ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                //this.resetMainForm();
                //Grid_Relay.DataSource = null;
                //Grid_Relay.Rows.Clear();
                //Grid_Relay.Refresh();
                ///ListComport.SelectedIndex = 0;
               // groupBox_Board.Text = "SELECT";
             
            }

            Debug.WriteLine("---------->");
            Grid_Relay.DefaultCellStyle.Font = new Font("Tahoma" , 7); 
        }


        public void loadExcelDataList(string boardRelayName) {

            string sheet = "Sheet1";
            string pathExcel = @"D:\Works\iConsiam\" + boardRelayName + ".xlsx";
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathExcel + "; Extended Properties='Excel 12.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + sheet + "$]", con);
            con.Open();

            OleDbDataAdapter dataAdaptor = new OleDbDataAdapter(oconn);
            DataTable dataTable = new DataTable();

            dataAdaptor.Fill(dataTable);

            DataColumn col_1 = dataTable.Columns.Add("1", Type.GetType("System.Boolean"));
            DataColumn col_2 = dataTable.Columns.Add("2", Type.GetType("System.Boolean"));
            DataColumn col_3 = dataTable.Columns.Add("3", Type.GetType("System.Boolean"));
            DataColumn col_4 = dataTable.Columns.Add("4", Type.GetType("System.Boolean"));
            DataColumn col_5 = dataTable.Columns.Add("5", Type.GetType("System.Boolean"));
            DataColumn col_6 = dataTable.Columns.Add("6", Type.GetType("System.Boolean"));
            DataColumn col_7 = dataTable.Columns.Add("7", Type.GetType("System.Boolean"));
            DataColumn col_8 = dataTable.Columns.Add("8", Type.GetType("System.Boolean"));

            col_1.SetOrdinal(1);
            col_2.SetOrdinal(3);
            col_3.SetOrdinal(5);
            col_4.SetOrdinal(7);
            col_5.SetOrdinal(9);
            col_6.SetOrdinal(11);
            col_7.SetOrdinal(13);
            col_8.SetOrdinal(15);
            Grid_Relay.DataSource = dataTable;


            int columnWidth = 30;
            Grid_Relay.Columns[1].Width = columnWidth;
            Grid_Relay.Columns[3].Width = columnWidth;
            Grid_Relay.Columns[5].Width = columnWidth;
            Grid_Relay.Columns[7].Width = columnWidth;
            Grid_Relay.Columns[9].Width = columnWidth;
            Grid_Relay.Columns[11].Width = columnWidth;
            Grid_Relay.Columns[13].Width = columnWidth;
            Grid_Relay.Columns[15].Width = columnWidth;

            //############################################################# END SET GRIDVIEW.
            int dataIndex = 0;


            //############################################################  GET READ STATUS.
            
            string sheetConfig = "Configs";

            OleDbConnection conConfig = new OleDbConnection(constr);
            OleDbCommand oconnConfig = new OleDbCommand("Select * From [" + sheetConfig + "$]", conConfig);
            conConfig.Open();
            OleDbDataAdapter dataAdaptorConfig = new OleDbDataAdapter(oconnConfig);
            DataTable dataTableConfig = new DataTable();

            dataAdaptorConfig.Fill(dataTableConfig);
            string getIpConfig = dataTableConfig.Rows[0]["VALUE"].ToString();
            ClassModBus classModBus = new ClassModBus();
            bool[] readCommands = classModBus.Read_Command(getIpConfig, 1);
            //bool[] readCommandsRealStatus = classModBus.Read_CommandRealStatus(getIpConfig, 1);

            //############################################################  END READ STATUS.


            foreach (DataGridViewRow gridRow in Grid_Relay.Rows) {

                //bool randomBool;
                //Random r = new Random();
                //Debug.WriteLine("====================================>");

                for (int index = 1; index <= 15; index = index + 2) {


                    if (gridRow.Cells[index + 1].Value != null && !String.IsNullOrWhiteSpace(gridRow.Cells[index + 1].Value.ToString())) {
                        //randomBool = (r.Next(100) % 2 == 0);
                        gridRow.Cells[index].Value = readCommands[dataIndex];
                        if (readCommands[dataIndex] == true ) {
                            gridRow.Cells[index + 1].Style.BackColor = getStyleBackColorGridView(true);
                        }
                        else {
                            gridRow.Cells[index + 1].Style.BackColor = getStyleBackColorGridView(false);
                        }
                        
                        //################################################   SET MANUAL BREAKER.
                        
                        //if (readCommandsRealStatus[dataIndex] == true) {
                            //gridRow.Cells[index + 1].Style.BackColor = Color.RoyalBlue; 
                        //}
                        
                        gridRow.Cells[index + 1].ReadOnly = true;
                        dataIndex++;
                    }
                    else {
                        gridRow.Cells[index].ReadOnly = true;
                        gridRow.Cells[index].Style.BackColor = Color.LightGray;
                        gridRow.Cells[index + 1].Style.BackColor = Color.LightGray;
                    }
                }
            }

            /*

            for (int index = 70; index <= 134; index++) {

                if (readCommands[index] == true) {
                    //gridRow.Cells[index + 1].Style.BackColor = getStyleBackColorGridView(true);
                    //Color.RoyalBlue
                }



            }
            */


        }

        private Color getStyleBackColorGridView(bool statusCell) {
            if (statusCell== true) {
                return Color.GreenYellow;
            }
            else {
                return Color.LightPink; 
            }
        }

        private void checkBoxGridView(bool status) {
            foreach (DataGridViewRow gridRow in Grid_Relay.Rows) {

                for (int index = 1; index <= 15; index = index + 2) {
                    if (gridRow.Cells[index + 1].Style.BackColor == Color.LightGray) {
                        continue; 
                    }
                    gridRow.Cells[index].Value = status;
                    gridRow.Cells[index+1].Style.BackColor = getStyleBackColorGridView(status);

                }
               
            }
        }

        private void Select_All_Click(object sender, EventArgs e) {
            if (ListComport.SelectedIndex == 0) {
                MessageBox.Show("กรุณาเลือก ตู้คอนโทรล");
                //Select_All.Checked = false;
            }
            else {
                this.checkBoxGridView(Select_All.Checked);                           
            }
        }

        private void BTN_SendPackage_Click(object sender, EventArgs e) {

            if (ListComport.SelectedIndex == 0) {
                MessageBox.Show("กรุณาเลือก ตู้คอนโทรล");
            }
            else {
                //TODO SEND PACKAGE.
                BTN_SendPackage.Enabled = false; 
                try {
                    this.Enabled = false; 
                    sendPackageCommand();
                }
                catch (Exception ex) {
                    Debug.WriteLine(ex);
                    AppClass.saveDataLogDebug("GROUP_FORM : BTN_SendPackage_Click ", ex.ToString());
                }
                finally {
                    this.Enabled = true; 
                    BTN_SendPackage.Enabled = true;
                    this.resetMainForm(); 
                }
                


            }
        }

        private void sendPackageCommand() {

            /*
            string sheet = "Configs";
            string pathExcel = @"D:\Works\iConsiam\" + ListComport.Text + ".xlsx";
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathExcel + "; Extended Properties='Excel 12.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + sheet + "$]", con);
            con.Open();
            OleDbDataAdapter dataAdaptor = new OleDbDataAdapter(oconn);
            DataTable dataTable = new DataTable();

            dataAdaptor.Fill(dataTable);

            */
            string sql = "SELECT * FROM iconsiam.config_ip WHERE  control_name = '" + ListComport.Text + "'; ; ";
            //DataTable dataTable = classDataBase.getDataTable(sql); 
            DataRow dataRow = classDataBase.getDataRow(sql); 

            TXT_LOG.Clear(); 


            //########################################  SET CONFIGs.
            string getIp = dataRow["control_ip"].ToString();
           
            int countRelayAll = 0;
            ClassModBus classModBus = new ClassModBus();
            bool[] readCommands = classModBus.Read_Command(getIp, 1);

            if (readCommands.Length == 1 ) {
                MessageBox.Show(" ไม่สามารถติดต่อ IP : "+ ListComport.Text + " ได้ ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow gridRow in Grid_Relay.Rows) {

                for (int index = 1; index <= 15; index = index + 2) {
                    
                    if (gridRow.Cells[index + 1].Style.BackColor == Color.LightGray) {
                        countRelayAll++;
                        continue;

                    }
                    else if (Convert.ToInt32(readCommands[countRelayAll]) == Convert.ToInt32(gridRow.Cells[index].Value) ) {
                        countRelayAll++;
                        continue;
                    }
                    else {
                        /*
                        if (gridRow.Cells[index].Value.ToString().Equals("True")) {
                            countRelay++;
                            MessageBox.Show((countRelayAll-1).ToString() ); 
                        }
                        */

                        //Grid_Relay.BeginInvoke()
                        string oldText = " ขณะนี้กำลังทำงานที่ Relay -----> "+ (countRelayAll+1)+" : "+ gridRow.Cells[index+1].Value + " " + (Convert.ToInt32(gridRow.Cells[index].Value) == 1 ? "เปิด" : "ปิด" );  //TXT_LOG.Text;
                        TXT_LOG.AppendText(oldText);
                        TXT_LOG.AppendText(Environment.NewLine); 
                        Debug.WriteLine(countRelayAll+" -----> " + Convert.ToInt32( gridRow.Cells[index].Value));

                        //Thread.Sleep(timeOutThread);
                        Color colorCell = gridRow.Cells[index + 1].Style.BackColor;
                        try {
                            
                            gridRow.Cells[index + 1].Style.BackColor = Color.Yellow;
                            Application.DoEvents();
                            classModBus.Write_Command(getIp, 1, countRelayAll, Convert.ToInt32(gridRow.Cells[index].Value));
                            Thread.Sleep(200);
                        }
                        catch (Exception ex) {
                            Debug.WriteLine(ex);
                            AppClass.saveDataLogDebug("MAIN_FORM : BTN_SendPackage_Click ", ex.ToString());
                        }
                        finally {
                            gridRow.Cells[index + 1].Style.BackColor = colorCell ;
                        }
                        

                    }
                    countRelayAll++;

                }

            }
            TXT_LOG.AppendText("ระบบได้ทำงานเสร็จสิ้นแล้ว");
            MessageBox.Show("ระบบได้ทำงานเสร็จสิ้นแล้ว");

        }


        private void Grid_Relay_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            Grid_Relay.CommitEdit(DataGridViewDataErrorContexts.Commit);
            DataGridViewCheckBoxCell currentCell = this.Grid_Relay.CurrentCell as DataGridViewCheckBoxCell;
            if (currentCell != null && !currentCell.ReadOnly) {
                //MessageBox.Show(currentCell.Value.ToString());
                if (currentCell.Value.ToString().Equals("True")) {
                    Grid_Relay.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Style.BackColor = getStyleBackColorGridView(true);
                }
                else {
                    Grid_Relay.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Style.BackColor = getStyleBackColorGridView(false);
                }


            }
        }

        private void RAD_ON_CheckedChanged(object sender, EventArgs e) {
            if(RAD_ON.Checked == true) {
                this.checkBoxGridView(true);
            }
        }

        private void RAD_OFF_CheckedChanged(object sender, EventArgs e) {
            if (RAD_OFF.Checked == true) {
                this.checkBoxGridView(false);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.resetMainForm();
            Grid_Relay.DataSource = null;
            Grid_Relay.Rows.Clear();
            Grid_Relay.Refresh();
            ListComport.SelectedIndex = 0;
            groupBox_Board.Text = "SELECT"; 

        }

        private void BTN_Reload_Click(object sender, EventArgs e) {
            this.loadExcelDataList(ListComport.Text);
        }

        private void BTN_REFRESH_Click(object sender, EventArgs e) {
            RAD_OFF.Checked = false;
            RAD_ON.Checked = false;
            this.loadDataGrid(ListComport.Text); 
            //this.loadExcelDataList(ListComport.Text);
        }

        private void BTN_HOME_Click(object sender, EventArgs e) {
            this.Hide();
            BuildingForm buildingForm = new BuildingForm();
            buildingForm.ShowDialog();
        }

        private void setListComportFloor(string floorValue) {

            string sql = "SELECT * FROM config_ip WHERE group_floor="+floorValue ;
            DataTable dataTable = classDataBase.getDataTable(sql);
            
            ListComport.Items.RemoveAt(0);
            ListComport.Items.Clear();
            ListComport.Items.Add("FLOOR : "+(floorValue.Equals("0") ? "UG" : floorValue)); 
            foreach (DataRow dataRow in dataTable.Rows) {
                ListComport.Items.Add(dataRow["control_name"].ToString() ); 
            }

            ListComport.SelectedIndex = 0; 

           
        }

        private void RAD_UG_CheckedChanged(object sender, EventArgs e) {
            setListComportFloor("0");
        }
        private void RAD_FLOOR_2_CheckedChanged(object sender, EventArgs e) {
            setListComportFloor("2"); 
        }
        private void RAD_FLOOR_3_CheckedChanged(object sender, EventArgs e) {
            setListComportFloor("3");
        }
        private void RAD_FLOOR_4_CheckedChanged(object sender, EventArgs e) {
            setListComportFloor("4");
        }
        private void RAD_FLOOR_6_CheckedChanged(object sender, EventArgs e) {
            setListComportFloor("6");
        }        
        private void RAD_FLOOR_7_CheckedChanged(object sender, EventArgs e) {
            setListComportFloor("7");
        }
        private void RAD_FLOOR_8_CheckedChanged(object sender, EventArgs e) {
            setListComportFloor("8");
        }

        private void BTN_EDIT_NAME_Click(object sender, EventArgs e) {
            if (ListComport.SelectedIndex != 0) {
                int boardId = 1;
                foreach (DataGridViewRow gridRow in Grid_Relay.Rows) {

                    Dictionary<string, string> fields = new Dictionary<string, string>();
                    string sqlUPDATE = "UPDATE `" + ListComport.Text + "` SET ";
                    for (int index = 0; index <= 16; index = index + 2) {

                        switch (index) {
                            case 0: fields.Add("board_relay_name", gridRow.Cells[index].Value.ToString()); break;
                            case 2: fields.Add("relay_name_1", gridRow.Cells[index].Value.ToString()); break;
                            case 4: fields.Add("relay_name_2", gridRow.Cells[index].Value.ToString()); break;
                            case 6: fields.Add("relay_name_3", gridRow.Cells[index].Value.ToString()); break;
                            case 8: fields.Add("relay_name_4", gridRow.Cells[index].Value.ToString()); break;
                            case 10: fields.Add("relay_name_5", gridRow.Cells[index].Value.ToString()); break;
                            case 12: fields.Add("relay_name_6", gridRow.Cells[index].Value.ToString()); break;
                            case 14: fields.Add("relay_name_7", gridRow.Cells[index].Value.ToString()); break;
                            case 16: fields.Add("relay_name_8", gridRow.Cells[index].Value.ToString()); break;

                            default:
                                break;
                        }
                        Debug.Write("=====>");
                        Debug.Write(index + ":::");
                        Debug.Write(gridRow.Cells[index].Value);
                        Debug.Write("<=====");
                        Debug.WriteLine("");

                    }
                    classDataBase.updateData(fields, ListComport.Text, " id=" + boardId);
                    boardId++;
                }
                MessageBox.Show("ระบบได้ทำการบันทึกข้อมูลเรียบร้อยแล้ว");
                RAD_OFF.Checked = false;
                RAD_ON.Checked = false;
                this.loadDataGrid(ListComport.Text);
            }
        }

        private void BTN_GROUP_Click(object sender, EventArgs e) {
            this.Hide();
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog();
        }

   
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit(); 
        }

        private void BTN_SCHEDULE_Click(object sender, EventArgs e) {
            this.Hide();
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void BTN_CONTROL_Click(object sender, EventArgs e) {

        }

        private void BTN_LOGOUT_Click(object sender, EventArgs e) {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void BTN_LAYOUT_Click(object sender, EventArgs e) {
            this.Hide();
            LayoutForm layoutForm = new LayoutForm();
            layoutForm.ShowDialog();
        }
    }
}
