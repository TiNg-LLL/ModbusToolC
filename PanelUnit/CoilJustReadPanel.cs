using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelUnit
{
    public partial class CoilJustReadPanel : UserControl
    {
        public int ID { get; set; }
        public CoilJustReadPanel(int i)
        {
            InitializeComponent();
            this.ID = i;
            //this.BackColor = Color.DarkRed;  //背景颜色
        }
    }
}
