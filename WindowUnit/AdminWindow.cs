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
        //辅助对象
        private bool b = true;
        public AdminWindow(ToolStripMenuItem toolStripMenuItem)
        {
            InitializeComponent();
            t = toolStripMenuItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0123"))
            {
                t.Enabled = true;
                CoilJustReadPanel.b = true;
                textBox1.Text = "";
                this.Close();
            }
            else
            {
                if (MessageBox.Show("密码错误", "密码错误", MessageBoxButtons.OK) == DialogResult.OK)
                {
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
                    if (textBox1.Text.Equals("0123"))
                    {
                        t.Enabled = true;
                        CoilJustReadPanel.b = true;
                        textBox1.Text = "";
                        this.Close();
                    }
                    else
                    {
                        b = false;
                        if (MessageBox.Show("密码错误", "密码错误", MessageBoxButtons.OK) == DialogResult.OK)
                        {
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
    }
}
