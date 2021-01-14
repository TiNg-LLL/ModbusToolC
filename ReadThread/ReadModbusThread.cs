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
        //private ModbusFunc modbusFunc = RegisterCommonPanel.modbusFunc;

        public ReadModbusThread()
        {
            childref = new ThreadStart(RegisterReadThread);
            childThread = new Thread(childref);
            childThread.IsBackground = true;  //设置为后台线程
            childThread.Name = "modbus读取线程";
            childThread.Start();
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
                                Thread.Sleep(10);
                            }
                            catch (Exception)
                            {
                                RegisterCollection.registerValueList[i] = "";
                                Thread.Sleep(20);
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
                                //Console.WriteLine(CoilJustReadCollection.coilJustReadValueList[i]);
                                Thread.Sleep(10);
                            }
                            catch (Exception)
                            {
                                CoilJustReadCollection.coilJustReadValueList[i] = null;
                                Thread.Sleep(20);
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
                                CoilButtonCollection.coilButtonList[i].nowValue = (bool)CoilButtonCollection.coilButtonValueList[i];
                                //Console.WriteLine(CoilButtonCollection.coilButtonValueList[i]);
                                Thread.Sleep(10);
                            }
                            catch (Exception)
                            {
                                CoilButtonCollection.coilButtonValueList[i] = null;
                                Thread.Sleep(20);
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
