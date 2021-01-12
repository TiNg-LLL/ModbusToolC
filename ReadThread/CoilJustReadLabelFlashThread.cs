using Func;
using PanelCollection;
using ReadThreadSpace;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadThreadSpace
{
    public class CoilJustReadLabelFlashThread
    {
        //new一个线程
        private Thread childThread;


        public CoilJustReadLabelFlashThread(int i)
        {
            childThread = new Thread(new ParameterizedThreadStart(CoilReadThread));
            childThread.IsBackground = true;  //设置为后台线程
            childThread.Name = "线圈只读Label刷新线程";
            childThread.Start(i);
        }
        //
        //线圈只读Label刷新线程方法
        //
        public void CoilReadThread(object obj)
        {
            while (true)
            {
                ThreadFather.met.WaitOne();
                //判断COM端口是否已连接
                if (COMFunc.serialPort.IsOpen)
                {
                    try
                    {
                        if (CoilJustReadCollection.coilJustReadValueList[(int)obj])
                        {
                            CoilJustReadCollection.coilJustReadList[(int)obj].GetUCSignalLamp().LampColor = CoilJustReadCollection.coilJustReadList[(int)obj].c;
                        }
                        else
                        {
                            CoilJustReadCollection.coilJustReadList[(int)obj].GetUCSignalLamp().LampColor = new Color[] { Color.FromArgb(165, 165, 165) };
                        }
                    }
                    catch (Exception)
                    {
                        CoilJustReadCollection.coilJustReadList[(int)obj].GetUCSignalLamp().LampColor = new Color[] { Color.FromArgb(211, 211, 211) };
                        Thread.Sleep(200);
                    }
                    Thread.Sleep(20);
                }
                else
                {
                    try
                    {
                        CoilJustReadCollection.coilJustReadList[(int)obj].GetUCSignalLamp().LampColor = new Color[] { Color.FromArgb(211, 211, 211) };
                    }
                    catch (Exception)
                    {
                        Thread.Sleep(200);
                    }
                    Thread.Sleep(20);
                }
            }
        }
    }
}
