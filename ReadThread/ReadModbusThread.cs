using Func;
using PanelCollection;
using PanelCollection.CoilButton;
using PanelUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadThreadSpace
{
    public class ReadModbusThread
    {
        private ThreadStart childref;
        private Thread childThread;
        int time;
        //private ModbusFunc modbusFunc = RegisterCommonPanel.modbusFunc;

        public ReadModbusThread()
        {
            childref = new ThreadStart(RegisterReadThread);
            childThread = new Thread(childref);
            childThread.IsBackground = true;  //设置为后台线程
            childThread.Name = "modbus读取线程";
            childThread.Start();
            time = 0;
        }
        //
        //寄存器modbus读取线程方法
        //
        public void RegisterReadThread()
        {
            while (true)
            {
                ThreadFather.met.WaitOne();
                if (COMFunc.serialPort.IsOpen)
                {
                    try
                    {
                        //***
                        //寄存器读取循环
                        for (int i = 0; i < RegisterCollection.registerAmount; i++)
                        {
                            try
                            {
                                RegisterCollection.registerValueList[i] = ModbusFunc.MyReadHoldingRegisters(DataTreat.RegisterAddressTransform(RegisterCollection.registerList[i].GetRegisterReadAddress()));
                                //Thread.Sleep(time);
                            }
                            catch (Exception)
                            {
                                RegisterCollection.registerValueList[i] = "null";
                                Thread.Sleep(50);
                                //Thread.Sleep(time);
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    //***********************************************************************************************
                    try
                    {
                        //***
                        //线圈读取循环---线圈只读状态
                        for (int i = 0; i < CoilJustReadCollection.coilJustReadAmount; i++)
                        {
                            try
                            {
                                CoilJustReadCollection.coilJustReadValueList[i] = ModbusFunc.MyReadCoils(
                                    DataTreat.CoilMXYAddressTransform(CoilJustReadCollection.coilJustReadList[i].coilJustReadAddress,
                                    CoilJustReadCollection.coilJustReadList[i].coilJustReadMXYAddress));
                                //Thread.Sleep(time);
                            }
                            catch (Exception)
                            {
                                CoilJustReadCollection.coilJustReadValueList[i] = null;
                                Thread.Sleep(50);
                                //Thread.Sleep(time);
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    //***********************************************************************************************
                    try
                    {
                        //***
                        //线圈读取循环---线圈按钮
                        for (int i = 0; i < CoilButtonCollection.coilButtonAmount; i++)
                        {
                            try
                            {
                                CoilButtonCollection.coilButtonValueList[i] = ModbusFunc.MyReadCoils(
                                    DataTreat.CoilMXYAddressTransform(CoilButtonCollection.coilButtonList[i].coilButtonReadAddress,
                                    CoilButtonCollection.coilButtonList[i].coilButtonReadMXYAddress));
                                //CoilButtonCollection.coilButtonList[i].nowValue = (bool)CoilButtonCollection.coilButtonValueList[i];
                                //Thread.Sleep(time);
                            }
                            catch (Exception)
                            {
                                CoilButtonCollection.coilButtonValueList[i] = null;
                                Thread.Sleep(50);
                                //Thread.Sleep(time);
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    //Console.WriteLine("----------------------------------------------------一次循环结果----------------------------------------------------");
                }
                else
                {
                    Thread.Sleep(200);
                }
            }
        }

        public Thread getThread()
        {
            return childThread;
        }
    }
}
