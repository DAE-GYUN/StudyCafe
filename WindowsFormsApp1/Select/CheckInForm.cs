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
    public partial class CheckInForm : Form
    {
        public CheckInForm()
        {
            InitializeComponent();
        }

        public CheckInForm(string select) : this()
        {
            _select = select;
        }

        private string _select, selectStudyRoom;

        private PurchaseForm purchaseForm;

        public CheckInForm(string select, PurchaseForm purchase) : this()
        {
            _select = select;
            purchaseForm = purchase;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_select == "StudyRoom")
                gbSeatNumber.Enabled = false;
            else
                gbStudyRoomNumber.Enabled = false;

            List<Seat> seats = Dao.Seat.GetAll();
            for (int i = 0; i < 24; i++)
            {
                if (seats[i].UserID != null)
                {
                    Seat seat = Dao.Seat.GetByUserID((int)(seats[i].UserID));

                    gbSeatNumber.Controls[int.Parse(seat.Name) - 1].Enabled = false;
                }
            }

            List<StudyRoom> studyRooms = Dao.StudyRoom.GetAll();
            for (int i = 0; i < 4; i++)
            {
                if (studyRooms[i].UserID != null)
                {
                    StudyRoom studyRoom = Dao.StudyRoom.GetByUserID((int)(studyRooms[i].UserID));

                    gbStudyRoomNumber.Controls[int.Parse(studyRoom.Name) - 1].Enabled = false;
                }
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (_select == "Shift")
            {
                CheckShiftSeatForm checkShiftSeatForm = new CheckShiftSeatForm(selectStudyRoom);
                checkShiftSeatForm.ShowDialog();
                if (checkShiftSeatForm.DialogResult == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else if (_select == "StudyRoom")
            {
                StudyRoomTimeChargingForm studyRoomTimeCharging = new StudyRoomTimeChargingForm(selectStudyRoom, purchaseForm);
                studyRoomTimeCharging.ShowDialog();
                if (studyRoomTimeCharging.DialogResult == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                SeatNumberCheckForm seatNumberCheck = new SeatNumberCheckForm(selectStudyRoom);
                seatNumberCheck.ShowDialog();
                if (seatNumberCheck.DialogResult == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }

        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectSeat_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = ((Button)sender).Text.ToString();
            selectStudyRoom = ((Button)sender).Tag.ToString();
        }
    }
}
