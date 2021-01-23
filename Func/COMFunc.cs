using System;
using System.IO;
using System.IO.Ports;

namespace Func
{
    public class COMFunc
    {
        private String COM;
        private int Baudrate;
        private String Parity;
        private int StartDate;
        private String StopDate;
        public static byte SlaveID;

        public static SerialPort serialPort = new SerialPort();

        private static string filenameSystemDate = Directory.GetCurrentDirectory() + @"\SystemDate.ini";

        public void COMConnect()
        {
            try
            {
                if (!(serialPort.IsOpen))
                {
                    //读取连接参数值
                    //COM = IniFunc.getString("COMDate", "COM", "", filenameSystemDate);
                    //Baudrate = int.Parse(IniFunc.getString("COMDate", "Baudrate", "", filenameSystemDate));
                    //Parity = IniFunc.getString("COMDate", "Parity", "", filenameSystemDate);
                    //StartDate = int.Parse(IniFunc.getString("COMDate", "StartDate", "", filenameSystemDate));
                    //StopDate = IniFunc.getString("COMDate", "StopDate", "", filenameSystemDate);
                    //SlaveID = byte.Parse(IniFunc.getString("COMDate", "SlaveID", "", filenameSystemDate));

                    COM = Properties.Settings.Default.COM;
                    Baudrate = int.Parse(Properties.Settings.Default.Baudrate);
                    Parity = Properties.Settings.Default.Parity;
                    StartDate = int.Parse(Properties.Settings.Default.StartDate);
                    StopDate = Properties.Settings.Default.StopDate;
                    SlaveID = byte.Parse(Properties.Settings.Default.SlaveID);

                    serialPort.PortName = COM;
                    serialPort.BaudRate = Baudrate;
                    switch (Parity)
                    {
                        case "偶":
                            serialPort.Parity = System.IO.Ports.Parity.Even;
                            break;
                        case "奇":
                            serialPort.Parity = System.IO.Ports.Parity.Odd;
                            break;
                        case "无":
                            serialPort.Parity = System.IO.Ports.Parity.None;
                            break;
                    }
                    serialPort.DataBits = StartDate;
                    switch (StopDate)
                    {
                        case "1":
                            serialPort.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            serialPort.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            serialPort.StopBits = StopBits.Two;
                            break;
                    }
                    serialPort.ReadTimeout = int.Parse(IniFunc.getString("COMDate", "ReadTimeout", "", filenameSystemDate));
                    serialPort.WriteTimeout = serialPort.ReadTimeout;
                    serialPort.Open();
                    Console.WriteLine("端口已连接");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void COMClose()
        {
            try
            {
                serialPort.Close();
                Console.WriteLine("端口已断开");
            }
            catch (Exception)
            {
                throw;
            }
        }
        //***Set***
        public static void SetCOM(string s)
        {
            Properties.Settings.Default.COM = s;
            Properties.Settings.Default.Save();
        }

        public static void SetBaudrate(string s)
        {
            Properties.Settings.Default.Baudrate = s;
            Properties.Settings.Default.Save();
        }

        public static void SetStartDate(string s)
        {
            Properties.Settings.Default.StartDate = s;
            Properties.Settings.Default.Save();
        }

        public static void SetStopDate(string s)
        {
            Properties.Settings.Default.StopDate = s;
            Properties.Settings.Default.Save();
        }

        public static void SetParity(string s)
        {
            Properties.Settings.Default.Parity = s;
            Properties.Settings.Default.Save();
        }

        public static void SetSlaveID(string s)
        {
            Properties.Settings.Default.SlaveID = s;
            Properties.Settings.Default.Save();
        }

        public static void SetReadTimeout(string s)
        {
            Properties.Settings.Default.ReadTimeout = s;
            Properties.Settings.Default.Save();
        }

        //***Get***
        public static string GetCOM()
        {
            return Properties.Settings.Default.COM;
        }

        public static string GetBaudrate()
        {
            return Properties.Settings.Default.Baudrate;
        }

        public static string GetStartDate()
        {
            return Properties.Settings.Default.StartDate;
        }

        public static string GetStopDate()
        {
            return Properties.Settings.Default.StopDate;
        }

        public static string GetParity()
        {
            return Properties.Settings.Default.Parity;
        }

        public static string GetSlaveID()
        {
            return Properties.Settings.Default.SlaveID;
        }

        public static string GetReadTimeout()
        {
            return Properties.Settings.Default.ReadTimeout;
        }
    }
}
