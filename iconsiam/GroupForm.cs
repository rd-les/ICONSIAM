using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconsiam {
    public partial class GroupForm : Form {

        ClassDataBase classDataBase = new ClassDataBase();
        ClassBoardRelay classBoardRelay = new ClassBoardRelay(); 

        public GroupForm() {
            InitializeComponent();
            classBoardRelay.relayInserts = new List<ClassRelayInsert>();

        }

        private void setTreeViewListRelay() {
            TREEVIEW_LIST_RELAY.Nodes.Clear();
            ClassModBus classModBus = new ClassModBus();
            string sql = "SELECT * FROM `grouping_list` WHERE group_id = "+TXT_GROUP_ID.Text+" GROUP BY `control_name` ";
            DataTable dataTable = classDataBase.getDataTable(sql);
            int rootNode = 0; 
            foreach (DataRow dataRow in dataTable.Rows) {


                TREEVIEW_LIST_RELAY.Nodes.Add(dataRow["control_name"].ToString(), dataRow["control_name"].ToString().ToUpper() );
                string getIpConfig = classDataBase.selectOnceData("config_ip", "control_ip", " control_name='" + dataRow["control_name"] + "'");
                bool[] readCommands = classModBus.Read_Command(getIpConfig, 1);
                string sqlList = "SELECT * FROM grouping_list WHERE control_name = '"+ dataRow["control_name"]+ "' AND group_id ="+TXT_GROUP_ID.Text+" ORDER BY relay_id , relay_position" ;                
                DataTable dataTableList = classDataBase.getDataTable(sqlList);
                foreach (DataRow dataRowList in dataTableList.Rows) {

                    string relayName = classDataBase.selectOnceData("`"+dataRow["control_name"].ToString()+"`", "relay_name_"+ dataRowList["relay_position"] , "id="+ dataRowList["relay_id"]); 
                    TREEVIEW_LIST_RELAY.Nodes[dataRow["control_name"].ToString()].Nodes.Add(dataRowList["id"].ToString() , relayName);

                    if (readCommands.Length > 1 ) {
                        int positionRelay = ((int.Parse(dataRowList["relay_id"].ToString()) - 1) * 8) + int.Parse(dataRowList["relay_position"].ToString());
                        TREEVIEW_LIST_RELAY.Nodes[dataRow["control_name"].ToString()].Nodes[dataRowList["id"].ToString()].ForeColor = (readCommands[positionRelay - 1] == true ? Color.LimeGreen : Color.Red);
                    }                   
                    
                }
                rootNode++; 
            }

            //TREEVIEW_LIST_RELAY.ExpandAll();

        }

        private void GroupForm_Load(object sender, EventArgs e) {
            setGridViewGroupList();
        }

        private void setGridViewGroupList() {
            GRIDVIEW_GROUP_LIST.DataSource = null;
            GRIDVIEW_GROUP_LIST.Rows.Clear();
            GRIDVIEW_GROUP_LIST.Refresh();

            string sql = @" SELECT TB1.group_id , TB1.group_name AS GROUP_NAME , COUNT(TB2.id) AS COUNT_RELAY , TB1.usable
                            FROM `grouping` TB1
                            LEFT JOIN grouping_list TB2 ON(TB1.`group_id` = TB2.group_id) 
                            WHERE 1
                            GROUP BY TB1.`group_id` ";
            DataTable dataTable = classDataBase.getDataTable(sql);            

            if (dataTable.Rows.Count > 0) {
                DataColumn col_sort = dataTable.Columns.Add("#", Type.GetType("System.Int32"));
                int countRow = 1; 
                foreach (DataRow dataRow in dataTable.Rows) {
                    dataRow["#"] = countRow;
                    countRow++;                  
                }
                col_sort.SetOrdinal(1);

                GRIDVIEW_GROUP_LIST.DataSource = dataTable;

                TXT_GROUP_ID.Text = GRIDVIEW_GROUP_LIST.Rows[0].Cells[0].Value.ToString();
                TXT_GROUP_NAME.Text = GRIDVIEW_GROUP_LIST.Rows[0].Cells[2].Value.ToString();
                CHK_USABLE.Checked = Convert.ToBoolean(GRIDVIEW_GROUP_LIST.Rows[0].Cells[4].Value);
                TXT_ACTION.Text = "EDIT";

                GRIDVIEW_GROUP_LIST.Columns[0].Width = 50;
                GRIDVIEW_GROUP_LIST.Columns[0].Visible = false;                
                GRIDVIEW_GROUP_LIST.Columns[1].Width = 50;
                GRIDVIEW_GROUP_LIST.Columns[2].Width = 300;
                GRIDVIEW_GROUP_LIST.Columns[3].Width = 100;
                GRIDVIEW_GROUP_LIST.Columns[4].Width = 100;



                //setTreeViewListRelay();
            }
            GRIDVIEW_GROUP_LIST.CurrentCell = null;
            GRIDVIEW_GROUP_LIST.ClearSelection() ; 

        }
             

        private void loadDataGridViewRelay(string boardRelayName) {

            //TreeNode[] treeNodes = TREEVIEW_LIST_RELAY.Nodes.Cast<TreeNode>().Where(r => r.Text == "10/LP2AFC/10").ToArray();
            string sql = "SELECT * FROM `" + boardRelayName+"`";
            DataTable dataTable = classDataBase.getDataTable(sql);
            dataTable.PrimaryKey = null;
            //dataTable.Columns.Remove("id");
            dataTable.Columns.RemoveAt(0);
            Grid_Relay.DataSource = dataTable;

            int columnWidth = 25;
            Grid_Relay.Columns[0].Width = 80;
            Grid_Relay.Columns[0].HeaderText = "Board Name";
            for (int indexHeader = 1; indexHeader <= 15; indexHeader = indexHeader + 2) {
                Grid_Relay.Columns[indexHeader].Width = columnWidth;
                Grid_Relay.Columns[indexHeader].HeaderText = "#";
            }

            foreach (DataGridViewRow gridRow in Grid_Relay.Rows) {

                for (int index = 1; index <= 15; index = index + 2) {
                    gridRow.Cells[index].Value = false;
                }

            }
            //############################################################# END SET GRIDVIEW.

            Debug.WriteLine("---------->");
            Grid_Relay.DefaultCellStyle.Font = new Font("Tahoma", 7);
        }


        private TreeNode FindNode(TreeView tvSelection, string matchText) {
            foreach (TreeNode node in tvSelection.Nodes) {
                if (node.Text.Equals(matchText) ) {
                    return node;
                }
                
            }
            return (TreeNode)null;
        }



        private void BTN_RELAY_SAVE_Click(object sender, EventArgs e) {
            int dataIndexRow = 1;
            TreeNode treenode = FindNode(TREEVIEW_LIST_RELAY, ListComport.Text);
            
            if (treenode== null) {
                TREEVIEW_LIST_RELAY.Nodes.Add(ListComport.Text, ListComport.Text);
            }
             
           
            foreach (DataGridViewRow gridRow in Grid_Relay.Rows) {
                int dataIndexColumn = 1;
                for (int index = 1; index <= 15; index = index + 2) {

                    if (Convert.ToBoolean(gridRow.Cells[index].Value) == true) {
                        TREEVIEW_LIST_RELAY.Nodes[ListComport.Text.ToLower()].Nodes.Add(gridRow.Cells[index+1].Value.ToString());
                        ClassRelayInsert classRelayInsert = new ClassRelayInsert();

                        classRelayInsert.group_id =  TXT_GROUP_ID.Text;
                        classRelayInsert.control_name = ListComport.Text.ToLower();
                        classRelayInsert.relay_id = dataIndexRow.ToString() ;
                        classRelayInsert.relay_position = dataIndexColumn.ToString(); 

                        this.classBoardRelay.relayInserts.Add(classRelayInsert); 


                    }
                    dataIndexColumn++;
                }
                dataIndexRow++;
            }
            TREEVIEW_LIST_RELAY.ExpandAll();
           

            PANEL_GRID_RELAY.Visible = false;
        }

        private void BTN_RELAY_CANCEL_Click(object sender, EventArgs e) {
            PANEL_GRID_RELAY.Visible = false;
        }

        private void BTN_ADD_RELAY_Click(object sender, EventArgs e) {
            
            PANEL_GRID_RELAY.Visible = true;
            LABEL_GROUP_NAME.Text = TXT_GROUP_NAME.Text;
            ListComport.SelectedIndex = 0;
            CHK_SELECT_ALL.Checked = false; 
            //loadDataGridViewRelay();
           
        }

        private void ListComport_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListComport.SelectedIndex != 0) {
                this.loadDataGridViewRelay(ListComport.Text);               
            }
            else {
                //Grid_Relay.remo
                Grid_Relay.DataSource = null;
                Grid_Relay.Rows.Clear();
                Grid_Relay.Refresh();               
            }
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

        private void GRIDVIEW_GROUP_LIST_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                TXT_GROUP_ID.Text = GRIDVIEW_GROUP_LIST.Rows[e.RowIndex].Cells[0].Value.ToString();
                TXT_GROUP_NAME.Text = GRIDVIEW_GROUP_LIST.Rows[e.RowIndex].Cells[2].Value.ToString();
                CHK_USABLE.Checked = Convert.ToBoolean(GRIDVIEW_GROUP_LIST.Rows[e.RowIndex].Cells[4].Value);
                TXT_ACTION.Text = "EDIT";
                setTreeViewListRelay();


            }

        }

        private void BTN_ADD_GROUP_Click(object sender, EventArgs e) {
            string promptValue = this.ShowDialog("PLEASE INSERT.",  "GROUP NAME");
            if (!promptValue.Equals("") ) {

                string sameName = classDataBase.selectOnceData("grouping", "group_id" , " group_name='"+ promptValue + "'" );
                if (sameName.Equals("")) {
                    string nextId = classDataBase.nextId("grouping", "group_id");
                    TXT_GROUP_ID.Text = nextId;
                    TXT_GROUP_NAME.Text = promptValue;
                    CHK_USABLE.Checked = true;
                    TREEVIEW_LIST_RELAY.Nodes.Clear();
                    TXT_ACTION.Text = "ADD";
                }
                else {
                    MessageBox.Show("ชื่อ GROUP: \""+promptValue+ "\" ที่คุณใส่มีอยู่แล้ว", "แจ้งเตือน",MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            else {
                MessageBox.Show("กรุณาใส่ชื่อ GROUP", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ShowDialog(string text, string caption) {
            Form prompt = new Form() {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "CONFIRM", Left = 50, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void CHK_SELECT_ALL_CheckedChanged(object sender, EventArgs e) {
            this.checkBoxGridView(CHK_SELECT_ALL.Checked); 
        }


        private void checkBoxGridView(bool status) {
            foreach (DataGridViewRow gridRow in Grid_Relay.Rows) {

                for (int index = 1; index <= 15; index = index + 2) {
                    if (gridRow.Cells[index + 1].Value == null || gridRow.Cells[index + 1].Value.ToString().Equals("") ) {
                        continue;
                    }
                    gridRow.Cells[index].Value = status;            
                }

            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e) {

            try {
                //################################################################ INSERT GROUP.
                //  group_name
                Dictionary<string, string> fieldsGroup = new Dictionary<string, string>();
                fieldsGroup.Add("group_id", TXT_GROUP_ID.Text);
                fieldsGroup.Add("group_name", TXT_GROUP_NAME.Text);
                
                fieldsGroup.Add("usable", (CHK_USABLE.Checked ?"1" : "0" ));
                if (TXT_ACTION.Text.Equals("ADD")) {
                    classDataBase.insertData(fieldsGroup, "grouping");
                    setGridViewGroupList(); 
                }
                else {
                    classDataBase.updateData(fieldsGroup, "grouping", " group_id=" + TXT_GROUP_ID.Text);
                }

                Debug.WriteLine(this.classBoardRelay.relayInserts);
                StringBuilder sqlInsertRelay = new StringBuilder();

                sqlInsertRelay.Append(" INSERT INTO  `grouping_list` ");
                sqlInsertRelay.Append(" ( group_id, control_name , relay_id, relay_position ) ");
                sqlInsertRelay.Append(" VALUES ");

                int countRelay = 0; 

                foreach (ClassRelayInsert relayInsert in this.classBoardRelay.relayInserts) {
                    string whereSql = " group_id=" + relayInsert.group_id + " AND control_name='" + relayInsert.control_name+ "' AND relay_id=" + relayInsert.relay_id+ "  AND relay_position=" + relayInsert.relay_position ;
                    classDataBase.deleteData("grouping_list", whereSql);

                    if (countRelay>0) {
                        sqlInsertRelay.Append(" , "); 
                    }

                    sqlInsertRelay.Append("( "+relayInsert.group_id+"  ,  '" + relayInsert.control_name+"' ,  "+ relayInsert.relay_id+" , "+ relayInsert.relay_position +" ) "); 

                    countRelay++;
                    /*
                     *  
                     *  Dictionary<string, string> fieds = new Dictionary<string, string>();
                        fieds.Add("group_id", relayInsert.group_id);
                        fieds.Add("control_name", relayInsert.control_name);
                        fieds.Add("relay_id", relayInsert.relay_id);
                        fieds.Add("relay_position", relayInsert.relay_position);

                        classDataBase.insertData(fieds, "grouping_list");
                    */
                    //Debug.WriteLine(whereSql); 
                }
                Debug.WriteLine(sqlInsertRelay);
                if (countRelay>0) {
                    classDataBase.insertCommand(sqlInsertRelay.ToString());
                }
                

                MessageBox.Show("ระบบได้ทำการบันทึกข้อมูลเรียบร้อยแล้ว");
                int rowIndexGrid = GRIDVIEW_GROUP_LIST.CurrentCell.RowIndex;
                this.setGridViewGroupListAfterAction(rowIndexGrid); 
                //this.setGridViewGroupList();

            }
            catch (Exception ex) {
                MessageBox.Show("ระบบ ไม่สามารถทำการบันทึกข้อมูล" ,"แจ้งเตือนข้อผิดพลาด" ,MessageBoxButtons.OK , MessageBoxIcon.Error);
                AppClass.saveDataLogDebug("GROUP FORM : BTN_SAVE_Click", ex.ToString());
                Debug.WriteLine(ex); 
            }
            finally {

            }
          
        }

        private void TREEVIEW_LIST_RELAY_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            DialogResult dialogResult = MessageBox.Show("ต้องการที่จะลบ "+e.Node.Text, "ยืนยันการลบ", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes) {
                //TREEVIEW_LIST_RELAY.Nodes.Remove(e.Node);
                string sqlDel = " group_id = " + TXT_GROUP_ID.Text;
                string relay_name = e.Node.Text;
                if (e.Node.Parent != null ) {
                    sqlDel += " AND control_name ='" + e.Node.Parent.Text.ToLower() + "' "; 
                    string tablelName = "`"+e.Node.Parent.Text.ToLower()+"`"  ; 
                    //############################################################  FIND RELAY POSITION.
                    string position_1 = classDataBase.selectOnceData(tablelName, "id" , " relay_name_1 = '"+ relay_name + "'" ) ;
                    string position_2 = classDataBase.selectOnceData(tablelName, "id", " relay_name_2 = '" + relay_name + "'");
                    string position_3 = classDataBase.selectOnceData(tablelName, "id", " relay_name_3 = '" + relay_name + "'");
                    string position_4 = classDataBase.selectOnceData(tablelName, "id", " relay_name_4 = '" + relay_name + "'");
                    string position_5 = classDataBase.selectOnceData(tablelName, "id", " relay_name_5 = '" + relay_name + "'");
                    string position_6 = classDataBase.selectOnceData(tablelName, "id", " relay_name_6 = '" + relay_name + "'");
                    string position_7 = classDataBase.selectOnceData(tablelName, "id", " relay_name_7 = '" + relay_name + "'");
                    string position_8 = classDataBase.selectOnceData(tablelName, "id", " relay_name_8 = '" + relay_name + "'");

                    string relay_id = "";
                    string relay_position = ""; 
                    if (!position_1.Equals("") ) { relay_id = position_1; relay_position = "1"; }
                    else if (!position_2.Equals("")) { relay_id = position_2; relay_position = "2"; }
                    else if (!position_3.Equals("")) { relay_id = position_3; relay_position = "3"; }
                    else if (!position_4.Equals("")) { relay_id = position_4; relay_position = "4"; }
                    else if (!position_5.Equals("")) { relay_id = position_5; relay_position = "5"; }
                    else if (!position_6.Equals("")) { relay_id = position_6; relay_position = "6"; }
                    else if (!position_7.Equals("")) { relay_id = position_7; relay_position = "7"; }
                    else if (!position_8.Equals("")) { relay_id = position_8; relay_position = "8"; }

                    sqlDel += " AND relay_id ="+ relay_id + " AND relay_position ="+relay_position; 
                }
                else {
                    sqlDel += " AND control_name ='" + e.Node.Text.ToLower() + "' ";
                }

                int rowIndexGrid = GRIDVIEW_GROUP_LIST.CurrentCell.RowIndex; 
                classDataBase.deleteData("grouping_list", sqlDel);

                MessageBox.Show("ระบบได้ทำการลบข้อมูลเรียบร้อยแล้ว");
                this.setGridViewGroupListAfterAction(rowIndexGrid);

            }

        }

        private void setGridViewGroupListAfterAction(int rowIndexGrid) {

            GRIDVIEW_GROUP_LIST.DataSource = null;
            GRIDVIEW_GROUP_LIST.Rows.Clear();
            GRIDVIEW_GROUP_LIST.Refresh();

            string sql = @" SELECT TB1.group_id , TB1.group_name AS GROUP_NAME , COUNT(TB2.id) AS COUNT_RELAY , TB1.usable
                            FROM `grouping` TB1
                            LEFT JOIN grouping_list TB2 ON(TB1.`group_id` = TB2.group_id) 
                            WHERE 1
                            GROUP BY TB1.`group_id` ";
            DataTable dataTable = classDataBase.getDataTable(sql);


            if (dataTable.Rows.Count > 0) {

                DataColumn col_sort = dataTable.Columns.Add("#", Type.GetType("System.Int32"));
                int countRow = 1;
                foreach (DataRow dataRow in dataTable.Rows) {
                    dataRow["#"] = countRow;
                    countRow++;
                }
                col_sort.SetOrdinal(1);

                GRIDVIEW_GROUP_LIST.DataSource = dataTable;
               

                TXT_GROUP_ID.Text = GRIDVIEW_GROUP_LIST.Rows[rowIndexGrid].Cells[0].Value.ToString();
                TXT_GROUP_NAME.Text = GRIDVIEW_GROUP_LIST.Rows[rowIndexGrid].Cells[2].Value.ToString();
                CHK_USABLE.Checked = Convert.ToBoolean(GRIDVIEW_GROUP_LIST.Rows[rowIndexGrid].Cells[4].Value);
                TXT_ACTION.Text = "EDIT";
                GRIDVIEW_GROUP_LIST.Columns[0].Width = 50;
                GRIDVIEW_GROUP_LIST.Columns[0].Visible = false;
                GRIDVIEW_GROUP_LIST.Columns[1].Width = 50;
                GRIDVIEW_GROUP_LIST.Columns[2].Width = 300;
                GRIDVIEW_GROUP_LIST.Columns[3].Width = 100;
                GRIDVIEW_GROUP_LIST.Columns[4].Width = 100;
                GRIDVIEW_GROUP_LIST.Rows[rowIndexGrid].Cells[1].Selected = true;
                setTreeViewListRelay();
            }            
        }


        private void GroupForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void BTN_SCHEDULE_Click(object sender, EventArgs e) {
            this.Hide();
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.ShowDialog();
        }

        private void BTN_SCHEDULE_Click_1(object sender, EventArgs e) {
            this.Hide();
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.ShowDialog();
        }

        private void BTN_CONTROL_Click_1(object sender, EventArgs e) {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void BTN_HOME_Click_1(object sender, EventArgs e) {
            this.Hide();
            BuildingForm buildingForm = new BuildingForm();
            buildingForm.ShowDialog();
        }

        private void BTN_ACTION_ON_OFF_Click(object sender, EventArgs e) {

            if (!TXT_ACTION.Text.Equals("EDIT")) {
                MessageBox.Show(" ไม่สามารถทำรายการได้ กรุณาเลือก รายการจาก GROUP ที่มี");
            }
            else if (RAD_ON.Checked == true) {
                try {
                    this.Enabled = false; 
                    sendPackageCommand(1);
                }
                catch (Exception ex) {
                    Debug.WriteLine(ex);
                    AppClass.saveDataLogDebug("GROUP_FORM : BTN_ACTION_ON_OFF_Click  else if (RAD_ON.Checked == true)", ex.ToString());
                }
                finally {
                    this.Enabled = true;
                }
               
            }
            else if(RAD_OFF.Checked == true) {

                try {
                    this.Enabled = false;
                    sendPackageCommand(0);
                }
                catch (Exception ex) {
                    Debug.WriteLine(ex);
                    AppClass.saveDataLogDebug("GROUP_FORM : BTN_ACTION_ON_OFF_Click else if(RAD_OFF.Checked == true) ", ex.ToString());
                }
                finally {
                    this.Enabled = true;
                }
            }
            else {
                
                MessageBox.Show(" กรุณาเลือก ON หรือ OFF "); 
            }
            
        }
        private void sendPackageCommand(int controlOnOff) {
            ClassModBus classModBus = new ClassModBus();
            TXT_LOG.Clear();
            try {
                string sql = @"SELECT* FROM `grouping_list` WHERE group_id = " + TXT_GROUP_ID.Text + " ORDER BY control_name ASC ,relay_id ASC , relay_position ASC";
                DataTable dataTable = classDataBase.getDataTable(sql);
                foreach (DataRow dataRow in dataTable.Rows) {
                    int positionRelay = ((int.Parse(dataRow["relay_id"].ToString()) - 1) * 8) + int.Parse(dataRow["relay_position"].ToString());
                    string getIp = classDataBase.selectOnceData("config_ip", "control_ip", " control_name='" + dataRow["control_name"] + "'");
                    Debug.WriteLine(getIp + " <=====> 1 <=====> " + positionRelay + " <=====> " + controlOnOff);
                    string textNode = TREEVIEW_LIST_RELAY.Nodes[dataRow["control_name"].ToString() ].Nodes[dataRow["id"].ToString()].Text;
                    string oldText = " ขณะนี้กำลังทำงานที่ Relay -----> " + (positionRelay) + " : " + textNode + " " + (controlOnOff == 1 ? "เปิด" : "ปิด");  //TXT_LOG.Text;
                    TXT_LOG.AppendText(oldText);
                    TXT_LOG.AppendText(Environment.NewLine);
                    TREEVIEW_LIST_RELAY.Nodes[dataRow["control_name"].ToString()].Nodes[dataRow["id"].ToString()].ForeColor = (controlOnOff == 1 ? Color.LimeGreen: Color.Red); 
                    Application.DoEvents();
                    classModBus.Write_Command(getIp, 1, positionRelay-1, controlOnOff);
                    Thread.Sleep(500);
                }
                MessageBox.Show(" ระบบทำงานเรียบร้อยแล้ว ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(" ระบบไม่สามารถทำงานได้ " , "แจ้งเตือน" , MessageBoxButtons.OK, MessageBoxIcon.Error); 
                Debug.WriteLine(ex);
                AppClass.saveDataLogDebug("GROUP_FORM : sendPackageCommand", ex.ToString());
            }
            
        }

        private void BTN_DELETE_GROUP_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("ต้องการที่จะลบ " + TXT_GROUP_NAME.Text + " ใช่หรือไม่ (ลบ GROUP จะมีผลต่อ SCHEDULE ด้วย !!!!! )", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes) {

                string sql = @" DELETE TB1, TB2, TB3 
                                FROM `grouping` TB1 
                                LEFT JOIN `grouping_list` TB2 ON(TB1.group_id = TB2.group_id) 
                                LEFT JOIN `schedule_group` TB3 ON(TB1.group_id = TB3.group_id)
                                WHERE TB1.group_id = "+TXT_GROUP_ID.Text;

                try {
                    classDataBase.updateCommand(sql);
                    TREEVIEW_LIST_RELAY.Nodes.Clear(); 
                    MessageBox.Show(" ระบบ ได้ทำการลบข้อมูลเรียบร้อยแล้ว");

                }
                catch (Exception ex) {
                    MessageBox.Show(" ระบบ ไม่สามารถทำรายการได้");
                    Debug.WriteLine(ex);
                    AppClass.saveDataLogDebug("GROUP_FORM : BTN_DELETE_GROUP_Click ", ex.ToString());
                }               

                this.setGridViewGroupList(); 
                


            }

            //BTN_DELETE_GROUP


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
