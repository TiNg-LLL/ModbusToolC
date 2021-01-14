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
    public partial class CoilButtonAdjustPanel : UserControl
    {
        //标识特征
        public int ID { get; set; }

        public CoilButtonAdjustPanel()
        {
            InitializeComponent();
            this.coilButtonReadcomboBox.Items.AddRange(new String[] { "M", "X", "Y" });
            this.coilButtonWritecomboBox.Items.AddRange(new String[] { "M", "X", "Y" });
        }
    }
}
