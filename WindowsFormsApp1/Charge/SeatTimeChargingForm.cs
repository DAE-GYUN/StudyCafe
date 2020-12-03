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
        public PurchaseForm purchaseForm;

        public SeatTimeChargingForm()
        {
            InitializeComponent();
        }

        public SeatTimeChargingForm(PurchaseForm purchase):this()
        {
            purchaseForm = purchase;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txbUserNumber.Text = Credential.Instance.User.PhoneNumber;

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string num = ((RadioButton)sender).Tag.ToString();
            Item item = Dao.Item.GetByPK(int.Parse(num));
            txbPrice.Text = item.Price.ToString();
            txbItemName.Text = item.Name;
        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            List<Item> items = Dao.Item.GetAll();
            foreach (var price in items)
            {
                if (txbPrice.Text == price.Price.ToString() && txbItemName.Text == price.Name.ToString())
                {
                    purchaseForm.AddItem(price);
                }
            }

            Close();

        }

    }
}