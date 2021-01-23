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

        //辅助对象
        public static int b;

        public CoilButtonCollection()
        {
            InitializeComponent();

            coilButtonAmount = int.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonAmount", "CoilButtonAmount", "bFMrIPLjXzYXCFBj9dj8cQ==", filename)));

            //在集合中创建对应数量的对象
            for (int i = 1; i <= coilButtonAmount; i++)
            {
                coilButtonList.Add(new CoilButtonPanel(i));
                coilButtonValueList.Add(null);
                //设置成员名称
                coilButtonList[i - 1].ucBtnExt1.lbl.Text = Func.DES.DESDecrypt(IniFunc.getString("CoilButtonName", "CoilButtonName" + i, "bFMrIPLjXzYXCFBj9dj8cQ==", filename));
                //设置成员写入地址
                coilButtonList[i - 1].coilButtonWriteAddress = int.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonWriteAddress", "CoilButtonWriteAddress" + i, "ba0s2hMe/Pg=", filename)));
                //设置成员写入地址MXY
                coilButtonList[i - 1].coilButtonWriteMXYAddress = Func.DES.DESDecrypt(IniFunc.getString("CoilButtonWriteMXYAddress", "CoilButtonWriteMXYAddress" + i, "/uz5sjJ8Zt4=", filename));
                //设置成员读取地址
                coilButtonList[i - 1].coilButtonReadAddress = int.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonReadAddress", "CoilButtonReadAddress" + i, "ba0s2hMe/Pg=", filename)));
                //设置成员读取地址MXY
                coilButtonList[i - 1].coilButtonReadMXYAddress = Func.DES.DESDecrypt(IniFunc.getString("CoilButtonReadMXYAddress", "CoilButtonReadMXYAddress" + i, "/uz5sjJ8Zt4=", filename));
                //设置成员功能点动切换Bool
                coilButtonList[i - 1].coilButtonTransform = bool.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonTransform", "CoilButtonTransform" + i, "rQKVA3srM0c=", filename)));
                //设置成员隐藏Bool
                coilButtonList[i - 1].coilButtonHideBool = bool.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonHideBool", "CoilButtonHideBool" + i, "rQKVA3srM0c=", filename)));
            }
            //***
            //Panel初始化
            //***
            b = 0;
            for (int i = 0; i < coilButtonAmount; i++)
            {
                if (!(coilButtonList[i].coilButtonHideBool))
                {
                    b++;
                }
            }
            //列数设置
            if (b <= 4)
            {
                this.tableLayoutPanel1.ColumnCount = b;  //列数
            }
            else
            {
                this.tableLayoutPanel1.ColumnCount = 4;  //列数
            }
            this.tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            }
            //行数设置
            if ((b / 4) <= 1)
            {
                this.tableLayoutPanel1.RowCount = 1;  //行数
            }
            else
            {
                this.tableLayoutPanel1.RowCount = ((int)(b / 4.1)) + 1;  //行数
            }
            this.tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i <= this.tableLayoutPanel1.RowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            }
            //添加Label对象
            b = 0;
            for (int i = 0; i < coilButtonAmount; i++)
            {
                if (!(coilButtonList[i].coilButtonHideBool))
                {
                    if (b < 4)
                    {
                        this.tableLayoutPanel1.Controls.Add(coilButtonList[i], b, 0);
                    }
                    else if (b < 8)
                    {
                        this.tableLayoutPanel1.Controls.Add(coilButtonList[i], b - 4, 1);
                    }
                    else if (b < 12)
                    {
                        this.tableLayoutPanel1.Controls.Add(coilButtonList[i], b - 8, 2);
                    }
                    else
                    {
                        this.tableLayoutPanel1.Controls.Add(coilButtonList[i], b - 12, 3);
                    }
                    b++;
                }
            }

            //this.tableLayoutPanel1.AutoSize = true;
            //this.BackColor = Color.DarkRed;  //背景颜色
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;   //边框样式
            //this.tableLayoutPanel1.Dock = DockStyle.Fill;  //铺满

            this.Dock = DockStyle.Fill;
            this.AutoSize = true;
        }

        public void Flash()
        {
            this.tableLayoutPanel1.Controls.Clear();

            b = 0;
            for (int i = 0; i < coilButtonAmount; i++)
            {
                if (!(coilButtonList[i].coilButtonHideBool))
                {
                    b++;
                }
            }
            //列数设置
            if (b <= 4)
            {
                this.tableLayoutPanel1.ColumnCount = b;  //列数
            }
            else
            {
                this.tableLayoutPanel1.ColumnCount = 4;  //列数
            }
            this.tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            }
            //行数设置
            if ((b / 4) <= 1)
            {
                this.tableLayoutPanel1.RowCount = 1;  //行数
            }
            else
            {
                this.tableLayoutPanel1.RowCount = ((int)(b / 4.1)) + 1;  //行数
            }
            this.tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i <= this.tableLayoutPanel1.RowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            }
            //添加Label对象
            b = 0;
            for (int i = 0; i < coilButtonAmount; i++)
            {
                if (!(coilButtonList[i].coilButtonHideBool))
                {
                    if (b < 4)
                    {
                        this.tableLayoutPanel1.Controls.Add(coilButtonList[i], b, 0);
                    }
                    else if (b < 8)
                    {
                        this.tableLayoutPanel1.Controls.Add(coilButtonList[i], b - 4, 1);
                    }
                    else if (b < 12)
                    {
                        this.tableLayoutPanel1.Controls.Add(coilButtonList[i], b - 8, 2);
                    }
                    else
                    {
                        this.tableLayoutPanel1.Controls.Add(coilButtonList[i], b - 12, 3);
                    }
                    b++;
                }
            }
        }
    }
}
