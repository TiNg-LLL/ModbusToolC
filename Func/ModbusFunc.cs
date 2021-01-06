using Modbus.Device;

namespace Func
{
    public class ModbusFunc
    {
        IModbusSerialMaster modbus = ModbusSerialMaster.CreateRtu(COMFunc.serialPort);

        ushort[] data;


        //无参构造方法
        public ModbusFunc()
        {
        }
        //
        //寄存器多个写入方法
        //
        public void MyWriteMultipleRegisters(int RegisterWriteAddress, string data)
        {
            if (COMFunc.serialPort.IsOpen)
            {
                ushort startAddress = (ushort)RegisterWriteAddress;
                ushort datas = ushort.Parse(data);
                try
                {
                    modbus.WriteSingleRegister(COMFunc.SlaveID, startAddress, datas);
                }
                catch (System.Exception)
                {
                    //throw;
                }
            }
        }
        //
        //寄存器多个读取方法
        //
        public string MyReadHoldingRegisters(int RegisterReadAddress)
        {
            if (COMFunc.serialPort.IsOpen)
            {
                ushort startAddress = (ushort)RegisterReadAddress;
                try
                {
                    data = modbus.ReadHoldingRegisters(COMFunc.SlaveID, startAddress, 1);
                    return data[0].ToString();
                }
                catch (System.Exception)
                {
                    //throw;
                }
            }
            return "";
        }
    }
}
