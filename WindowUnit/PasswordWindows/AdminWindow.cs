using PanelUnit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowUnit
{
    public partial class AdminWindow : Form
    {
        ToolStripMenuItem t;

        //密码修改副窗口
        ChangePWWindow changePWWindow = new ChangePWWindow();

        //读取密码寄存
        //public string pd = Properties.Settings.Default.password;

        //辅助对象
        private bool b = true;
        public AdminWindow(ToolStripMenuItem toolStripMenuItem)
        {
            InitializeComponent();
            t = toolStripMenuItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(Func.DES.DESDecrypt(Properties.Settings.Default.password)))
            {
                t.Enabled = true;
                CoilJustReadPanel.b = true;
                textBox1.Text = "";
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + "：" + "登入成功");
                this.Close();
            }
            else
            {
                if (MessageBox.Show("密码错误", "密码错误", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + "：" + "密码错误");
                    textBox1.Text = "";
                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (b)
                {
                    if (textBox1.Text.Equals(Func.DES.DESDecrypt(Properties.Settings.Default.password)))
                    {
                        t.Enabled = true;
                        CoilJustReadPanel.b = true;
                        textBox1.Text = "";
                        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + "：" + "登入成功");
                        this.Close();
                    }
                    else
                    {
                        b = false;
                        if (MessageBox.Show("密码错误", "密码错误", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + "：" + "密码错误");
                            textBox1.Text = "";
                        }
                    }
                }
            }
            else
            {
                b = true;
            }
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            changePWWindow.ShowDialog();
        }
    }
}
