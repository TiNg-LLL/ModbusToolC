using PanelCollection;
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
        List<LabelFlashThread> labelFlashThreadList;
        //线程挂起启动标记 true为挂起
        Boolean b = true;
        Boolean c = true;   //辅助标记

        public ThreadFather()
        {
            // childref = new ThreadStart(RegisterReadThread);
            childThread = new Thread(new ParameterizedThreadStart(RegisterReadThread));
            childThread.IsBackground = true;  //设置为后台线程
            childThread.Name = "管理线程";
            childThread.Start();
            //
            //new出modbua与label刷新线程
            //
            readModbusThread = new ReadModbusThread();
            labelFlashThreadList = new List<LabelFlashThread>();
            for (int i = 0; i < RegisterCollection.registerAmount; i++)
            {
                labelFlashThreadList.Add(new LabelFlashThread(i));
            }
        }


        public void RegisterReadThread(object obj)
        {
            while (true)
            {
                Thread.Sleep(200);
                if (b)
                {
                    if (c)
                    {
                        //管理线程挂起
                        Thread.Sleep(200);
                        readModbusThread.getThread().Suspend();
                        for (int i = 0; i < RegisterCollection.registerAmount; i++)
                        {
                            labelFlashThreadList[i].getThread().Suspend();
                        }
                        c = false;
                        Console.WriteLine("线程已挂起");
                    }
                }
                else
                {
                    if (c)
                    {
                        //管理线程恢复
                        Thread.Sleep(200);
                        readModbusThread.getThread().Resume();
                        for (int i = 0; i < RegisterCollection.registerAmount; i++)
                        {
                            labelFlashThreadList[i].getThread().Resume();
                        }
                        c = false;
                        Console.WriteLine("线程已恢复");
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
