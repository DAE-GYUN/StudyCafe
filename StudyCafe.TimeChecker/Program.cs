using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EFLibrary;
using StudyCafe.Data;

namespace StudyCafe.TimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContextCreator.Context = () => new KoreanStudyCafeEntities();

            List<User> CheckInStatus = Dao.User.GetByCheckInStatus(true);

            foreach (var user in CheckInStatus)
            {
                if (user.RemainSeatTime != 0)
                {
                    user.RemainSeatTime -= 1;
                    Dao.User.Update(user);
                }
            }
        }
    }
}
