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
    public partial class PaymentControl : UserControl
    {

   
        public PaymentControl()
        {
            InitializeComponent();
           
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
           
            bdsItem.DataSource = _items;
        }
        private List<Item> _items = new List<Item>();
        
        public void AddItem(Item item)
        {
            
            _items.Add(item);

            bdsItem.ResetBindings(false);
          //bdsItem.DataSource = _items;
            // 다시 바인딩
            txbTotalPrice.Text = _items.Select(x => x.Price).Sum().ToString();
        }

        private void bdsItem_CurrentChanged(object sender, EventArgs e)
        {

        }
    }

}
