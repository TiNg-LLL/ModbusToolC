﻿using Func;
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

        //是否闪烁标志
        public bool flashbool { get; set; }

        //颜色修改权限标志
        public static bool b = false;

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\CoilJustRead.ini";

        public CoilJustReadPanel(int i)
        {
            InitializeComponent();
            this.Width = this.ucSignalLamp1.Width;
            this.Height = this.Width + 10;
            this.ID = i;
            c = new Color[] { new Color(), Color.Transparent };
            //this.BackColor = Color.DarkRed;  //背景颜色

            //从非 UI 线程更新 UI 线程  线程不安全
            CheckForIllegalCrossThreadCalls = false;
        }

        public UCSignalLamp GetUCSignalLamp()
        {
            return this.ucSignalLamp1;
        }

        //双击颜色选取控件
        private void ucSignalLamp1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (b)
            {
                cd.Color = c[0];
                DialogResult dr = cd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    c[0] = cd.Color;
                    IniFunc.writeString("CoilJustReadColor", "CoilJustReadColor" + ID, Func.DES.DESEncrypt(ColorTranslator.ToHtml(c[0])), filename);
                }
            }
        }
    }
}
