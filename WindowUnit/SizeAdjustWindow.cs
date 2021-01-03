using Func;
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowUnit
{
    public partial class SizeAdjustWindow : Form
    {
        //初始化INI文件地址
        private static string filename = Directory.GetCurrentDirectory() + @"\SystemDate.ini";

        public SizeAdjustWindow()
        {
            InitializeComponent();
            this.textBox1.Text = IniFunc.getString("FirstWindowSize", "Width", "800", filename);
            this.textBox2.Text = IniFunc.getString("FirstWindowSize", "Height", "400", filename);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniFunc.writeString("FirstWindowSize", "Width", this.textBox1.Text, filename);
            IniFunc.writeString("FirstWindowSize", "Height", this.textBox2.Text, filename);
            if (MessageBox.Show("需要重启软件，是否现在重启", "修改成功", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}