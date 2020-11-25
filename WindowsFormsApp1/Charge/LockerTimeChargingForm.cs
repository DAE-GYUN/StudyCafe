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
    public partial class LockerTimeChargingForm : Form
    {
        public LockerTimeChargingForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void btn1Week_Click(object sender, EventArgs e)
        {
            txbPrice.Text = "4000";
        }

        private void btn3Week_Click(object sender, EventArgs e)
        {
            txbPrice.Text = "8000";
        }

        private void btn1Month_Click(object sender, EventArgs e)
        {
            txbPrice.Text = "11500";
        }

        private void btnPayMent_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.ShowDialog();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LockersForm lockersForm = new LockersForm();
            lockersForm.ShowDialog();
        }

        private void txbUserNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbRemainTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
