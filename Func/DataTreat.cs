using Modbus.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    public class DataTreat
    {
        public static String RegisterReadDataTreat(ushort[] us)
        {
            //***以下代码为java版时使用的转换，现在C#中弃用；***
            //String s = Convert.ToString(us[0], 2);
            //while (s.Length < 16)
            //{
            //    s = "0" + s;
            //}
            //String s1 = Convert.ToString(us[1], 2);
            //String s2 = s1 + s;
            //String s3 = Convert.ToInt32(s2, 2).ToString();
            //return s3;

            //***现有方法,满足负数，将实现写入的方法反过来；***
            byte[] b1 = BitConverter.GetBytes(us[0]);
            byte[] b2 = BitConverter.GetBytes(us[1]);
            byte[] b3 = new byte[b1.Length + b2.Length];
            b1.CopyTo(b3, 0);
            b2.CopyTo(b3, b1.Length);
            return BitConverter.ToInt32(b3, 0).ToString();
        }

        public static ushort[] RegisterWriteDataTreat(String s)
        {
            int i = int.Parse(s);
            ushort lowOrderValue = BitConverter.ToUInt16(BitConverter.GetBytes(i), 0);
            ushort highOrderValue = BitConverter.ToUInt16(BitConverter.GetBytes(i), 2);
            return new ushort[] { lowOrderValue, highOrderValue };
        }
        //脉冲转换为mm单位  数据读取后使用
        public static String RegisterDataProportionToMM(int i1, float i2)
        {
            return ((float)i1 / i2).ToString("F2"); //保留两位小数
        }
        //mm单位转换为脉冲   数据写入时使用
        public static String RegisterDataProportionMMTo(float i1, float i2)
        {
            return ((int)(i1 * i2)).ToString();
        }
    }
}
