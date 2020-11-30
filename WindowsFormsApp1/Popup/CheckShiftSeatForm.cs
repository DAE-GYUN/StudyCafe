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
    public partial class CheckShiftSeatForm : Form
    {
        public CheckShiftSeatForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string presentSeatNumber = Dao.Seat.GetByUserKey(Credential.Instance.User.UserID);

            txbNowSeatNumber.Text = presentSeatNumber;
            txbMovedSeatNumber.Text = _seatNumber;
            txbUserNumber.Text = Credential.Instance.User.PhoneNumber;
            int credentialUser = Credential.Instance.User.UserID;
            txbRemainTime.Text = $"{Dao.User.GetByPK(credentialUser).RemainSeatTime / 60}시간 {Dao.User.GetByPK(credentialUser).RemainSeatTime % 60 }분 ";
        }

        public CheckShiftSeatForm(string setNumber) : this()
        {
            _seatNumber = setNumber;
        }

        private string _seatNumber;

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int userCredential = Credential.Instance.User.UserID;

            Seat nowSeat = Dao.Seat.GetByKey(int.Parse(txbNowSeatNumber.Text));
            nowSeat.UserID = null;
            Dao.Seat.Update(nowSeat);

            Seat movedSeat = Dao.Seat.GetByKey(int.Parse(_seatNumber));
            movedSeat.UserID = Credential.Instance.User.UserID;
            Dao.Seat.Update(movedSeat);

            MessageBox.Show($"{movedSeat.Name}번 자리로 이동되었습니다");

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbRemainTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
