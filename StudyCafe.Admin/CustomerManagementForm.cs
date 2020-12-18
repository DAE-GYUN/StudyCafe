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
            sbnSearch.Enabled = true;
            bdsUser.DataSource = Dao.User.GetAll();
            
           
        }


        private List<User> _users = new List<User>();


private void sbnSearch_Click(object sender, EventArgs e)
        {
         
            if (cbeSearch.Text == "")
            {
                MessageBox.Show("검색조건을 선택하세요");
            }
            else
            {
                bdsUser.DataSource = _users;
                List<User> users = Dao.User.GetAll();
                _users.Clear();

                if (cbeSearch.Text == "이름")
                {
                    foreach (var user in users)
                    {
                        if (txeSearch.Text == user.Name)
                        {
                            _users.Add(user);
                            bdsUser.ResetBindings(false);
                        }
                    }
                }

                else if (cbeSearch.Text == "전화번호")
                {
                    foreach (var user in users)
                    {
                        if (txeSearch.Text == user.PhoneNumber)
                        {
                            _users.Add(user);
                            bdsUser.ResetBindings(false);
                        }
                    }
                }

                else if (cbeSearch.Text == "회원번호")
                {
                    foreach (var user in users)
                    {
                        if (txeSearch.Text == user.UserID.ToString())
                        {
                            _users.Add(user);
                            bdsUser.ResetBindings(false);
                        }
                    }
                }

                if (_users.Count == 0)
                {
                    MessageBox.Show($"입력하신 {cbeSearch.Text}가 없습니다.");
                }
            }
        }
    
        private void sbnShowAll_Click(object sender, EventArgs e)
        {
            txeSearch.Text = "";
            cbeSearch.Text = default;
            bdsUser.DataSource = Dao.User.GetAll();
            bdsUser.ResetBindings(false);
        }

  
    }
}
