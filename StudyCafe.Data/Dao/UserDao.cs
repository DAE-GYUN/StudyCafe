
#region using
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;
using StudyCafe.Data.Models;
using WindowsFormsApp1ML.Model;
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
        public static List<StockControlModels> GetModel(int beverageId)
        {
            DateTime yesterday = DateTime.Today.AddDays(-2);
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.BeverageRecords
                            orderby x.DayQuarter
                            where x.BeverageID == beverageId && x.Date == yesterday
                            select new StockControlModels
                            {
                                UserCount = x.UserCount,
                                DayQuater = x.DayQuarter,
                                Usage = x.Usage
                            };

                return query.ToList();
            }


        }

        public static List<StockControlModelPredict> GetPredictModel(int beverageId)
        {
            DateTime lastWeek = DateTime.Today.AddDays(-7);
            using (var context = new KoreanStudyCafeEntities())
            {
                
                var query = from x in context.BeverageRecords
                            orderby x.DayQuarter
                            where x.BeverageID == beverageId && x.Date == lastWeek
                            select x;

                List<BeverageRecord> list = query.ToList();

                var query2 = from x in list
                             select new StockControlModelPredict
                             {
                                 UserCount = x.UserCount,
                                 DayQuater = x.DayQuarter,
                                 Usage = Predict.Predictor(beverageId, x.DayQuarter, x.UserCount, GetDay(DateTime.Now))
                             };
                
                return query2.ToList();

                //return list.ConvertAll(x => new StockConreolModelPredictCoffee
                //{
                //    UserCount = x.UserCount,
                //    DayQuater = x.DayQuarter,
                //    Usage = Predict.Predictor(1, x.DayQuarter, x.UserCount, GetDay(DateTime.Now))
                //});
            }
        }

        private static string GetDay(DateTime dateTime)
        {
            string strDay = "";

            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    strDay = "월";
                    break;
                case DayOfWeek.Tuesday:
                    strDay = "화";
                    break;
                case DayOfWeek.Wednesday:
                    strDay = "수";
                    break;
                case DayOfWeek.Thursday:
                    strDay = "목";
                    break;
                case DayOfWeek.Friday:
                    strDay = "금";
                    break;
                case DayOfWeek.Saturday:
                    strDay = "토";
                    break;
                case DayOfWeek.Sunday:
                    strDay = "일";
                    break;
            }

            return strDay;
        }
    }
}
