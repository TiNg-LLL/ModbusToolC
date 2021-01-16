using Func;
using Controls;
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

namespace PanelUnit
{
    public partial class CoilJustReadPanel : UserControl
    {
        //标识特征
        public int ID { get; set; }

        //true的Color成员
        ColorDialog cd = new ColorDialog();
        public Color[] c { get; set; }

        //modbus参数成员
        public int coilJustReadAddress { get; set; }
        public string coilJustReadMXYAddress { get; set; }

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\CoilJustRead.ini";

        public CoilJustReadPanel(int i)
        {
            InitializeComponent();
            this.Width = this.ucSignalLamp1.Width;
            this.Height = this.Width + 10;
            this.ID = i;
            c = new Color[] { new Color() ,Color.Transparent};
            //this.BackColor = Color.DarkRed;  //背景颜色

            //从非 UI 线程更新 UI 线程  线程不安全
            CheckForIllegalCrossThreadCalls = false;
        }

        public UCSignalLamp GetUCSignalLamp()
        {
            return this.ucSignalLamp1;
        }

        private void ucSignalLamp1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                c[0] = cd.Color;
                IniFunc.writeString("CoilJustReadColor", "CoilJustReadColor" + ID, ColorTranslator.ToHtml(c[0]), filename);
            }
        }
    }
}
