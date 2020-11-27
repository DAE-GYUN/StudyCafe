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
            dgvItem.DataSource = _items;
  
            
        }
        private List<Item> _items = new List<Item>();

        public void AddItem(Item item)
        {
       
            _items.Add(item);

            // 다시 바인딩

        }

       
    }

}
