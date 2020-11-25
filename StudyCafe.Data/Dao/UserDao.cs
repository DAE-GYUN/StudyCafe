
#region using
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace StudyCafe.Data
{
    public partial class UserDao
    {

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
