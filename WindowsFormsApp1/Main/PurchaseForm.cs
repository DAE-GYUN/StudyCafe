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
    public partial class PurchaseForm : Form
    {
        LockerTimeChargingForm lockerTimeChargingForm;
        public PurchaseForm()
        {
            InitializeComponent();
            
        }
   
        public PurchaseForm(LockerTimeChargingForm form):this()
        {
            lockerTimeChargingForm = form;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void btnSeetTimeCharnging_Click(object sender, EventArgs e)
        {
            SeatTimeChargingForm seatTimeChargingForm = new SeatTimeChargingForm();
            seatTimeChargingForm.ShowDialog();
        }

        private void btnStudyRoom_Click(object sender, EventArgs e)
        {
            if (Credential.Instance.User.CheckInStatus == true)
                MessageBox.Show("좌석이용중인 고객은 스터디룸을 예약할 수 없습니다.");
            else
            {
                CheckInForm checkInForm = new CheckInForm("StudyRoom");
                checkInForm.ShowDialog();
            }
            
        }

        private void btnLockers_Click(object sender, EventArgs e)
        {
            LockersForm lockersForm = new LockersForm();
            lockersForm.ShowDialog();

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void paymentControl1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
