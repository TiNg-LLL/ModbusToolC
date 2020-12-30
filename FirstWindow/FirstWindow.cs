using PanelCollection;
using System.IO;
using System.Windows.Forms;
using WindowUnit;
using Func;
using System;

namespace FirstWindow
{
    public partial class FirstWindow : Form
    {
        //寄存器功能模块
        public static RegisterCollection resgisterCollection = new RegisterCollection();

        //参数信息设置副窗口
        private RegisterAdjustWindow registerAdjustWindow = new RegisterAdjustWindow();

        //窗口大小调整副窗口
        private SizeAdjustWindow sizeAdjustWindow = new SizeAdjustWindow();

        //初始化INI文件地址
        private static string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";
        private static string filenameSystemDate = Directory.GetCurrentDirectory() + @"\SystemDate.ini";


        //获取窗口大小参数
        public static int width = int.Parse(IniFunc.getString("FirstWindowSize", "width", "800", filenameSystemDate));
        public static int height = int.Parse(IniFunc.getString("FirstWindowSize", "Height", "400", filenameSystemDate));

        public FirstWindow()
        {
            InitializeComponent();
            //添加resgisterCollection
            this.ClientSize = new System.Drawing.Size(width,height);
            this.groupBox1.Controls.Add(resgisterCollection = new RegisterCollection());
        }
        //参数信息修改显示窗口按钮
        private void 参数信息修改ToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            //参数信息列表刷新
            RegisterAdjustWindow.registerAdjustCollection.Flash();
            registerAdjustWindow.Flash();
            //窗口显示
            registerAdjustWindow.ShowDialog();
        }
        //参数数量修改textbox
        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Enter)
            {
                IniFunc.writeString("RegisterAmount", "RegisterAmount", this.参数数量TextBox.Text, filename);
                resgisterCollection.Flash();
                Console.WriteLine("参数数量成功修改为" + 参数数量TextBox.Text);
            }
        }
        //参数数量修改鼠标放置动作
        private void 参数数量修改ToolStripMenuItem_DropDownOpening(object sender, System.EventArgs e)
        {
            //给toolStripTextBox1赋值
            this.参数数量TextBox.Text = RegisterCollection.registerAmount.ToString();
        }

        private void 窗口大小设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sizeAdjustWindow.ShowDialog();
        }
    }
}