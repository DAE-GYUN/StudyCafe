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

        public StudyRoomTimeChargingForm(string str) : this()
        {
            _str = str;
        }
        private string _str;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txbRoomNumber.Text = _str;
            txbUserNumber.Text = Credential.Instance.User.PhoneNumber;
           


        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txbPrice.Text == "10000")
            {
                Item item = Dao.Item.GetByPK(7);
                uscItem.AddItem(item);

                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainStudyRoomTime+= 120;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainStudyRoomTime = lockerTime;
                    Dao.User.Update(user);

                    DialogResult = DialogResult.Yes;
                    Close();
                    
                }
                else
                {
                    
                }
            }

            if (txbPrice.Text == "35000")
            {
                Item item = Dao.Item.GetByPK(8);
                uscItem.AddItem(item);

                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainStudyRoomTime += 240;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainStudyRoomTime = lockerTime;
                    Dao.User.Update(user);

                    DialogResult = DialogResult.Yes;
                    Close();
                }
                else
                {
                    
                }
            }

            if (txbPrice.Text == "50000")
            {
                Item item = Dao.Item.GetByPK(8);
                uscItem.AddItem(item);

                if (MessageBox.Show("결제하시겠습니까?", "YesorNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int userCredential = Credential.Instance.User.UserID;
                    int userKey = Dao.User.GetByUserKey(userCredential);


                    int lockerTime = Credential.Instance.User.RemainStudyRoomTime += 360;

                    User user = Dao.User.GetByPK(userKey);
                    user.RemainStudyRoomTime = lockerTime;
                    Dao.User.Update(user);

                    DialogResult = DialogResult.Yes;
                    Close();
                }
                else
                {
                    
                }
                
            }
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

        private void rbtn2Hours_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByPK(7);
            // uscItem.AddItem(item);
            txbPrice.Text = item.Price.ToString();
            txbChargingTime.Text = item.Name.ToString();
        }

        private void btn4Hour_Click(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByPK(8);
            // uscItem.AddItem(item);
            txbPrice.Text = item.Price.ToString();
            txbChargingTime.Text = item.Name.ToString();
        }

        private void btn6Hour_Click(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByPK(9);
            // uscItem.AddItem(item);
            txbPrice.Text = item.Price.ToString();
            txbChargingTime.Text = item.Name.ToString();
        }
    }
}
