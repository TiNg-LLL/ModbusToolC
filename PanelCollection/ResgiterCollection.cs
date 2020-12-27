using Panel_Unit.Register.Common;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Panel_Collection.Register.Collection
{
    public class ResgisterCollection : TableLayoutPanel
    {
        //创建Register集合
        public static List<ResgisterCommon> resgisterList = new List<ResgisterCommon>();

        public static int resgisterAmount = 5;

        public ResgisterCollection()
        {
            //在集合中创建对应数量的对象
            for (int i = 1; i <= resgisterAmount; i++)
            {
                resgisterList.Add(new ResgisterCommon());
                resgisterList[0].SetID(i);
            }

            //
            //Panel初始化
            //
            this.ColumnCount = 1;  //列数
            this.RowCount = resgisterAmount;  //行数
            for (int i = 0; i < RowCount; i++)
            {
                this.ColumnStyles.Add(new ColumnStyle());
                this.Controls.Add(resgisterList[i], 0, i);
            }
            this.AutoSize = true;
            //this.BackColor = Color.DarkRed;  //背景颜色
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;   //边框样式
        }
    }
}