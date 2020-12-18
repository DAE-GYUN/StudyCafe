using System;
using System.Linq;
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


        private void ShowChild(Form form)
        {
            var childform = MdiChildren.FirstOrDefault(x => x.GetType() == form.GetType());

            if (childform == null)
            {
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                childform.Focus();
            }
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            ShowChild(new CustomerManagementForm());

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            ShowChild(new StockControlForm());
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            ShowChild(new LogForm());
        }
    }
}
