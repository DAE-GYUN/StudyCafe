
#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;
#endregion

namespace StudyCafe.Data
{
    public partial class UserDao : SingleKeyDao<User, int>
    {
        protected override Expression<Func<User, int>> KeySelector => x => x.UserID;

        protected override Expression<Func<User, bool>> IsKey(int key)
        {
            return x => x.UserID == key;
        }

        public User GetByPhoneNumber(string phoneNumber)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                return context.Users.FirstOrDefault(x => x.PhoneNumber == phoneNumber);
            }
        }

        public bool Exists(string text)
        {
            using (var contexrt  = new KoreanStudyCafeEntities())
            {
                return contexrt.Users.Any(x => x.PhoneNumber == text);
            }
        }

        
    }
}
