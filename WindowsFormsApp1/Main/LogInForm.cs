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
            Cursor = Cursors.WaitCursor;

            bgwLogin.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            User user = Dao.User.GetByPhoneNumber(txbUserPhoneNumber.Text);

            if (user != null)
            {
                Credential.Instance.User = user;
            }

            e.Result = user;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Arrow;
            User user = (User)e.Result;

            if (user != null)
            {
                MainForm mainform = new MainForm();
                mainform.ShowDialog();
                txbUserPhoneNumber.Text = "010";
            }

            else
            {
                txbUserPhoneNumber.Text = "010";
                MessageBox.Show("존재하지않는 회원입니다");
            }
        }
    }
}
