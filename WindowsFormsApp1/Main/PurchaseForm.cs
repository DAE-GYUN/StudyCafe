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
        //public MainCart maincart;
        public PurchaseForm()
        {
            InitializeComponent();
          //  maincart = new MainCart();
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
            int userId = Credential.Instance.User.UserID;
            
            Locker locker = Dao.Locker.GetByUserId(userId);

            if(locker == null)
            {
                LockersForm lockersForm = new LockersForm(this);
                lockersForm.ShowDialog();
            }

            else
            {
                if (MessageBox.Show("이미 사물함이 있습니다. 시간을 구매하시겠습니까?", "구매여부", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                   
                    
                    LockerTimeChargingForm lockerTimeChargingForm = new LockerTimeChargingForm(this);
                    lockerTimeChargingForm.ShowDialog();
                }
                
            }
            
           

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

      
        //아이템을 담을 리스트 생성 =>  장바구니
        private List<Item> _items = new List<Item>();


        // 아이템 추가
        public void AddItem(Item item)
        {
            _items.Add(item);
            bdsItem.ResetBindings(false);
            txbTotalPrice.Text = _items.Select(x => x.Price).Sum().ToString();
        }  


        public void DeleteItem(Item item)
        {

            for (int i = 0; i < _items.Count; i++)
            {
                if(_items[i]==item)
                {
                    _items.RemoveAt(i);
                }
            }

            bdsItem.ResetBindings(false);
            txbTotalPrice.Text = _items.Select(x => x.Price).Sum().ToString();
        }

      

        private string _lockerNumber;
        public void GetLockerNumber(string lockerNumber)
        {
            _lockerNumber = lockerNumber;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show($"{txbTotalPrice.Text:c}을 결제 하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                foreach (var itemNumber in _items)
                {
                    int userId = Credential.Instance.User.UserID;

                    if(itemNumber.Kind=="Seat")
                    {

                    }

                    else if (itemNumber.Kind=="StudyRoom")
                    {

                    }

                    else
                    {
                        int lockerTime = Credential.Instance.User.RemainLockerTime += itemNumber.Time;
                        MessageBox.Show($"{Credential.Instance.User.RemainLockerTime.ToString()}");

                        User user = Dao.User.GetByPK(userId);
                        user.RemainLockerTime = lockerTime;
                        Dao.User.Update(user);
                    }

                    
                }
                dgvItem.Columns.Clear();
                _items.Clear();            
            }


        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("삭제 하시겠습니까","네Or아니요",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                //현재 토탈 가격 - 삭제할 가격
                int oldTxbTotalPrice = int.Parse(txbTotalPrice.Text);
                string price = dgvItem.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                string deleteUserId = dgvItem.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

                // _item 리스트에 들어있는 아이템 삭제
                Item item = Dao.Item.GetByPK(int.Parse(deleteUserId));

                DeleteItem(item);
                //토탈 가격
                txbTotalPrice.Text = (oldTxbTotalPrice - int.Parse(price)).ToString();

                //행 삭제
                int rw = dgvItem.CurrentCell.RowIndex;
                dgvItem.Rows.RemoveAt(rw);
               
            }

        }
 
    }
}
