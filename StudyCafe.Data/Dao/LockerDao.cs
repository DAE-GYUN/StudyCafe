
#region using
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
#endregion

namespace StudyCafe.Data
{
    public partial class LockerDao : SingleKeyDao<Locker, int>
    {
        protected override Expression<Func<Locker, int>> KeySelector => x => x.LockerID;

        protected override Expression<Func<Locker, bool>> IsKey(int key)
        {
            return x => x.LockerID == key;
        }


        public Locker GetByKey(int LockserId)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.Lockers
                            where x.LockerID == LockserId
                            select x;

                return query.FirstOrDefault();

            }
        }

        public Locker GetByUserID(int userID)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                return context.Lockers.FirstOrDefault(x => x.UserID == userID);
            }
        }
    }
}
