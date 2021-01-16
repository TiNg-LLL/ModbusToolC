using Func;
using PanelUnit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelCollection
{
    public class CoilJustReadAdjustCollection : TableLayoutPanel
    {
        //创建CoilJustReadAdjustPanel集合
        public static List<CoilJustReadAdjustPanel> coilJustReadAdjustList = new List<CoilJustReadAdjustPanel>();

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\CoilJustRead.ini";

        public CoilJustReadAdjustCollection()
        {
            this.AutoSize = true;
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;   //边框样式
            this.Dock = DockStyle.Fill;  //铺满
        }

        public void Flash()
        {
            coilJustReadAdjustList.Clear();
            this.Controls.Clear();
            this.ColumnStyles.Clear();
            this.RowStyles.Clear();

            for (int i = 1; i <= CoilJustReadCollection.coilJustReadAmount; i++)
            {
                coilJustReadAdjustList.Add(new CoilJustReadAdjustPanel());
                //设置成员ID
                coilJustReadAdjustList[i - 1].ID = i;
                //设置成员名称
                coilJustReadAdjustList[i - 1].coilJustReadTextBox1.Text = IniFunc.getString("CoilJustReadName", "CoilJustReadName" + i, "读取错误", filename);
                //设置成员读取地址
                coilJustReadAdjustList[i - 1].coilJustReadTextBox2.Text = IniFunc.getString("CoilJustReadAddress", "CoilJustReadAddress" + i, "读取错误", filename);
                //设置成员读取地址MXY
                coilJustReadAdjustList[i - 1].comboBox1.Text = IniFunc.getString("CoilJustReadMXYAddress", "CoilJustReadMXYAddress" + i, "读取错误", filename);
            }

            this.ColumnCount = 1;  //列数
            this.RowCount = CoilJustReadCollection.coilJustReadAmount;  //行数
            for (int i = 0; i < RowCount; i++)
            {
                this.Controls.Add(coilJustReadAdjustList[i], 0, i);
                this.ColumnStyles.Add(new ColumnStyle());
                this.RowStyles.Add(new ColumnStyle());
            }
        }
    }
}
