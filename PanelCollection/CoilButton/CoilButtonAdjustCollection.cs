﻿using Func;
using PanelCollection.CoilButton;
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
    public class CoilButtonAdjustCollection : TableLayoutPanel
    {
        //创建CoilJustReadAdjustPanel集合
        public static List<CoilButtonAdjustPanel> coilButtonAdjustList = new List<CoilButtonAdjustPanel>();

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\CoilButton.ini";

        public CoilButtonAdjustCollection()
        {
            this.AutoSize = true;
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;   //边框样式
            this.Dock = DockStyle.Fill;  //铺满
        }

        public void Flash()
        {
            coilButtonAdjustList.Clear();
            this.Controls.Clear();
            this.ColumnStyles.Clear();
            this.RowStyles.Clear();

            for (int i = 1; i <= CoilButtonCollection.coilButtonAmount; i++)
            {
                coilButtonAdjustList.Add(new CoilButtonAdjustPanel());
                //设置成员ID
                coilButtonAdjustList[i - 1].ID = i;
                //设置成员名称
                coilButtonAdjustList[i - 1].coilButtonTextBox1.Text = Func.DES.DESDecrypt(IniFunc.getString("CoilButtonName", "CoilButtonName" + i, "bFMrIPLjXzYXCFBj9dj8cQ==", filename));
                //设置成员读取地址
                coilButtonAdjustList[i - 1].coilButtonReadtextBox.Text = Func.DES.DESDecrypt(IniFunc.getString("CoilButtonReadAddress", "CoilButtonReadAddress" + i, "bFMrIPLjXzYXCFBj9dj8cQ==", filename));
                //设置成员读取地址MXY
                coilButtonAdjustList[i - 1].coilButtonReadcomboBox.Text = Func.DES.DESDecrypt(IniFunc.getString("CoilButtonReadMXYAddress", "CoilButtonReadMXYAddress" + i, "bFMrIPLjXzYXCFBj9dj8cQ==", filename));
                //设置成员写入地址
                coilButtonAdjustList[i - 1].coilButtonWriteTextBox.Text = Func.DES.DESDecrypt(IniFunc.getString("CoilButtonWriteAddress", "CoilButtonWriteAddress" + i, "bFMrIPLjXzYXCFBj9dj8cQ==", filename));
                //设置成员写入地址MXY
                coilButtonAdjustList[i - 1].coilButtonWritecomboBox.Text = Func.DES.DESDecrypt(IniFunc.getString("CoilButtonWriteMXYAddress", "CoilButtonWriteMXYAddress" + i, "bFMrIPLjXzYXCFBj9dj8cQ==", filename));
                //设置成员点动切换选择
                if (bool.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonTransform", "CoilButtonTransform" + i, "bFMrIPLjXzYXCFBj9dj8cQ==", filename))))
                {
                    coilButtonAdjustList[i - 1].radioButton1.Checked = true;
                }
                else if (!bool.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonTransform", "CoilButtonTransform" + i, "bFMrIPLjXzYXCFBj9dj8cQ==", filename))))
                {
                    coilButtonAdjustList[i - 1].radioButton2.Checked = true;
                }
                //设置成员隐藏bool
                coilButtonAdjustList[i - 1].checkBox1.Checked = bool.Parse(Func.DES.DESDecrypt(IniFunc.getString("CoilButtonHideBool", "CoilButtonHideBool" + i, "rQKVA3srM0c=", filename)));
            }

            this.ColumnCount = 1;  //列数
            this.RowCount = CoilButtonCollection.coilButtonAmount;  //行数
            for (int i = 0; i < RowCount; i++)
            {
                this.Controls.Add(coilButtonAdjustList[i], 0, i);
                this.ColumnStyles.Add(new ColumnStyle());
                this.RowStyles.Add(new ColumnStyle());
            }
        }
    }
}
