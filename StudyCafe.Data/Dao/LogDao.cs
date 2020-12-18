
#region using
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
#endregion

namespace StudyCafe.Data
{
    public partial class LogDao : SingleKeyDao<Log, int>
    {
        protected override Expression<Func<Log, int>> KeySelector => x => x.LogID;

        protected override Expression<Func<Log, bool>> IsKey(int key)
        {
            return x => x.LogID == key;
        }
    }
}
