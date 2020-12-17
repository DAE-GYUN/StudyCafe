
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

            using (KoreanStudyCafeEntities context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.BeverageRecord
                            select new
                            {
                                UserCount = x.UserCount,
                                DayQuarter = x.DayQuarter,
                                Usage = x.Usage,
                                BeverageId = x.BeverageID,
                               
                            };

                var list = query.ToList();

                List<StockControlModels> models = new List<StockControlModels>();
                List<StockControlModels> beverages = new List<StockControlModels>();
               
                
                foreach (var item in list)
                {
                   // StockControlModels beverage = beverages.Find(x => x.BeverageId == 1);
                    StockControlModels model = models.Find(x => x.BeverageId == 1 && x.UserCount == item.UserCount && x.Usage == item.Usage);
                        
                    if (model != null)
                    {
                       // model.Quantity += item.Quantity;
                    }
                    else
                    {
                        model = new StockControlModels();
                        
                        model.UserCount = item.UserCount;
                        model.Usage = item.Usage;
                        model.DayQuater = item.DayQuarter;
                      
                        models.Add(model);

                    }
                }

                return models;
            }
        }

        public static List<StockControlModels> GetCocoaModel()
        {
            using(KoreanStudyCafeEntities context = new KoreanStudyCafeEntities())
            {
                var quary = from x in context.BeverageRecord
                            select new
                            {
                                UserCount = x.UserCount,
                                Useage = x.Usage,
                                BeverageId = x.BeverageID,
                                DayQuarter = x.DayQuarter
                            };

                var list = quary.ToList();

                List<StockControlModels> models = new List<StockControlModels>();

                foreach (var item in list)
                {
                    StockControlModels model = models.Find(x => x.BeverageId == 2 && x.Usage == item.Useage && x.UserCount == item.UserCount);

                    if(model == null)
                    {
                        model = new StockControlModels();
                        model.Usage = item.Useage;
                        model.UserCount = item.UserCount;
                        model.DayQuater = item.DayQuarter;

                        models.Add(model);
                    }

                 
                }
                return models;
            }
        }
    }
}
