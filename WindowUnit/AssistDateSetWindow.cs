using Func;
using PanelCollection;
using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowUnit
{
    public partial class AssistDateSetWindow : Form
    {
        //初始化INI文件地址
        private static string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";

        public AssistDateSetWindow()
        {
            InitializeComponent();
            //读取寄存器单位转换比率并设置
            this.proportionTextBox.Text = IniFunc.getString("RegisterDataProportion", "RegisterDataProportion1", "1", filename);
        }
        //
        //应用按钮
        //
        private void button1_Click(object sender, EventArgs e)
        {
            //寄存器单位转换比率写入
            IniFunc.writeString("RegisterDataProportion", "RegisterDataProportion1", this.proportionTextBox.Text, filename);
            RegisterCollection.registerDataProportion = float.Parse(IniFunc.getString("RegisterDataProportion", "RegisterDataProportion1", "1", filename));
            this.Close();
        }
        //
        //取消按钮
        //
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //输入框只能填写数字
        private void proportionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == '.') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}