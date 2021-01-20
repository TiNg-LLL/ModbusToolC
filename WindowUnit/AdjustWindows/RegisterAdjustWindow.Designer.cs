
namespace WindowUnit
{
    partial class RegisterAdjustWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterAdjustWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisterNamelabel = new System.Windows.Forms.Label();
            this.RegisterWritelabel = new System.Windows.Forms.Label();
            this.RegisterReadlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mmlabel1 = new System.Windows.Forms.Label();
            this.只读label2 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(424, 181);
            this.panel1.TabIndex = 0;
            // 
            // RegisterNamelabel
            // 
            this.RegisterNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterNamelabel.AutoSize = true;
            this.RegisterNamelabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegisterNamelabel.Location = new System.Drawing.Point(25, 5);
            this.RegisterNamelabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.RegisterNamelabel.Name = "RegisterNamelabel";
            this.RegisterNamelabel.Size = new System.Drawing.Size(74, 21);
            this.RegisterNamelabel.TabIndex = 1;
            this.RegisterNamelabel.Text = "参数名称";
            this.RegisterNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterWritelabel
            // 
            this.RegisterWritelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterWritelabel.AutoSize = true;
            this.RegisterWritelabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegisterWritelabel.Location = new System.Drawing.Point(115, 5);
            this.RegisterWritelabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.RegisterWritelabel.Name = "RegisterWritelabel";
            this.RegisterWritelabel.Size = new System.Drawing.Size(74, 21);
            this.RegisterWritelabel.TabIndex = 2;
            this.RegisterWritelabel.Text = "写入地址";
            this.RegisterWritelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterReadlabel
            // 
            this.RegisterReadlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterReadlabel.AutoSize = true;
            this.RegisterReadlabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegisterReadlabel.Location = new System.Drawing.Point(192, 5);
            this.RegisterReadlabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.RegisterReadlabel.Name = "RegisterReadlabel";
            this.RegisterReadlabel.Size = new System.Drawing.Size(74, 21);
            this.RegisterReadlabel.TabIndex = 3;
            this.RegisterReadlabel.Text = "读取地址";
            this.RegisterReadlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(111, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "应用";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(233, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mmlabel1
            // 
            this.mmlabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mmlabel1.AutoSize = true;
            this.mmlabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mmlabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mmlabel1.Location = new System.Drawing.Point(265, 5);
            this.mmlabel1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.mmlabel1.Name = "mmlabel1";
            this.mmlabel1.Size = new System.Drawing.Size(47, 21);
            this.mmlabel1.TabIndex = 6;
            this.mmlabel1.Text = "/mm";
            this.mmlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mmlabel1.Click += new System.EventHandler(this.mmlabel1_Click);
            // 
            // 只读label2
            // 
            this.只读label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.只读label2.AutoSize = true;
            this.只读label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.只读label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.只读label2.Location = new System.Drawing.Point(314, 5);
            this.只读label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.只读label2.Name = "只读label2";
            this.只读label2.Size = new System.Drawing.Size(42, 21);
            this.只读label2.TabIndex = 7;
            this.只读label2.Text = "只读";
            this.只读label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.只读label2.Click += new System.EventHandler(this.只读label2_Click);
            // 
            // 隐藏label3
            // 
            this.隐藏label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.隐藏label3.AutoSize = true;
            this.隐藏label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.隐藏label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.隐藏label3.Location = new System.Drawing.Point(365, 5);
            this.隐藏label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.隐藏label3.Name = "隐藏label3";
            this.隐藏label3.Size = new System.Drawing.Size(42, 21);
            this.隐藏label3.TabIndex = 8;
            this.隐藏label3.Text = "隐藏";
            this.隐藏label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.隐藏label3.Click += new System.EventHandler(this.隐藏label3_Click);
            // 
            // RegisterAdjustWindow
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.隐藏label3);
            this.Controls.Add(this.只读label2);
            this.Controls.Add(this.mmlabel1);
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
            this.Name = "RegisterAdjustWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 30, 5, 50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "参数设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RegisterNamelabel;
        private System.Windows.Forms.Label RegisterWritelabel;
        private System.Windows.Forms.Label RegisterReadlabel;
        public  System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label mmlabel1;
        private System.Windows.Forms.Label 只读label2;
        private System.Windows.Forms.Label 隐藏label3;
    }
}

