using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbUserPhoneNumber.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbUserPhoneNumber.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbUserPhoneNumber.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbUserPhoneNumber.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbUserPhoneNumber.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbUserPhoneNumber.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbUserPhoneNumber.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbUserPhoneNumber.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbUserPhoneNumber.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbUserPhoneNumber.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txbUserPhoneNumber.Text.Length >= 1)
                txbUserPhoneNumber.Text = txbUserPhoneNumber.Text.Remove(txbUserPhoneNumber.Text.Length - 1, 1);
        }
    }
}
