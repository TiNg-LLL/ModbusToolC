using Func;
using PanelCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadThreadSpace
{
    public class LabelFlashThread
    {
        //new一个线程
        private Thread childThread;

        public LabelFlashThread(int i)
        {
            // childref = new ThreadStart(RegisterReadThread);
            childThread = new Thread(new ParameterizedThreadStart(RegisterReadThread));
            childThread.IsBackground = true;  //设置为后台线程
            childThread.Name = "Label刷新线程";
            childThread.Start(i);
        }
        //
        //寄存器Label刷新线程方法
        //
        public void RegisterReadThread(object obj)
        {
            while (true)
            {
                ThreadFather.met.WaitOne();
                if (COMFunc.serialPort.IsOpen)
                {
                    try
                    {
                        RegisterCollection.registerList[(int)obj].GetRegisterNowValue().Text =
    RegisterCollection.registerValueList[(int)obj];
                    }
                    catch (Exception)
                    {
                    }
                    Thread.Sleep(20);
                }
                else
                {
                    for (int i = 0; i < RegisterCollection.registerAmount; i++)
                    {
                        try
                        {
                            RegisterCollection.registerList[i].GetRegisterNowValue().Text = "000";
                        }
                        catch (Exception)
                        {
                        }
                        Thread.Sleep(20);
                    }
                }
            }
        }

        public Thread getThread()
        {
            return childThread;
        }
    }
}
