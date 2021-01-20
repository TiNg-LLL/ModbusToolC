using Func;
using PanelCollection.CoilButton;
using System;
using System.Drawing;
using System.Threading;

namespace ReadThreadSpace
{
    public class CoilButtonLabelFlashThread
    {
        //new一个线程
        private Thread childThread;
        //辅助变量
        int i;

        public CoilButtonLabelFlashThread(int i)
        {
            childThread = new Thread(new ParameterizedThreadStart(CoilReadThread));
            childThread.IsBackground = true;  //设置为后台线程
            childThread.Name = "线圈按钮Label刷新线程";
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
                        if ((bool)CoilButtonCollection.coilButtonValueList[(int)obj])
                        {
                            if (!(i == 0))
                            {
                                //小绿点
                                CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.ucSignalLamp1.LampColor =
                                    new Color[] { Color.FromArgb(0, 255, 0) };//绿色
                                //***
                                //按钮背景
                                CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor = Color.FromArgb(165, 165, 165);
                                i = 0;
                            }
                        }
                        else if (!(bool)CoilButtonCollection.coilButtonValueList[(int)obj])
                        {
                            if (!(i == 1))
                            {
                                //小绿点
                                CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.ucSignalLamp1.LampColor = new Color[] { Color.Transparent };
                                //按钮背景
                                CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor = Color.FromArgb(190, 190, 190);
                                i = 1;
                            }
                        }
                        else
                        {
                            ////小绿点
                            //CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.ucSignalLamp1.LampColor = new Color[] { Color.Transparent };
                            ////new Color[] { CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor };
                            ////按钮背景
                            //CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor = Color.FromArgb(220, 220, 220);
                        }
                    }
                    catch (Exception)
                    {
                        if (!(i == 2))
                        {
                            //小绿点
                            CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.ucSignalLamp1.LampColor = new Color[] { Color.Red };
                            //按钮背景
                            CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor = Color.FromArgb(220, 220, 220);
                            i = 2;
                        }
                        //Thread.Sleep(200);
                    }
                    Thread.Sleep(50);
                }
                else
                {
                    try
                    {
                        if (!(i == 3))
                        {
                            //小绿点
                            CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.ucSignalLamp1.LampColor = new Color[] { Color.Transparent };
                            //new Color[] { CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor };
                            //按钮背景
                            CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor = Color.FromArgb(211, 211, 211);
                            i = 3;
                        }
                    }
                    catch (Exception)
                    {
                        Thread.Sleep(500);
                    }
                    Thread.Sleep(200);
                }
            }
        }
    }
}