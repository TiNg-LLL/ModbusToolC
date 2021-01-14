using Func;
using PanelCollection;
using PanelCollection.CoilButton;
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
    public class CoilButtonLabelFlashThread
    {
        //new一个线程
        private Thread childThread;


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
                            //小绿点
                            CoilButtonCollection.coilButtonList[(int)obj].ucSignalLamp1.LampColor = 
                                new Color[] { Color.FromArgb(0, 255, 0) };//绿色
                            //按钮背景
                            CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor = Color.FromArgb(165, 165, 165);
                            CoilButtonCollection.coilButtonList[(int)obj].ucSignalLamp1.BackColor = CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor;
                        }
                        else if (!(bool)CoilButtonCollection.coilButtonValueList[(int)obj])
                        {
                            //小绿点
                            CoilButtonCollection.coilButtonList[(int)obj].ucSignalLamp1.LampColor =
                                new Color[] { CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor };
                            //按钮背景
                            CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor = Color.FromArgb(165, 165, 165);
                            CoilButtonCollection.coilButtonList[(int)obj].ucSignalLamp1.BackColor = CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor;
                        }
                        else
                        {
                            //小绿点
                            CoilButtonCollection.coilButtonList[(int)obj].ucSignalLamp1.LampColor =
                                new Color[] { CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor };
                            //按钮背景
                            CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor = Color.FromArgb(211, 211, 211);
                            CoilButtonCollection.coilButtonList[(int)obj].ucSignalLamp1.BackColor = CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor;
                        }
                    }
                    catch (Exception)
                    {
                        //小绿点
                        CoilButtonCollection.coilButtonList[(int)obj].ucSignalLamp1.LampColor =
                            new Color[] { CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor };
                        //按钮背景
                        CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor = Color.FromArgb(211, 211, 211);
                        CoilButtonCollection.coilButtonList[(int)obj].ucSignalLamp1.BackColor = CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor;
                        Thread.Sleep(200);
                    }
                    Thread.Sleep(50);
                }
                else
                {
                    try
                    {
                        //小绿点
                        CoilButtonCollection.coilButtonList[(int)obj].ucSignalLamp1.LampColor = 
                            new Color[] { CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor };
                        //按钮背景
                        CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor = Color.FromArgb(211, 211, 211);
                        CoilButtonCollection.coilButtonList[(int)obj].ucSignalLamp1.BackColor = CoilButtonCollection.coilButtonList[(int)obj].ucBtnExt1.FillColor;
                    }
                    catch (Exception)
                    {
                        Thread.Sleep(200);
                    }
                    Thread.Sleep(200);
                }
            }
        }
    }
}
