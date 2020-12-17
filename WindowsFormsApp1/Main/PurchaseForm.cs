using StudyCafe.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            bdsItem.DataSource = _items;

        }

        private void btnSeetTimeCharnging_Click(object sender, EventArgs e)
        {
            SeatTimeChargingForm seatTimeChargingForm = new SeatTimeChargingForm(this);
            seatTimeChargingForm.ShowDialog();
        }

        private void btnStudyRoom_Click(object sender, EventArgs e)
        {
            if (Credential.Instance.User.CheckInStatus == true)
                MessageBox.Show("좌석이용중인 고객은 스터디룸을 예약할 수 없습니다.");

            else if (Credential.Instance.User.RemainStudyRoomTime != 0)
                MessageBox.Show("스터디룸은 중복으로 사용할수 없습니다.");

            else
            {
                CheckInForm checkInForm = new CheckInForm("StudyRoom", this);
                checkInForm.ShowDialog();
            }
        }

        private void btnLockers_Click(object sender, EventArgs e)
        {
            int userId = Credential.Instance.User.UserID;
            Locker locker = Dao.Locker.GetByUserId(userId);
            if (locker == null)
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
        private List<int> _itemsID = new List<int>();
        // 아이템 추가

        public void AddItem(Item item)
        {
            foreach (var itemid in _items)
            {
                _itemsID.Add(itemid.ItemID);
            }

            if(_itemsID.Contains(item.ItemID))
            {
                MessageBox.Show("중복구매안됨");
            }
            else
            {
                _items.Add(item);
                bdsItem.ResetBindings(false);
                txbTotalPrice.Text = _items.Select(x => x.Price).Sum().ToString();
                btnPayment.Enabled = true;
            }
    
            
        }

 

        public void DeleteItem(Item item)
        {

            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i] == item)
                {
                    _items.RemoveAt(i);
                }
            }
            bdsItem.ResetBindings(false);
            txbTotalPrice.Text = _items.Select(x => x.Price).Sum().ToString();
        }

        private string _lockerNumber;
        private string _studyRoomNumber;

        public void GetLockerNumber(string lockerNumber)
        {
            _lockerNumber = lockerNumber;
        }
        public void GetStudyRoomNumber(string studyRoomNumber)
        {
            _studyRoomNumber = studyRoomNumber;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice()
            {
                InvoiceDatetime = DateTime.Now,
                UserID = Credential.Instance.User.UserID,
                InvoicePlace = "1"
            };

            Dao.Invoice.Insert(invoice);

            int maxInvoiceKey = Dao.Invoice.GetCount();

            if (_items.Count == 0)
            {
                MessageBox.Show("결제할 품목이 없습니다.");
            }

            else if (MessageBox.Show($"{int.Parse(txbTotalPrice.Text):c0}을 결제 하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int totalPrice = 0;
                foreach (var itemNumber in _items)
                {
                    int userId = Credential.Instance.User.UserID;

                    if (itemNumber.Kind == "Seat")
                    {
                        int seatTime = Credential.Instance.User.RemainSeatTime += itemNumber.Time;
                        MessageBox.Show($"{Credential.Instance.User.RemainSeatTime}");
                        User user = Dao.User.GetByPK(userId);
                        user.RemainSeatTime = seatTime;
                        Dao.User.Update(user);
                        totalPrice += itemNumber.Price;
                    }

                    else if (itemNumber.Kind == "StudyRoom")
                    {
                        int strudyRoomTime = Credential.Instance.User.RemainStudyRoomTime += itemNumber.Time;
                        MessageBox.Show($"{Credential.Instance.User.RemainStudyRoomTime}");
                        User user = Dao.User.GetByPK(userId);
                        user.RemainStudyRoomTime = strudyRoomTime;
                        Dao.User.Update(user);
                        StudyRoom studyRoom = Dao.StudyRoom.GetByPK(int.Parse(_studyRoomNumber));
                        studyRoom.UserID = userId;
                        Dao.StudyRoom.Update(studyRoom);
                        totalPrice += itemNumber.Price;
                    }

                    else
                    {
                        if (_lockerNumber != null)
                        {
                            int lockerTime = Credential.Instance.User.RemainLockerTime += itemNumber.Time;
                            MessageBox.Show($"{Credential.Instance.User.RemainLockerTime}");

                            User user = Dao.User.GetByPK(userId);
                            user.RemainLockerTime = lockerTime;
                            Dao.User.Update(user);
                            Locker locker = Dao.Locker.GetByPK(int.Parse(_lockerNumber));
                            locker.UserID = userId;
                            Dao.Locker.Update(locker);
                            totalPrice += itemNumber.Price;
                        }

                        else
                        {
                            int lockerTime = Credential.Instance.User.RemainLockerTime += itemNumber.Time;
                            MessageBox.Show($"{Credential.Instance.User.RemainLockerTime}");

                            User user = Dao.User.GetByPK(userId);
                            user.RemainLockerTime = lockerTime;
                            Dao.User.Update(user);
                            totalPrice += itemNumber.Price;
                        }
                    }

                    InvoiceLine invoiceLine = new InvoiceLine()
                    {
                        InvoiceID = maxInvoiceKey,
                        ItemID = itemNumber.ItemID,
                        ItemPrice = totalPrice,
                        NumberOfItem = 1
                    };

                    Dao.InvoiceLine.Insert(invoiceLine);

                    //InvoiceLine invoiceLine1 = Dao.InvoiceLine.GetByPK(maxInvoiceKey, itemNumber.ItemID);
                    //if (invoiceLine1.ItemID == itemNumber.ItemID && invoiceLine1.InvoiceID == maxInvoiceKey)
                    //{
                    //    invoiceLine.NumberOfItem += 1;
                    //    Dao.InvoiceLine.Update(invoiceLine);
                    //}

                    //else
                    //    Dao.InvoiceLine.Insert(invoiceLine);

                }
                dgvItem.Rows.Clear();
                _items.Clear();
                txbTotalPrice.Clear();
            }
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("삭제 하시겠습니까", "네Or아니요", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
