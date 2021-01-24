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

        //辅助变量
        int i;
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
                    if (CoilJustReadCollection.coilJustReadValueList[(int)obj].Equals(null))
                    {
                        if (!(i == 2))
                        {
                            CoilJustReadCollection.coilJustReadList[(int)obj].ucSignalLamp1.LampColor = new Color[] { Color.FromArgb(220, 220, 220), Color.Transparent };
                            CoilJustReadCollection.coilJustReadList[(int)obj].label1.ForeColor = Color.Red;
                            CoilJustReadCollection.coilJustReadList[(int)obj].ucSignalLamp1.TwinkleSpeed = 0;
                            i = 2;
                        }
                        Thread.Sleep(500);
                    }
                    else
                    {
                        try
                        {
                            if ((bool)CoilJustReadCollection.coilJustReadValueList[(int)obj])
                            {
                                if (!(i == 0))
                                {

                                    CoilJustReadCollection.coilJustReadList[(int)obj].ucSignalLamp1.LampColor = CoilJustReadCollection.coilJustReadList[(int)obj].c;
                                    CoilJustReadCollection.coilJustReadList[(int)obj].label1.ForeColor = Color.Black;
                                    if (CoilJustReadCollection.coilJustReadList[(int)obj].flashbool)
                                    {
                                        CoilJustReadCollection.coilJustReadList[(int)obj].ucSignalLamp1.TwinkleSpeed = 500;
                                    }
                                    i = 0;
                                }
                            }
                            else if (!(bool)CoilJustReadCollection.coilJustReadValueList[(int)obj])
                            {
                                if (!(i == 1))
                                {
                                    CoilJustReadCollection.coilJustReadList[(int)obj].ucSignalLamp1.LampColor = new Color[] { Color.FromArgb(165, 165, 165), Color.Transparent };
                                    CoilJustReadCollection.coilJustReadList[(int)obj].label1.ForeColor = Color.Black;
                                    CoilJustReadCollection.coilJustReadList[(int)obj].ucSignalLamp1.TwinkleSpeed = 0;
                                    i = 1;
                                }
                            }
                            else
                            {
                                //if (CoilJustReadCollection.coilJustReadList[(int)obj].ucSignalLamp1.TwinkleSpeed == 0)
                                //{
                                //    CoilJustReadCollection.coilJustReadList[(int)obj].ucSignalLamp1.LampColor = new Color[] { Color.FromArgb(220, 220, 220), Color.FromArgb(50, 50, 50) };
                                //    CoilJustReadCollection.coilJustReadList[(int)obj].ucSignalLamp1.TwinkleSpeed = 1000;
                                //}
                            }
                        }
                        catch (Exception)
                        {
                            //if (!(i == 2))
                            //{
                            //    CoilJustReadCollection.coilJustReadList[(int)obj].ucSignalLamp1.LampColor = new Color[] { Color.FromArgb(220, 220, 220), Color.Transparent };
                            //    CoilJustReadCollection.coilJustReadList[(int)obj].label1.ForeColor = Color.Red;
                            //    i = 2;
                            //}
                        }
                    }
                    Thread.Sleep(5);
                }
                else
                {
                    try
                    {
                        if (!(i == 3))
                        {
                            CoilJustReadCollection.coilJustReadList[(int)obj].GetUCSignalLamp().LampColor = new Color[] { Color.FromArgb(220, 220, 220), Color.Transparent };
                            CoilJustReadCollection.coilJustReadList[(int)obj].label1.ForeColor = Color.Black;
                            CoilJustReadCollection.coilJustReadList[(int)obj].ucSignalLamp1.TwinkleSpeed = 0;
                            i = 3;
                        }
                    }
                    catch (Exception)
                    {
                        Thread.Sleep(200);
                    }
                    Thread.Sleep(50);
                }
            }
        }
    }
}
