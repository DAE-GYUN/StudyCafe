using DevExpress.XtraEditors;
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
    public partial class SalesManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public SalesManagementForm()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void tileBar_Click(object sender, EventArgs e)
        {

        }

        private void tileBar_Click_1(object sender, EventArgs e)
        {

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        private void chartControl2_Click(object sender, EventArgs e)
        {
         
        }
    }
}