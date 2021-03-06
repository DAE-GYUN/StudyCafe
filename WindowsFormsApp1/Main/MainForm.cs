﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            int phoneNumber = int.Parse(Credential.Instance.User.PhoneNumber);
            string firstNumber = String.Format("{0:D3}", phoneNumber / 100000000);
            string secondNumber = String.Format("{0:D4}", (phoneNumber % 100000000) / 10000);
            string thirdNumber = String.Format("{0:D4}", phoneNumber % 1000);
            txbUserNumber.Text = $"{firstNumber}-{secondNumber}-{thirdNumber}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            int userCredential = Credential.Instance.User.UserID;
            int userId = Dao.User.GetByUserKey(userCredential);

            User user = Dao.User.GetByPK(userId);
            user.IsLogin = false;
            Dao.User.Update(user);
            Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (Credential.Instance.User.CheckInStatus == true)
            {
                MessageBox.Show("현재 사용중인 좌석이 있습니다");
            }

            else if (Credential.Instance.User.RemainStudyRoomTime != 0)
            {
                MessageBox.Show("스터디룸을 사용중인 고객은 좌석을 이용할 수 없습니다");
            }

            else if (Credential.Instance.User.RemainSeatTime == 0)
            {
                MessageBox.Show("좌석 이용시간을 충전해 주세요");
            }

            else
            {
                CheckInForm checkInForm = new CheckInForm("CheckIn");
                checkInForm.ShowDialog();

                if (checkInForm.DialogResult == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (Credential.Instance.User.CheckInStatus == true)
            {
                if (MessageBox.Show("퇴실하시겠습니까?", "퇴실Or취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int userCredential = Credential.Instance.User.UserID;
                    int userId = Dao.User.GetByUserKey(userCredential);

                    Seat seat = Dao.Seat.GetByUserID(userCredential);
                    seat.UserID = null;
                    Dao.Seat.Update(seat);

                    User user = Dao.User.GetByPK(userId);
                    user.CheckInStatus = false;
                    user.IsLogin = false;
                    Dao.User.Update(user);
                    Close();
                }
            }

            else if (Credential.Instance.User.RemainStudyRoomTime != 0)
            {
                if (MessageBox.Show("퇴실하시겠습니까?" +
                    "스터디룸은 남은 시간이 저장되지 않습니다",
                    "퇴실Or취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int userCredential = Credential.Instance.User.UserID;
                    int userId = Dao.User.GetByUserKey(userCredential);

                    User user = Dao.User.GetByPK(userId);
                    user.RemainStudyRoomTime = 0;
                    user.IsLogin = false;
                    Dao.User.Update(user);
                    Close();
                }
            }

            else
            {
                MessageBox.Show("현재 사용중인 좌석이 없습니다");
            }
        }

        private void btnShiftSeat_Click(object sender, EventArgs e)
        {
            if (Credential.Instance.User.CheckInStatus == true)
            {
                CheckInForm checkInForm = new CheckInForm("Shift");
                checkInForm.ShowDialog();

                if (checkInForm.DialogResult == DialogResult.OK)
                {
                    Close();
                }
            }

            else
            {
                MessageBox.Show("현재 사용중인 좌석이 없습니다");
            }

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PurchaseForm puchaseForm = new PurchaseForm();
            puchaseForm.ShowDialog();

            if (puchaseForm.DialogResult == DialogResult.OK)
                txbRemainTime.Text = Credential.Instance.User.RemainSeatTime.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int credentialUser = Credential.Instance.User.UserID;
            txbRemainTime.Text = $"{Dao.User.GetByPK(credentialUser).RemainSeatTime / 60}시간 {Dao.User.GetByPK(credentialUser).RemainSeatTime % 60}분";
        }
    }
}
