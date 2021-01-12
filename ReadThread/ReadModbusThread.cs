using Func;
using PanelCollection;
using PanelUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadThreadSpace
{
    public class ReadModbusThread
    {
        private ThreadStart childref;
        private Thread childThread;
        //private ModbusFunc modbusFunc = RegisterCommonPanel.modbusFunc;

        public ReadModbusThread()
        {
            childref = new ThreadStart(RegisterReadThread);
            childThread = new Thread(childref);
            childThread.IsBackground = true;  //设置为后台线程
            childThread.Name = "modbus读取线程";
            childThread.Start();
        }
        //
        //寄存器modbus读取线程方法
        //
        public void RegisterReadThread()
        {
            while (true)
            {
                ThreadFather.met.WaitOne();
                if (COMFunc.serialPort.IsOpen)
                {
                    //寄存器读取循环
                    for (int i = 0; i < RegisterCollection.registerAmount; i++)
                    {
                        try
                        {
                            RegisterCollection.registerValueList[i] = ModbusFunc.MyReadHoldingRegisters(RegisterCollection.registerList[i].GetRegisterReadAddress());
                            Thread.Sleep(5);
                        }
                        catch (Exception)
                        {
                            RegisterCollection.registerValueList[i] = "";
                            Thread.Sleep(50);
                        }
                    }
                    //线圈读取循环
                    for (int i = 0; i < CoilJustReadCollection.coilJustReadAmount; i++)
                    {
                        try
                        {
                            CoilJustReadCollection.coilJustReadValueList[i] = ModbusFunc.MyReadCoils(CoilJustReadCollection.coilJustReadList[i].coilJustReadAddress);
                            //Console.WriteLine(CoilJustReadCollection.coilJustReadValueList[i]);
                            Thread.Sleep(5);
                        }
                        catch (Exception)
                        {
                            RegisterCollection.registerValueList[i] = "";
                            Thread.Sleep(50);
                        }
                    }
                    //Console.WriteLine("----------------------------------------------------一次循环结果----------------------------------------------------");
                }
                else
                {
                    Thread.Sleep(500);
                }
            }
        }

        public Thread getThread()
        {
            return childThread;
        }
    }
}
