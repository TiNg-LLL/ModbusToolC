using Func;
using PanelCollection;
using PanelCollection.CoilButton;
using System.IO;
using System.Windows.Forms;

namespace WindowUnit
{
    public partial class CoilButtonAdjustWindow : Form
    {
        //new出寄存器地址修改组合模块
        public static CoilButtonAdjustCollection coilButtonAdjustCollection = new CoilButtonAdjustCollection();

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\CoilButton.ini";

        public CoilButtonAdjustWindow()
        {
            InitializeComponent();
            //添加registerNameAdjustCollection
            this.panel1.Controls.Add(coilButtonAdjustCollection);
        }

        //寄存器参数设置应用按钮
        private void button1_Click(object sender, System.EventArgs e)
        {
            //参数刷新
            for (int i = 1; i <= CoilButtonCollection.coilButtonAmount; i++)
            {
                //***
                //名称ini文件刷新
                IniFunc.writeString("CoilButtonName", "CoilButtonName" + i, CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].coilButtonTextBox1.Text, filename);
                //名称对象刷新
                CoilButtonCollection.coilButtonList[i - 1].ucBtnExt1.lbl.Text = IniFunc.getString("CoilButtonName", "CoilButtonName" + i, "读取错误", filename);
                //***
                //读取地址
                //***
                //读取地址ini文件刷新
                IniFunc.writeString("CoilButtonReadAddress", "CoilButtonReadAddress" + i, CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].coilButtonReadtextBox.Text, filename);
                //读取地址对象刷新
                CoilButtonCollection.coilButtonList[i - 1].coilButtonReadAddress = int.Parse(IniFunc.getString("CoilButtonReadAddress", "CoilButtonReadAddress" + i, "0", filename));
                //读取MXY地址ini文件刷新
                IniFunc.writeString("CoilButtonReadMXYAddress", "CoilButtonReadMXYAddress" + i, CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].coilButtonReadcomboBox.Text, filename);
                //读取MXY地址对象刷新
                CoilButtonCollection.coilButtonList[i - 1].coilButtonReadMXYAddress = IniFunc.getString("CoilButtonReadMXYAddress", "CoilButtonReadMXYAddress" + i, "M", filename);
                //***
                //写入地址
                //***
                //写入地址ini文件刷新
                IniFunc.writeString("CoilButtonWriteAddress", "CoilButtonWriteAddress" + i, CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].coilButtonWriteTextBox.Text, filename);
                //写入地址对象刷新
                CoilButtonCollection.coilButtonList[i - 1].coilButtonWriteAddress = int.Parse(IniFunc.getString("CoilButtonWriteAddress", "CoilButtonWriteAddress" + i, "0", filename));
                //写入MXY地址ini文件刷新
                IniFunc.writeString("CoilButtonWriteMXYAddress", "CoilButtonWriteMXYAddress" + i, CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].coilButtonWritecomboBox.Text, filename);
                //写入MXY地址对象刷新
                CoilButtonCollection.coilButtonList[i - 1].coilButtonWriteMXYAddress = IniFunc.getString("CoilButtonWriteMXYAddress", "CoilButtonWriteMXYAddress" + i, "M", filename);
                //***
                //点动切换
                //***
                if (CoilButtonAdjustCollection.coilButtonAdjustList[i - 1].radioButton1.Checked)
                {
                    IniFunc.writeString("CoilButtonTransform", "CoilButtonTransform" + i, "true", filename);
                    CoilButtonCollection.coilButtonList[i - 1].coilButtonTransform = bool.Parse(IniFunc.getString("CoilButtonTransform", "CoilButtonTransform" + i, "false", filename));
                }
                else
                {
                    IniFunc.writeString("CoilButtonTransform", "CoilButtonTransform" + i, "false", filename);
                    CoilButtonCollection.coilButtonList[i - 1].coilButtonTransform = bool.Parse(IniFunc.getString("CoilButtonTransform", "CoilButtonTransform" + i, "false", filename));
                }
            }
            //设置窗口关闭
            this.Close();
        }
        //取消按钮
        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        //***
        //窗口内容刷新
        //***
        public void Flash()
        {
            this.Controls.Clear();
            InitializeComponent();
            this.panel1.Controls.Add(coilButtonAdjustCollection);
        }
    }
}