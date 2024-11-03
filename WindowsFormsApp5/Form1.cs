﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private string[] Paths = new string[0];
        private int ImageIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void select_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Multiselect = true,
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Paths = ofd.FileNames;
                    ImageIndex = 0;
                    pictureBox1.Image = Image.FromFile(Paths[ImageIndex]);
                }
            }

        }

        private void next_Click_1(object sender, EventArgs e)
        {
            if (Paths.Length == 0)
            {
                MessageBox.Show("Please Select Picture..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ImageIndex = (ImageIndex + 1) % Paths.Length;
                pictureBox1.Image = Image.FromFile(Paths[ImageIndex]);
            }
        }

        private void previous_Click_1(object sender, EventArgs e)
        {
            if (Paths.Length == 0)
            {
                MessageBox.Show("Please Select Picture..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ImageIndex = (ImageIndex - 1 + Paths.Length) % Paths.Length;
            pictureBox1.Image = Image.FromFile(Paths[ImageIndex]);
        }
    }
}

