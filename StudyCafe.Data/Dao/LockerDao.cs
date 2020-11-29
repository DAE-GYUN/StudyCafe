
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
    }
}
