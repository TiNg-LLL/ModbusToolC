using Func;
using PanelUnit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PanelCollection
{
    public class RegisterCollection : TableLayoutPanel
    {
        //创建Register集合
        public static List<RegisterCommonPanel> registerList = new List<RegisterCommonPanel>();
        //创建Register读取结果集合
        public static List<string> registerValueList = new List<string>();
        //寄存器功能模块数量
        public static int registerAmount;
        //寄存器单位转换比率
        public static float registerDataProportion { get; set; }

        //辅助对象
        private int t;

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";

        public RegisterCollection()
        {
            registerAmount = int.Parse(Func.DES.DESDecrypt(IniFunc.getString("RegisterAmount", "RegisterAmount", "ba0s2hMe/Pg=", filename)));

            //在集合中创建对应数量的对象
            for (int i = 1; i <= registerAmount; i++)
            {
                registerList.Add(new RegisterCommonPanel(i));
                registerValueList.Add("");
                //设置成员名称
                registerList[i - 1].SetRegisterName(Func.DES.DESDecrypt(IniFunc.getString("RegisterName", "RegisterName" + i, "bFMrIPLjXzYXCFBj9dj8cQ==", filename)));  //读取错误为“读取错误”
                //设置成员写入地址
                registerList[i - 1].SetRegisterWriteAddress(int.Parse(Func.DES.DESDecrypt(IniFunc.getString("RegisterWriteAddress", "RegisterWriteAddress" + i, "ba0s2hMe/Pg=", filename))));  //读取错误为0
                //设置成员读取地址
                registerList[i - 1].SetRegisterReadAddress(int.Parse(Func.DES.DESDecrypt(IniFunc.getString("RegisterReadAddress", "RegisterReadAddress" + i, "ba0s2hMe/Pg=", filename))));  //读取错误为0
                //设置成员数据转换Boolean
                registerList[i - 1].dataTransform = bool.Parse(Func.DES.DESDecrypt(IniFunc.getString("RegisterDataTransform", "RegisterDataTransform" + i, "rQKVA3srM0c=", filename)));  //读取错误为false
                //设置成员隐藏Boolean
                registerList[i - 1].hidebool = bool.Parse(Func.DES.DESDecrypt(IniFunc.getString("RegisterHideBool", "RegisterHideBool" + i, "rQKVA3srM0c=", filename)));  //读取错误为false
                //设置寄存器单位转换比率
                registerDataProportion = float.Parse(Func.DES.DESDecrypt(IniFunc.getString("RegisterDataProportion", "RegisterDataProportion1", "Eln6MAJktr8=", filename)));  //读取错误为1
            }
            //
            //Panel初始化
            //
            this.ColumnCount = 1;  //列数
            //this.RowCount = registerAmount;  //行数
            t = 0;
            for (int i = 0; i < registerAmount; i++)
            {
                if (!(registerList[i].hidebool))
                {
                    this.ColumnStyles.Add(new ColumnStyle());
                    this.Controls.Add(registerList[i], 0, i - t);
                }
                else
                {
                    t++;
                    Console.WriteLine(t);
                }
            }
            this.RowCount = registerAmount - t;  //行数
            this.AutoSize = true;
            //this.BackColor = Color.DarkRed;  //背景颜色
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;   //边框样式
            this.Dock = DockStyle.Fill;  //铺满
        }
        //
        //内容刷新方法
        //
        public void Flash()
        {
            this.Controls.Clear();
            this.ColumnStyles.Clear();

            t = 0;
            for (int i = 0; i < registerAmount; i++)
            {
                if (!(registerList[i].hidebool))
                {
                    this.ColumnStyles.Add(new ColumnStyle());
                    this.Controls.Add(registerList[i], 0, i - t);
                }
                else
                {
                    t++;
                    //Console.WriteLine(t);
                }
            }
            this.RowCount = registerAmount - t;  //行数
        }
    }
}