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
using EFLibrary;
using System.IO;
using WindowsFormsApp1.Popup;

namespace WindowsFormsApp1
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txbUserName.TextLength < 1 || txbUserPhoneNumber.TextLength < 11)
                MessageBox.Show("입력칸을 다 채우세요!!");
            else if(pbUserImage.Image == null)
                MessageBox.Show("사진을 등록해 주세요");
            else
            {
                User user = new User
                {
                    Name = txbUserName.Text,
                    PhoneNumber = txbUserPhoneNumber.Text,
                    PictureID = Dao.Picture.GetMaxKey()
                };

                Dao.User.Insert(user);
                MessageBox.Show("가입완료");
                Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (pbUserImage.Image != null)
            {
                int maxKey = Dao.Picture.GetMaxKey();
                Dao.Picture.DeleteByPK(maxKey);
            }
            Close();
        }

        private void btnSnapshot_Click(object sender, EventArgs e)
        {
            SnapshotForm snapshotForm = new SnapshotForm();
            snapshotForm.ShowDialog();

            if (snapshotForm.DialogResult == DialogResult.OK)
            {
                int maxPictureKey = Dao.Picture.GetMaxKey();

                byte[] userByteImage = Dao.Picture.GetByPK(maxPictureKey).value;
                Image userImage = ByteArrayToImage(userByteImage);

                pbUserImage.Image = userImage;

                btnSnapshot.Enabled = false;
            }
        }

        public Image ByteArrayToImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            Image recImg = Image.FromStream(ms);
            return recImg;
        }

        private void btnPhoneNumberCheck_Click(object sender, EventArgs e)
        {
            if(txbUserPhoneNumber.Text.Length < 11)
            {
                MessageBox.Show("올바르게 입력하세요");
            }

            else
            {
                Cursor = Cursors.WaitCursor;
                bgwDuplicateCheck.RunWorkerAsync();
            }   
        }

        

        private void bgwDuplicateCheck_DoWork(object sender, DoWorkEventArgs e)
        {
            User user = Dao.User.GetByPhoneNumber(txbUserPhoneNumber.Text);

            e.Result = user;
        }

        private void bgwDuplicateCheck_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Arrow;
            User user = (User)e.Result;

            if (user != null)
            {
                MessageBox.Show("이미 존재하는 번호입니다");
            }

            else
            {
                if (MessageBox.Show("가입 가능한 번호입니다. 사용하시겠습니까?",
                    "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnSignUp.Enabled = true;
                    txbUserPhoneNumber.ReadOnly = true;
                }
            }
        }
    }
}
