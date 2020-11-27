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
    public partial class StudyRoomTimeChargingForm : Form
    {
        public StudyRoomTimeChargingForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txbUserNumber.Text = Credential.Instance.User.PhoneNumber;

        }

        private string _str;

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


        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            txbChargingTime.Text = ((Button)sender).Text.ToString();
            _str = ((Button)sender).Tag.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
