using DevExpress.XtraEditors;
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


namespace StudyCafe.Admin
{
    public partial class CustomerManagementForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public CustomerManagementForm()
        {
            InitializeComponent();
          
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
            bdsUser.DataSource = Dao.User.GetAll();



        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            bdsUser.DataSource = Dao.User.GetAll();
        }

        private void grdUser_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
