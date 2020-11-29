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

            //List<Locker> lockers = Dao.Locker.GetAll();
            //for (int i = 0; i < 13; i++)
            //{
            //    if (lockers[i].UserID != null)
            //    {
            //        Locker locker = Dao.Locker.GetByUserID((int)(lockers[i].UserID));

            //        gbLockerNumber.Controls[int.Parse(locker.Name) -1 ].Enabled = false;
            //    }
            //}



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
