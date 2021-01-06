using Func;
using PanelCollection;
using System.IO;
using System.Windows.Forms;

namespace WindowUnit
{
    public partial class RegisterAdjustWindow : Form
    {
        //new出寄存器功能模块
        public static RegisterAdjustCollection registerAdjustCollection = new RegisterAdjustCollection();

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";

        public RegisterAdjustWindow()
        {
            InitializeComponent();
            //添加registerNameAdjustCollection
            this.panel1.Controls.Add(registerAdjustCollection);
        }

        //寄存器参数设置应用按钮
        private void button1_Click(object sender, System.EventArgs e)
        {
            //ini文件刷新
            for (int i = 1; i <= RegisterCollection.registerAmount; i++)
            {
                IniFunc.writeString("RegisterName", "RegisterName" + i, RegisterAdjustCollection.resgisterAdjustList[i - 1].GetRegisterNameText(), filename);
                IniFunc.writeString("RegisterWriteAddress", "RegisterWriteAddress" + i, RegisterAdjustCollection.resgisterAdjustList[i - 1].GetRegisterWriteAddressText(), filename);
                IniFunc.writeString("RegisterReadAddress", "RegisterReadAddress" + i, RegisterAdjustCollection.resgisterAdjustList[i - 1].GetRegisterReadAddressText(), filename);
            }
            //地址参数刷新
            for (int i = 1; i <= RegisterCollection.registerAmount; i++)
            {
                RegisterCollection.registerList[i - 1].SetRegisterName(IniFunc.getString("RegisterName", "RegisterName" + i, "读取错误", filename));
                RegisterCollection.registerList[i - 1].SetRegisterWriteAddress(int.Parse(IniFunc.getString("RegisterWriteAddress", "RegisterWriteAddress" + i, "0", filename)));
                RegisterCollection.registerList[i - 1].SetRegisterReadAddress(int.Parse(IniFunc.getString("RegisterReadAddress", "RegisterReadAddress" + i, "0", filename)));
            }
            //设置窗口关闭
            this.Close();
        }
        //取消按钮
        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        //窗口内容刷新
        public void Flash()
        {
            this.Controls.Clear();
            InitializeComponent();
            this.panel1.Controls.Add(registerAdjustCollection);
        }
    }
}