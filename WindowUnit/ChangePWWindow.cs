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
    public partial class ChangePWWindow : Form
    {
        public ChangePWWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(Func.DES.DESDecrypt(Properties.Settings.Default.password)))
            {
                if (textBox2.Text.Equals(textBox3.Text) && !(textBox2.Text == ""))
                {
                    Properties.Settings.Default.password = Func.DES.DESEncrypt(textBox2.Text);
                    Properties.Settings.Default.Save();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    this.Close();
                }
            }
            else
            {
                textBox1.Text = "";
            }
        }
    }
}
