using Func;
using PanelUnit;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PanelCollection
{
    public class RegisterCollection : TableLayoutPanel
    {
        //创建Register集合
        public static List<RegisterCommonPanel> registerList = new List<RegisterCommonPanel>();

        //寄存器功能模块数量
        public static int registerAmount;

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";

        public RegisterCollection()
        {
            registerAmount = int.Parse(IniFunc.getString("RegisterAmount", "RegisterAmount", "读取错误", filename));

            //在集合中创建对应数量的对象
            for (int i = 1; i <= registerAmount; i++)
            {
                registerList.Add(new RegisterCommonPanel());
                registerList[i - 1].SetID(i);
                registerList[i - 1].SetResgisterName(IniFunc.getString("RegisterName", "RegisterName" + i, "读取错误", filename));
            }

            //
            //Panel初始化
            //
            this.ColumnCount = 1;  //列数
            this.RowCount = registerAmount;  //行数
            for (int i = 0; i < RowCount; i++)
            {
                this.ColumnStyles.Add(new ColumnStyle());
                this.Controls.Add(registerList[i], 0, i);
            }
            this.AutoSize = true;
            //this.BackColor = Color.DarkRed;  //背景颜色
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;   //边框样式
            this.Dock = DockStyle.Fill;  //铺满
        }
        //内容刷新
        public void Flash()
        {
            registerList.Clear();
            this.Controls.Clear();
            this.ColumnStyles.Clear();
            registerAmount = int.Parse(IniFunc.getString("RegisterAmount", "RegisterAmount", "读取错误", filename));

            for (int i = 1; i <= registerAmount; i++)
            {
                registerList.Add(new RegisterCommonPanel());
                registerList[i - 1].SetID(i);
                registerList[i - 1].SetResgisterName(IniFunc.getString("RegisterName", "RegisterName" + i, "读取错误", filename));
            }

            this.ColumnCount = 1;  //列数
            this.RowCount = registerAmount;  //行数
            for (int i = 0; i < RowCount; i++)
            {
                this.ColumnStyles.Add(new ColumnStyle());
                this.Controls.Add(registerList[i], 0, i);
            }
        }
    }
}