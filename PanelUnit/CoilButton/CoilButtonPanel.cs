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
        public CoilButtonPanel(int ID)
        {
            InitializeComponent();
            //设置ID
            this.ID = ID;
            this.ucBtnExt1.lbl.MouseUp += new MouseEventHandler(this.ucBtnExt1_MouseUp);
            //从非 UI 线程更新 UI 线程  线程不安全
            CheckForIllegalCrossThreadCalls = false;
        }

        private void ucBtnExt1_MouseUp(object sender, MouseEventArgs e)
        {
            if (COMFunc.serialPort.IsOpen)
            {
                ModbusFunc.MyWriteSingleCoil(DataTreat.CoilMXYAddressTransform(coilButtonWriteAddress, coilButtonWriteMXYAddress), !(nowValue));
            }
        }
    }
}
