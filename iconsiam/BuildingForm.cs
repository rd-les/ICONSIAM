using System;
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
    public partial class BuildingForm : Form {


        private Color mouseOverColor = Color.Yellow;
        private Color mouseLeaveColor = Color.Transparent;
        private int THICKNESS = 3;
        private ClassDataBase classDataBase = new ClassDataBase();
        private ClassModBus classModBus = new ClassModBus();

        Color statusColorFloorUG = Color.LimeGreen;
        Color statusColorFloor2 = Color.LimeGreen;
        Color statusColorFloor3 = Color.LimeGreen;
        Color statusColorFloor4 = Color.LimeGreen;
        Color statusColorFloor6 = Color.LimeGreen;
        Color statusColorFloor7 = Color.LimeGreen;
        Color statusColorFloor8 = Color.LimeGreen;

        public BuildingForm() {
            InitializeComponent();
        }

        private void BTN_CONTROL_Click(object sender, EventArgs e) {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog(); 
        }

        private void BuildingForm_Load(object sender, EventArgs e) {
            this.statusColorFloorUG = this.getStatusBuildFloor("0");
            this.statusColorFloor2 = this.getStatusBuildFloor("2");
            this.statusColorFloor3 = this.getStatusBuildFloor("3");
            this.statusColorFloor4 = this.getStatusBuildFloor("4");
            this.statusColorFloor6 = this.getStatusBuildFloor("6");
            this.statusColorFloor7 = this.getStatusBuildFloor("7");
            this.statusColorFloor8 = this.getStatusBuildFloor("8");
            this.Invalidate(); 

        }


        private Color getStatusBuildFloor(string floor ) {

            string sql = "SELECT * FROM `config_ip`  WHERE group_floor="+ floor ;
            //string sql = "SELECT * FROM `config_ip`  WHERE id=1";
            DataTable dataTable = classDataBase.getDataTable(sql);
            Color returnColor = Color.LimeGreen;

            bool ipFound = true;
            bool currentOpenAll = true;
            bool currentDiff = false; 
            
            foreach (DataRow dataRow in dataTable.Rows) {

                bool[] getStatus = classModBus.Read_CommandRealStatus(dataRow["control_ip"].ToString() , 1 );

                if (getStatus.Length == 1) {
                    MessageBox.Show("ระบบไม่สามารถค้นหา IP "+ dataRow["control_ip"]+" ชื่อตู้ "+ dataRow["control_name"]+" ได้ ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ipFound = false; 
                    break;
                }
                else {
                    int count = 0;
                    int getCountIp = int.Parse(dataRow["relay_count"].ToString()) ;
                    bool currentStatus = false; 
                    foreach (bool statusCurrent in getStatus) {

                        if (count==0) {
                            currentOpenAll = statusCurrent;
                            currentStatus = statusCurrent;
                        }
                        if (currentStatus !=  statusCurrent) {
                            currentDiff = true; 
                            break;
                        }
                        
                        Debug.WriteLine(count + " :   ==========>    " + statusCurrent);
                        if (count+1 == getCountIp) {
                            break; 
                        }                       
                        count++;
                    }
                }
                if (currentDiff==true) {
                    break;
                }
                Debug.WriteLine(getStatus.Length); 
            }

            if (ipFound==false) {
                returnColor = Color.AliceBlue;
            }
            else if (currentDiff == true) {
                returnColor = Color.Navy; 
            }
            else if (currentOpenAll== true) {
                returnColor = Color.LimeGreen;
            }
            else if (currentOpenAll == false ) {
                returnColor = Color.OrangeRed ;
            }
            
            return returnColor; 
        }

        private void panelFloorUG_Paint(object sender, PaintEventArgs e) {
            int halfThickness = THICKNESS / 2;
            using (Pen p = new Pen(this.statusColorFloorUG, THICKNESS)) {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panelFloor2.ClientSize.Width - THICKNESS,
                                                          panelFloor2.ClientSize.Height - THICKNESS));
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {
            int halfThickness = THICKNESS / 2;            
            using (Pen p = new Pen(this.statusColorFloor2 , THICKNESS)) {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panelFloor2.ClientSize.Width - THICKNESS,
                                                          panelFloor2.ClientSize.Height - THICKNESS));
            }

            

        }

        private void panelFloor3_Paint(object sender, PaintEventArgs e) {
            int halfThickness = THICKNESS / 2;
            using (Pen p = new Pen(statusColorFloor3, THICKNESS)) {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panelFloor3.ClientSize.Width - THICKNESS,
                                                          panelFloor3.ClientSize.Height - THICKNESS));
            }
        }

        private void panelFloor4_Paint(object sender, PaintEventArgs e) {
            int halfThickness = THICKNESS / 2;
            using (Pen p = new Pen(statusColorFloor4, THICKNESS)) {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panelFloor4.ClientSize.Width - THICKNESS,
                                                          panelFloor4.ClientSize.Height - THICKNESS));
            }
        }

        private void panelFloor6_Paint(object sender, PaintEventArgs e) {
            int halfThickness = THICKNESS / 2;
            using (Pen p = new Pen(statusColorFloor6, THICKNESS)) {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panelFloor6.ClientSize.Width - THICKNESS,
                                                          panelFloor6.ClientSize.Height - THICKNESS));
            }
        }

        private void panelFloor7_Paint(object sender, PaintEventArgs e) {
            int halfThickness = THICKNESS / 2;
            using (Pen p = new Pen(statusColorFloor7, THICKNESS)) {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panelFloor6.ClientSize.Width - THICKNESS,
                                                          panelFloor6.ClientSize.Height - THICKNESS));
            }
        }

        private void panelFloor8_Paint(object sender, PaintEventArgs e) {
            int halfThickness = THICKNESS / 2;
            using (Pen p = new Pen(statusColorFloor8, THICKNESS)) {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panelFloor6.ClientSize.Width - THICKNESS,
                                                          panelFloor6.ClientSize.Height - THICKNESS));
            }
        }




        //##############################################################    HOVER/LEAVE EVENT.
        private void panelFloorUG_MouseHover(object sender, EventArgs e) {
            panelFloorUG.BackColor = mouseOverColor;
        }
        private void panelFloorUG_MouseLeave(object sender, EventArgs e) {
            panelFloorUG.BackColor = mouseLeaveColor;
        }
        private void panelFloor2_MouseHover(object sender, EventArgs e) {
            panelFloor2.BackColor = mouseOverColor;
        }
        private void panelFloor2_MouseLeave(object sender, EventArgs e) {
            panelFloor2.BackColor = mouseLeaveColor;
        }
        private void panelFloor3_MouseHover(object sender, EventArgs e) {
            panelFloor3.BackColor = mouseOverColor;
        }
        private void panelFloor3_MouseLeave(object sender, EventArgs e) {
            panelFloor3.BackColor = mouseLeaveColor;
        }
        private void panelFloor4_MouseHover(object sender, EventArgs e) {
            panelFloor4.BackColor = mouseOverColor;
        }
        private void panelFloor4_MouseLeave(object sender, EventArgs e) {
            panelFloor4.BackColor = mouseLeaveColor;
        }
        private void panelFloor6_MouseHover(object sender, EventArgs e) {
            panelFloor6.BackColor = mouseOverColor;
        }
        private void panelFloor6_MouseLeave(object sender, EventArgs e) {
            panelFloor6.BackColor = mouseLeaveColor;
        }

        private void panelFloor7_MouseHover(object sender, EventArgs e) {
            panelFloor7.BackColor = mouseOverColor; 
        }

        private void panelFloor7_MouseLeave(object sender, EventArgs e) {
            panelFloor7.BackColor = mouseLeaveColor;
        }
        private void panelFloor8_MouseHover(object sender, EventArgs e) {
            panelFloor8.BackColor = mouseOverColor; 
        }
        private void panelFloor8_MouseLeave(object sender, EventArgs e) {
            panelFloor8.BackColor = mouseLeaveColor;
        }

        //##############################################################    END HOVER/LEAVE EVENT.




        //##############################################################    CLICK EVENT.

        private void panelFloorUG_Click(object sender, EventArgs e) {
            openMainForm("0");
        }
        private void panelFloor2_Click(object sender, EventArgs e) {
            openMainForm("2"); 
        }
        private void panelFloor3_Click(object sender, EventArgs e) {
            openMainForm("3"); 
        }
        private void panelFloor4_Click(object sender, EventArgs e) {
            openMainForm("4"); 
        }
        private void panelFloor6_Click(object sender, EventArgs e) {
            openMainForm("6"); 
        }
        private void panelFloor7_Click(object sender, EventArgs e) {
            openMainForm("7");
        }
        private void panelFloor8_Click(object sender, EventArgs e) {
            openMainForm("8");
        }

        //##############################################################    END CLICK EVENT.


        private void openMainForm(string floorValue) {
            this.Hide();
            MainForm mainForm = new MainForm(floorValue);
            mainForm.ShowDialog();
        }

        private void BTN_GROUP_Click(object sender, EventArgs e) {
            this.Hide();
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog();
        }

        private void BuildingForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void BTN_SCHEDULE_Click(object sender, EventArgs e) {
            this.Hide();
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.ShowDialog();
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

        private void BTN_CONTROL_Click_1(object sender, EventArgs e) {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
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
