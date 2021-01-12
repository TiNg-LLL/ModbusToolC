
namespace PanelUnit
{
    partial class CoilJustReadAdjustPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.coilJustReadTextBox2 = new System.Windows.Forms.TextBox();
            this.coilJustReadTextBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.coilJustReadTextBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.coilJustReadTextBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // coilJustReadTextBox2
            // 
            this.coilJustReadTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.coilJustReadTextBox2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coilJustReadTextBox2.Location = new System.Drawing.Point(109, 3);
            this.coilJustReadTextBox2.Name = "coilJustReadTextBox2";
            this.coilJustReadTextBox2.Size = new System.Drawing.Size(70, 23);
            this.coilJustReadTextBox2.TabIndex = 2;
            // 
            // coilJustReadTextBox1
            // 
            this.coilJustReadTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.coilJustReadTextBox1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coilJustReadTextBox1.Location = new System.Drawing.Point(3, 3);
            this.coilJustReadTextBox1.Name = "coilJustReadTextBox1";
            this.coilJustReadTextBox1.Size = new System.Drawing.Size(100, 23);
            this.coilJustReadTextBox1.TabIndex = 1;
            // 
            // CoilJustReadAdjustPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CoilJustReadAdjustPanel";
            this.Size = new System.Drawing.Size(180, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox coilJustReadTextBox2;
        public System.Windows.Forms.TextBox coilJustReadTextBox1;

        #endregion
    }
}
