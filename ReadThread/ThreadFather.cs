using PanelCollection;
using PanelCollection.CoilButton;
using ReadThreadSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadThreadSpace
{
    public class ThreadFather
    {
        //new一个管理线程
        private Thread childThread;
        //modbua与label刷新线程对象
        ReadModbusThread readModbusThread;
        List<RegisterLabelFlashThread> registerLabelFlashThreadList;
        List<CoilJustReadLabelFlashThread> coilJustReadLabelFlashThreadList;
        List<CoilButtonLabelFlashThread> coilButtonLabelFlashThreadList;
        //线程挂起启动标记 true为挂起
        Boolean b = true;
        Boolean c = false;   //辅助标记

        public static ManualResetEvent met = new ManualResetEvent(false);

        public ThreadFather()
        {
            //
            //new出modbua与label刷新线程
            //
            readModbusThread = new ReadModbusThread();
            registerLabelFlashThreadList = new List<RegisterLabelFlashThread>();
            coilJustReadLabelFlashThreadList = new List<CoilJustReadLabelFlashThread>();
            coilButtonLabelFlashThreadList = new List<CoilButtonLabelFlashThread>();
            for (int i = 0; i < RegisterCollection.registerAmount; i++)
            {
                registerLabelFlashThreadList.Add(new RegisterLabelFlashThread(i));
            }
            for (int i = 0; i < CoilJustReadCollection.coilJustReadAmount; i++)
            {
                coilJustReadLabelFlashThreadList.Add(new CoilJustReadLabelFlashThread(i));
            }
            for (int i = 0; i < CoilButtonCollection.coilButtonAmount; i++)
            {
                coilButtonLabelFlashThreadList.Add(new CoilButtonLabelFlashThread(i));
            }
            //管理线程
            childThread = new Thread(new ParameterizedThreadStart(RegisterReadThread));
            childThread.IsBackground = true;  //设置为后台线程
            childThread.Name = "管理线程";
            childThread.Start();
        }


        public void RegisterReadThread(object obj)
        {
            while (true)
            {
                Thread.Sleep(100);
                if (b)
                {
                    if (c)
                    {
                        Thread.Sleep(1000);
                        met.Reset();
                        c = false;
                        Console.WriteLine("线程已暂停");
                    }
                }
                else
                {
                    if (c)
                    {
                        met.Set();
                        c = false;
                        Console.WriteLine("线程已继续");
                    }
                }
            }
        }

        public void ThreadStop()
        {
            b = true;
            c = true;
        }

        public void ThreadStart()
        {
            b = false;
            c = true;
        }
    }
}





