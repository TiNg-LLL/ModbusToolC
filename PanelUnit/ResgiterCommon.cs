using System;
using System.Drawing;
using System.Windows.Forms;

namespace PanelUnit
{
    public class ResgisterCommon : TableLayoutPanel
    {
        //成员
        private Label ResgisterName = new Label();
        private Label Resgistersign = new Label();
        private Label ResgisterValue = new Label();
        private TextBox ResgisterText = new TextBox();
        private Button ResgisterButton = new Button();

        //标识特征
        private int ID;

        //无参构造方法
        public ResgisterCommon()
        {
            //
            //Panel初始化
            //
            this.ColumnCount = 5;  //列数
            this.RowCount = 1;  //行数
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            this.ColumnStyles.Add(new ColumnStyle());
            this.ColumnStyles.Add(new ColumnStyle());
            this.Size = new Size(390, 35);
            //this.BackColor = Color.DarkGray;  //背景颜色
            //
            //添加成员
            //
            this.Controls.Add(this.ResgisterName, 0, 0);
            this.Controls.Add(this.Resgistersign, 1, 0);
            this.Controls.Add(this.ResgisterValue, 2, 0);
            this.Controls.Add(this.ResgisterText, 3, 0);
            this.Controls.Add(this.ResgisterButton, 4, 0);
            //
            // 名称
            //
            this.ResgisterName.AutoSize = true;
            this.ResgisterName.Dock = DockStyle.Fill;
            this.ResgisterName.TextAlign = ContentAlignment.MiddleRight;
            this.ResgisterName.Name = "ResgisterName";
            this.ResgisterName.TabIndex = 2;
            this.ResgisterName.Text = "初始代码段";
            this.ResgisterName.Font = new Font("微软雅黑", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            //this.ResgisterName.BackColor = Color.Red;  //背景颜色
            //
            // :
            //
            this.Resgistersign.AutoSize = true;
            this.Resgistersign.Dock = DockStyle.Fill;
            this.Resgistersign.TextAlign = ContentAlignment.MiddleCenter;
            this.Resgistersign.Name = "Resgistersign";
            this.Resgistersign.TabIndex = 2;
            this.Resgistersign.Text = ":";
            this.Resgistersign.Font = new Font("宋体", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            //this.Resgistersign.BackColor = Color.Red;  //背景颜色
            //
            // 读取值
            //
            this.ResgisterValue.AutoSize = true;
            this.ResgisterValue.Dock = DockStyle.Fill;
            this.ResgisterValue.TextAlign = ContentAlignment.MiddleLeft;
            this.ResgisterValue.Name = "ResgisterValue";
            this.ResgisterValue.TabIndex = 2;
            this.ResgisterValue.Text = "初始代码段";
            this.ResgisterValue.Font = new Font("宋体", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            //this.ResgisterValue.BackColor = Color.Cyan;  //背景颜色
            //
            // 输入值填写框
            //
            this.ResgisterText.AutoSize = true;
            this.ResgisterText.Anchor = AnchorStyles.Right;  //设置居中
            this.ResgisterText.Name = "ResgisterText";
            this.ResgisterText.TabIndex = 2;
            //this.ResgisterText.Text = "3333333";
            this.ResgisterText.Size = new Size(70, 10);  //输入框大小
            this.ResgisterText.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            //this.ResgisterText.BackColor = Color.Green;  //背景颜色
            //
            // 按钮
            //
            this.ResgisterButton.Dock = DockStyle.Fill;
            this.ResgisterButton.Anchor = AnchorStyles.Right;
            this.ResgisterButton.Name = "ResgisterButton";
            this.ResgisterButton.TabIndex = 2;
            this.ResgisterButton.Text = "设置";
            this.ResgisterButton.UseVisualStyleBackColor = true;
            this.ResgisterButton.FlatStyle = FlatStyle.Popup;
            this.ResgisterButton.Cursor = Cursors.Hand;
            this.ResgisterButton.Size = new Size(75, 25);
            this.ResgisterButton.Click += new EventHandler(this.ResgisterButton_Click);
        }

        private void ResgisterButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ResgisterText.Text);
            ResgisterValue.Text = ResgisterText.Text;
            ResgisterName.Text = ResgisterText.Text;
        }

        public void SetID(int ID)
        {
            this.ID = ID;
        }

        public int GetID()
        {
            return ID;
        }

        public void SetResgisterName(String name)
        {
            this.ResgisterName.Text = name;
        }

        public String GetResgisterName()
        {
            return ResgisterName.Text;
        }
    }
}