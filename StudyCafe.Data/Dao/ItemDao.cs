
#region using
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
#endregion

namespace StudyCafe.Data
{
    public partial class ItemDao : SingleKeyDao<Item, int>
    {
        protected override Expression<Func<Item, int>> KeySelector => x => x.ItemID;

        protected override Expression<Func<Item, bool>> IsKey(int key)
        {
            return x=> x.ItemID==key;
        }

        public Item GetByKey(int itemId)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.Items
                            where x.ItemID == itemId
                            select x;

                return query.First();
            }
        }
    }
}
