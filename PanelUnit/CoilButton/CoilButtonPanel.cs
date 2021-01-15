using Func;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelUnit.CoilButton
{
    public partial class CoilButtonPanel : UserControl
    {
        //标识特征
        public int ID { get; set; }
        //modbus参数成员
        public int coilButtonWriteAddress { get; set; }
        public string coilButtonWriteMXYAddress { get; set; }
        public int coilButtonReadAddress { get; set; }
        public string coilButtonReadMXYAddress { get; set; }
        public bool nowValue { get; set; }
        public bool coilButtonTransform { get; set; }
        //辅助成员
        private bool b;
        private bool c = true;
        private bool d;
        Timer timer = new Timer();  //点动防快速点击

        public CoilButtonPanel(int ID)
        {
            InitializeComponent();
            //设置ID
            this.ID = ID;
            this.ucBtnExt1.lbl.MouseUp += new MouseEventHandler(this.ucBtnExt1_MouseUp);
            this.ucBtnExt1.lbl.MouseDown += new MouseEventHandler(this.ucBtnExt1_MouseDown);
            timer.Interval = 350;
            timer.Tick += new System.EventHandler(this.timer_Tick);
            timer.Enabled = false;
            //从非 UI 线程更新 UI 线程  线程不安全
            CheckForIllegalCrossThreadCalls = false;
        }
        //鼠标按下
        private void ucBtnExt1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  //判断鼠标左键
            {
                if (COMFunc.serialPort.IsOpen)
                {
                    if (coilButtonTransform)
                    {
                        if (c)
                        {
                            b = nowValue;
                            c = false;
                            d = true;
                            ModbusFunc.MyWriteSingleCoil(DataTreat.CoilMXYAddressTransform(coilButtonWriteAddress, coilButtonWriteMXYAddress), !(nowValue));
                        }
                        else
                        {
                        }
                    }
                }
            }
        }
        //鼠标抬起
        private void ucBtnExt1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  //判断鼠标左键
            {
                if (COMFunc.serialPort.IsOpen)
                {
                    if (coilButtonTransform)
                    {
                        if (d)
                        {
                            ModbusFunc.MyWriteSingleCoil(DataTreat.CoilMXYAddressTransform(coilButtonWriteAddress, coilButtonWriteMXYAddress), b);
                            d = false;
                            timer.Enabled = true;
                        }
                    }
                    else
                    {
                        ModbusFunc.MyWriteSingleCoil(DataTreat.CoilMXYAddressTransform(coilButtonWriteAddress, coilButtonWriteMXYAddress), !(nowValue));
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (COMFunc.serialPort.IsOpen)
                {
                    ModbusFunc.MyWriteSingleCoil(DataTreat.CoilMXYAddressTransform(coilButtonWriteAddress, coilButtonWriteMXYAddress), !(nowValue));
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            c = true;
            d = false;
            timer.Enabled = false;
            //Console.WriteLine("123");
        }
    }
}
