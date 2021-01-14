
using System.Windows.Forms;

namespace PanelUnit
{
    partial class CoilButtonAdjustPanel
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
            this.coilButtonTextBox1 = new System.Windows.Forms.TextBox();
            this.coilButtonWriteTextBox = new System.Windows.Forms.TextBox();
            this.coilButtonReadcomboBox = new System.Windows.Forms.ComboBox();
            this.coilButtonWritecomboBox = new System.Windows.Forms.ComboBox();
            this.coilButtonReadtextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.coilButtonWritecomboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.coilButtonTextBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.coilButtonWriteTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.coilButtonReadtextBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.coilButtonReadcomboBox, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // coilButtonTextBox1
            // 
            this.coilButtonTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.coilButtonTextBox1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coilButtonTextBox1.Location = new System.Drawing.Point(3, 3);
            this.coilButtonTextBox1.Name = "coilButtonTextBox1";
            this.coilButtonTextBox1.Size = new System.Drawing.Size(100, 23);
            this.coilButtonTextBox1.TabIndex = 1;
            // 
            // coilButtonWriteTextBox
            // 
            this.coilButtonWriteTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.coilButtonWriteTextBox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coilButtonWriteTextBox.Location = new System.Drawing.Point(155, 3);
            this.coilButtonWriteTextBox.Name = "coilButtonWriteTextBox";
            this.coilButtonWriteTextBox.Size = new System.Drawing.Size(70, 23);
            this.coilButtonWriteTextBox.TabIndex = 2;
            this.coilButtonWriteTextBox.KeyPress += new KeyPressEventHandler(this.textBoxText_KeyPress);
            this.coilButtonWriteTextBox.KeyUp += new KeyEventHandler(this.coilButtonWriteTextBox_KeyUp);
            // 
            // coilButtonReadcomboBox
            // 
            this.coilButtonReadcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.coilButtonReadcomboBox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coilButtonReadcomboBox.FormattingEnabled = true;
            this.coilButtonReadcomboBox.Location = new System.Drawing.Point(231, 4);
            this.coilButtonReadcomboBox.Name = "coilButtonReadcomboBox";
            this.coilButtonReadcomboBox.Size = new System.Drawing.Size(40, 21);
            this.coilButtonReadcomboBox.TabIndex = 3;
            // 
            // coilButtonWritecomboBox
            // 
            this.coilButtonWritecomboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.coilButtonWritecomboBox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coilButtonWritecomboBox.FormattingEnabled = true;
            this.coilButtonWritecomboBox.Location = new System.Drawing.Point(109, 4);
            this.coilButtonWritecomboBox.Name = "coilButtonWritecomboBox";
            this.coilButtonWritecomboBox.Size = new System.Drawing.Size(40, 21);
            this.coilButtonWritecomboBox.TabIndex = 4;
            // 
            // coilButtonReadtextBox
            // 
            this.coilButtonReadtextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.coilButtonReadtextBox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coilButtonReadtextBox.Location = new System.Drawing.Point(277, 3);
            this.coilButtonReadtextBox.Name = "coilButtonReadtextBox";
            this.coilButtonReadtextBox.Size = new System.Drawing.Size(70, 23);
            this.coilButtonReadtextBox.TabIndex = 5;
            this.coilButtonReadtextBox.KeyPress += new KeyPressEventHandler(this.textBoxText_KeyPress);
            this.coilButtonReadtextBox.KeyUp += new KeyEventHandler(this.coilButtonReadtextBox_KeyUp);
            // 
            // CoilButtonAdjustPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CoilButtonAdjustPanel";
            this.Size = new System.Drawing.Size(350, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }
        //输入框只能填写数字
        private void textBoxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //空格建使读取写入地址一致
        private void coilButtonWriteTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.coilButtonReadtextBox.Text = this.coilButtonWriteTextBox.Text;
                this.coilButtonReadcomboBox.Text = this.coilButtonWritecomboBox.Text;
            }
        }
        //空格建使读取写入地址一致
        private void coilButtonReadtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.coilButtonWriteTextBox.Text = this.coilButtonReadtextBox.Text;
                this.coilButtonWritecomboBox.Text = this.coilButtonReadcomboBox.Text;
            }
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox coilButtonWriteTextBox;
        public System.Windows.Forms.TextBox coilButtonTextBox1;
        public System.Windows.Forms.ComboBox coilButtonReadcomboBox;

        #endregion

        public System.Windows.Forms.ComboBox coilButtonWritecomboBox;
        public System.Windows.Forms.TextBox coilButtonReadtextBox;
    }
}
