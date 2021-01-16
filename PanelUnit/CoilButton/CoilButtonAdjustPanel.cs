using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelUnit
{
    public partial class CoilButtonAdjustPanel : UserControl
    {
        //标识特征
        public int ID { get; set; }

        public CoilButtonAdjustPanel()
        {
            InitializeComponent();
            this.coilButtonReadcomboBox.Items.AddRange(new String[] { "M", "X", "Y" });
            this.coilButtonWritecomboBox.Items.AddRange(new String[] { "M", "X", "Y" });
        }

        //输入框只能填写数字
        private void textBoxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //空格建使读取写入地址一致
        private void coilButtonWriteTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.coilButtonReadtextBox.Text = this.coilButtonWriteTextBox.Text;
                this.coilButtonReadcomboBox.Text = this.coilButtonWritecomboBox.Text;
            }
        }
        //空格建使读取写入地址一致
        private void coilButtonReadtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.coilButtonWriteTextBox.Text = this.coilButtonReadtextBox.Text;
                this.coilButtonWritecomboBox.Text = this.coilButtonReadcomboBox.Text;
            }
        }
    }
}
