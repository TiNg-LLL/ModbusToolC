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

        public static bool MyReadCoils(int CoilJustReadAddress) {
            if (COMFunc.serialPort.IsOpen)
            {
                ushort startAddress = (ushort)CoilJustReadAddress;
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
    }
}
