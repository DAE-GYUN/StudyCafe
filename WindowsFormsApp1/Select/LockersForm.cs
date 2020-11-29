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
    public partial class LockersForm : Form
    {
        public LockersForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        private void btnLocker1_Click(object sender, EventArgs e)
        {
            LockerTimeChargingForm lockerTimeChargingForm = new LockerTimeChargingForm();
            lockerTimeChargingForm.ShowDialog();
            Close();
        }

        private void btnLocker2_Click(object sender, EventArgs e)
        {
            btnLocker1.PerformClick();
        }

        private void btnLocker3_Click(object sender, EventArgs e)
        {
            btnLocker1.PerformClick();
        }

        private void btnLocker4_Click(object sender, EventArgs e)
        {
            btnLocker1.PerformClick();
        }

        private void btnLocker5_Click(object sender, EventArgs e)
        {
            btnLocker1.PerformClick();
        }

        private void btnLocker6_Click(object sender, EventArgs e)
        {
            btnLocker1.PerformClick();
        }

        private void btnLocker7_Click(object sender, EventArgs e)
        {
            btnLocker1.PerformClick();
        }

        private void btnLocker8_Click(object sender, EventArgs e)
        {
            btnLocker1.PerformClick();
        }

        private void btnLocker9_Click(object sender, EventArgs e)
        {
            btnLocker1.PerformClick();
        }

        private void btnLocker10_Click(object sender, EventArgs e)
        {
            btnLocker1.PerformClick();
        }

        private void btnLocker11_Click(object sender, EventArgs e)
        {
            btnLocker1.PerformClick();
        }

        private void btnLocker12_Click(object sender, EventArgs e)
        {
            btnLocker1.PerformClick();
        }

        private void btnLockersCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
