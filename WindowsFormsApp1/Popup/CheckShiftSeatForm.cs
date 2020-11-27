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

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
