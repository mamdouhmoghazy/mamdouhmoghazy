using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] a = new string[] { "Tamil", "keral" };
            foreach (string i in a)
            {
                comboBox1.Items.Add(i);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "Tamil")
            {
                comboBox2.Items.Add("Channal");
                comboBox2.Items.Add("Trichy");
                comboBox2.Items.Add("pondi");
            }
          
            if (comboBox1.SelectedItem.ToString() == "keral")
            {
                comboBox2.Items.Add("Kolam");
                comboBox2.Items.Add("cochin");
            }
    
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
