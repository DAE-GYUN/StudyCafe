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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void btnSeetTimeCharnging_Click(object sender, EventArgs e)
        {
            SeetTimeCharngingForm seetTimeCharngingForm = new SeetTimeCharngingForm();
            seetTimeCharngingForm.ShowDialog();
        }

        private void btnStudyRoom_Click(object sender, EventArgs e)
        {
            StudyRoomForm studyRoomForm = new StudyRoomForm();
            studyRoomForm.ShowDialog();
        }

        private void btnLockers_Click(object sender, EventArgs e)
        {
            LockersForm lockersForm = new LockersForm();
            lockersForm.ShowDialog();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
