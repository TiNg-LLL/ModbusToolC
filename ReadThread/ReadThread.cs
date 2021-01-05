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
    public class ReadThread
    {
        private ThreadStart childref;
        private Thread childThread;
        private ModbusFunc modbusFunc = new ModbusFunc();

        public ReadThread()
        {
            childref = new ThreadStart(RegisterReadThread);
            childThread = new Thread(childref);
            childThread.IsBackground = true;  //设置为后台程序
            childThread.Start();
        }
        //
        //寄存器读取线程方法
        //
        public void RegisterReadThread()
        {
            while (true)
            {
                if (COMFunc.serialPort.IsOpen)
                {
                    for (int i = 0; i < RegisterCollection.registerAmount; i++)
                    {
                        RegisterCollection.registerList[i].GetRegisterNowValue().Text = modbusFunc.MyReadHoldingRegisters(RegisterCollection.registerList[i].GetRegisterReadAddress());
                    }
                }
                else
                {
                    for (int i = 0; i < RegisterCollection.registerAmount; i++)
                    {
                        RegisterCollection.registerList[i].GetRegisterNowValue().Text = "未连接";
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
