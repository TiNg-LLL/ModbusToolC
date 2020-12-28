using PanelCollection;
using System.Windows.Forms;

namespace FirstWindow
{
    public partial class Form1 : Form
    {
        //new出寄存器功能模块
        private ResgisterCollection resgisterCollection = new ResgisterCollection();

        public Form1()
        {
            InitializeComponent();
            this.groupBox1.Controls.Add(resgisterCollection);
        }
    }
}