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
        public LockerTimeChargingForm(string lockerNumber,PurchaseForm purchase) : this()
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
            //purchaseForm.AddItem(item);
            txbPrice.Text = item.Price.ToString();
        }

        private void btn1Month_Click(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByPK(12);
            //purchaseForm.AddItem(item);
            txbPrice.Text = item.Price.ToString();
        }


        private void btnPayMent_Click(object sender, EventArgs e)
        {
            //string item = ((Button)sender).Tag.ToString();
            //Item _item = Dao.Item.GetByPK(int.Parse(item));
            //uscItem.AddItem(_item);
            //Item k = _item.ItemID;

            //uscItem.AddItem(k);
            purchaseForm.GetLockerNumber(_lockerNumber);

            if (txbPrice.Text == "4000")
            {
                Item item = Dao.Item.GetByPK(10);

                if (MessageBox.Show("장바구니에 담겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    //int userCredential = Credential.Instance.User.UserID;
                    //int userKey = Dao.User.GetByUserKey(userCredential);
                    //int lockerTime = Credential.Instance.User.RemainLockerTime += 10080;

                    //User user = Dao.User.GetByPK(userKey);
                    //user.RemainLockerTime = lockerTime;
                    //Dao.User.Update(user);


                    //Locker oldLocker = Dao.Locker.GetByUserId(userCredential);
                    //if (oldLocker != null)
                    //{
                    //    oldLocker.UserID = null;
                    //    Dao.Locker.Update(oldLocker);
                    //}

                    //Locker newLocker = Dao.Locker.GetByPK(int.Parse(_lockerNumber));
                    //newLocker.UserID = userCredential;
                    //Dao.Locker.Update(newLocker);

                    purchaseForm.AddItem(item);
                    Close();
                }
                else
                {
                    Close();
                }
            }

            if (txbPrice.Text == "8000")
            {
                Item item = Dao.Item.GetByPK(11);

                if (MessageBox.Show("장바구니에 담겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    //int userCredential = Credential.Instance.User.UserID;
                    //int userKey = Dao.User.GetByUserKey(userCredential);


                    //int lockerTime = Credential.Instance.User.RemainLockerTime += 30240;

                    //User user = Dao.User.GetByPK(userKey);
                    //user.RemainLockerTime = lockerTime;
                    //Dao.User.Update(user);

                    //Locker oldLocker = Dao.Locker.GetByUserId(userCredential);
                    //if (oldLocker != null)
                    //{
                    //    oldLocker.UserID = null;
                    //    Dao.Locker.Update(oldLocker);
                    //}

                    //Locker newLocker = Dao.Locker.GetByPK(int.Parse(_lockerNumber));
                    //newLocker.UserID = userCredential;
                    //Dao.Locker.Update(newLocker);

                    purchaseForm.AddItem(item);

                    Close();
                }
                else
                {
                    Close();
                }
            }

            if (txbPrice.Text == "11500")
            {
                Item item = Dao.Item.GetByPK(12);
          

                if (MessageBox.Show("장바구니에 담겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //int userCredential = Credential.Instance.User.UserID;
                    //int userKey = Dao.User.GetByUserKey(userCredential);


                    //int lockerTime = Credential.Instance.User.RemainLockerTime += 50040;

                    //User user = Dao.User.GetByPK(userKey);
                    //user.RemainLockerTime = lockerTime;
                    //Dao.User.Update(user);

                    //Locker oldLocker = Dao.Locker.GetByUserId(userCredential);
                    //if (oldLocker != null)
                    //{
                    //    oldLocker.UserID = null;
                    //    Dao.Locker.Update(oldLocker);
                    //}

                    //Locker newLocker = Dao.Locker.GetByPK(int.Parse(_lockerNumber));
                    //newLocker.UserID = userCredential;
                    //Dao.Locker.Update(newLocker);

                    purchaseForm.AddItem(item);

                    Close();

                }
                else
                {
                    Close();
                }
            }
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
