using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCafe.Data;

namespace WindowsFormsApp1
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();

            
            // 기간안의 데이터 가져오기
            //DateTime from = DateTime.Today.AddDays(-7);

            //List<Invoice> invoices = Dao.Invoice.GetFordDate(from, null);

            //foreach (var invoice in invoices)
            //{
            //    invoice.InvoiceDatetime = DateTime.Today;
            //    Dao.Invoice.Update(invoice);
            //}
            


        }
    }
}
