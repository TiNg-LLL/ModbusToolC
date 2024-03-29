﻿using Func;
using PanelCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadThreadSpace
{
    public class RegisterLabelFlashThread
    {
        //new一个线程
        private Thread childThread;

        public RegisterLabelFlashThread(int i)
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
                //判断是否隐藏
                if (!RegisterCollection.registerList[(int)obj].hidebool)
                {
                    //判断COM端口是否已连接
                    if (COMFunc.serialPort.IsOpen)
                    {
                        if (RegisterCollection.registerValueList[(int)obj].Equals("null"))
                        {
                            if (!(RegisterCollection.registerList[(int)obj].GetRegisterNowValue().Text.Equals("error")))
                            {
                                RegisterCollection.registerList[(int)obj].GetRegisterNowValue().Text = "error";
                            }
                            Thread.Sleep(500);
                        }
                        else
                        {
                            //判断刷新至Label的值是否需要单位转换
                            if (RegisterCollection.registerList[(int)obj].dataTransform)
                            {

                                try
                                {
                                    RegisterCollection.registerList[(int)obj].GetRegisterNowValue().Text =
                                    DataTreat.RegisterDataProportionToMM(int.Parse(RegisterCollection.registerValueList[(int)obj]), RegisterCollection.registerDataProportion) + "mm";
                                }
                                catch (Exception)
                                {
                                    //if (!(RegisterCollection.registerList[(int)obj].GetRegisterNowValue().Text.Equals("error")))
                                    //{
                                    //    RegisterCollection.registerList[(int)obj].GetRegisterNowValue().Text = "error";
                                    //}
                                    //Thread.Sleep(500);
                                }
                            }
                            else  //不转换
                            {
                                try
                                {
                                    RegisterCollection.registerList[(int)obj].GetRegisterNowValue().Text =
                                    RegisterCollection.registerValueList[(int)obj];
                                }
                                catch (Exception)
                                {
                                    //RegisterCollection.registerList[(int)obj].GetRegisterNowValue().Text = "error";
                                }
                            }
                        }
                        Thread.Sleep(5);
                    }
                    else
                    {
                        try
                        {
                            RegisterCollection.registerList[(int)obj].GetRegisterNowValue().Text = "000";
                        }
                        catch (Exception)
                        {
                            Thread.Sleep(200);
                        }
                        Thread.Sleep(50);
                    }
                }
                else
                {
                    Thread.Sleep(2000);
                }
            }
        }

        public Thread getThread()
        {
            return childThread;
        }
    }
}
