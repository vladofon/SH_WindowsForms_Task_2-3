using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParentFormE3 form = new ParentFormE3();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParentFormE4 form = new ParentFormE4();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WinContainer form = new WinContainer();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WinLinkLabelE6 form = new WinLinkLabelE6();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WinLinkLabel form = new WinLinkLabel();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrationFormE9 form = new RegistrationFormE9();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistrationFormE8 form = new RegistrationFormE8();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WinQuestion form = new WinQuestion();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TestList form = new TestList();
            form.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
