using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyCafe.Admin
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
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
