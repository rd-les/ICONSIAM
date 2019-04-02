using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace iconsiam {
    public partial class TestScheduleForm : Form {
        public TestScheduleForm() {
            InitializeComponent();
        }

        private void TestScheduleForm_Load(object sender, EventArgs e) {
            scheduleTimer();
        }

        public void AppendTextBox(string statusOn, string statusOff) {
            if (InvokeRequired) {
                this.Invoke(new Action<string, string>(AppendTextBox), new object[] { statusOn, statusOff });
                return;
            }
            TXT_STATUS.AppendText(statusOn);
            TXT_STATUS.AppendText(Environment.NewLine);
            TXT_STATUS.AppendText(statusOff);
            TXT_STATUS.AppendText(Environment.NewLine);
            TXT_STATUS.AppendText("===========================================");
            TXT_STATUS.AppendText(Environment.NewLine);
        }

        public void AppendTextBox2(string statusTxt) {
            if (InvokeRequired) {
                this.Invoke(new Action<string>(AppendTextBox2), new object[] { statusTxt});
                return;
            }
            TXT_TIME.AppendText(statusTxt);
            TXT_TIME.AppendText(Environment.NewLine);
            TXT_TIME.AppendText("===========================================");
            TXT_TIME.AppendText(Environment.NewLine); 


        }





        private void scheduleTimer() {

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(this.OnTimedEvent);
            aTimer.Interval = 1000*30;
            aTimer.Enabled = true;
            //Debug.WriteLine("Press \'q\' to quit the sample.");

        }
        private void OnTimedEvent(object source, ElapsedEventArgs e) {
            ClassDataBase classDataBase = new ClassDataBase();
            ClassModBus classModBus = new ClassModBus();


            string sql = "SELECT* FROM `schedule_group` WHERE usable = 1 ";
            DataTable dataTable = classDataBase.getDataTable(sql);
            foreach (DataRow dataRow in dataTable.Rows) {
                Debug.WriteLine("=================================>"+ dataRow["schedule_group_id"]);
                AppendTextBox2("=================================>" + dataRow["schedule_group_id"]); 

                DateTime mainTime = DateTime.Now;
                DateTime lastDate = DateTime.Parse(dataRow["current_date_onoff"].ToString());
                if (DateTime.Today != lastDate) {
                    classDataBase.updateCommand("UPDATE schedule_group SET current_date_onoff='" + mainTime.ToString("yyyy-MM-dd") + "' , current_status_on = 0 ,current_status_off = 0  WHERE schedule_group_id=" + dataRow["schedule_group_id"]);
                    Debug.WriteLine("-----------------------------------> UPDATE DATE TODAY.");
                    AppendTextBox2("=================================>  UPDATE DATE TODAY." );
                }

                DateTime scheduleTimeStart = Convert.ToDateTime(dataRow["time_start"].ToString());
                DateTime scheduleTimeStop = Convert.ToDateTime(dataRow["time_stop"].ToString());


                AppendTextBox("TIME START : "+dataRow["time_start"]+" : " + DateTime.Compare(mainTime, scheduleTimeStart) + " TODAY STATUS : " + Convert.ToBoolean(dataRow["current_status_on"].ToString())
                    , "TIME STOP : " + dataRow["time_stop"] + " " + DateTime.Compare(mainTime, scheduleTimeStop) + " TODAY STATUS : " + Convert.ToBoolean(dataRow["current_status_off"].ToString())
                ); 
                /*
                TXT_STATUS.AppendText("TIME START : " + DateTime.Compare(mainTime, scheduleTimeStart) + " TODAY STATUS : " + Convert.ToBoolean(dataRow["current_status_on"].ToString()));
                TXT_STATUS.AppendText(Environment.NewLine); 
                TXT_STATUS.AppendText("TIME STOP : " + DateTime.Compare(mainTime, scheduleTimeStop) + " TODAY STATUS : " + Convert.ToBoolean(dataRow["current_status_off"].ToString()));
                TXT_STATUS.AppendText(Environment.NewLine);
                */

                Debug.WriteLine("TIME START : " + DateTime.Compare(mainTime, scheduleTimeStart) +" TODAY STATUS : "+ Convert.ToBoolean(dataRow["current_status_on"].ToString()));
                Debug.WriteLine("TIME STOP : " + DateTime.Compare(mainTime, scheduleTimeStop) + " TODAY STATUS : " + Convert.ToBoolean(dataRow["current_status_off"].ToString()) );
                
                //############################################################### FOR ON STATUS.
                if (DateTime.Compare(mainTime, scheduleTimeStart) >= 0 && Convert.ToBoolean(dataRow["current_status_on"].ToString()) == false) {
                    classDataBase.updateCommand("UPDATE schedule_group SET current_status_on = 1 , datetime_status_on ='" + mainTime.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE schedule_group_id=" + dataRow["schedule_group_id"]);
                    Debug.WriteLine("----------> UPDATE CURRENT ON."); 
                    string sql_list = "SELECT * FROM grouping_list WHERE group_id = " + dataRow["group_id"] + " ORDER BY control_name ASC ,relay_id ASC , relay_position ASC ";
                    DataTable dataTableList = classDataBase.getDataTable(sql_list);
                    foreach (DataRow dataRowList in dataTableList.Rows) {
                        int positionRelay = ((int.Parse(dataRowList["relay_id"].ToString()) - 1) * 8) + int.Parse(dataRowList["relay_position"].ToString());
                        string getIp = classDataBase.selectOnceData("config_ip", "control_ip", " control_name='" + dataRowList["control_name"] + "'");

                        TXT_TIME.AppendText(getIp + " <=====> 1 <=====> " + positionRelay + " <=====> ON"); 
                        TXT_TIME.AppendText(Environment.NewLine);

                        Debug.WriteLine(getIp + " <=====> 1 <=====> " + positionRelay + " <=====> ON");
                        //classModBus.Write_Command(getIp, 1, positionRelay - 1, 1);
                    }


                    Debug.WriteLine("SCHEDULE ID " + dataRow["schedule_group_id"] + " ON");

                }
                //############################################################### FOR OFF STATUS.

                else if (DateTime.Compare(mainTime, scheduleTimeStop) >= 0 && Convert.ToBoolean(dataRow["current_status_off"].ToString()) == false) {
                    classDataBase.updateCommand("UPDATE schedule_group SET current_status_off = 1 , datetime_status_off ='" + mainTime.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE schedule_group_id=" + dataRow["schedule_group_id"]);
                    Debug.WriteLine("----------> UPDATE CURRENT OFF.");

                    string sql_list = "SELECT * FROM grouping_list WHERE group_id = " + dataRow["group_id"] + " ORDER BY control_name ASC ,relay_id ASC , relay_position ASC ";
                    DataTable dataTableList = classDataBase.getDataTable(sql_list);
                    foreach (DataRow dataRowList in dataTableList.Rows) {
                        int positionRelay = ((int.Parse(dataRowList["relay_id"].ToString()) - 1) * 8) + int.Parse(dataRowList["relay_position"].ToString());
                        string getIp = classDataBase.selectOnceData("config_ip", "control_ip", " control_name='" + dataRowList["control_name"] + "'");
                        Debug.WriteLine(getIp + " <=====> 1 <=====> " + positionRelay + " <=====> OFF");
                        //classModBus.Write_Command(getIp, 1, positionRelay - 1, 0);
                    }
                    //classModBus.Write_Command("192.168.1.105", 1, 2, 0);
                    Debug.WriteLine("SCHEDULE ID " + dataRow["schedule_group_id"] + " OFF");

                }
            }

            classDataBase.closeConnection();
            Debug.WriteLine("THIS TIME " + DateTime.Now);
        }
    }
}
