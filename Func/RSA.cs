using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    public class RSA
    {

        public static string RSAEncrypt(string normaltxt)
        {
            var bytes = Encoding.Default.GetBytes(normaltxt);
            var encryptBytes = new RSACryptoServiceProvider(new CspParameters()).Encrypt(bytes, false);
            return Convert.ToBase64String(encryptBytes);
            Console.WriteLine(Convert.ToBase64String(encryptBytes));
        }


        public static string RSADecrypt(string securityTxt)
        {
            try//必须使用Try catch,不然输入的字符串不是净荷明文程序就Gameover了
            {
                var bytes = Convert.FromBase64String(securityTxt);
                var DecryptBytes = new RSACryptoServiceProvider(new CspParameters()).Decrypt(bytes, false);
                //Console.WriteLine(Encoding.Default.GetString(DecryptBytes));
                return Encoding.Default.GetString(DecryptBytes);
            }
            catch (Exception)
            {
                //Console.WriteLine("---------");
                return string.Empty;
            }
        }
    }
}
