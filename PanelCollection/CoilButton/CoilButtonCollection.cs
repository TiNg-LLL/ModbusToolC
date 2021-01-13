using Controls;
using Func;
using PanelUnit.CoilButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelCollection.CoilButton
{
    public partial class CoilButtonCollection : UserControl
    {
        //创建CoilButton集合
        public static List<CoilButtonPanel> coilButtonList = new List<CoilButtonPanel>();
        //创建CoilButton读取结果集合
        public static List<bool?> coilButtonValueList = new List<bool?>();
        //线圈按钮功能模块数量
        public static int coilButtonAmount;

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\CoilButton.ini";
        public CoilButtonCollection()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.AutoSize = true;

            coilButtonAmount = int.Parse(IniFunc.getString("CoilButtonAmount", "CoilButtonAmount", "读取错误", filename));

            //在集合中创建对应数量的对象
            for (int i = 1; i <= coilButtonAmount; i++)
            {
                coilButtonList.Add(new CoilButtonPanel(i));
                coilButtonValueList.Add(null);
                //设置成员名称
                coilButtonList[i - 1].ucBtnExt1.lbl.Text = IniFunc.getString("CoilButtonName", "CoilButtonName" + i, "读取错误", filename);
                //设置成员读取地址
                coilButtonList[i - 1].coilButtonAddress = int.Parse(IniFunc.getString("CoilButtonAddress", "CoilButtonAddress" + i, "0", filename));
                //设置成员读取地址MXY
                coilButtonList[i - 1].coilButtonMXYAddress = IniFunc.getString("CoilButtonMXYAddress", "CoilButtonMXYAddress" + i, "M", filename);
            }
            //***
            //Panel初始化
            //***
            //列数设置
            if (coilButtonAmount <= 4)
            {
                this.tableLayoutPanel1.ColumnCount = coilButtonAmount;  //列数
            }
            else
            {
                this.tableLayoutPanel1.ColumnCount = 4;  //列数
            }
            this.tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            }
            //行数设置
            if ((coilButtonAmount / 4) <= 1)
            {
                this.tableLayoutPanel1.RowCount = 1;  //行数
            }
            else
            {
                this.tableLayoutPanel1.RowCount = ((coilButtonAmount / 4) + 1);  //行数
            }
            this.tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i <= this.tableLayoutPanel1.RowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            }
            //添加Label对象
            for (int i = 0; i < coilButtonAmount; i++)
            {
                if (i < 4)
                {
                    this.tableLayoutPanel1.Controls.Add(coilButtonList[i], i, 0);
                }
                else if (i < 8)
                {
                    this.tableLayoutPanel1.Controls.Add(coilButtonList[i], i - 4, 1);
                }
                else if (i < 12)
                {
                    this.tableLayoutPanel1.Controls.Add(coilButtonList[i], i - 8, 2);
                }
                else
                {
                    this.tableLayoutPanel1.Controls.Add(coilButtonList[i], i - 12, 3);
                }
            }
            this.tableLayoutPanel1.AutoSize = true;
            //this.BackColor = Color.DarkRed;  //背景颜色
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;   //边框样式
            this.tableLayoutPanel1.Dock = DockStyle.Fill;  //铺满
        }
    }
}
