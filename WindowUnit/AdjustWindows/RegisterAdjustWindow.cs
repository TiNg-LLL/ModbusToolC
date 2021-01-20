using Func;
using PanelCollection;
using System.IO;
using System.Windows.Forms;

namespace WindowUnit
{
    public partial class RegisterAdjustWindow : Form
    {
        //new出寄存器地址修改组合模块
        public static RegisterAdjustCollection registerAdjustCollection = new RegisterAdjustCollection();

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";

        //辅助对象
        public bool b { get; set; }

        public RegisterAdjustWindow()
        {
            InitializeComponent();
            //添加registerNameAdjustCollection
            this.panel1.Controls.Add(registerAdjustCollection);
            //隐藏右上角关闭按钮
            this.ControlBox = false;
        }

        //寄存器参数设置应用按钮
        public void button1_Click(object sender, System.EventArgs e)
        {
            int t = 0;
            //参数刷新
            for (int i = 1; i <= RegisterCollection.registerAmount; i++)
            {
                //***
                //名称ini文件刷新
                IniFunc.writeString("RegisterName", "RegisterName" + i, RegisterAdjustCollection.resgisterAdjustList[i - 1].GetRegisterNameText(), filename);
                //名称对象刷新
                RegisterCollection.registerList[i - 1].SetRegisterName(IniFunc.getString("RegisterName", "RegisterName" + i, "读取错误", filename));
                //***
                //地址刷新
                //ini文件刷新
                IniFunc.writeString("RegisterWriteAddress", "RegisterWriteAddress" + i, RegisterAdjustCollection.resgisterAdjustList[i - 1].GetRegisterWriteAddressText(), filename);
                IniFunc.writeString("RegisterReadAddress", "RegisterReadAddress" + i, RegisterAdjustCollection.resgisterAdjustList[i - 1].GetRegisterReadAddressText(), filename);
                //写入读取地址对象刷新
                RegisterCollection.registerList[i - 1].SetRegisterWriteAddress(int.Parse(IniFunc.getString("RegisterWriteAddress", "RegisterWriteAddress" + i, "0", filename)));
                RegisterCollection.registerList[i - 1].SetRegisterReadAddress(int.Parse(IniFunc.getString("RegisterReadAddress", "RegisterReadAddress" + i, "0", filename)));
                //***
                //数据转换刷新
                //***
                if (RegisterAdjustCollection.resgisterAdjustList[i - 1].RegisterDataTransform.Checked)
                {
                    RegisterCollection.registerList[i - 1].dataTransform = true;
                }
                else
                {
                    RegisterCollection.registerList[i - 1].dataTransform = false;
                }
                IniFunc.writeString("RegisterDataTransform", "RegisterDataTransform" + i, RegisterCollection.registerList[i - 1].dataTransform.ToString(), filename);
                //***
                //JustLabel刷新
                //***
                if (RegisterAdjustCollection.resgisterAdjustList[i - 1].RegisterJustLabel.Checked)
                {
                    RegisterCollection.registerList[i - 1].justLabel = true;
                }
                else
                {
                    RegisterCollection.registerList[i - 1].justLabel = false;
                }
                IniFunc.writeString("RegisterJustLabel", "RegisterJustLabel" + i, RegisterCollection.registerList[i - 1].justLabel.ToString(), filename);
                //***
                //隐藏bool刷新
                //***
                if (!(RegisterCollection.registerList[i - 1].hidebool.Equals(RegisterAdjustCollection.resgisterAdjustList[i - 1].hidecheckBox3.Checked)))
                {
                    if (RegisterAdjustCollection.resgisterAdjustList[i - 1].hidecheckBox3.Checked)
                    {
                        RegisterCollection.registerList[i - 1].hidebool = true;
                    }
                    else
                    {
                        RegisterCollection.registerList[i - 1].hidebool = false;
                    }
                    IniFunc.writeString("RegisterHideBool", "RegisterHideBool" + i, RegisterCollection.registerList[i - 1].hidebool.ToString(), filename);
                    t++;
                }
            }
            if (t > 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            //窗口关闭
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
            this.panel1.Controls.Add(registerAdjustCollection);
        }

        private void mmlabel1_Click(object sender, System.EventArgs e)
        {
            if (RegisterAdjustCollection.resgisterAdjustList[0].RegisterDataTransform.Checked)
            {
                for (int i = 0; i < RegisterCollection.registerAmount; i++)
                {
                    RegisterAdjustCollection.resgisterAdjustList[i].RegisterDataTransform.Checked = false;
                }
            }
            else
            {
                for (int i = 0; i < RegisterCollection.registerAmount; i++)
                {
                    RegisterAdjustCollection.resgisterAdjustList[i].RegisterDataTransform.Checked = true;
                }
            }
        }

        private void 只读label2_Click(object sender, System.EventArgs e)
        {
            if (RegisterAdjustCollection.resgisterAdjustList[0].RegisterJustLabel.Checked)
            {
                for (int i = 0; i < RegisterCollection.registerAmount; i++)
                {
                    RegisterAdjustCollection.resgisterAdjustList[i].RegisterJustLabel.Checked = false;
                }
            }
            else
            {
                for (int i = 0; i < RegisterCollection.registerAmount; i++)
                {
                    RegisterAdjustCollection.resgisterAdjustList[i].RegisterJustLabel.Checked = true;
                }
            }
        }

        private void 隐藏label3_Click(object sender, System.EventArgs e)
        {
            if (RegisterAdjustCollection.resgisterAdjustList[0].hidecheckBox3.Checked)
            {
                for (int i = 0; i < RegisterCollection.registerAmount; i++)
                {
                    RegisterAdjustCollection.resgisterAdjustList[i].hidecheckBox3.Checked = false;
                }
            }
            else
            {
                for (int i = 0; i < RegisterCollection.registerAmount; i++)
                {
                    RegisterAdjustCollection.resgisterAdjustList[i].hidecheckBox3.Checked = true;
                }
            }
        }
    }
}