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

        private void Button_click(object sender, EventArgs e)
        {
            txbSeatNumber.Text = Dao.Seat.GetByKey(1).Name.ToString();
        }
        

    }

   

}
