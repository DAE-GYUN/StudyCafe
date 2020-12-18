
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
        public static List<StockControlModels> GetCoffeModel()
        {
            DateTime yesterday = DateTime.Today.AddDays(-1);
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.BeverageRecords
                            orderby x.DayQuarter
                            where x.BeverageID == 1 && x.Date == yesterday
                            select new StockControlModels
                            {
                                UserCount = x.UserCount,
                                DayQuater = x.DayQuarter,
                                Usage = x.Usage
                            };

                return query.ToList();
            }


        }

        public static List<StockControlModelsCocoa> GetCocoaModel()
        {
            DateTime yesterday = DateTime.Today.AddDays(-1);
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.BeverageRecords
                            orderby x.DayQuarter
                            where x.BeverageID == 2 && x.Date == yesterday
                            select new StockControlModelsCocoa
                            {
                                UserCount = x.UserCount,
                                DayQuater = x.DayQuarter,
                                Usage = x.Usage,
                            };

                return query.ToList();
            }
        }
        

        public static List<StockControlModels> GetPredictCoffeModel()
        {
            DateTime lastWeek = DateTime.Today.AddDays(-7);
            using (var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.BeverageRecords
                            orderby x.DayQuarter
                            where x.BeverageID == 1 && x.Date == lastWeek
                            select new StockControlModels
                            {
                                UserCount = x.UserCount,
                                DayQuater = x.DayQuarter,
                                Usage = Predict.Predictor(1, x.DayQuarter, x.UserCount, GetDay(DateTime.Now)),
                            };
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
