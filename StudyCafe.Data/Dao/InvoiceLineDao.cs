
#region using
using EFLibrary;
using System.Collections.Generic;
using System.Linq;
using StudyCafe.Data;
using System.Linq.Expressions;
using System;
#endregion

namespace StudyCafe.Data
{
    public partial class InvoiceLineDao : DualKeyDao<InvoiceLine, int, int>
    {
        protected override Expression<Func<InvoiceLine, bool>> IsKey(int key1, int key2)
        {
            return x => x.ItemID == key1 && x.InvoiceID == key2;
        }


    }
}
