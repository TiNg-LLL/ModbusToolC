using Func;
using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowUnit
{
    public partial class ComDateSetWindow : Form
    {
        //new出端口功能对象
        private SerialPort serialport = new SerialPort();
        //初始化INI文件地址
        private static string filenameSystemDate = Directory.GetCurrentDirectory() + @"\SystemDate.ini";
        //COM口数组
        private String[] com;

        public ComDateSetWindow()
        {
            InitializeComponent();
            //获取com端口数组
            com = SerialPort.GetPortNames();
            Array.Sort(com, new CustomComparer()); //排序
            //com下拉添加
            this.comboBox.Items.AddRange(com);
            this.comboBox.SelectedItem = Func.COMFunc.GetCOM();
            //波特率数据添加
            this.baudRateBox.Items.AddRange(new String[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "43000", "56000", "57600", "115200" });
            this.baudRateBox.Text = Func.COMFunc.GetBaudrate();

            this.parityComboBox.Items.AddRange(new String[] { "偶", "奇", "无" });
            this.parityComboBox.SelectedItem = Func.COMFunc.GetParity();

            //读取数据位并设置
            this.startDateTextBox.Text = Func.COMFunc.GetStartDate();

            //读取结束位并设置
            this.stopDatecomboBox.Items.AddRange(new String[] { "1", "1.5", "2" });
            this.stopDatecomboBox.Text = Func.COMFunc.GetStopDate();

            //读取站号并设置
            this.slaveIDTextBox.Text = Func.COMFunc.GetSlaveID();

            //读取超时时间
            this.readTimeoutTextBox.Text = Func.COMFunc.GetReadTimeout();
        }
        //
        //COM列表 点击时刷新
        //
        private void comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            com = SerialPort.GetPortNames();
            Array.Sort(com, new CustomComparer()); //排序
            String s = null;
            if (!(comboBox.SelectedItem == null))
            {
                s = this.comboBox.SelectedItem.ToString();
            }
            this.comboBox.Items.Clear();
            this.comboBox.Items.AddRange(com);
            if (s == null)
            {
                this.comboBox.SelectedIndex = 0;
            }
            else
            {
                this.comboBox.SelectedItem = s;
            }
        }
        //
        //应用按钮
        //
        private void button1_Click(object sender, EventArgs e)
        {
            ////端口写入
            //IniFunc.writeString("COMDate", "COM", this.comboBox.Text, filenameSystemDate);
            ////波特率写入
            //IniFunc.writeString("COMDate", "Baudrate", this.baudRateBox.Text, filenameSystemDate);
            ////奇偶效验写入
            //IniFunc.writeString("COMDate", "Parity", this.parityComboBox.Text, filenameSystemDate);
            ////起始位写入
            //IniFunc.writeString("COMDate", "StartDate", this.startDateTextBox.Text, filenameSystemDate);
            ////结束位写入
            //IniFunc.writeString("COMDate", "StopDate", this.readTimeOutcomboBox.Text, filenameSystemDate);
            ////站号写入
            //IniFunc.writeString("COMDate", "SlaveID", this.slaveIDTextBox.Text, filenameSystemDate);
            ////超时时间写入
            //IniFunc.writeString("COMDate", "ReadTimeout", this.readTimeoutTextBox.Text, filenameSystemDate);

            //端口写入
            Func.COMFunc.SetCOM(this.comboBox.Text);
            //波特率写入
            Func.COMFunc.SetBaudrate(this.baudRateBox.Text);
            //奇偶效验写入
            Func.COMFunc.SetParity(this.parityComboBox.Text);
            //起始位写入
            Func.COMFunc.SetStartDate(this.startDateTextBox.Text);
            //结束位写入
            Func.COMFunc.SetReadTimeout(this.stopDatecomboBox.Text);
            //站号写入
            Func.COMFunc.SetSlaveID(this.slaveIDTextBox.Text);
            //超时时间写入
            Func.COMFunc.SetReadTimeout(this.readTimeoutTextBox.Text);
            if (COMFunc.serialPort.IsOpen)
            {
                if (MessageBox.Show("端口现已是连接状态，需要断开后重新连接，修改才能生效", "修改已保存", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        //
        //取消按钮
        //
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    //COM口排序类
    public class CustomComparer : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            if (s1.Length > s2.Length) return 1;
            if (s1.Length < s2.Length) return -1;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] > s2[i]) return 1;
                if (s1[i] < s2[i]) return -1;
            }
            return 0;
        }
    }
}