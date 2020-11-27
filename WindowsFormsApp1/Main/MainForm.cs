using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lovanpis.UsingEntityFramework;
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
            //if (Credential.Instance.User.SeatID == null)
            //{
                CheckInForm checkInForm = new CheckInForm("CheckIn");
                checkInForm.ShowDialog();
            //}

            //else
            //{
            //    MessageBox.Show("이미 사용중인 자리가 있습니다");
            //    btnCheckIn.Enabled = false;
            //}
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("퇴실하시겠습니까?", "퇴실Or취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                MessageBox.Show("메인으로");
            }
        }

        private void btnShiftSeat_Click(object sender, EventArgs e)
        {
            CheckInForm checkInForm = new CheckInForm();
            checkInForm.ShowDialog();
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
