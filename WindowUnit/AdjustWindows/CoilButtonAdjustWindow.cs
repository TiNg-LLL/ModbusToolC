using Func;
using PanelCollection;
using PanelCollection.CoilButton;
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowUnit
{
    public partial class CoilButtonAdjustWindow : Form
    {
        //new出寄存器地址修改组合模块
        public static CoilButtonAdjustCollection coilButtonAdjustCollection = new CoilButtonAdjustCollection();

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\CoilButton.ini";

        //辅助对象
        public bool b { get; set; }

        public CoilButtonAdjustWindow()
        {
            InitializeComponent();
            //添加registerNameAdjustCollection
            this.panel1.Controls.Add(coilButtonAdjustCollection);
            //隐藏右上角关闭按钮
            this.ControlBox = false;
        }

        //寄存器参数设置应用按钮
        private void button1_Click(object sender, System.EventArgs e)
        {
            int t = 0;
            //参数刷新
            for (int i = 1; i <= CoilButtonCollection.coilButtonAmount; i++)
            {
                //***
                //名称ini文件刷新
                IniFunc.writeString("CoilButtonName", "CoilButtonName" + i, Func.DES.DESEncrypt(CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].coilButtonTextBox1.Text), filename);
                //名称对象刷新
                CoilButtonCollection.coilButtonList[i - 1].ucBtnExt1.lbl.Text = Func.DES.DESDecrypt(IniFunc.getString("CoilButtonName", "CoilButtonName" + i, "bFMrIPLjXzYXCFBj9dj8cQ==", filename));
                //***
                //读取地址
                //***
                //读取地址ini文件刷新
                IniFunc.writeString("CoilButtonReadAddress", "CoilButtonReadAddress" + i, Func.DES.DESEncrypt(CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].coilButtonReadtextBox.Text), filename);
                //读取地址对象刷新
                CoilButtonCollection.coilButtonList[i - 1].coilButtonReadAddress = int.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonReadAddress", "CoilButtonReadAddress" + i, "ba0s2hMe/Pg=", filename)));  //默认0
                //读取MXY地址ini文件刷新
                IniFunc.writeString("CoilButtonReadMXYAddress", "CoilButtonReadMXYAddress" + i, Func.DES.DESEncrypt(CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].coilButtonReadcomboBox.Text), filename);
                //读取MXY地址对象刷新
                CoilButtonCollection.coilButtonList[i - 1].coilButtonReadMXYAddress = Func.DES.DESDecrypt(IniFunc.getString("CoilButtonReadMXYAddress", "CoilButtonReadMXYAddress" + i, "/uz5sjJ8Zt4=", filename));  //默认M
                //***
                //写入地址
                //***
                //写入地址ini文件刷新
                IniFunc.writeString("CoilButtonWriteAddress", "CoilButtonWriteAddress" + i, Func.DES.DESEncrypt(CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].coilButtonWriteTextBox.Text), filename);
                //写入地址对象刷新
                CoilButtonCollection.coilButtonList[i - 1].coilButtonWriteAddress = int.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonWriteAddress", "CoilButtonWriteAddress" + i, "ba0s2hMe/Pg=", filename)));  //默认0
                //写入MXY地址ini文件刷新
                IniFunc.writeString("CoilButtonWriteMXYAddress", "CoilButtonWriteMXYAddress" + i, Func.DES.DESEncrypt(CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].coilButtonWritecomboBox.Text), filename);
                //写入MXY地址对象刷新
                CoilButtonCollection.coilButtonList[i - 1].coilButtonWriteMXYAddress = Func.DES.DESDecrypt(IniFunc.getString("CoilButtonWriteMXYAddress", "CoilButtonWriteMXYAddress" + i, "/uz5sjJ8Zt4=", filename));  //默认M
                //***
                //点动切换
                //***
                if (CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].radioButton1.Checked)
                {
                    IniFunc.writeString("CoilButtonTransform", "CoilButtonTransform" + i, "IY61r8XnUzA=", filename);
                    CoilButtonCollection.coilButtonList[i - 1].coilButtonTransform = bool.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonTransform", "CoilButtonTransform" + i, "rQKVA3srM0c=", filename)));
                }
                else
                {
                    IniFunc.writeString("CoilButtonTransform", "CoilButtonTransform" + i, "rQKVA3srM0c=", filename);
                    CoilButtonCollection.coilButtonList[i - 1].coilButtonTransform = bool.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonTransform", "CoilButtonTransform" + i, "rQKVA3srM0c=", filename)));
                }
                //***
                //隐藏bool刷新
                //***
                if (!(CoilButtonCollection.coilButtonList[i - 1].coilButtonHideBool.Equals(CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].checkBox1.Checked)))
                {
                    if (CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].checkBox1.Checked)
                    {
                        CoilButtonCollection.coilButtonList[i - 1].coilButtonHideBool = true;
                    }
                    else
                    {
                        CoilButtonCollection.coilButtonList[i - 1].coilButtonHideBool = false;
                    }
                    IniFunc.writeString("CoilButtonHideBool", "CoilButtonHideBool" + i, Func.DES.DESEncrypt(CoilButtonCollection.coilButtonList[i - 1].coilButtonHideBool.ToString()), filename);
                    t++;
                }
                if (t > 0)
                {
                    b = true;
                }
                else
                {
                    b = false;
                }
            }
            //设置窗口关闭
            this.Close();
        }
        //取消按钮
        private void button2_Click(object sender, System.EventArgs e)
        {
            b = false;
            this.Close();
        }
        //***
        //窗口内容刷新
        //***
        public void Flash()
        {
            this.Controls.Clear();
            InitializeComponent();
            this.panel1.Controls.Add(coilButtonAdjustCollection);
        }

        private void 点动label1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CoilButtonCollection.coilButtonAmount; i++)
            {
                CoilButtonAdjustCollection.coilButtonAdjustList[i].radioButton1.Checked = true;
            }
        }

        private void 切换label2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CoilButtonCollection.coilButtonAmount; i++)
            {
                CoilButtonAdjustCollection.coilButtonAdjustList[i].radioButton2.Checked = true;
            }
        }

        private void 隐藏label3_Click(object sender, EventArgs e)
        {
            if (CoilButtonAdjustCollection.coilButtonAdjustList[0].checkBox1.Checked)
            {
                for (int i = 0; i < CoilButtonCollection.coilButtonAmount; i++)
                {
                    CoilButtonAdjustCollection.coilButtonAdjustList[i].checkBox1.Checked = false;
                }
            }
            else
            {
                for (int i = 0; i < CoilButtonCollection.coilButtonAmount; i++)
                {
                    CoilButtonAdjustCollection.coilButtonAdjustList[i].checkBox1.Checked = true;
                }
            }
        }
    }
}