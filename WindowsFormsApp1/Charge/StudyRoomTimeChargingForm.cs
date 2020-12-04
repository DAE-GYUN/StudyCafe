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

        public StudyRoomTimeChargingForm(string str, PurchaseForm purchase) : this()
        {
            _str = str;
            purchaseForm = purchase;
        }
        private PurchaseForm purchaseForm;
        private string _str;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txbRoomNumber.Text = _str;
            txbUserNumber.Text = Credential.Instance.User.PhoneNumber;
            btnPurchase.Enabled = false;



        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            purchaseForm.GetStudyRoomNumber(_str);

            List<Item> items = Dao.Item.GetAll();
            foreach (var price in items)
            {
                if (txbPrice.Text == price.Price.ToString() && txbItemName.Text == price.Name.ToString())
                {
                    purchaseForm.AddItem(price);
                }
            }
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            txbChargingTime.Text = ((RadioButton)sender).Text.ToString();
            txbPrice.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string num = ((Button)sender).Tag.ToString();
            Item item = Dao.Item.GetByPK(int.Parse(num));
            txbPrice.Text = item.Price.ToString();
            txbItemName.Text = item.Name;
            txbChargingTime.Text = item.Time.ToString();
            btnPurchase.Enabled = true;
        }


    }
}
