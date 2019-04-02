using ModbusTCP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconsiam {
    class ClassModBus {

        int Count64 = 0;
        static public Master MBmaster;
        static public Boolean[] Values_Return = new Boolean[64];
        static public Boolean[] Values_ReturnRealStatus = new Boolean[64];
        static public Boolean[] Values_ReturnRealTime = new Boolean[1];
        private int timeOutThread = 500;


        private bool FlagRead = true ;
        private bool FlagWrite = true;


        public void Write_Command(string IP, Int32 Modbus_Address, Int32 Address_Relay, int On_OffRelay) {

            byte[] buffer = new byte[20];

            if (PingHost(IP)) {
                if (FlagWrite == true) {
                    MBmaster = new Master(IP, 502, true);

                    MBmaster.OnResponseData += new Master.ResponseData(MBmaster_OnResponseData);
                    MBmaster.OnException += new Master.ExceptionData(MBmaster_OnException);
                    buffer[0] = (byte)(On_OffRelay);

                }
                FlagWrite = false;
                MBmaster.WriteSingleRegister((ushort)6, (byte)Modbus_Address, (ushort)(Address_Relay + 100), buffer);
                string nextLogCommandId = AppClass.saveDataLogCommand(IP, Address_Relay, On_OffRelay, 1); 
                Thread.Sleep(500);

                if (FlagWrite == false) {
                    //MessageBox.Show(" ตู้ IP : " + IP + " ไม่สามารถทำงานต่อได้ กรุณารอ 1 นาที แล้วกด ตกลง (OK)");
                    AppClass.updateDataLogCommand(nextLogCommandId);
                    AppClass.saveDataLogNotWriteCommand(IP, (int)(Address_Relay + 100), On_OffRelay); 
                    Thread.Sleep(30000);
                    MBmaster = new Master(IP, 502, true);

                    MBmaster.OnResponseData += new Master.ResponseData(MBmaster_OnResponseData);
                    MBmaster.OnException += new Master.ExceptionData(MBmaster_OnException);
                    buffer[0] = (byte)(On_OffRelay);

                    FlagWrite = false;
                    MBmaster.WriteSingleRegister((ushort)6, (byte)Modbus_Address, (ushort)(Address_Relay + 100), buffer);
                    Thread.Sleep(500);
                }
                if (FlagWrite == true) {
                    MBmaster.disconnect();
                    Thread.Sleep(200);
                }

            }
            
        }



        /*
        public void Write_Command(string IP, Int32 Modbus_Address, Int32 Address_Relay, int On_OffRelay) {
            //IP = "192.168.1" + IP;

            if (PingHost(IP)) {

                
                byte[] buffer = new byte[20];
                MBmaster = new Master(IP, 502, true);

                MBmaster.OnResponseData += new Master.ResponseData(MBmaster_OnResponseData);
                MBmaster.OnException += new Master.ExceptionData(MBmaster_OnException);
                buffer[0] = (byte)(On_OffRelay);

                MBmaster.WriteSingleRegister((ushort)6, (byte)Modbus_Address, (ushort)(Address_Relay + 100), buffer);
                Thread.Sleep(timeOutThread);
                MBmaster.disconnect();
                Thread.Sleep(200);
            }
            else {
                AppClass.saveDataLogDebug("Write_Command", "NOT FOUND IP : "+ IP);
            }
        }*/


        public bool[] Read_CommandRealTime(string IP, Int32 Modbus_Address , Int32 positionBoard ) {
            try {

                if (PingHost(IP)) {
                    MBmaster = new Master(IP, 502, true);

                    MBmaster.OnResponseData += new Master.ResponseData(MBmaster_OnResponseDataRealTime);
                    MBmaster.OnException += new Master.ExceptionData(MBmaster_OnException);

                    FlagRead = false;
                    MBmaster.ReadHoldingRegister((ushort)03, (byte)Modbus_Address, (ushort) (positionBoard+100), 1);
                    Thread.Sleep(300);
                    MBmaster.disconnect();
                    return (Values_ReturnRealTime);
                }

                else {
                    MBmaster.disconnect();
                    return new bool[1] { false };
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex);
                
                return new bool[1] { false };

            }
            
          

        }

        public bool[] Read_Command(string IP, Int32 Modbus_Address) {
            try {

                if (PingHost(IP)) {
                    MBmaster = new Master(IP, 502, true);

                    MBmaster.OnResponseData += new Master.ResponseData(MBmaster_OnResponseData);
                    MBmaster.OnException += new Master.ExceptionData(MBmaster_OnException);

                    FlagRead = false;
                    MBmaster.ReadHoldingRegister((ushort)03, (byte)Modbus_Address, 100, 64);
                    Thread.Sleep(500);
                }

                else {
                    return new bool[1] { false };
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex); 
                return new bool[1] { false };

            }

            if (FlagRead == true) {
                MBmaster.disconnect();
                return (Values_Return);
            }
            else {
                return new bool[2] { false, false };
            }

        }




        /*

        public bool[] Read_Command(string IP, Int32 Modbus_Address) {
            try {

                if (PingHost(IP)) {
                    MBmaster = new Master(IP, 502, true);
                   
                    MBmaster.OnResponseData += new Master.ResponseData(MBmaster_OnResponseData);
                    MBmaster.OnException += new Master.ExceptionData(MBmaster_OnException);

                    FlagRead = false; 
                    MBmaster.ReadHoldingRegister((ushort)03, (byte)Modbus_Address, 100, 64);
                    Thread.Sleep(timeOutThread);
                    MBmaster.disconnect();
                    /*
                    if (FlagRead==true) {
                        MBmaster.disconnect();
                        return (Values_Return);
                    }
                    else {
                        //return new bool[2] { false , false  };
                    }
                    
                    return (Values_Return);


                }
                else {
                    return new bool[1] { false };
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex);
                AppClass.saveDataLogDebug("Read_Command", ex.ToString() ); 
                return new bool[1] { false };
            }
           

        }
        */

        public bool[] Read_CommandRealStatus(string IP, Int32 Modbus_Address) {


            try {

                if (PingHost(IP)) {
                    MBmaster = new Master(IP, 502, true);
                    MBmaster.OnResponseData += new Master.ResponseData(MBmaster_OnResponseDataReadStatus);
                    MBmaster.OnException += new Master.ExceptionData(MBmaster_OnException);

                    // MBmaster.ReadHoldingRegister((ushort)03, (byte)Modbus_Address, 170, 64);
                    MBmaster.ReadHoldingRegister((ushort)03, (byte)Modbus_Address, 100, 64);
                    Thread.Sleep(timeOutThread);
                    MBmaster.disconnect();
                    return (Values_ReturnRealStatus);
                }
                else {
                    return new bool[1] { false };
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex);
                AppClass.saveDataLogDebug("Read_CommandRealStatus", ex.ToString());
                return new bool[1] { false };
            }


        }


        public void MBmaster_OnResponseDataRealTime(ushort ID, byte unit, byte function, byte[] values) {

            Values_ReturnRealTime[0] = false;
         
            switch (ID) {
                case 1:
                    break;
                case 2:
                    break;
                case 3:


                    if (values[1] == 1) {
                        Values_ReturnRealTime[0] = true;
                    }
                   
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    FlagWrite = true;
                    break;
                case 7:
                    break;
                case 8:
                    break;
            }
        }




        public void MBmaster_OnResponseDataReadStatus(ushort ID, byte unit, byte function, byte[] values) {
            switch (ID) {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    Count64 = 0;
                    for (int i = 0; i < 128; i++) {
                        if ((i % 2) == 1) {
                            if (values[i] == 1) {
                                Values_ReturnRealStatus[Count64] = true;
                            }
                            else {
                                Values_ReturnRealStatus[Count64] = false;
                            }
                            Count64++;
                        }
                    }
                    FlagRead = true; 
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6: FlagWrite = true;
                    break;
                case 7:
                    break;
                case 8:
                    break;
            }
        }






        public void MBmaster_OnResponseData(ushort ID, byte unit, byte function, byte[] values) {
            switch (ID) {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    Count64 = 0;
                    for (int i = 0; i <128; i++) {
                        if ((i % 2) == 1) {
                            if (values[i] == 1) {
                                Values_Return[Count64] = true;
                            }
                            else {
                                Values_Return[Count64] = false;
                            }
                            Count64++;
                        }
                    }
                    FlagRead = true;
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:FlagWrite = true;
                    break;
                case 7:
                    break;
                case 8:
                    break;
            }
        }
        public void MBmaster_OnException(ushort id, byte unit, byte function, byte exception) {
            string exc = "Modbus says error: ";
            switch (exception) {
                case Master.excIllegalFunction: exc += "Illegal function!"; break;
                case Master.excIllegalDataAdr: exc += "Illegal data adress!"; break;
                case Master.excIllegalDataVal: exc += "Illegal data value!"; break;
                case Master.excSlaveDeviceFailure: exc += "Slave device failure!"; break;
                case Master.excAck: exc += "Acknoledge!"; break;
                case Master.excGatePathUnavailable: exc += "Gateway path unavailbale!"; break;
                case Master.excExceptionTimeout: exc += "Slave timed out!"; break;
                case Master.excExceptionConnectionLost: exc += "Connection is lost!"; break;
                case Master.excExceptionNotConnected: exc += "Not connected!"; break;
            }


        }

        public bool PingHost(string nameOrAddress) {
            bool pingable = false;
            Ping pinger = null;
            var timeout = TimeSpan.FromMilliseconds(500);


            try {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress, (int)timeout.TotalMilliseconds);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException) {
                // Discard PingExceptions and return false;
            }
            finally {
                if (pinger != null) {
                    pinger.Dispose();
                }
            }

            return pingable;
        }




    }
}
