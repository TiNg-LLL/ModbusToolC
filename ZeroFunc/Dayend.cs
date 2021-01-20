using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroFunc
{
    public class Dayend
    {
        public Dayend()
        {
            //adminTime
            DateTime nowTime = DateTime.Now;
            string DeadTime = "2021-11-14";
            DateTime endTime = Convert.ToDateTime(DeadTime);
            if (!(DateTime.Compare(endTime, nowTime) > 0))
            {
                //Environment.Exit(0);
            }
        }
    }
}
