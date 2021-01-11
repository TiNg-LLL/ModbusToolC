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
        public static List<bool> coilJustReadValueList = new List<bool>();
        //线圈只读功能模块数量
        public static int coilJustReadAmount;

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\CoilJustRead.ini";
        public CoilJustReadCollection()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.AutoSize = true;

            coilJustReadAmount = int.Parse(IniFunc.getString("CoilJustReadAmount", "CoilJustReadAmount", "读取错误", filename));

            //在集合中创建对应数量的对象
            for (int i = 1; i <= coilJustReadAmount; i++)
            {
                coilJustReadList.Add(new CoilJustReadPanel(i));
                coilJustReadValueList.Add(false);
                ////设置成员名称
                //registerList[i - 1].SetRegisterName(IniFunc.getString("RegisterName", "RegisterName" + i, "读取错误", filename));
                ////设置成员写入地址
                //registerList[i - 1].SetRegisterWriteAddress(int.Parse(IniFunc.getString("RegisterWriteAddress", "RegisterWriteAddress" + i, "0", filename)));
                ////设置成员读取地址
                //registerList[i - 1].SetRegisterReadAddress(int.Parse(IniFunc.getString("RegisterReadAddress", "RegisterReadAddress" + i, "0", filename)));
                ////设置成员数据转换Boolean
                //registerList[i - 1].dataTransform = bool.Parse(IniFunc.getString("RegisterDataTransform", "RegisterDataTransform" + i, "false", filename));
                ////设置寄存器单位转换比率
                //registerDataProportion = float.Parse(IniFunc.getString("RegisterDataProportion", "RegisterDataProportion1", "1", filename));
            }

            //
            //Panel初始化
            //
            for (int i = 0; i < coilJustReadAmount; i++)
            {
                this.flowLayoutPanel1.Controls.Add(coilJustReadList[i]);
            }
            //this.BackColor = Color.DarkRed;  //背景颜色
        }
    }
}
