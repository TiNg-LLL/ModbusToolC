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
                    COM = IniFunc.getString("COMDate", "COM", "", filenameSystemDate);
                    Baudrate = int.Parse(IniFunc.getString("COMDate", "Baudrate", "", filenameSystemDate));
                    Parity = IniFunc.getString("COMDate", "Parity", "", filenameSystemDate);
                    StartDate = int.Parse(IniFunc.getString("COMDate", "StartDate", "", filenameSystemDate));
                    StopDate = IniFunc.getString("COMDate", "StopDate", "", filenameSystemDate);
                    SlaveID = byte.Parse(IniFunc.getString("COMDate", "SlaveID", "", filenameSystemDate));

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
                    serialPort.Open();
                    Console.WriteLine("端口已连接");
                }
            }
            catch (Exception)
            {
                throw;
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
    }
}
