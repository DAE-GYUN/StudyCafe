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

            List<User> users = Dao.User.GetAll();

            foreach (var user in users)
            {
                if (user.CheckInStatus == true)
                {
                    if (user.RemainSeatTime != 0)
                        user.RemainSeatTime -= 1;


                    else if (user.RemainSeatTime == 0)
                        user.CheckInStatus = false;
                }

                if (user.RemainLockerTime != 0)
                    user.RemainLockerTime -= 1;


                if (user.RemainStudyRoomTime != 0)
                    user.RemainStudyRoomTime -= 1;

                Dao.User.Update(user);
            }


        }
    }
}
