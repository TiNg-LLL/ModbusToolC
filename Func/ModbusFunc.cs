using Modbus.Device;
using Modbus.Utility;

namespace Func
{
    public class ModbusFunc
    {
        static IModbusSerialMaster modbus = ModbusSerialMaster.CreateRtu(COMFunc.serialPort);

        //
        //寄存器多个写入方法
        //
        public static void MyWriteMultipleRegisters(int RegisterWriteAddress, string data)
        {
            if (COMFunc.serialPort.IsOpen)
            {
                ushort startAddress = (ushort)RegisterWriteAddress;
                // datas = ushort.Parse(data);
                try
                {
                    modbus.WriteMultipleRegisters(COMFunc.SlaveID, startAddress, DataTreat.RegisterWriteDataTreat(data));
                }
                catch (System.Exception e)
                {
                    throw e;
                }
            }
        }
        //
        //寄存器多个读取方法
        //
        public static string MyReadHoldingRegisters(int RegisterReadAddress)
        {
            if (COMFunc.serialPort.IsOpen)
            {
                ushort startAddress = (ushort)RegisterReadAddress;
                try
                {
                    return DataTreat.RegisterReadDataTreat(modbus.ReadHoldingRegisters(COMFunc.SlaveID, startAddress, 2));
                }
                catch (System.Exception e)
                {
                    throw e;
                }
            }
            return "";
        }
        //***
        //线圈单个读取
        //***
        public static bool MyReadCoils(int CoilReadAddress) {
            if (COMFunc.serialPort.IsOpen)
            {
                ushort startAddress = (ushort)CoilReadAddress;
                try
                {
                    return modbus.ReadCoils(COMFunc.SlaveID,startAddress,1)[0];
                }
                catch (System.Exception e)
                {
                    throw e;
                }
            }
            return false;
        }
        //***
        //线圈单个写入
        //***
        public static void MyWriteSingleCoil(int CoilWriteAddress,bool b)
        {
            if (COMFunc.serialPort.IsOpen)
            {
                ushort startAddress = (ushort)CoilWriteAddress;
                try
                {
                    modbus.WriteSingleCoil(COMFunc.SlaveID, startAddress, b);
                }
                catch (System.Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
