using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    public class DES
    {
        //初始化INI文件地址
        private static string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";
        //初始化INI文件地址
        private static string filename1 = Directory.GetCurrentDirectory() + @"\CoilButton.ini";

        //static byte[] keyvi = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x05, 0x07 };  //向量
        static String keyvi = IniFunc.getString("1", "user", "11111111", filename);
        static String EncryptKey = IniFunc.getString("1", "user", "11111111", filename1);

        public static string DESEncrypt(string originalValue)
        {
            using (DESCryptoServiceProvider sa
                = new DESCryptoServiceProvider { Key = Encoding.UTF8.GetBytes(EncryptKey), IV = Encoding.UTF8.GetBytes(keyvi) })
            {
                using (ICryptoTransform ct = sa.CreateEncryptor())
                {
                    byte[] by = Encoding.UTF8.GetBytes(originalValue);
                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, ct,
                                                         CryptoStreamMode.Write))
                        {
                            cs.Write(by, 0, by.Length);
                            cs.FlushFinalBlock();
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

        public static string DESDecrypt(string encryptedValue)
        {
            try
            {
                using (DESCryptoServiceProvider sa =
                new DESCryptoServiceProvider
                { Key = Encoding.UTF8.GetBytes(EncryptKey), IV = Encoding.UTF8.GetBytes(keyvi) })
                {
                    using (ICryptoTransform ct = sa.CreateDecryptor())
                    {
                        byte[] byt = Convert.FromBase64String(encryptedValue);

                        using (var ms = new MemoryStream())
                        {
                            using (var cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                            {
                                cs.Write(byt, 0, byt.Length);
                                cs.FlushFinalBlock();
                            }
                            return Encoding.UTF8.GetString(ms.ToArray());
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
