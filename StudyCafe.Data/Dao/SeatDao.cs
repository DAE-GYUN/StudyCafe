
#region using
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
#endregion

namespace StudyCafe.Data
{
    public partial class SeatDao : SingleKeyDao<Seat, int>
    {
        protected override Expression<Func<Seat, int>> KeySelector => x => x.SeatID;

        protected override Expression<Func<Seat, bool>> IsKey(int key)
        {
            return x => x.SeatID == key;
        }
        public Seat GetByKey(int seatId)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.Seats
                            where x.SeatID == seatId
                            select x;

                return query.FirstOrDefault();
            }

        }

        public string GetByUserKey(int userId)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.Seats
                            where x.UserID == userId
                            select x.Name;

                return query.FirstOrDefault();
            }
        }
    }
}
