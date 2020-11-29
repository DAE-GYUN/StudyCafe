using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCafe.Data;

namespace WindowsFormsApp1
{
    public partial class SeatTimeChargingForm : Form
    {
        public SeatTimeChargingForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txbUserNumber.Text = Credential.Instance.User.PhoneNumber;

        }

        private void btnSeatTime_Click(object sender, EventArgs e)
        {
            txbItemName.Text = ((RadioButton)sender).Text.ToString();
            txbPrice.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.ShowDialog();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.ShowDialog();
        }
    }
}
