﻿
namespace FirstWindow
{
    partial class FirstWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            try
            {
                base.Dispose(disposing);
            }
            catch (System.Exception)
            {
            }
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.端口连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.端口断开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.端口参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数文件修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数数量TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.参数信息修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.状态数量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态数量TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.状态地址修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.按钮数量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按钮数量TextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.按钮地址修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.辅助信息修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.窗口大小设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件重启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(20, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.权限ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 连接ToolStripMenuItem
            // 
            this.连接ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.端口连接ToolStripMenuItem,
            this.端口断开ToolStripMenuItem,
            this.toolStripSeparator2,
            this.端口参数设置ToolStripMenuItem});
            this.连接ToolStripMenuItem.Name = "连接ToolStripMenuItem";
            this.连接ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.连接ToolStripMenuItem.Text = "端口";
            // 
            // 端口连接ToolStripMenuItem
            // 
            this.端口连接ToolStripMenuItem.Name = "端口连接ToolStripMenuItem";
            this.端口连接ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.端口连接ToolStripMenuItem.Text = "连接";
            this.端口连接ToolStripMenuItem.Click += new System.EventHandler(this.端口连接ToolStripMenuItem_Click);
            // 
            // 端口断开ToolStripMenuItem
            // 
            this.端口断开ToolStripMenuItem.Name = "端口断开ToolStripMenuItem";
            this.端口断开ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.端口断开ToolStripMenuItem.Text = "断开";
            this.端口断开ToolStripMenuItem.Click += new System.EventHandler(this.端口断开ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // 端口参数设置ToolStripMenuItem
            // 
            this.端口参数设置ToolStripMenuItem.Name = "端口参数设置ToolStripMenuItem";
            this.端口参数设置ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.端口参数设置ToolStripMenuItem.Text = "端口参数设置";
            this.端口参数设置ToolStripMenuItem.Click += new System.EventHandler(this.端口参数设置ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.参数文件修改ToolStripMenuItem,
            this.参数信息修改ToolStripMenuItem,
            this.toolStripSeparator4,
            this.状态数量ToolStripMenuItem,
            this.状态地址修改ToolStripMenuItem,
            this.toolStripSeparator1,
            this.按钮数量ToolStripMenuItem,
            this.按钮地址修改ToolStripMenuItem,
            this.toolStripSeparator5,
            this.辅助信息修改ToolStripMenuItem,
            this.toolStripSeparator3,
            this.窗口大小设置ToolStripMenuItem,
            this.软件重启ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 参数文件修改ToolStripMenuItem
            // 
            this.参数文件修改ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.参数数量TextBox});
            this.参数文件修改ToolStripMenuItem.Name = "参数文件修改ToolStripMenuItem";
            this.参数文件修改ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.参数文件修改ToolStripMenuItem.Text = "参数数量";
            this.参数文件修改ToolStripMenuItem.DropDownOpening += new System.EventHandler(this.参数数量修改ToolStripMenuItem_DropDownOpening);
            // 
            // 参数数量TextBox
            // 
            this.参数数量TextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.参数数量TextBox.Name = "参数数量TextBox";
            this.参数数量TextBox.Size = new System.Drawing.Size(25, 23);
            this.参数数量TextBox.Text = "0";
            this.参数数量TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyUp);
            // 
            // 参数信息修改ToolStripMenuItem
            // 
            this.参数信息修改ToolStripMenuItem.Name = "参数信息修改ToolStripMenuItem";
            this.参数信息修改ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.参数信息修改ToolStripMenuItem.Text = "参数地址修改";
            this.参数信息修改ToolStripMenuItem.Click += new System.EventHandler(this.参数信息修改ToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(159, 6);
            // 
            // 状态数量ToolStripMenuItem
            // 
            this.状态数量ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态数量TextBox});
            this.状态数量ToolStripMenuItem.Name = "状态数量ToolStripMenuItem";
            this.状态数量ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.状态数量ToolStripMenuItem.Text = "状态数量";
            this.状态数量ToolStripMenuItem.DropDownOpening += new System.EventHandler(this.状态数量ToolStripMenuItem_DropDownOpening);
            // 
            // 状态数量TextBox
            // 
            this.状态数量TextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.状态数量TextBox.Name = "状态数量TextBox";
            this.状态数量TextBox.Size = new System.Drawing.Size(25, 23);
            this.状态数量TextBox.Text = "0";
            this.状态数量TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.状态数量toolStripTextBox2_KeyUp);
            // 
            // 状态地址修改ToolStripMenuItem
            // 
            this.状态地址修改ToolStripMenuItem.Name = "状态地址修改ToolStripMenuItem";
            this.状态地址修改ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.状态地址修改ToolStripMenuItem.Text = "状态地址修改";
            this.状态地址修改ToolStripMenuItem.Click += new System.EventHandler(this.状态地址修改ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // 按钮数量ToolStripMenuItem
            // 
            this.按钮数量ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按钮数量TextBox1});
            this.按钮数量ToolStripMenuItem.Name = "按钮数量ToolStripMenuItem";
            this.按钮数量ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.按钮数量ToolStripMenuItem.Text = "按钮数量";
            this.按钮数量ToolStripMenuItem.DropDownOpening += new System.EventHandler(this.按钮数量ToolStripMenuItem_DropDownOpening);
            // 
            // 按钮数量TextBox1
            // 
            this.按钮数量TextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.按钮数量TextBox1.Name = "按钮数量TextBox1";
            this.按钮数量TextBox1.Size = new System.Drawing.Size(25, 23);
            this.按钮数量TextBox1.Text = "0";
            this.按钮数量TextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.按钮数量TextBox1_KeyUp);
            // 
            // 按钮地址修改ToolStripMenuItem
            // 
            this.按钮地址修改ToolStripMenuItem.Name = "按钮地址修改ToolStripMenuItem";
            this.按钮地址修改ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.按钮地址修改ToolStripMenuItem.Text = "按钮地址修改";
            this.按钮地址修改ToolStripMenuItem.Click += new System.EventHandler(this.按钮地址修改ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(159, 6);
            // 
            // 辅助信息修改ToolStripMenuItem
            // 
            this.辅助信息修改ToolStripMenuItem.Name = "辅助信息修改ToolStripMenuItem";
            this.辅助信息修改ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.辅助信息修改ToolStripMenuItem.Text = "辅助信息修改";
            this.辅助信息修改ToolStripMenuItem.Click += new System.EventHandler(this.辅助信息修改ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(159, 6);
            // 
            // 窗口大小设置ToolStripMenuItem
            // 
            this.窗口大小设置ToolStripMenuItem.Name = "窗口大小设置ToolStripMenuItem";
            this.窗口大小设置ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.窗口大小设置ToolStripMenuItem.Text = "窗口大小设置";
            this.窗口大小设置ToolStripMenuItem.Click += new System.EventHandler(this.窗口大小设置ToolStripMenuItem_Click);
            // 
            // 软件重启ToolStripMenuItem
            // 
            this.软件重启ToolStripMenuItem.Name = "软件重启ToolStripMenuItem";
            this.软件重启ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.软件重启ToolStripMenuItem.Text = "软件重启";
            this.软件重启ToolStripMenuItem.Click += new System.EventHandler(this.软件重启ToolStripMenuItem_Click);
            // 
            // 权限ToolStripMenuItem
            // 
            this.权限ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登入ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.权限ToolStripMenuItem.Name = "权限ToolStripMenuItem";
            this.权限ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.权限ToolStripMenuItem.Text = "权限";
            // 
            // 登入ToolStripMenuItem
            // 
            this.登入ToolStripMenuItem.Name = "登入ToolStripMenuItem";
            this.登入ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.登入ToolStripMenuItem.Text = "登入";
            this.登入ToolStripMenuItem.Click += new System.EventHandler(this.登入ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "COM端口未连接";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(500, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 50);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "状态";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(500, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 106);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "按钮";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(54, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 46);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // FirstWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FirstWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数文件修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox 参数数量TextBox;
        private System.Windows.Forms.ToolStripMenuItem 参数信息修改ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 窗口大小设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 端口连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 端口断开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 端口参数设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 权限ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 辅助信息修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 软件重启ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 状态数量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox 状态数量TextBox;
        private System.Windows.Forms.ToolStripMenuItem 状态地址修改ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem 按钮数量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox 按钮数量TextBox1;
        private System.Windows.Forms.ToolStripMenuItem 按钮地址修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Panel panel1;
    }
}

