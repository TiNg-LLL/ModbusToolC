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
        //创建Register读取结果集合
        public static List<string> registerValueList = new List<string>();
        //寄存器功能模块数量
        public static int registerAmount;
        //寄存器单位转换比率
        public static float registerDataProportion { get; set; }

        //初始化INI文件地址
        private string filename = Directory.GetCurrentDirectory() + @"\Resgiter.ini";

        public RegisterCollection()
        {
            registerAmount = int.Parse(IniFunc.getString("RegisterAmount", "RegisterAmount", "读取错误", filename));

            //在集合中创建对应数量的对象
            for (int i = 1; i <= registerAmount; i++)
            {
                registerList.Add(new RegisterCommonPanel());
                registerValueList.Add("");
                //设置成员ID
                registerList[i - 1].ID = i;
                //设置成员名称
                registerList[i - 1].SetRegisterName(IniFunc.getString("RegisterName", "RegisterName" + i, "读取错误", filename));
                //设置成员写入地址
                registerList[i - 1].SetRegisterWriteAddress(int.Parse(IniFunc.getString("RegisterWriteAddress", "RegisterWriteAddress" + i, "0", filename)));
                //设置成员读取地址
                registerList[i - 1].SetRegisterReadAddress(int.Parse(IniFunc.getString("RegisterReadAddress", "RegisterReadAddress" + i, "0", filename)));
                //设置成员数据转换Boolean
                registerList[i - 1].dataTransform = bool.Parse(IniFunc.getString("RegisterDataTransform", "RegisterDataTransform" + i, "false", filename));
                //设置寄存器单位转换比率
                registerDataProportion = float.Parse(IniFunc.getString("RegisterDataProportion", "RegisterDataProportion1", "1", filename));
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
        //
        //内容刷新方法
        //
        public void Flash()
        {
            registerList.Clear();
            registerValueList.Clear();
            this.Controls.Clear();
            this.ColumnStyles.Clear();
            registerAmount = int.Parse(IniFunc.getString("RegisterAmount", "RegisterAmount", "读取错误", filename));

            for (int i = 1; i <= registerAmount; i++)
            {
                registerList.Add(new RegisterCommonPanel());
                registerValueList.Add("");
                //设置成员ID
                registerList[i - 1].ID = i;
                //设置成员名称
                registerList[i - 1].SetRegisterName(IniFunc.getString("RegisterName", "RegisterName" + i, "读取错误", filename));
                //设置成员写入地址
                registerList[i - 1].SetRegisterWriteAddress(int.Parse(IniFunc.getString("RegisterWriteAddress", "RegisterWriteAddress" + i, "0", filename)));
                //设置成员读取地址
                registerList[i - 1].SetRegisterReadAddress(int.Parse(IniFunc.getString("RegisterReadAddress", "RegisterReadAddress" + i, "0", filename)));
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