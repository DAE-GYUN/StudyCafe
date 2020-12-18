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
    public partial class StockControlForm : DevExpress.XtraEditors.XtraForm
    {
        public StockControlForm()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }


        private void StockControlForm_Load(object sender, EventArgs e)
        {
            scmBdsCoffee.DataSource = UserDao.GetCoffeModel();
            scmBdsCocoa.DataSource = UserDao.GetCocoaModel();
            scmBdsPredictCoffee.DataSource = UserDao.GetPredictCoffeModel();
        }

        private void stockControlModelsCocoaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}