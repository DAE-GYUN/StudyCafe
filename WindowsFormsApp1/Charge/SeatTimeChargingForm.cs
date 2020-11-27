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
    public partial class SeatTimeChargingForm : Form
    {
        public SeatTimeChargingForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txbUserNumber.Text = Credential.Instance.User.PhoneNumber;

        }

        private void rbtn2Hours_CheckedChanged(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByKey(1);
            txbItemName.Text = item.Name.ToString();
            txbPrice.Text = item.Price.ToString();
        }

        private void rbtn5Hours_CheckedChanged(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByKey(2);
            txbItemName.Text = item.Name.ToString();
            txbPrice.Text = item.Price.ToString();
        }

        private void rbtn12Hours_CheckedChanged(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByKey(3);
            txbItemName.Text = item.Name.ToString();
            txbPrice.Text = item.Price.ToString();
        }

        private void rbtn30Hours_CheckedChanged(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByKey(4);
            txbItemName.Text = item.Name.ToString();
            txbPrice.Text = item.Price.ToString();
        }

        private void rbtn60Hours_CheckedChanged(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByKey(5);
            txbItemName.Text = item.Name.ToString();
            txbPrice.Text = item.Price.ToString();
        }

        private void rbtn100Hours_CheckedChanged(object sender, EventArgs e)
        {
            Item item = Dao.Item.GetByKey(6);
            txbItemName.Text = item.Name.ToString();
            txbPrice.Text = item.Price.ToString();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
