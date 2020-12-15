using System;
using System.Windows.Forms;
using WindowsFormsApp1ML.Model;

namespace StudyCafe.Admin
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            //double test = Predict.Predictor(1, "00시~06시", 24, "월");
            //MessageBox.Show(test.ToString());
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            CustomerManagementForm customerManagementForm = new CustomerManagementForm();
            customerManagementForm.MdiParent = this;
            customerManagementForm.Show();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            StockControlForm stockControlForm = new StockControlForm();
            stockControlForm.MdiParent = this;
            stockControlForm.Show();
        }
    }
}
