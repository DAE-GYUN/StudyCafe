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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BeverageChartActualForm BeverageChart = new BeverageChartActualForm();
            BeverageChart.MdiParent = this;
            BeverageChart.Show();

          //  machineLearningTempBindingSource.DataSource = // 리턴받은 리스트 대입
        }

        private void StockControlForm_Load(object sender, EventArgs e)
        {
            StockControlForm coffeUseage = new StockControlForm();
            
            
            stockControlModelsBindingSource.DataSource = UserDao.GetCoffeModel();

            StockControlForm cocoaUseage = new StockControlForm();

            stockControlModelsBindingSource.DataSource = UserDao.GetCocoaModel();
        }
    }
}