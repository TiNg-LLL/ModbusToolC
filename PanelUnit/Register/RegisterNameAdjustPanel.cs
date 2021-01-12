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
        public CheckBox RegisterDataTransform = new CheckBox();
        public CheckBox RegisterJustLabel = new CheckBox();
        //标识特征
        public int ID { get; set; }

        public RegisterNameAdjustPanel()
        {
            //
            //Panel初始化
            //
            this.ColumnCount = 5;  //列数
            this.RowCount = 1;  //行数
            this.ColumnStyles.Add(new ColumnStyle());
            this.ColumnStyles.Add(new ColumnStyle());
            this.ColumnStyles.Add(new ColumnStyle());
            this.ColumnStyles.Add(new ColumnStyle());
            this.ColumnStyles.Add(new ColumnStyle());
            //this.AutoSize = true;
            //this.Dock = DockStyle.Fill;  //铺满
            this.Size = new Size(355, 30);
            //this.BackColor = Color.DarkGray;  //背景颜色
            //
            //添加成员
            //
            this.Controls.Add(this.RegisterNameText, 0, 0);
            this.Controls.Add(this.RegisterWriteAddressText, 1, 0);
            this.Controls.Add(this.RegisterReadAddressText, 2, 0);
            this.Controls.Add(this.RegisterDataTransform, 3, 0);
            this.Controls.Add(this.RegisterJustLabel, 4, 0);
            //***
            // RegisterNameText填写框
            //***
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
            this.RegisterWriteAddressText.KeyPress += new KeyPressEventHandler(this.RegisterValueText_KeyPress);
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
            this.RegisterReadAddressText.KeyPress += new KeyPressEventHandler(this.RegisterValueText_KeyPress);
            //this.RegisterReadAddressText.BackColor = Color.Green;  //背景颜色
            // ***
            // checkBox1寄存器数据是否转换为mm选项
            // ***
            this.RegisterDataTransform.Anchor = AnchorStyles.None;  //设置居中
            this.RegisterDataTransform.AutoSize = true;
            this.RegisterDataTransform.Name = "checkBox1";
            this.RegisterDataTransform.Size = new System.Drawing.Size(78, 16);
            this.RegisterDataTransform.TabIndex = 0;
            this.RegisterDataTransform.Text = "mm";
            this.RegisterDataTransform.UseVisualStyleBackColor = true;
            // ***
            // checkBox2是否只是为Label功能   JustLabel
            // ***
            this.RegisterJustLabel.Anchor = AnchorStyles.None;  //设置居中
            this.RegisterJustLabel.AutoSize = true;
            this.RegisterJustLabel.Name = "checkBox2";
            this.RegisterJustLabel.Size = new System.Drawing.Size(78, 16);
            this.RegisterJustLabel.TabIndex = 0;
            this.RegisterJustLabel.Text = "只读";
            this.RegisterJustLabel.UseVisualStyleBackColor = true;
        }
        //输入框只能填写数字
        private void RegisterValueText_KeyPress(object sender, KeyPressEventArgs e)
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
        //***
        //名称 set get
        //***
        public void SetRegisterNameText(String name)
        {
            this.RegisterNameText.Text = name;
        }
        public String GetRegisterNameText()
        {
            return RegisterNameText.Text;
        }
        //***
        //寄存器写入地址 set get
        //***
        public void SetRegisterWriteAddressText(String RegisterWriteAddress)
        {
            this.RegisterWriteAddressText.Text = RegisterWriteAddress;
        }

        public String GetRegisterWriteAddressText()
        {
            return RegisterWriteAddressText.Text;
        }
        //***
        //寄存器读取地址 set get
        //***
        public void SetRegisterReadAddressText(String RegisterReadAddress)
        {
            this.RegisterReadAddressText.Text = RegisterReadAddress;
        }

        public String GetRegisterReadAddressText()
        {
            return RegisterReadAddressText.Text;
        }
    }
}