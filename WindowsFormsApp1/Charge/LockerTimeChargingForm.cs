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
    public partial class LockerTimeChargingForm : Form
    {

        public LockerTimeChargingForm()
        {
            InitializeComponent();
        }
        public PurchaseForm purchaseForm;
       
        public LockerTimeChargingForm(string lockerNumber, PurchaseForm purchase) : this()
        {
            purchaseForm = purchase;
            _lockerNumber = lockerNumber;
        }

        public LockerTimeChargingForm(PurchaseForm purchase) : this()
        {
            purchaseForm = purchase;
          

        }
        public string _lockerNumber { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txbUserNumber.Text = Credential.Instance.PhoneNumber;
            txbLockerRemainTime.Text = Credential.Instance.User.RemainLockerTime.ToString();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            string num = ((Button)sender).Tag.ToString();
            Item item = Dao.Item.GetByPK(int.Parse(num));
            txbPrice.Text = item.Price.ToString();
            txbItemName.Text = item.Name;
        }

        private void btnPayMent_Click(object sender, EventArgs e)
        {
            purchaseForm.GetLockerNumber(_lockerNumber);

            List<Item> items = Dao.Item.GetAll();
           
           
            
            foreach (var item in items)
            {
                if (txbPrice.Text == item.Price.ToString() && txbItemName.Text == item.Name.ToString())
                {

                   
                    purchaseForm.AddItem(item);

                    //InvoiceLine invoiceLine = new InvoiceLine()
                    //{
                    //    InvoiceID = maxInvoiceKey,
                    //    ItemID = price.ItemID,
                    //};

                    //if (_ItemsList.Contains(item))
                    //{
                    //    MessageBox.Show("중복구매x");
                    //}
                    //else
                    //{
                    //    purchaseForm.AddItem(item);
                    //    //Dao.InvoiceLine.Insert(invoiceLine);
                    //}             


                    //아이템 아이디 저장하는 함수

                }
            }
            Close();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
