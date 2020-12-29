using System;
using System.Drawing;
using System.Windows.Forms;

namespace PanelUnit
{
    public class RegisterNameAdjustPanel : TableLayoutPanel
    {
        //成员
        private TextBox RegisterNameText = new TextBox();
        private TextBox RegisterWriteAddressText = new TextBox();
        private TextBox RegisterReadAddressText = new TextBox();

        //标识特征
        private int ID;

        public RegisterNameAdjustPanel()
        {
            //
            //Panel初始化
            //
            this.ColumnCount = 3;  //列数
            this.RowCount = 1;  //行数
            this.ColumnStyles.Add(new ColumnStyle());
            this.ColumnStyles.Add(new ColumnStyle());
            this.ColumnStyles.Add(new ColumnStyle());
            this.AutoSize = true;
            this.Dock = DockStyle.Fill;  //铺满
            //this.Size = new Size(390, 35);
            //this.BackColor = Color.DarkGray;  //背景颜色

            //
            //添加成员
            //
            this.Controls.Add(this.RegisterNameText, 0, 0);
            this.Controls.Add(this.RegisterWriteAddressText, 1, 0);
            this.Controls.Add(this.RegisterReadAddressText, 2, 0);

            //
            // RegisterNameText填写框
            //
            //this.RegisterNameText.AutoSize = true;
            this.RegisterNameText.Anchor = AnchorStyles.None;  //设置居中
            this.RegisterNameText.Name = "ResgisterText";
            this.RegisterNameText.TabIndex = 2;
            this.RegisterNameText.Text = "1111111";
            this.RegisterNameText.Size = new Size(100, 10);  //输入框大小
            this.RegisterNameText.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            //this.RegisterNameText.BackColor = Color.Green;  //背景颜色

            //
            // RegisterWriteAddressText填写框
            //
            this.RegisterWriteAddressText.Anchor = AnchorStyles.None;  //设置居中
            this.RegisterWriteAddressText.Name = "ResgisterText";
            this.RegisterWriteAddressText.TabIndex = 2;
            this.RegisterWriteAddressText.Text = "22222222";
            this.RegisterWriteAddressText.Size = new Size(70, 10);  //输入框大小
            this.RegisterWriteAddressText.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            //this.RegisterWriteAddressText.BackColor = Color.Green;  //背景颜色

            //
            // RegisterReadAddressText填写框
            //
            this.RegisterReadAddressText.Anchor = AnchorStyles.None;  //设置居中
            this.RegisterReadAddressText.Name = "ResgisterText";
            this.RegisterReadAddressText.TabIndex = 2;
            this.RegisterReadAddressText.Text = "3333333";
            this.RegisterReadAddressText.Size = new Size(70, 10);  //输入框大小
            this.RegisterReadAddressText.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            //this.RegisterReadAddressText.BackColor = Color.Green;  //背景颜色
        }

        public void SetID(int ID)
        {
            this.ID = ID;
        }

        public int GetID()
        {
            return ID;
        }

        public void SetRegisterNameText(String name)
        {
            this.RegisterNameText.Text = name;
        }

        public String GetRegisterNameText()
        {
            return RegisterNameText.Text;
        }
    }
}