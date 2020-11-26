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

        private string _select;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_select == "StudyRoom")
                groupBox3.Enabled = false;
            else if (_select == "CheckIn")
                groupBox2.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnCheckIn_Click(object sender, EventArgs e)
        {
                SeatNumberCheckForm seatNumberCheck = new SeatNumberCheckForm();
                seatNumberCheck.ShowDialog();
        }

        private void txbSeatNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSeat1_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(1).Name.ToString();
        }

        private void btnSeat2_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(2).Name.ToString();
        }

        private void btnSeat3_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(3).Name.ToString();
        }

        private void btnSeat4_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(4).Name.ToString();
        }

        private void btnSeat5_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(5).Name.ToString();
        }

        private void btnSeat6_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(6).Name.ToString();
        }

        private void btnSeat7_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(7).Name.ToString();
        }

        private void btnSeat8_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(8).Name.ToString();
        }

        private void btnSeat9_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(9).Name.ToString();
        }

        private void btnSeat10_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(10).Name.ToString();
        }

        private void btnSeat11_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(11).Name.ToString();
        }

        private void btnSeat12_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(12).Name.ToString();
        }

        private void btnSeat13_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(13).Name.ToString();
        }

        private void btnSeat14_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(14).Name.ToString();
        }

        private void btnSeat15_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(15).Name.ToString();
        }

        private void btnSeat16_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(16).Name.ToString();
        }

        private void btnSeat17_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(17).Name.ToString();
        }

        private void btnSeat18_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(18).Name.ToString();
        }

        private void btnSeat19_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(19).Name.ToString();
        }

        private void btnSeat20_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(20).Name.ToString();
        }

        private void btnSeat21_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(21).Name.ToString();
        }

        private void btnSeat22_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(22).Name.ToString();
        }

        private void btnSeat23_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(23).Name.ToString();
        }

        private void btnSeat24_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(32).Name.ToString();
        }

        private void btnStudyRoom1_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.StudyRoom.GetByKey(1).Name.ToString();
        }

        private void btnStudyRoom2_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.StudyRoom.GetByKey(2).Name.ToString();
        }

        private void btnStudyRoom3_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.StudyRoom.GetByKey(3).Name.ToString();
        }

        private void btnStudyRoom4_Click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.StudyRoom.GetByKey(4).Name.ToString();
        }
    }

   

}
