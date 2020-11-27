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

namespace WindowsFormsApp1
{
    public partial class LockerTimeChargingForm : Form
    {
        public LockerTimeChargingForm()
        {
            InitializeComponent();
        }

       

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txbUserNumber.Text = Credential.Instance.PhoneNumber;
            txbLockerRemainTime.Text = Credential.Instance.User.RemainLockerTime.ToString();
            txbRemainTime.Text = Credential.Instance.User.RemainSeatTime.ToString();
          

        }

        private void btn1Week_Click(object sender, EventArgs e)
        {

            Item item = Dao.Item.GetByKey(10);
            txbPrice.Text = item.Price.ToString();
         
        }

        private void btn3Week_Click(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByKey(11);
            txbPrice.Text = item.Price.ToString();
        }

        private void btn1Month_Click(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByKey(12);
            txbPrice.Text = item.Price.ToString();
        }

        private void btnPayMent_Click(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByKey(10);
            uscItem.AddItem(item);
            txbPrice.Text = null;

         
         
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LockersForm lockersForm = new LockersForm();
            lockersForm.ShowDialog();
        }

        private void paymentControl1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
