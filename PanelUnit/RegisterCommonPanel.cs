using System;
using System.Drawing;
using System.Windows.Forms;

namespace PanelUnit
{
    public class RegisterCommonPanel : TableLayoutPanel
    {
        //成员
        private Label RegisterName = new Label();

        private Label RegisterSign = new Label();
        private Label RegisterNowValue = new Label();
        private TextBox RegisterValueText = new TextBox();
        private Button RegisterButton = new Button();

        //标识特征
        private int ID;

        //无参构造方法
        public RegisterCommonPanel()
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
            this.Controls.Add(this.RegisterName, 0, 0);
            this.Controls.Add(this.RegisterSign, 1, 0);
            this.Controls.Add(this.RegisterNowValue, 2, 0);
            this.Controls.Add(this.RegisterValueText, 3, 0);
            this.Controls.Add(this.RegisterButton, 4, 0);
            //
            // 名称
            //
            this.RegisterName.AutoSize = true;
            this.RegisterName.Dock = DockStyle.Fill;
            this.RegisterName.TextAlign = ContentAlignment.MiddleRight;
            this.RegisterName.Name = "ResgisterName";
            this.RegisterName.TabIndex = 2;
            this.RegisterName.Text = "初始代码段";
            this.RegisterName.Font = new Font("微软雅黑", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            //this.ResgisterName.BackColor = Color.Red;  //背景颜色
            //
            // :
            //
            this.RegisterSign.AutoSize = true;
            this.RegisterSign.Dock = DockStyle.Fill;
            this.RegisterSign.TextAlign = ContentAlignment.MiddleCenter;
            this.RegisterSign.Name = "Resgistersign";
            this.RegisterSign.TabIndex = 2;
            this.RegisterSign.Text = ":";
            this.RegisterSign.Font = new Font("宋体", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            //this.Resgistersign.BackColor = Color.Red;  //背景颜色
            //
            // 读取值
            //
            this.RegisterNowValue.AutoSize = true;
            this.RegisterNowValue.Dock = DockStyle.Fill;
            this.RegisterNowValue.TextAlign = ContentAlignment.MiddleLeft;
            this.RegisterNowValue.Name = "ResgisterValue";
            this.RegisterNowValue.TabIndex = 2;
            this.RegisterNowValue.Text = "00000000";
            this.RegisterNowValue.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            //this.ResgisterValue.BackColor = Color.Cyan;  //背景颜色
            //
            // 输入值填写框
            //
            this.RegisterValueText.AutoSize = true;
            this.RegisterValueText.Anchor = AnchorStyles.Right;  //设置右靠齐
            this.RegisterValueText.Name = "ResgisterText";
            this.RegisterValueText.TabIndex = 2;
            //this.ResgisterText.Text = "3333333";
            this.RegisterValueText.Size = new Size(70, 10);  //输入框大小
            this.RegisterValueText.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            //this.ResgisterText.BackColor = Color.Green;  //背景颜色
            //
            // 按钮
            //
            this.RegisterButton.Dock = DockStyle.Fill;
            this.RegisterButton.Anchor = AnchorStyles.Right;
            this.RegisterButton.Name = "ResgisterButton";
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "设置";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.FlatStyle = FlatStyle.Popup;
            this.RegisterButton.Cursor = Cursors.Hand;
            this.RegisterButton.Size = new Size(75, 25);
            this.RegisterButton.Click += new EventHandler(this.ResgisterButton_Click);
        }

        private void ResgisterButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(RegisterValueText.Text);
            RegisterNowValue.Text = RegisterValueText.Text;
            RegisterName.Text = RegisterValueText.Text;
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
            this.RegisterName.Text = name;
        }

        public String GetResgisterName()
        {
            return RegisterName.Text;
        }
    }
}