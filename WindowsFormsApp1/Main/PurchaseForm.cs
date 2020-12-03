using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Main;
using StudyCafe.Data;

namespace WindowsFormsApp1
{
    public partial class PurchaseForm : Form
    {
        public MainCart maincart;
        public PurchaseForm()
        {
            InitializeComponent();
            maincart = new MainCart();
        }
   
      

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            bdsItem.DataSource = _items;
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

            else if(Credential.Instance.User.RemainStudyRoomTime != 0)
                MessageBox.Show("스터디룸은 중복으로 사용할수 없습니다.");
            
            else
            {
                CheckInForm checkInForm = new CheckInForm("StudyRoom");
                checkInForm.ShowDialog();
            }
            
        }

        private void btnLockers_Click(object sender, EventArgs e)
        {
            LockersForm lockersForm = new LockersForm(this );
            lockersForm.ShowDialog();

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

      

        private List<Item> _items = new List<Item>();

        public void AddItem(Item item)
        {

            _items.Add(item);

            bdsItem.ResetBindings(false);
            ////bdsItem.DataSource = _items;  
            //// 다시 바인딩
            txbTotalPrice.Text = _items.Select(x => x.Price).Sum().ToString();
        }

        private string _lockerNumber;
        public void GetLockerNumber(string lockerNumber)
        {
            _lockerNumber = lockerNumber;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show($"{txbTotalPrice:c}을 결제 하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
  


                dgvItem.Columns.Clear();
            }
           else
            {

            }

        }
    }
}
