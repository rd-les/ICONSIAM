using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconsiam {
    public partial class LayoutForm : Form {



        private ClassDataBase classDataBase = new ClassDataBase();
        private DataTable dataTableGrid = new DataTable();


        private bool isMouseDown = false;
        private readonly Color colorCircle = Color.RoyalBlue;
        private readonly Color colorCircleCurrent = Color.Gold;

        private readonly Color colorCircleClose = Color.Red;
        private readonly Color colorCircleOpen = Color.LimeGreen;
        private readonly Color colorCircleNotFound = Color.Gray;


        private readonly int circleSize = 15;

        private int itemCheckedCurrent { get; set; }

        private int gridCurrentRow = -1;
        private int gridCurrentCellX { get; set; }
        private int gridCurrentCellY { get; set; }
        private int cellLastIndex { get; set; }



        List<CirclePoint> listCircles = new List<CirclePoint>();
        Dictionary<Rectangle, CirclePointXY> CirclePoint = new Dictionary<Rectangle, CirclePointXY>();
        Rectangle rect = new Rectangle(125, 125, 50, 50);


        List<Rectangle> listRects = new List<Rectangle>();

        //######################################################################    SET GRID INDEX.
        private readonly int gridCellCircuitId = 0;
        private readonly int gridCellCircuitName = 1;
        private readonly int gridCellControlId = 2;
        private readonly int gridCellX = 3;
        private readonly int gridCellY = 4;
        private readonly int gridCellEdit = 5;
        private readonly int gridCellDelete = 6;



        private string roottPathImage = Application.StartupPath + @"\Images\Layout";

        public LayoutForm() {
            InitializeComponent();
        }

        private void LayoutForm_Load(object sender, EventArgs e) {

            this.loadComboLayout();
            this.setDataTableGrid();
            this.setImageCircuitLocation(dataTableGrid);
        }

        public void loadComboLayout() {
            string sql = @"SELECT * FROM layout_building Order By layout_building_id ASC; ";
            DataTable dataTable = classDataBase.getDataTable(sql);

            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            //comboSource.Add("0", "Please Select");
            foreach (DataRow dataRow in dataTable.Rows) {
                comboSource.Add(dataRow["layout_building_id"].ToString(), dataRow["layout_building_name"].ToString());
                //COMBO_GROUP.Items.Add(new { Text = dataRow["group_name"].ToString(), Value= dataRow["group_id"].ToString() }  ); 
            }
            LAYOUT_COMBO.DataSource = new BindingSource(comboSource, null);
            LAYOUT_COMBO.DisplayMember = "Value";
            LAYOUT_COMBO.ValueMember = "Key";
            //LAYOUT_COMBO.SelectedIndex = 0;
        }

        private void LAYOUT_COMBO_SelectedIndexChanged(object sender, EventArgs e) {
            this.cellLastIndex = 0;
            if (LAYOUT_COMBO.Items.Count > 0) {
                this.gridCurrentCellX = 0;
                this.gridCurrentCellY = 0;
                setDataTableGrid();
                setImageCircuitLocation(dataTableGrid);
            }

        }


        private void setDataTableGrid() {
            ClassDataBase classDB = new ClassDataBase();
            GRIDVIEW_CIRCLE.DataSource = null;
            GRIDVIEW_CIRCLE.Rows.Clear();
            GRIDVIEW_CIRCLE.Refresh();

            string keyCombo = ((KeyValuePair<string, string>)LAYOUT_COMBO.SelectedItem).Key;
            string valueCombo = ((KeyValuePair<string, string>)LAYOUT_COMBO.SelectedItem).Value;

            /*
            string sql = @" SELECT TB2.* , TB3.control_name ,'Del' AS `Remove`
                            FROM layout_building TB1
                            LEFT JOIN layout_circuit TB2 ON (TB1.layout_building_id = TB2.layout_building_id) 
                            INNER JOIN config_ip TB3 ON (TB2.config_ip_id = TB3.id) 
                            WHERE TB1.layout_building_id =  "+ keyCombo;

            GRIDVIEW_CIRCLE.Columns[gridCellCircuitId].ReadOnly = false;
            GRIDVIEW_CIRCLE.Columns[gridCellCircuitName].ReadOnly = false; 
            GRIDVIEW_CIRCLE.Columns[gridCellControlId].ReadOnly = true;
            GRIDVIEW_CIRCLE.Columns[gridCellX].ReadOnly = true;
            GRIDVIEW_CIRCLE.Columns[gridCellY].ReadOnly = true;
            GRIDVIEW_CIRCLE.Columns[gridCellDelete].ReadOnly = false ;

            */
            string sql = @"  SELECT 
                                 TB2.id
                                 ,TB2.layout_circuit_name AS `Circuit Name`
                                 , TB3.control_name  AS `Name`
                                 ,TB2.layout_circuit_x  AS `X`
                                 ,TB2.layout_circuit_y AS `Y`
                                 , 'Edit' AS `Edit`
                                 , 'Del' AS `Remove` 
                                 , TB2.config_ip
                                 , TB2.relay_position
                                , '0' AS led_status
                            FROM layout_building TB1
                            LEFT JOIN layout_circuit TB2 ON (TB1.layout_building_id = TB2.layout_building_id) 
                            INNER JOIN config_ip TB3 ON (TB2.config_ip_id = TB3.id) 
                            WHERE TB1.layout_building_id =" + keyCombo;

            this.dataTableGrid = classDB.getDataTable(sql);

            GRIDVIEW_CIRCLE.DataSource = dataTableGrid;
            GRIDVIEW_CIRCLE.Columns[gridCellCircuitId].Width = 50;
            GRIDVIEW_CIRCLE.Columns[gridCellCircuitName].Width = 100;
            GRIDVIEW_CIRCLE.Columns[gridCellControlId].Width = 100;
            GRIDVIEW_CIRCLE.Columns[gridCellX].Width = 35;
            GRIDVIEW_CIRCLE.Columns[gridCellY].Width = 35;
            GRIDVIEW_CIRCLE.Columns[gridCellEdit].Width = 50;
            GRIDVIEW_CIRCLE.Columns[gridCellEdit].DefaultCellStyle.ForeColor = Color.Blue;
            GRIDVIEW_CIRCLE.Columns[gridCellEdit].DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);



            GRIDVIEW_CIRCLE.Columns[gridCellDelete].Width = 50;
            GRIDVIEW_CIRCLE.Columns[gridCellDelete].DefaultCellStyle.ForeColor = Color.Red;
            GRIDVIEW_CIRCLE.Columns[gridCellDelete].DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);

            GRIDVIEW_CIRCLE.Columns[7].Visible = false;
            GRIDVIEW_CIRCLE.Columns[8].Visible = false;
            GRIDVIEW_CIRCLE.Columns[9].Visible = false;


            classDB.closeConnection();
            GRIDVIEW_CIRCLE.ClearSelection();

        }

        private Color getCurcuitRealTime(DataRow dataRow , int countRow) {

            if (!dataRow["config_ip"].ToString().Equals("")) {
                Debug.WriteLine("config_ip : -" + dataRow["config_ip"] + "-  ----->  relay_position:    " + dataRow["relay_position"]);

                ClassModBus classModBus = new ClassModBus();
                bool[] readCommands = classModBus.Read_CommandRealTime(dataRow["config_ip"].ToString(), 1,Int32.Parse(dataRow["relay_position"].ToString()));
                //bool[] readCommands = new bool[1];
                //readCommands[0] = true; 


                if (readCommands[0] == true) {
                    this.dataTableGrid.Rows[countRow]["led_status"] = '1'; 
                    return this.colorCircleOpen;
                }
                else {
                    this.dataTableGrid.Rows[countRow]["led_status"] = '0';
                    return this.colorCircleClose;
                }

            }
            else {
                Debug.WriteLine("config_ip : null ----->  relay_position:  null");
                return this.colorCircleClose;
            }
        }

        private void setCircuitColorRealTime(Rectangle circleCircuit, Color color) {
            using (Graphics gfx = Graphics.FromImage(this.PICTUREBOX_MAIN.Image)) {
                SolidBrush brushRed = new SolidBrush(color);

                gfx.FillEllipse(brushRed, circleCircuit);
                gfx.DrawEllipse(Pens.RoyalBlue, circleCircuit);
                gfx.Dispose();

            }
        }

        private void setCircuitColor(Rectangle circleCircuit) {
            using (Graphics gfx = Graphics.FromImage(this.PICTUREBOX_MAIN.Image)) {
                SolidBrush brushRed = new SolidBrush(colorCircle);

                gfx.FillEllipse(brushRed, circleCircuit);
                gfx.DrawEllipse(Pens.RoyalBlue, circleCircuit);
                gfx.Dispose();

            }
        }
        private void setCircuitColorCurrent(Rectangle circleCircuit) {
            using (Graphics gfx = Graphics.FromImage(this.PICTUREBOX_MAIN.Image)) {
                SolidBrush brushYellow = new SolidBrush(colorCircleCurrent);

                gfx.FillEllipse(brushYellow, circleCircuit);
                gfx.DrawEllipse(Pens.Yellow, circleCircuit);
                gfx.Dispose();

            }
        }

        private void setImageCircuitLocation(DataTable dataTable) {

            string keyCombo = ((KeyValuePair<string, string>)LAYOUT_COMBO.SelectedItem).Key;
            //PICTUREBOX_MAIN.Image = Image.FromFile(roottPathImage+"\\"+keyCombo+ "\\image.png"); 
            using (Stream fs = File.Open(roottPathImage + "\\" + keyCombo + "\\image.png" , FileMode.Open ) ) {
                PICTUREBOX_MAIN.Image = Image.FromStream(fs);
            }
            /*
             * 
             * 
             * 
             * // Using fs As New IO.Stream(Files.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                    //PictureBox1.Image = Image.FromStream(fs)
                //End Using
            switch (keyCombo) {
                case "1": PICTUREBOX_MAIN.Image = Properties.Resources.LAYOUT_1; break;
                case "2": PICTUREBOX_MAIN.Image = Properties.Resources.LAYOUT_2; break;
                case "3": PICTUREBOX_MAIN.Image = Properties.Resources.LAYOUT_3; break;
            }
            */

            //PICTUREBOX_MAIN.Image = Properties.Resources.Condo_Layout;
            //Image.FromFile(@"Images\a.bmp");
            if (dataTable.Rows.Count > 0) {
                int countRow = 0; 
                foreach (DataRow dataRow in dataTable.Rows) {

                    //getCurcuitRealTime(dataRow); 

                    Rectangle circleCircuit = new Rectangle();
                    circleCircuit.Location = new Point(Int32.Parse(dataRow["X"].ToString()), Int32.Parse(dataRow["Y"].ToString()));
                    circleCircuit.Size = new Size(circleSize, circleSize);
                    setCircuitColor(circleCircuit);
                    setCircuitColorRealTime(circleCircuit, getCurcuitRealTime(dataRow , countRow));
                    countRow++;

                }
            }

        }

        private void GRIDVIEW_CIRCLE_CellClick(object sender, DataGridViewCellEventArgs e) {


        }


        private void setLastCircleCircuit(Rectangle circleCircuit  , Color color ) {
            using (Graphics gfx = Graphics.FromImage(this.PICTUREBOX_MAIN.Image)) {
                SolidBrush brushRed = new SolidBrush(color);

                gfx.FillEllipse(brushRed, circleCircuit);
                gfx.DrawEllipse(Pens.RoyalBlue, circleCircuit);
                gfx.Dispose();

            }
        }

        private void GRIDVIEW_CIRCLE_SelectionChanged(object sender, EventArgs e) {
            
            if (GRIDVIEW_CIRCLE.CurrentRow != null && PICTUREBOX_MAIN.Image != null ) {
                if (GRIDVIEW_CIRCLE.CurrentRow.Index != this.gridCurrentRow) {
                    this.gridCurrentRow = GRIDVIEW_CIRCLE.CurrentRow.Index;
                    
                    int rowIndex = GRIDVIEW_CIRCLE.CurrentRow.Index;
                    int circuitX = Int32.Parse(GRIDVIEW_CIRCLE.Rows[rowIndex].Cells[gridCellX].Value.ToString());
                    int circuitY = Int32.Parse(GRIDVIEW_CIRCLE.Rows[rowIndex].Cells[gridCellY].Value.ToString());

                    Console.WriteLine(GRIDVIEW_CIRCLE.Rows[rowIndex].Cells[gridCellX].Value + " : " + GRIDVIEW_CIRCLE.Rows[rowIndex].Cells[gridCellY].Value);

                    Rectangle circleCircuit = new Rectangle();
                    circleCircuit.Location = new Point(circuitX, circuitY);
                    circleCircuit.Size = new Size(circleSize, circleSize);
                    this.setCircuitColorCurrent(circleCircuit);

                    //Rectangle circleCircuitCurrent = new Rectangle();
                    //circleCircuitCurrent.Location = new Point(this.gridCurrentCellX, this.gridCurrentCellY);
                    //circleCircuitCurrent.Size = new Size(circleSize, circleSize);
                    //this.setCircuitColor(circleCircuitCurrent);

                    this.gridCurrentCellX = circuitX;
                    this.gridCurrentCellY = circuitY;

                    if (this.dataTableGrid.Rows.Count > 0 ) {
                        DataRow dataRowLast = this.dataTableGrid.Rows[cellLastIndex];
                        Rectangle circleCircuitLast = new Rectangle();
                        circleCircuitLast.Location = new Point(Int32.Parse(dataRowLast["X"].ToString()), Int32.Parse(dataRowLast["Y"].ToString()));
                        circleCircuitLast.Size = new Size(circleSize, circleSize);
                        setLastCircleCircuit(circleCircuitLast, (dataRowLast["led_status"].Equals("1") ? this.colorCircleOpen : this.colorCircleClose));
                        this.cellLastIndex = GRIDVIEW_CIRCLE.CurrentRow.Index;
                    }
                   

                    PICTUREBOX_MAIN.Refresh();
                }
            }

        }

        private void GRIDVIEW_CIRCLE_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            //gridCellDelete
            if (e.RowIndex >= 0) {
                if (e.ColumnIndex == gridCellDelete) {
                    GRIDVIEW_CIRCLE.Cursor = Cursors.No;
                }
                else {
                    GRIDVIEW_CIRCLE.Cursor = Cursors.Default;
                }
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

        private void BTN_GROUP_Click(object sender, EventArgs e) {
            this.Hide();
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog();
        }

        private void BTN_SCHEDULE_Click(object sender, EventArgs e) {
            this.Hide();
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.ShowDialog();
        }

        private void PICTUREBOX_MAIN_MouseDoubleClick(object sender, MouseEventArgs e) {

            Rectangle circle_bounds = new Rectangle();
            circle_bounds.Location = e.Location;
            circle_bounds.Size = new Size(circleSize, circleSize);
            circle_bounds.X = circle_bounds.X - 5;
            circle_bounds.Y = circle_bounds.Y - 5;
            listRects.Add(circle_bounds);

            CirclePointXY circlePointXY = new CirclePointXY(e.X, e.Y);
            CirclePoint.Add(circle_bounds, circlePointXY);

            using (Graphics gfx = Graphics.FromImage(this.PICTUREBOX_MAIN.Image)) {
                SolidBrush brushRed = new SolidBrush(colorCircle);

                gfx.FillEllipse(brushRed, circle_bounds);
                gfx.DrawEllipse(Pens.RoyalBlue, circle_bounds);
                gfx.Dispose();
                //gfx.DrawEllipse(Pens.Red, circle_bounds);
                //MessageBox.Show("X: " + circle_bounds.X + " :: Y:" + circle_bounds.Y);
                this.PICTUREBOX_MAIN.Refresh();
                ClassDataBase classDB = new ClassDataBase();

                //layout_circuit
                Dictionary<string, string> fields = new Dictionary<string, string>();
                string keyCombo = ((KeyValuePair<string, string>)LAYOUT_COMBO.SelectedItem).Key;
                fields.Add("layout_building_id", keyCombo);
                fields.Add("layout_circuit_name", "Relay Name");
                fields.Add("config_ip_id", "1");
                fields.Add("layout_circuit_x", circle_bounds.Location.X.ToString());
                fields.Add("layout_circuit_y", circle_bounds.Location.Y.ToString());

                classDB.insertData(fields, "layout_circuit");
                classDB.closeConnection();
                setDataTableGrid();

                //GRIDVIEW_CIRCLE.DataSource = dataTableGrid; 
                //GRIDVIEW_CIRCLE.Rows.Add("" , "" , "" ); 
                //GRIDVIEW_CIRCLE.Refresh() ;
                //GRIDVIEW_CIRCLE.Ro
            }

        }

        private void PICTUREBOX_MAIN_MouseDown(object sender, MouseEventArgs e) {
            isMouseDown = true;
        }

        private void PICTUREBOX_MAIN_MouseUp(object sender, MouseEventArgs e) {
            if (isMouseDown == true) {
                isMouseDown = false;
                rect = new Rectangle(e.X, e.Y, 50, 50);
                // var rc = getRectangle();
                //if (rc.Width > 0 && rc.Height > 0) rectangles.Add(rc);

                this.PICTUREBOX_MAIN.Invalidate();
            }


            // Graphics gfx = Graphics.FromImage(this.PICTUREBOX_MAIN.Image);
            // gfx.FillRectangle(new SolidBrush(Color.RoyalBlue), rect);
            // this.PICTUREBOX_MAIN.Refresh();
        }

        private void PICTUREBOX_MAIN_MouseMove(object sender, MouseEventArgs e) {
            if (isMouseDown == true) {
                this.PICTUREBOX_MAIN.Invalidate();
            }
        }

        private void GRIDVIEW_CIRCLE_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                if (e.ColumnIndex == gridCellDelete) {
                    //MessageBox.Show("คุณต้องการลบ Circuit \"" + GRIDVIEW_CIRCLE.Rows[e.RowIndex].Cells[gridCellCircuitName].Value + "\"");
                    DialogResult dialogResult = MessageBox.Show("คุณต้องการลบ Circuit \"" + GRIDVIEW_CIRCLE.Rows[e.RowIndex].Cells[gridCellCircuitName].Value + "\" ใช่หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes) {
                        ClassDataBase classDB = new ClassDataBase();
                        classDB.deleteData("layout_circuit", "id=" + GRIDVIEW_CIRCLE.Rows[e.RowIndex].Cells[gridCellCircuitId].Value);
                        classDB.closeConnection();

                        setDataTableGrid();
                        setImageCircuitLocation(dataTableGrid);
                    }
                }
                else if (e.ColumnIndex == gridCellEdit) {
                    PANEL_CONTROL.Show();
                    COMBO_ADD_CONTROL.SelectedIndex = 0;
                    CHECKLIST_RELAY.Items.Clear();
                    //GRIDVIEW_CIRCLE.Enabled = false ; 
                }

            }
        }

        private void GRIDVIEW_CIRCLE_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                if (e.ColumnIndex == gridCellCircuitName) {
                    string sql = "UPDATE layout_circuit SET layout_circuit_name = '" + GRIDVIEW_CIRCLE.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + "' WHERE id=" + GRIDVIEW_CIRCLE.Rows[e.RowIndex].Cells[gridCellCircuitId].Value;
                    classDataBase.updateCommand(sql);
                }
            }
        }

        private void COMBO_ADD_CONTROL_SelectedIndexChanged(object sender, EventArgs e) {

            if (COMBO_ADD_CONTROL.SelectedIndex != 0) {

                //MessageBox.Show("----->"+COMBO_ADD_CONTROL.Text);
                string sql = "SELECT * FROM `" + COMBO_ADD_CONTROL.Text + "`";
                DataTable dataTable = classDataBase.getDataTable(sql);
                CHECKLIST_RELAY.Items.Clear();
                int countRow = 1;

                foreach (DataRow dataRow in dataTable.Rows) {


                    for (int index = 1; index <= 8; index++) {
                        if (!dataRow["relay_name_" + index].Equals("")) {
                            CHECKLIST_RELAY.Items.Add(dataRow["relay_name_" + index]);
                        }
                        else {
                            continue;
                        }

                    }
                    //CHECKLIST_RELAY.Items.Add(countRow);
                    countRow++;
                }
            }
            Debug.WriteLine("---------->");


        }

        private void CHECKLIST_RELAY_ItemCheck(object sender, ItemCheckEventArgs e) {
            for (int ix = 0; ix < CHECKLIST_RELAY.Items.Count; ++ix) {
                if (ix != e.Index) CHECKLIST_RELAY.SetItemChecked(ix, false);
                else {
                    this.itemCheckedCurrent = e.Index;
                }

            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e) {
            var checkedItems = CHECKLIST_RELAY.CheckedItems.Cast<object>().Aggregate(string.Empty, (current, item) => current + item.ToString());
            //MessageBox.Show(checkedItems);
            GRIDVIEW_CIRCLE.Rows[GRIDVIEW_CIRCLE.CurrentCell.RowIndex].Cells[gridCellCircuitName].Value = checkedItems;
            string configIP = classDataBase.selectOnceData("config_ip", "control_ip", "control_name='" + COMBO_ADD_CONTROL.Text + "'");
            string sql = "UPDATE layout_circuit SET config_ip = '" + configIP + "'  , relay_position = '" + this.itemCheckedCurrent + "'  Where id=" + GRIDVIEW_CIRCLE.Rows[GRIDVIEW_CIRCLE.CurrentCell.RowIndex].Cells[gridCellCircuitId].Value;

            classDataBase.updateCommand(sql);

            Debug.WriteLine("=======================================>   : " + GRIDVIEW_CIRCLE.Rows[GRIDVIEW_CIRCLE.CurrentCell.RowIndex].Cells[gridCellCircuitId].Value);
            Debug.WriteLine("=======================================>   : " + configIP + "=======================================>" + this.itemCheckedCurrent);
            PANEL_CONTROL.Hide();


        }

        private void BUTTON_CANCEL_Click(object sender, EventArgs e) {
            PANEL_CONTROL.Hide();
            //GRIDVIEW_CIRCLE.Enabled = true;
        }

        private void BTN_DELETE_Click(object sender, EventArgs e) {

            DialogResult dialogResult = MessageBox.Show("คุณต้องการลบ Circuit ทั้งหมดใช่หรือไม่ ใช่หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes) {
                string keyCombo = ((KeyValuePair<string, string>)LAYOUT_COMBO.SelectedItem).Key;
                string sql = "DELETE FROM layout_circuit WHERE layout_building_id=" + keyCombo;
                classDataBase.updateCommand(sql);
                setDataTableGrid();
            }

        }

        private void BTN_RELOAD_Click(object sender, EventArgs e) {
            this.setDataTableGrid();
            this.setImageCircuitLocation(dataTableGrid);
        }

        private void BTN_CHANGE_IMAGE_Click(object sender, EventArgs e) {


           // DialogResult dialogResult = MessageBox.Show("เมื่อทำการเปลี่ยนรูป ข้อมูลทั้งหมดจะหายไป ต้องการทำรายการต่อหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
            DialogResult dialogResult = MessageBox.Show("คุณตั้องการที่จะเปลี่ยนรูปใช่หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes) {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Image Files(*.png; *.PNG)|*.png; *.PNG";
                if (openDialog.ShowDialog() == DialogResult.OK) {
                    Console.WriteLine(openDialog.FileName);
                    // display image in picture box  
                    PICTUREBOX_MAIN.InitialImage = null;
                    PICTUREBOX_MAIN.Image = null;
                    PICTUREBOX_MAIN.Refresh();
                   

                    string keyCombo = ((KeyValuePair<string, string>)LAYOUT_COMBO.SelectedItem).Key;
                    string desPathFile = roottPathImage + "\\" + keyCombo + "\\image.png";

                    try {
                        File.Copy(openDialog.FileName, desPathFile, true);
                        PICTUREBOX_MAIN.Image = new Bitmap(openDialog.FileName);
                        //string sqlDel = "DELETE FROM layout_circuit WHERE layout_building_id = " + keyCombo;
                        //classDataBase.updateCommand(sqlDel);
                        this.setDataTableGrid();
                        this.setImageCircuitLocation(dataTableGrid);
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        private void BTN_LAYOUT_Click(object sender, EventArgs e) {
           
        }

        private void BTN_HOME_Click_1(object sender, EventArgs e) {
            this.Hide();
            BuildingForm buildingForm = new BuildingForm();
            buildingForm.ShowDialog();
        }

        private void BTN_CONTROL_Click_1(object sender, EventArgs e) {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void BTN_GROUP_Click_1(object sender, EventArgs e) {
            this.Hide();
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog();
        }

        private void BTN_SCHEDULE_Click_1(object sender, EventArgs e) {
            this.Hide();
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.ShowDialog();
        }

        private void BTN_LOGOUT_Click(object sender, EventArgs e) {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void LayoutForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void BTN_CONTROL_Click_2(object sender, EventArgs e) {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }






    public class CirclePoint {
        Dictionary<Rectangle, CirclePointXY> circleBounds { get; set; }
    }
    public class CirclePointXY {
        public CirclePointXY(int x, int y) {
            this.circleX = x;
            this.circleY = y;
        }
        private int circleX { get; set; }
        private int circleY { get; set; }
    }






}
