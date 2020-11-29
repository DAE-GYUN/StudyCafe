
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

        public List<User> GetByCheckInStatus(bool staus)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.Users
                            where x.CheckInStatus == staus
                            select x;
                return query.ToList();
            }
        }

        public List<User> GetByLockerStatus(bool status)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.Users
                            where x.CheckInStatus == status
                            select x;
                return query.ToList();
            }
        }

        public List<User> GetByStudyRoomStatus(bool status)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.Users
                            where x.CheckInStatus == status
                            select x;
                return query.ToList();
            }
        }

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
            using (var contexrt = new KoreanStudyCafeEntities())
            {
                return contexrt.Users.Any(x => x.PhoneNumber == text);
            }
        }

        public int GetByUserKey(int userId)
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.Users
                            where x.UserID == userId
                            select x.UserID;

                return query.FirstOrDefault();
            }
        }
    }
}
