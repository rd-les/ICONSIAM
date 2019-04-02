using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iconsiam {
    static class AppClass {


        public static void saveDataLogDebug( string pageName , string details) {
            ClassDataBase classDataBase = new ClassDataBase();
            DateTime mainTime = DateTime.Now;
            string sql = @" INSERT log_debug SET log_debug_method = '"+ pageName + "' , log_debug_detail = '"+ details + "' , log_debug_datetime='" + mainTime.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
            classDataBase.insertCommand(sql);
            classDataBase.closeConnection();
        }

        public static void saveDataLogSchedule(string str) {

            ClassDataBase classDataBase = new ClassDataBase();
            DateTime mainTime = DateTime.Now;
            string sql = " INSERT schedule_log SET schedule_str = '" + str + "' , schedule_log_datetime='" + mainTime.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
            classDataBase.insertCommand(sql);
            classDataBase.closeConnection();
        }


        public static void saveDataLogNotWriteCommand(string ip , int relay_address , int onOffStatus ) {
            ClassDataBase classDataBase = new ClassDataBase();
            DateTime mainTime = DateTime.Now;
            string sql = " INSERT log_write_command SET ip = '" + ip + "', relay_address="+ relay_address + " , on_off_status='"+ onOffStatus + "', date_time  ='" + mainTime.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
            classDataBase.insertCommand(sql);
            classDataBase.closeConnection();
            //log_write_command
        }


        private static string getPositionRelay(int relay_address) {

            return ""; 
        }


        public static string saveDataLogCommand(string ip, int relay_address , int onOffCommand, int onOffStatus) {
            ClassDataBase classDataBase = new ClassDataBase();
            DateTime mainTime = DateTime.Now;
            string logCommandId = classDataBase.nextId("log_command" , "log_command_id"); 
            string sql = @" INSERT log_command SET 
                            log_command_id = "+ logCommandId + " " +
                            ", ip = '" + ip + "'" +                      
                            ", relay_address=" + relay_address + " " +
                            ", on_off_command='" + onOffStatus + "'" +
                            ", on_off_status='" + onOffStatus + "'" +
                            ", date_time  ='" + mainTime.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
            classDataBase.insertCommand(sql);
            classDataBase.closeConnection();
            return logCommandId;
        }
        public static void updateDataLogCommand(string logCommandid) {
            ClassDataBase classDataBase = new ClassDataBase();
            DateTime mainTime = DateTime.Now;
            string sql = "UPDATE log_command SET on_off_status='0' ,  date_time_false='" + mainTime.ToString("yyyy-MM-dd HH:mm:ss") + "'   WHERE log_command_id= " + logCommandid ;            
            classDataBase.updateCommand(sql);
            classDataBase.closeConnection(); 

        }




    }
}
