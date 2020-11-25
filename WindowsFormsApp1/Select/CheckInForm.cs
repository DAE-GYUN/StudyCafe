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
    public partial class CheckInForm : Form
    {
        public CheckInForm()
        {
            InitializeComponent();
        }

        public CheckInForm(string select) : this()
        {
            _select = select;
        }

        private string _select;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_select == "StudyRoom")
                groupBox3.Enabled = false;
            else if (_select == "CheckIn")
                groupBox2.Enabled = false;

        }
    }

   

}
