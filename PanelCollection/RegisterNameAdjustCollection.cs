using System.Collections.Generic;
using PanelUnit;
using System.Windows.Forms;
using System.IO;
using Func;
using System.Drawing;

namespace PanelCollection
{
    public class RegisterNameAdjustCollection : TableLayoutPanel
    {
        //创建RegisterAdjustPanel集合
        public static List<RegisterNameAdjustPanel> resgisterAdjustList = new List<RegisterNameAdjustPanel>();

        //寄存器功能模块数量
        public static int registerAmount = RegisterCollection.registerAmount;

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";

        public RegisterNameAdjustCollection()
        {
            //在集合中创建对应数量的对象
            for (int i = 1; i <= registerAmount; i++)
            {
                resgisterAdjustList.Add(new RegisterNameAdjustPanel());
                resgisterAdjustList[i - 1].SetID(i);
                resgisterAdjustList[i - 1].SetRegisterNameText(IniFunc.getString("ResgiterName", "ResgiterName" + i, "读取错误", filename));
            }

            //
            //Panel初始化
            //
            this.ColumnCount = 1;  //列数
            this.RowCount = registerAmount;  //行数
            for (int i = 0; i < RowCount; i++)
            {
                this.ColumnStyles.Add(new ColumnStyle());
                this.Controls.Add(resgisterAdjustList[i], 0, i);
            }
            this.AutoSize = true;
            //this.BackColor = Color.DarkRed;  //背景颜色
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;   //边框样式
            this.Location = new Point(7, 25);  //相对布局位置
            this.Dock = DockStyle.Fill;  //铺满
        }
    }
}
