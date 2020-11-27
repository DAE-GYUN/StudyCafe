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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txbUserPhoneNumber.TextLength < 11)
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

            if (user != null)
            {
                Credential.Instance.User = user;

                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();

                if(mainForm.DialogResult == DialogResult.OK)
                {
                    
                    while (true)
                    {
                        if (mainForm.DialogResult == DialogResult.Cancel)
                        {
                            User thisUser = new User()
                            {
                                RemainSeatTime = user.RemainSeatTime
                            };
                            Dao.User.Update(thisUser);
                            break;
                        }
                        else
                        {
                            user.RemainSeatTime -= 1;
                        }
                    }
                }

                txbUserPhoneNumber.Text = "010";
            }

            else
            {
                MessageBox.Show("존재하지않는 회원입니다");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
