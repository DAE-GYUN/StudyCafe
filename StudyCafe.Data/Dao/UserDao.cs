
#region using
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;
using StudyCafe.Data.Models;
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
            using (var context = new KoreanStudyCafeEntities())
            {
                return context.Users.Any(x => x.PhoneNumber == text);
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


        public static List<StockControlModels> GetCoffeModel()
        {

            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.BeverageRecords
                            select new StockControlModels
                            {
                                UserCount = x.UserCount,
                                DayQuater = x.DayQuarter,
                                Usage = x.Usage,
                                BeverageId = 1,
                               // Date = DateTime.Now.AddDays(-1), 
                            };

                return query.ToList();
            }

          
        }

        public static List<StockControlModelsCocoa> GetCocoaModel()
        {
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.BeverageRecords
                            select new StockControlModelsCocoa
                            {
                                UserCount = x.UserCount,
                                DayQuater = x.DayQuarter,
                                Usage = x.Usage,
                                BeverageId = 2,
                                Date = DateTime.Now.AddDays(-1), 
                            };

                return query.ToList();
            }
        }
    }
}
