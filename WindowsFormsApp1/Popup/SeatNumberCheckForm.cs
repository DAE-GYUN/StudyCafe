using StudyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SeatNumberCheckForm : Form
    {
        public SeatNumberCheckForm()
        {
            InitializeComponent();
        }

        public SeatNumberCheckForm(string seatNumber) : this()

        {
            _seatNumber = seatNumber;
        }

        private string _seatNumber;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txbRemainTime.Text = Credential.Instance.User.RemainSeatTime.ToString();
            txbSelectSeatNumber.Text = _seatNumber;
            txbUserNumber.Text = Credential.Instance.User.PhoneNumber;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int userCredential = Credential.Instance.User.UserID;
            int userId = Dao.User.GetByUserKey(userCredential);

            User user = Dao.User.GetByPK(userId);
            user.LoginStatus = true;
            Dao.User.Update(user);

            Seat seat = Dao.Seat.GetByPK(int.Parse(_seatNumber));
            seat.UserID = userCredential;
            Dao.Seat.Update(seat);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
