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

        public MainForm(string userId) : this()
        {
            _userId = userId;
        }

        private string _userId;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CodeGenerator.Generate(new KoreanStudyCafeEntities(),
                @"C:\Users\kccistc\Desktop\KDJ\Git_StudyCafe\StudyCafe.Data");

            txbUserNumber.Text = _userId;
            User user = Dao.User.GetByPhoneNumber(_userId);
            txbRemainTime.Text = user.RemainSeatTime.ToString();
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
            if (MessageBox.Show("퇴실하시겠습니까?", "퇴실Or취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("좌석 해제");
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
    }
}
