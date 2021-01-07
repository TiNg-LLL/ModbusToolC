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
                if (COMFunc.serialPort.IsOpen)
                {
                    //RegisterCollection.registerList[i].GetRegisterNowValue().Invoke(
                    //    new Action(() => { RegisterCollection.registerList[i].GetRegisterNowValue().Text = 
                    //        RegisterCollection.registerValueList[i]; }));

                    RegisterCollection.registerList[(int)obj].GetRegisterNowValue().Text =
                        RegisterCollection.registerValueList[(int)obj];

                    Thread.Sleep(50);
                }
                else
                {
                    for (int i = 0; i < RegisterCollection.registerAmount; i++)
                    {
                        RegisterCollection.registerList[i].GetRegisterNowValue().Text = "未连接";
                    }
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
