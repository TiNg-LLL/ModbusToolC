using Func;
using PanelCollection;
using PanelCollection.CoilButton;
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

        //线圈只读状态灯模块
        public static CoilJustReadCollection coilJustReadCollection = new CoilJustReadCollection();

        //线圈按钮模块
        public static CoilButtonCollection coilButtonCollection = new CoilButtonCollection();

        //参数地址设置副窗口
        private RegisterAdjustWindow registerAdjustWindow = new RegisterAdjustWindow();

        //状态地址设置副窗口
        private CoilJustReadAdjustWindow coilJustReadAdjustWindow = new CoilJustReadAdjustWindow();

        //按钮地址设置副窗口
        private CoilButtonAdjustWindow coilButtonAdjustWindow = new CoilButtonAdjustWindow();

        //窗口大小调整副窗口
        private SizeAdjustWindow sizeAdjustWindow = new SizeAdjustWindow();

        //Com参数设置副窗口
        private ComDateSetWindow comDateSetWindow = new ComDateSetWindow();

        //权限登入副窗口
        private AdminWindow adminWindow;

        //辅助信息修改副窗口
        private AssistDateSetWindow assistDateSetWindow = new AssistDateSetWindow();

        //初始化INI文件地址
        private static string filenameSystemDate = Directory.GetCurrentDirectory() + @"\SystemDate.ini";
        private static string filenameRegister = Directory.GetCurrentDirectory() + @"\Resgiter.ini";
        private static string filenameCoilJustRead = Directory.GetCurrentDirectory() + @"\CoilJustRead.ini";
        private static string filenameButtonRead = Directory.GetCurrentDirectory() + @"\CoilButton.ini";

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
            this.groupBox1.Controls.Add(resgisterCollection);
            this.groupBox2.Location = new Point(this.groupBox1.Width + 50, 35);
            this.groupBox2.Controls.Add(coilJustReadCollection);
            this.groupBox3.Location = new Point(this.groupBox1.Width + 50, this.groupBox2.Location.Y + this.groupBox2.Height +20);
            this.groupBox3.Controls.Add(coilButtonCollection);
            this.groupBox3.Width = this.groupBox2.Width;
            this.groupBox3.Height = ((CoilButtonCollection.coilButtonAmount / 5)+1) * 62 + 23;
            threadFather = new ThreadFather();
            adminWindow = new AdminWindow(设置ToolStripMenuItem);
            设置ToolStripMenuItem.Enabled = false;
        }
        //***
        //参数地址修改显示副窗口按钮
        //***
        private void 参数信息修改ToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            //参数信息列表刷新
            RegisterAdjustWindow.registerAdjustCollection.Flash();
            registerAdjustWindow.Flash();
            //窗口显示
            registerAdjustWindow.ShowDialog();
        }
        //***
        //参数数量修改textbox
        //***
        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IniFunc.writeString("RegisterAmount", "RegisterAmount", this.参数数量TextBox.Text, filenameRegister);
                if (MessageBox.Show("需要重启软件才能生效，是否现在重启", "修改成功", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    //resgisterCollection.Flash();
                }
            }
        }
        //***
        //参数数量修改鼠标放置动作
        //***
        private void 参数数量修改ToolStripMenuItem_DropDownOpening(object sender, System.EventArgs e)
        {
            //给toolStripTextBox1赋值
            this.参数数量TextBox.Text = RegisterCollection.registerAmount.ToString();
        }
        //***
        //状态数量修改textbox
        //***
        private void 状态数量toolStripTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IniFunc.writeString("CoilJustReadAmount", "CoilJustReadAmount", this.状态数量TextBox.Text, filenameCoilJustRead);
                if (MessageBox.Show("需要重启软件才能生效，是否现在重启", "修改成功", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    //coilJustReadCollection.Flash();
                }
            }
        }
        //***
        //状态数量修改鼠标放置动作
        //***
        private void 状态数量ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            this.状态数量TextBox.Text = CoilJustReadCollection.coilJustReadAmount.ToString();
        }
        //***
        //按钮数量修改textbox
        //***
        private void 按钮数量TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IniFunc.writeString("CoilButtonAmount", "CoilButtonAmount", this.按钮数量TextBox1.Text, filenameButtonRead);
                if (MessageBox.Show("需要重启软件才能生效，是否现在重启", "修改成功", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    //coilJustReadCollection.Flash();
                }
            }
        }
        //按钮数量修改鼠标放置动作
        private void 按钮数量ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            this.按钮数量TextBox1.Text = CoilButtonCollection.coilButtonAmount.ToString();
        }
        //***
        //窗口大小设置副窗口按钮
        //***
        private void 窗口大小设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sizeAdjustWindow.ShowDialog();
        }
        //***
        //端口设置副窗口按钮
        //***
        private void 端口参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comDateSetWindow.ShowDialog();
        }
        //***
        //端口连接按钮
        //***
        private void 端口连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                comFunc.COMConnect();
            }
            catch (Exception)
            {
                this.toolStripStatusLabel1.Text = "COM端口被占用";
            }
            if (COMFunc.serialPort.IsOpen)
            {
                this.端口连接ToolStripMenuItem.Enabled = false;
                this.端口连接ToolStripMenuItem.Text = "已连接";
                this.statusStrip1.BackColor = SystemColors.HotTrack;
                this.toolStripStatusLabel1.Text = "COM端口已连接";
                this.toolStripStatusLabel1.ForeColor = Color.FromArgb(255, 255, 255);
                threadFather.ThreadStart();
            }
        }
        //***
        //端口断开按钮
        //***
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

        private void 登入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminWindow.ShowDialog();
        }

        private void 辅助信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assistDateSetWindow.ShowDialog();
        }

        private void 软件重启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否重启", "重启", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
        //***
        //状态地址修改副窗口显示
        //***
        private void 状态地址修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoilJustReadAdjustWindow.coilJustReadAdjustCollection.Flash();
            //coilJustReadAdjustWindow.Flash();
            coilJustReadAdjustWindow.ShowDialog();
        }
        //***
        //按钮地址修改副窗口显示
        //***
        private void 按钮地址修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoilButtonAdjustWindow.coilButtonAdjustCollection.Flash();
            //coilButtonAdjustWindow.Flash();
            coilButtonAdjustWindow.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            设置ToolStripMenuItem.Enabled = false;
        }
    }
}