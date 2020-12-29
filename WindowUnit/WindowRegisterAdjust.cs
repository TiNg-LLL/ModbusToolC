using Func;
using PanelCollection;
using System.IO;
using System.Windows.Forms;

namespace WindowUnit
{
    public partial class WindowRegisterAdjust : Form
    {
        //new出寄存器功能模块
        private RegisterNameAdjustCollection registerNameAdjustCollection = new RegisterNameAdjustCollection();

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";

        public WindowRegisterAdjust()
        {
            InitializeComponent();
            //添加registerNameAdjustCollection
            this.panel1.Controls.Add(registerNameAdjustCollection);
        }

        //寄存器参数设置应用按钮
        private void button1_Click(object sender, System.EventArgs e)
        {
            //ini文件刷新
            for (int i = 1; i <= RegisterCollection.registerAmount; i++)
            {
                IniFunc.writeString("ResgiterName", "ResgiterName" + i, RegisterNameAdjustCollection.resgisterAdjustList[i-1].GetRegisterNameText(), filename);
            }
            //显示刷新
            for (int i = 1; i <= RegisterCollection.registerAmount; i++)
            {
                RegisterCollection.resgisterList[i - 1].SetResgisterName(IniFunc.getString("ResgiterName", "ResgiterName" + i, "读取错误", filename));
            }
            //设置窗口关闭
            this.Close();
        }
    }
}