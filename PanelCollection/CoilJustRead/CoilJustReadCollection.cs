using Func;
using PanelUnit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelCollection
{
    public partial class CoilJustReadCollection : UserControl
    {
        //创建CoilJustRead集合
        public static List<CoilJustReadPanel> coilJustReadList = new List<CoilJustReadPanel>();
        //创建CoilJustRead读取结果集合
        public static List<bool?> coilJustReadValueList = new List<bool?>();
        //线圈只读功能模块数量
        public static int coilJustReadAmount;

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\CoilJustRead.ini";
        public CoilJustReadCollection()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.AutoSize = true;

            coilJustReadAmount = int.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilJustReadAmount", "CoilJustReadAmount", "ba0s2hMe/Pg=", filename)));

            //在集合中创建对应数量的对象
            for (int i = 1; i <= coilJustReadAmount; i++)
            {
                coilJustReadList.Add(new CoilJustReadPanel(i));
                coilJustReadValueList.Add(null);
                //设置成员名称
                coilJustReadList[i - 1].label1.Text = Func.DES.DESDecrypt(IniFunc.getString("CoilJustReadName", "CoilJustReadName" + i, "bFMrIPLjXzYXCFBj9dj8cQ==", filename));
                //设置成员读取地址
                coilJustReadList[i - 1].coilJustReadAddress = int.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilJustReadAddress", "CoilJustReadAddress" + i, "ba0s2hMe/Pg=", filename)));
                //设置成员Color
                coilJustReadList[i - 1].c[0] = ColorTranslator.FromHtml(Func.DES.DESDecrypt(IniFunc.getString("CoilJustReadColor", "CoilJustReadColor" + i, "UxDrTFlFQDI=", filename)));
                //设置成员读取地址MXY
                coilJustReadList[i - 1].coilJustReadMXYAddress = Func.DES.DESDecrypt(IniFunc.getString("CoilJustReadMXYAddress", "CoilJustReadMXYAddress" + i, "/uz5sjJ8Zt4=", filename));
            }
            //***
            //Panel初始化
            //***
            for (int i = 0; i < coilJustReadAmount; i++)
            {
                this.flowLayoutPanel1.Controls.Add(coilJustReadList[i]);
            }
            //this.BackColor = Color.DarkRed;  //背景颜色
        }

        //public void Flash()
        //{
        //    coilJustReadList.Clear();
        //    coilJustReadValueList.Clear();
        //    this.flowLayoutPanel1.Controls.Clear();
        //    coilJustReadAmount = int.Parse(IniFunc.getString("CoilJustReadAmount", "CoilJustReadAmount", "读取错误", filename));

        //    //在集合中创建对应数量的对象
        //    for (int i = 1; i <= coilJustReadAmount; i++)
        //    {
        //        coilJustReadList.Add(new CoilJustReadPanel(i));
        //        coilJustReadValueList.Add(false);
        //        //设置成员名称
        //        coilJustReadList[i - 1].label1.Text = Func.DES.DESDecrypt(IniFunc.getString("CoilJustReadName", "CoilJustReadName" + i, "读取错误", filename));
        //        //设置成员读取地址
        //        coilJustReadList[i - 1].coilJustReadAddress = int.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilJustReadAddress", "CoilJustReadAddress" + i, "0", filename)));
        //        //设置成员Color
        //        coilJustReadList[i - 1].c[0] = ColorTranslator.FromHtml(IniFunc.getString("CoilJustReadColor", "CoilJustReadColor" + i, "#D3D3D3", filename));
        //        //设置成员读取地址MXY
        //        coilJustReadList[i - 1].coilJustReadMXYAddress = Func.DES.DESDecrypt(IniFunc.getString("CoilJustReadMXYAddress", "CoilJustReadMXYAddress" + i, "M", filename));
        //    }
        //    //***
        //    //Panel初始化
        //    //***
        //    for (int i = 0; i < coilJustReadAmount; i++)
        //    {
        //        this.flowLayoutPanel1.Controls.Add(coilJustReadList[i]);
        //    }
        //}
    }
}
