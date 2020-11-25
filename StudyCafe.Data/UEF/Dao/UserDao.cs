
#region using
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
    }
}
