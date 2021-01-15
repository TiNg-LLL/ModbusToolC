﻿using Func;
using PanelCollection;
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

namespace WindowUnit
{
    public partial class CoilJustReadAdjustWindow : Form
    {
        //new出线圈地址修改组合模块
        public static CoilJustReadAdjustCollection coilJustReadAdjustCollection = new CoilJustReadAdjustCollection();

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\CoilJustRead.ini";

        public CoilJustReadAdjustWindow()
        {
            InitializeComponent();
            this.panel1.Controls.Add(coilJustReadAdjustCollection);
        }

        //寄存器参数设置应用按钮
        private void button1_Click(object sender, System.EventArgs e)
        {
            //参数刷新
            for (int i = 1; i <= CoilJustReadCollection.coilJustReadAmount; i++)
            {
                //***
                //名称ini文件刷新
                IniFunc.writeString("CoilJustReadName", "CoilJustReadName" + i, CoilJustReadAdjustCollection.coilJustReadAdjustList[i - 1].coilJustReadTextBox1.Text, filename);
                //***
                //名称对象刷新
                CoilJustReadCollection.coilJustReadList[i - 1].label1.Text = (IniFunc.getString("CoilJustReadName", "CoilJustReadName" + i, "读取错误", filename));
                //***
                //地址ini文件刷新
                IniFunc.writeString("CoilJustReadAddress", "CoilJustReadAddress" + i, CoilJustReadAdjustCollection.coilJustReadAdjustList[i - 1].coilJustReadTextBox2.Text, filename);
                //***
                //读取地址对象刷新
                CoilJustReadCollection.coilJustReadList[i - 1].coilJustReadAddress = int.Parse(IniFunc.getString("CoilJustReadAddress", "CoilJustReadAddress" + i, "0", filename));
                //***
                //MXY地址ini文件刷新
                IniFunc.writeString("CoilJustReadMXYAddress", "CoilJustReadMXYAddress" + i, CoilJustReadAdjustCollection.coilJustReadAdjustList[i - 1].comboBox1.Text, filename);
                //***
                //MXY读取地址对象刷新
                CoilJustReadCollection.coilJustReadList[i - 1].coilJustReadMXYAddress = IniFunc.getString("CoilJustReadMXYAddress", "CoilJustReadMXYAddress" + i, "M", filename);
            }
            //设置窗口关闭
            this.Close();
        }
        //***
        //取消按钮
        //***
        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        //***
        //窗口内容刷新
        //***
        public void Flash()
        {
            this.Controls.Clear();
            InitializeComponent();
            this.panel1.Controls.Add(coilJustReadAdjustCollection);
        }
    }
}