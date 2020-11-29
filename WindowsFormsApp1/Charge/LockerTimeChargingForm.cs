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

       

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txbUserNumber.Text = Credential.Instance.PhoneNumber;
            txbLockerRemainTime.Text = Credential.Instance.User.RemainLockerTime.ToString();
            txbRemainTime.Text = Credential.Instance.User.RemainSeatTime.ToString();
          

        }
        
        private void btn1Week_Click(object sender, EventArgs e)
        {

            Item item = Dao.Item.GetByPK(10);
           // uscItem.AddItem(item);
            txbPrice.Text = item.Price.ToString();
         
        }

        private void btn3Week_Click(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByPK(11);
            //uscItem.AddItem(item);
            txbPrice.Text = item.Price.ToString();
        }

        private void btn1Month_Click(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByPK(12);
            //uscItem.AddItem(item);
            txbPrice.Text = item.Price.ToString();
        }


        private void btnPayMent_Click(object sender, EventArgs e)
        {
            //string item = ((Button)sender).Tag.ToString();
            //Item _item = Dao.Item.GetByPK(int.Parse(item));
            //uscItem.AddItem(_item);
            //Item k = _item.ItemID;

            //uscItem.AddItem(k);
            if (txbPrice.Text == "4000")
            {
                Item item = Dao.Item.GetByPK(10);
                uscItem.AddItem(item);

                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainLockerTime += 10080;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainLockerTime = lockerTime;
                    Dao.User.Update(user);

                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }

            if (txbPrice.Text == "8000")
            {
                Item item = Dao.Item.GetByPK(11);
                uscItem.AddItem(item);
                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainLockerTime += 30240;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainLockerTime = lockerTime;
                    Dao.User.Update(user);

                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }

            if (txbPrice.Text == "11500")
            {
                Item item = Dao.Item.GetByPK(12);
                uscItem.AddItem(item);
                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainLockerTime += 50040;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainLockerTime = lockerTime;
                    Dao.User.Update(user);
                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }



        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm(this);
            purchaseForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LockersForm lockersForm = new LockersForm();
            lockersForm.ShowDialog();
        }

        private void paymentControl1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
