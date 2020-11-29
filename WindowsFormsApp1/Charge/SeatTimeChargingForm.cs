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
            Close();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txbPrice.Text == "4000")
            {
                Item item = Dao.Item.GetByPK(1);
                uscItem.AddItem(item);

                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainSeatTime += 120;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainSeatTime = lockerTime;
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
                Item item = Dao.Item.GetByPK(2);
                uscItem.AddItem(item);

                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainSeatTime += 300;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainSeatTime = lockerTime;
                    Dao.User.Update(user);

                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }

            if (txbPrice.Text == "15000")
            {
                Item item = Dao.Item.GetByPK(3);
                uscItem.AddItem(item);

                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainSeatTime += 720;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainSeatTime = lockerTime;
                    Dao.User.Update(user);

                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }

            if (txbPrice.Text == "60000")
            {
                Item item = Dao.Item.GetByPK(4);
                uscItem.AddItem(item);

                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainSeatTime += 1800;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainSeatTime = lockerTime;
                    Dao.User.Update(user);

                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }

            if (txbPrice.Text == "80000")
            {
                Item item = Dao.Item.GetByPK(5);
                uscItem.AddItem(item);

                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainSeatTime += 3600;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainSeatTime = lockerTime;
                    Dao.User.Update(user);

                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }

            if (txbPrice.Text == "100000")
            {
                Item item = Dao.Item.GetByPK(6);
                uscItem.AddItem(item);

                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainSeatTime += 6000;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainSeatTime = lockerTime;
                    Dao.User.Update(user);

                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}