
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
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数文件修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数数量TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.参数信息修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.窗口大小设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.参数文件修改ToolStripMenuItem,
            this.参数信息修改ToolStripMenuItem,
            this.toolStripSeparator1,
            this.窗口大小设置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 参数文件修改ToolStripMenuItem
            // 
            this.参数文件修改ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.参数数量TextBox});
            this.参数文件修改ToolStripMenuItem.Name = "参数文件修改ToolStripMenuItem";
            this.参数文件修改ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
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
            this.参数信息修改ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.参数信息修改ToolStripMenuItem.Text = "参数信息修改";
            this.参数信息修改ToolStripMenuItem.Click += new System.EventHandler(this.参数信息修改ToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // 窗口大小设置ToolStripMenuItem
            // 
            this.窗口大小设置ToolStripMenuItem.Name = "窗口大小设置ToolStripMenuItem";
            this.窗口大小设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.窗口大小设置ToolStripMenuItem.Text = "窗口大小设置";
            this.窗口大小设置ToolStripMenuItem.Click += new System.EventHandler(this.窗口大小设置ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FirstWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FirstWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

