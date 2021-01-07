using Func;
using PanelCollection;
using ReadThreadSpace;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using WindowUnit;

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

        //Com参数设置副窗口
        private ComDateSetWindow comDateSetWindow = new ComDateSetWindow();

        //初始化INI文件地址
        private static string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";

        private static string filenameSystemDate = Directory.GetCurrentDirectory() + @"\SystemDate.ini";

        //获取窗口大小参数
        public static int width = int.Parse(IniFunc.getString("FirstWindowSize", "Width", "800", filenameSystemDate));
        public static int height = int.Parse(IniFunc.getString("FirstWindowSize", "Height", "400", filenameSystemDate));

        //COM端口功能
        COMFunc comFunc = new COMFunc();

        //线程的爸爸
        ThreadFather threadFather;

        public FirstWindow()
        {
            InitializeComponent();
            //添加resgisterCollection
            this.ClientSize = new System.Drawing.Size(width, height);
            this.groupBox1.Controls.Add(resgisterCollection = new RegisterCollection());
            threadFather = new ThreadFather();
            //threadFather.ThreadStop();
        }

        //参数信息修改显示副窗口按钮
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
                if (MessageBox.Show("需要重启软件，是否现在重启", "修改成功", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    //this.Close();
                    resgisterCollection.Flash();

                }
            }
        }

        //参数数量修改鼠标放置动作
        private void 参数数量修改ToolStripMenuItem_DropDownOpening(object sender, System.EventArgs e)
        {
            //给toolStripTextBox1赋值
            this.参数数量TextBox.Text = RegisterCollection.registerAmount.ToString();
        }
        //窗口大小设置副窗口按钮
        private void 窗口大小设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sizeAdjustWindow.ShowDialog();
        }
        //端口设置副窗口按钮
        private void 端口参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comDateSetWindow.ShowDialog();
        }
        //端口连接按钮
        private void 端口连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comFunc.COMConnect();
            this.端口连接ToolStripMenuItem.Enabled = false;
            this.端口连接ToolStripMenuItem.Text = "已连接";
            this.statusStrip1.BackColor = SystemColors.HotTrack;
            this.toolStripStatusLabel1.Text = "COM端口已连接";
            this.toolStripStatusLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            threadFather.ThreadStart();
        }
        //端口断开按钮
        private void 端口断开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comFunc.COMClose();
            this.端口连接ToolStripMenuItem.Enabled = true;
            this.端口连接ToolStripMenuItem.Text = "连接";
            this.statusStrip1.BackColor = SystemColors.ScrollBar;
            this.toolStripStatusLabel1.Text = "COM端口未连接";
            this.toolStripStatusLabel1.ForeColor = Color.FromArgb(0, 0, 0);
            threadFather.ThreadStop();
        }
    }
}