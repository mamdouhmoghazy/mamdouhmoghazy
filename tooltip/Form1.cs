using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();


            toolTip.AutoPopDelay = 5000; 
            toolTip.InitialDelay = 500; 
            toolTip.ReshowDelay = 500;   
            toolTip.ShowAlways = true;  

            toolTip.SetToolTip(this.button1, "click");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
