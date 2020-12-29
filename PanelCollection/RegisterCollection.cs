using Func;
using PanelUnit;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PanelCollection
{
    public class RegisterCollection : TableLayoutPanel
    {
        //创建Register集合
        public static List<RegisterCommonPanel> resgisterList = new List<RegisterCommonPanel>();

        //寄存器功能模块数量
        public static int registerAmount = 5;

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";

        public RegisterCollection()
        {
            //在集合中创建对应数量的对象
            for (int i = 1; i <= registerAmount; i++)
            {
                resgisterList.Add(new RegisterCommonPanel());
                resgisterList[i - 1].SetID(i);
                resgisterList[i - 1].SetResgisterName(IniFunc.getString("ResgiterName", "ResgiterName" + i, "读取错误", filename));
            }

            //
            //Panel初始化
            //
            this.ColumnCount = 1;  //列数
            this.RowCount = registerAmount;  //行数
            for (int i = 0; i < RowCount; i++)
            {
                this.ColumnStyles.Add(new ColumnStyle());
                this.Controls.Add(resgisterList[i], 0, i);
            }
            this.AutoSize = true;
            //this.BackColor = Color.DarkRed;  //背景颜色
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;   //边框样式
            //this.Location = new Point(8, 25);  //相对布局位置
            this.Dock = DockStyle.Fill;  //铺满
        }

        public void FlashName() {
            for (int i = 1; i <= registerAmount; i++)
            {
                resgisterList[i - 1].SetResgisterName(IniFunc.getString("ResgiterName", "ResgiterName" + i, "读取错误", filename));
            }
        }
    }
}