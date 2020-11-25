using StudyCafe.Data;
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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if(txbUserPhoneNumber.TextLength < 11)
                txbUserPhoneNumber.Text += ((Button)sender).Text.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txbUserPhoneNumber.Text.Length >= 1)
                txbUserPhoneNumber.Text = txbUserPhoneNumber.Text.Remove(txbUserPhoneNumber.Text.Length - 1, 1);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            User user = Dao.User.GetByPhoneNumber(txbUserPhoneNumber.Text);

            if (user.PhoneNumber.Equals(txbUserPhoneNumber.Text))
            {
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                txbUserPhoneNumber.Text = "";
            }
            
        }
    }
}
