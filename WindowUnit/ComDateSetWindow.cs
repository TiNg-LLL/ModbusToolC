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
            this.comboBox.SelectedItem = IniFunc.getString("COMDate", "COM", "读取错误", filenameSystemDate);
            //波特率数据添加
            this.baudRateBox.Items.AddRange(new String[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "43000", "56000", "57600", "115200" });
            this.baudRateBox.Text = IniFunc.getString("COMDate", "Baudrate", "读取错误", filenameSystemDate);
            //奇偶效验数据添加
            this.parityComboBox.Items.AddRange(new String[] { "偶", "奇", "无" });
            this.parityComboBox.SelectedItem = IniFunc.getString("COMDate", "Parity", "读取错误", filenameSystemDate);
            //读取数据位并设置
            this.startDateTextBox.Text = IniFunc.getString("COMDate", "StartDate", "读取错误", filenameSystemDate);
            //读取结束位并设置
            this.readTimeOutcomboBox.Items.AddRange(new String[] { "1", "1.5", "2" });
            this.readTimeOutcomboBox.Text = IniFunc.getString("COMDate", "StopDate", "读取错误", filenameSystemDate);
            //读取站号并设置
            this.slaveIDTextBox.Text = IniFunc.getString("COMDate", "SlaveID", "读取错误", filenameSystemDate);
            //读取超时时间
            this.readTimeoutTextBox.Text = IniFunc.getString("COMDate", "ReadTimeout", "读取错误", filenameSystemDate);
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
        //取消按钮
        //
        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //应用按钮
        //
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            //端口写入
            IniFunc.writeString("COMDate", "COM", this.comboBox.Text, filenameSystemDate);
            //波特率写入
            IniFunc.writeString("COMDate", "Baudrate", this.baudRateBox.Text, filenameSystemDate);
            //奇偶效验写入
            IniFunc.writeString("COMDate", "Parity", this.parityComboBox.Text, filenameSystemDate);
            //起始位写入
            IniFunc.writeString("COMDate", "StartDate", this.startDateTextBox.Text, filenameSystemDate);
            //结束位写入
            IniFunc.writeString("COMDate", "StopDate", this.readTimeOutcomboBox.Text, filenameSystemDate);
            //站号写入
            IniFunc.writeString("COMDate", "SlaveID", this.slaveIDTextBox.Text, filenameSystemDate);
            //超时时间写入
            IniFunc.writeString("COMDate", "ReadTimeout", this.readTimeoutTextBox.Text, filenameSystemDate);
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