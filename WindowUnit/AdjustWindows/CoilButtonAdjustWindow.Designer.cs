﻿
namespace WindowUnit
{
    partial class CoilButtonAdjustWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoilButtonAdjustWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisterNamelabel = new System.Windows.Forms.Label();
            this.RegisterWritelabel = new System.Windows.Forms.Label();
            this.RegisterReadlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.点动label1 = new System.Windows.Forms.Label();
            this.切换label2 = new System.Windows.Forms.Label();
            this.隐藏label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 181);
            this.panel1.TabIndex = 0;
            // 
            // RegisterNamelabel
            // 
            this.RegisterNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterNamelabel.AutoSize = true;
            this.RegisterNamelabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegisterNamelabel.Location = new System.Drawing.Point(25, 5);
            this.RegisterNamelabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.RegisterNamelabel.Name = "RegisterNamelabel";
            this.RegisterNamelabel.Size = new System.Drawing.Size(74, 22);
            this.RegisterNamelabel.TabIndex = 1;
            this.RegisterNamelabel.Text = "参数名称";
            this.RegisterNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterWritelabel
            // 
            this.RegisterWritelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterWritelabel.AutoSize = true;
            this.RegisterWritelabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegisterWritelabel.Location = new System.Drawing.Point(143, 5);
            this.RegisterWritelabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.RegisterWritelabel.Name = "RegisterWritelabel";
            this.RegisterWritelabel.Size = new System.Drawing.Size(74, 22);
            this.RegisterWritelabel.TabIndex = 2;
            this.RegisterWritelabel.Text = "写入地址";
            this.RegisterWritelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterReadlabel
            // 
            this.RegisterReadlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterReadlabel.AutoSize = true;
            this.RegisterReadlabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegisterReadlabel.Location = new System.Drawing.Point(260, 5);
            this.RegisterReadlabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.RegisterReadlabel.Name = "RegisterReadlabel";
            this.RegisterReadlabel.Size = new System.Drawing.Size(74, 22);
            this.RegisterReadlabel.TabIndex = 3;
            this.RegisterReadlabel.Text = "读取地址";
            this.RegisterReadlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(100, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "应用";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(359, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 点动label1
            // 
            this.点动label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.点动label1.AutoSize = true;
            this.点动label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.点动label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.点动label1.Location = new System.Drawing.Point(365, 5);
            this.点动label1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.点动label1.Name = "点动label1";
            this.点动label1.Size = new System.Drawing.Size(42, 22);
            this.点动label1.TabIndex = 6;
            this.点动label1.Text = "点动";
            this.点动label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.点动label1.Click += new System.EventHandler(this.点动label1_Click);
            // 
            // 切换label2
            // 
            this.切换label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.切换label2.AutoSize = true;
            this.切换label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.切换label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.切换label2.Location = new System.Drawing.Point(415, 5);
            this.切换label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.切换label2.Name = "切换label2";
            this.切换label2.Size = new System.Drawing.Size(42, 22);
            this.切换label2.TabIndex = 7;
            this.切换label2.Text = "切换";
            this.切换label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.切换label2.Click += new System.EventHandler(this.切换label2_Click);
            // 
            // 隐藏label3
            // 
            this.隐藏label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.隐藏label3.AutoSize = true;
            this.隐藏label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.隐藏label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.隐藏label3.Location = new System.Drawing.Point(460, 5);
            this.隐藏label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.隐藏label3.Name = "隐藏label3";
            this.隐藏label3.Size = new System.Drawing.Size(42, 22);
            this.隐藏label3.TabIndex = 8;
            this.隐藏label3.Text = "隐藏";
            this.隐藏label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.隐藏label3.Click += new System.EventHandler(this.隐藏label3_Click);
            // 
            // CoilButtonAdjustWindow
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(518, 261);
            this.Controls.Add(this.隐藏label3);
            this.Controls.Add(this.切换label2);
            this.Controls.Add(this.点动label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RegisterReadlabel);
            this.Controls.Add(this.RegisterWritelabel);
            this.Controls.Add(this.RegisterNamelabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CoilButtonAdjustWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 30, 5, 50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "按钮设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RegisterNamelabel;
        private System.Windows.Forms.Label RegisterWritelabel;
        private System.Windows.Forms.Label RegisterReadlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label 点动label1;
        private System.Windows.Forms.Label 切换label2;
        private System.Windows.Forms.Label 隐藏label3;
    }
}

