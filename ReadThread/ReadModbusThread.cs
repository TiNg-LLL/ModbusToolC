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
        private ModbusFunc modbusFunc = RegisterCommonPanel.modbusFunc;


        public ReadModbusThread()
        {
            childref = new ThreadStart(RegisterReadThread);
            childThread = new Thread(childref);
            childThread.IsBackground = true;  //设置为后台线程
            childThread.Start();
        }
        //
        //寄存器modbus读取线程方法
        //
        public void RegisterReadThread()
        {
            while (true)
            {
                if (COMFunc.serialPort.IsOpen)
                {
                    for (int i = 0; i < RegisterCollection.registerAmount; i++)
                    {
                        RegisterCollection.registerValueList[i] = modbusFunc.MyReadHoldingRegisters(RegisterCollection.registerList[i].GetRegisterReadAddress());
                        //Thread.Sleep(10);
                    }
                    Console.WriteLine("----------------------------------------------------一次循环结果----------------------------------------------------");
                }
                else
                {
                Thread.Sleep(10);
                }
            }
        }
    }
}
