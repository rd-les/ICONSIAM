using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace iconsiam {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main() {
            Program.scheduleTimer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new MainForm());
            Application.Run(new LoginForm());
            //Application.Run(new BuildingForm()); 
            //Application.Run(new GroupForm() );
            // Application.Run(new ScheduleForm());
            //Application.Run(new TestScheduleForm() ); 


            //Application.Run(new TestImageDragDrop());
            //Application.Run(new LayoutForm());

        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 3;


        static System.Threading.Timer TTimer = null;

        static void TickTimer(object state) {
            Console.Write("Tick! ");
            Console.WriteLine(
                Thread.CurrentThread.
                ManagedThreadId.ToString());
            Thread.Sleep(4000);
        }

        static void scheduleTimer() {
            TTimer = new System.Threading.Timer(new TimerCallback(OnTimedEvent), null, 1000, Timeout.Infinite);
            ShowWindow(GetConsoleWindow(), SW_HIDE);

            /*
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(Program.OnTimedEvent);
            aTimer.Interval = 1000*60;
            aTimer.Enabled = true;
           

            
            Program.OnTimedEvent();
            Application.DoEvents();
            scheduleTimer();
            Thread.Sleep(100);
            */
            //Debug.WriteLine("Press \'q\' to quit the sample.");
        }


        static private bool flagNormal { get; set; }

        static void OnTimedEvent(object source) {
            //static void OnTimedEvent() {
            var handle = GetConsoleWindow();
            ClassDataBase classDataBase = new ClassDataBase();
            ClassModBus classModBus = new ClassModBus();

            string sql = @" SELECT * 
                            FROM `schedule_group` 
                            INNER JOIN grouping ON(schedule_group.group_id = grouping.group_id)
                            WHERE schedule_group.usable = 1";
            DataTable dataTable = classDataBase.getDataTable(sql);

            flagNormal = true;

            foreach (DataRow dataRow in dataTable.Rows) {
                Console.WriteLine("=================================>" + dataRow["schedule_group_id"]);

                DateTime mainTime = DateTime.Now;
                DateTime lastDate = DateTime.Parse(dataRow["current_date_onoff"].ToString());
                if (DateTime.Today != lastDate) {
                    classDataBase.updateCommand("UPDATE schedule_group SET current_date_onoff='" + mainTime.ToString("yyyy-MM-dd") + "' , current_status_on = 0 ,current_status_off = 0  WHERE schedule_group_id=" + dataRow["schedule_group_id"]);
                    Debug.WriteLine("-----------------------------------> UPDATE DATE TODAY.");
                    //AppClass.saveDataLogDebug("OnTimedEvent : BTN_SendPackage_Click ", "UPDATE schedule_group SET current_date_onoff=" + mainTime.ToString("yyyy-MM-dd") + " , current_status_on = 0 ,current_status_off = 0  WHERE schedule_group_id=" + dataRow["schedule_group_id"]);
                    //AppClass.saveDataLogSchedule("UPDATE schedule_group SET current_date_onoff=" + mainTime.ToString("yyyy-MM-dd") + " , current_status_on = 0 ,current_status_off = 0  WHERE schedule_group_id=" + dataRow["schedule_group_id"]); 

                }

                DateTime scheduleTimeStart = Convert.ToDateTime(dataRow["time_start"].ToString());
                DateTime scheduleTimeStop = Convert.ToDateTime(dataRow["time_stop"].ToString());
                Console.WriteLine("TIME START : " + scheduleTimeStart + " : " + DateTime.Compare(mainTime, scheduleTimeStart) + " TODAY STATUS : " + Convert.ToBoolean(dataRow["current_status_on"].ToString()));
                Console.WriteLine("TIME STOP : " + scheduleTimeStop + " : " + DateTime.Compare(mainTime, scheduleTimeStop) + " TODAY STATUS : " + Convert.ToBoolean(dataRow["current_status_off"].ToString()));

                //############################################################### FOR ON STATUS.
                //AppClass.saveDataLogSchedule(DateTime.Today + " - " + lastDate + "mainTime: " + mainTime + " scheduleTimeStart :  " + scheduleTimeStart + " =====>" + DateTime.Compare(mainTime, scheduleTimeStart) + " ----- " + Convert.ToBoolean(dataRow["current_status_on"].ToString()));

                try {

                    Application.DoEvents();
                    if (DateTime.Compare(mainTime, scheduleTimeStart) >= 0 && Convert.ToBoolean(dataRow["current_status_on"].ToString()) == false) {
                        // Console.Clear();
                        ShowWindow(handle, SW_SHOW);
                        classDataBase.updateCommand("UPDATE schedule_group SET current_status_on = 1 , datetime_status_on ='" + mainTime.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE schedule_group_id=" + dataRow["schedule_group_id"]);
                        Console.WriteLine("----------> UPDATE CURRENT ON.");
                        string sql_list = "SELECT * FROM grouping_list WHERE group_id = " + dataRow["group_id"] + " ORDER BY control_name ASC ,relay_id ASC , relay_position ASC ";
                        DataTable dataTableList = classDataBase.getDataTable(sql_list);
                        foreach (DataRow dataRowList in dataTableList.Rows) {
                            int positionRelay = ((int.Parse(dataRowList["relay_id"].ToString()) - 1) * 8) + int.Parse(dataRowList["relay_position"].ToString());
                            string getIp = classDataBase.selectOnceData("config_ip", "control_ip", " control_name='" + dataRowList["control_name"] + "'");
                            Console.WriteLine(dataRow["schedule_group_id"] + " (" + dataRow["schedule_group_name"] + ") : " + getIp + " [ " + dataRowList["control_name"].ToString().ToUpper() + " ] <=====> Relay :  <=====> " + positionRelay + " <=====> ON");
                            AppClass.saveDataLogSchedule(dataRow["schedule_group_id"] + " (" + dataRow["schedule_group_name"] + ") : " + getIp + " [ " + dataRowList["control_name"].ToString().ToUpper() + " ] <=====> Relay :  <=====> " + positionRelay + " <=====> ON");
                            Application.DoEvents();
                            classModBus.Write_Command(getIp, 1, positionRelay - 1, 1);
                            Thread.Sleep(200);
                        }
                        Console.WriteLine("SCHEDULE ID " + dataRow["schedule_group_id"] + " ON");
                        AppClass.saveDataLogSchedule("SCHEDULE ID " + dataRow["schedule_group_id"] + " ON");
                        Program.flagNormal = false;
                    }
                    //############################################################### FOR OFF STATUS.

                    else if (DateTime.Compare(mainTime, scheduleTimeStop) >= 0 && Convert.ToBoolean(dataRow["current_status_off"].ToString()) == false) {
                        //Console.Clear();
                        ShowWindow(handle, SW_SHOW);
                        classDataBase.updateCommand("UPDATE schedule_group SET current_status_off = 1 , datetime_status_off ='" + mainTime.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE schedule_group_id=" + dataRow["schedule_group_id"]);
                        Console.WriteLine("----------> UPDATE CURRENT OFF.");
                        string sql_list = "SELECT * FROM grouping_list WHERE group_id = " + dataRow["group_id"] + " ORDER BY control_name ASC ,relay_id ASC , relay_position ASC ";
                        DataTable dataTableList = classDataBase.getDataTable(sql_list);
                        foreach (DataRow dataRowList in dataTableList.Rows) {
                            int positionRelay = ((int.Parse(dataRowList["relay_id"].ToString()) - 1) * 8) + int.Parse(dataRowList["relay_position"].ToString());
                            string getIp = classDataBase.selectOnceData("config_ip", "control_ip", " control_name='" + dataRowList["control_name"] + "'");
                            Console.WriteLine(dataRow["schedule_group_id"] + " (" + dataRow["schedule_group_name"] + ") : " + getIp + " [ " + dataRowList["control_name"].ToString().ToUpper() + " ]  <=====> Relay : <=====> " + positionRelay + " <=====> OFF");
                            AppClass.saveDataLogSchedule(dataRow["schedule_group_id"] + " (" + dataRow["schedule_group_name"] + ") : " + getIp + " [ " + dataRowList["control_name"].ToString().ToUpper() + " ]  <=====> Relay : <=====> " + positionRelay + " <=====> OFF");

                            Application.DoEvents();
                            classModBus.Write_Command(getIp, 1, positionRelay - 1, 0);
                            Thread.Sleep(200);
                        }
                        //classModBus.Write_Command("192.168.1.105", 1, 2, 0);
                        Console.WriteLine("SCHEDULE ID " + dataRow["schedule_group_id"] + " OFF");
                        AppClass.saveDataLogSchedule("SCHEDULE ID " + dataRow["schedule_group_id"] + " OFF");
                        Program.flagNormal = false;
                    }
                }
                catch (Exception ex) {
                    Debug.WriteLine(ex);
                }
                finally {
                    Program.flagNormal = true;
                    ShowWindow(handle, SW_HIDE);
                    //TTimer.Change(1000, Timeout.Infinite);
                }

            }
            if (Program.flagNormal == true) {
                Console.WriteLine("====================================================================================> THIS TIME " + DateTime.Now);
                Thread.Sleep(60000);
                TTimer.Change(1000, Timeout.Infinite);
                Console.Clear();
                ShowWindow(handle, SW_HIDE);
            }

            classDataBase.closeConnection();
            //Console.WriteLine("====================================================================================> THIS TIME " + DateTime.Now);
        }

    }
}
