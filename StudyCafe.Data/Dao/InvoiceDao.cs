
#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;
#endregion

namespace StudyCafe.Data
{
    public partial class InvoiceDao : SingleKeyDao<Invoice, int>
    {
        protected override Expression<Func<Invoice, int>> KeySelector =>
            x => x.InvoiceID;


        protected override Expression<Func<Invoice, bool>> IsKey(int key)
        {
            return x => x.InvoiceID == key;
        }

        /// <summary>
        /// 정해진 기간의 데이터
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public List<Invoice> GetFordDate(DateTime? from, DateTime? to)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.Invoices
                            select x;

                if (from.HasValue)
                    query = query.Where(x => x.InvoiceDatetime >= from);

                if (to.HasValue)
                    query = query.Where(x => x.InvoiceDatetime <= to);

                return query.ToList();
            }
        }
        

        public List<DateTime> SelectFordDate(DateTime? from, DateTime? to)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.Invoices
                            select x.InvoiceDatetime;

                if (from.HasValue)
                    query = query.Where(x => x >= from);

                if (to.HasValue)
                    query = query.Where(x => x <= to);

                return query.Select(x => x).ToList();
            }
        }
    }
}
