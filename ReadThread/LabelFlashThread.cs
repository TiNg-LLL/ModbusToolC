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
        private ThreadStart childref;
        private Thread childThread;

        public LabelFlashThread()
        {
            childref = new ThreadStart(RegisterReadThread);
            childThread = new Thread(childref);
            childThread.IsBackground = true;  //设置为后台线程
            childThread.Start();
        }
        //
        //寄存器Label刷新线程方法
        //
        public void RegisterReadThread()
        {
            while (true)
            {
                if (COMFunc.serialPort.IsOpen)
                {
                    for (int i = 0; i < RegisterCollection.registerAmount; i++)
                    {
                        //RegisterCollection.registerList[i].GetRegisterNowValue().Invoke(
                        //    new Action(() => { RegisterCollection.registerList[i].GetRegisterNowValue().Text = 
                        //        RegisterCollection.registerValueList[i]; }));

                        RegisterCollection.registerList[i].GetRegisterNowValue().Text =
                            RegisterCollection.registerValueList[i];
                    }
                    Thread.Sleep(20);
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
    }
}
