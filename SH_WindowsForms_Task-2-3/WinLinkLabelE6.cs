﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SH_WindowsForms_Task2_3
{
    public partial class WinLinkLabelE6 : Form
    {
        public WinLinkLabelE6()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            Form2 aForm = new
            Form2(); aResult = aForm.ShowDialog();
            if (aResult == System.Windows.Forms.DialogResult.OK)
            {

                MessageBox.Show("Your name is " + aForm.textBox1.Text + " " +

                aForm.textBox2.Text);
            }
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.limtu.com");
            linkLabel2.LinkVisited = true;
        }
    }
}
