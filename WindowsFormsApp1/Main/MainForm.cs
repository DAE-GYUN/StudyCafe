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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txbUserNumber.Text = Credential.Instance.User.PhoneNumber;
            txbRemainTime.Text = Credential.Instance.User.RemainSeatTime.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (Credential.Instance.User.CheckInStatus == true)
            {
                MessageBox.Show("현재 사용중인 좌석이 있습니다");
            }

            else
            {
                CheckInForm checkInForm = new CheckInForm("CheckIn");
                checkInForm.ShowDialog();

                if (checkInForm.DialogResult == DialogResult.OK)
                    Close();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (Credential.Instance.User.CheckInStatus == true)
            {
                if (MessageBox.Show("퇴실하시겠습니까?", "퇴실Or취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int userCredential = Credential.Instance.User.UserID;
                    int userId = Dao.User.GetByUserKey(userCredential);

                    Seat seat = Dao.Seat.GetByUserID(userCredential);
                    seat.UserID = null;
                    Dao.Seat.Update(seat);

                    User user = Dao.User.GetByPK(userId);
                    user.CheckInStatus = false;
                    Dao.User.Update(user);
                    Close();
                }
            }
            else
                MessageBox.Show("현재 사용중인 좌석이 없습니다");
        }

        private void btnShiftSeat_Click(object sender, EventArgs e)
        {
            if (Credential.Instance.User.CheckInStatus == true)
            {
                CheckInForm checkInForm = new CheckInForm("Shift");
                checkInForm.ShowDialog();

                if (checkInForm.DialogResult == DialogResult.OK)
                    Close();
            }

            else
            {
                MessageBox.Show("현재 사용중인 좌석이 없습니다");
            }

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PurchaseForm puchaseForm = new PurchaseForm();
            puchaseForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
