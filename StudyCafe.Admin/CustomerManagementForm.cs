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
            bdsUser.DataSource = _users;

        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            bdsUser.DataSource = Dao.User.GetAll();
        }

        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
            bdsUser.ResetBindings(false);
        }

        private void sbnSearch_Click(object sender, EventArgs e)
        {

            
            

        } 


    }
}
