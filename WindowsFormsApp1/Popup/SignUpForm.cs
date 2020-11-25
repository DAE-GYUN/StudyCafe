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

namespace WindowsFormsApp1
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txbUserName.TextLength < 1 || txbUserPhoneNumber.TextLength < 11)
                MessageBox.Show("입력칸을 다 채우세요!!");
            else
            {

                User user = new User
                {
                    Name = txbUserName.Text,
                    PhoneNumber = txbUserPhoneNumber.Text
                };

                Dao.User.Insert(user);
                MessageBox.Show("가입완료");
                Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
