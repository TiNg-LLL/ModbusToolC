using PanelCollection;
using System.Windows.Forms;
using WindowUnit;

namespace FirstWindow
{
    public partial class FirstWindow : Form
    {
        //new出寄存器功能模块
        public static RegisterCollection resgisterCollection = new RegisterCollection();
        //
        private WindowRegisterAdjust resgisterNameAdjustWindow;
        public FirstWindow()
        {
            InitializeComponent();
            //添加resgisterCollection
            this.groupBox1.Controls.Add(resgisterCollection);
        }

        private void 参数文件修改ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            resgisterNameAdjustWindow = new WindowRegisterAdjust();
            resgisterNameAdjustWindow.ShowDialog();
        }
    }
}