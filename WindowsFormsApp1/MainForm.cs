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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInForm checkInForm = new CheckInForm();
            checkInForm.ShowDialog();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOutForm = new CheckOutForm();
            checkOutForm.ShowDialog();
        }

        private void btnShiftSeat_Click(object sender, EventArgs e)
        {
            ShiftSeatForm shiftSeatForm = new ShiftSeatForm();
            shiftSeatForm.ShowDialog();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PuchaseForm puchaseForm = new PuchaseForm();
            puchaseForm.ShowDialog();
        }
    }
}
