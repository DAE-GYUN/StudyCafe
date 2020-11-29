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
    public partial class LockersForm : Form
    {
        public LockersForm()
        {
            InitializeComponent();

       
        }

        public string lockerNumber { get; set; }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //List<Locker> lockers = new List<Locker>();
            //lockers.AddRange(Dao.Locker.GetAll());
            //foreach (var lockcer in lockers)
            //{
            //    if(lockers.
            //}
            List<Locker> lockers = Dao.Locker.GetAll();
            for (int i = 0; i < 12; i++)
            {
                if (lockers[i].UserID != null)
                {
                    Locker locker = Dao.Locker.GetByUserId((int)lockers[i].UserID);

                    tlpLockerNumber.Controls[locker.LockerID - 1].Enabled = false;
                }
            }
        }

        private void btnLocker1_Click(object sender, EventArgs e)
        {

            lockerNumber = ((Button)sender).Tag.ToString();
            LockerTimeChargingForm lockerTimeChargingForm = new LockerTimeChargingForm(lockerNumber);
            lockerTimeChargingForm.ShowDialog();
            Close();
            
        }
        


        private void btnLockersCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
