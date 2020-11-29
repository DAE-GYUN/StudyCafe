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

            

            List<User> checkInStatus = Dao.User.GetByCheckInStatus(true);
            List<User> studyRoomUsers = Dao.User.GetAll();
            List<User> hasLockerUsers = Dao.User.GetAll();

            foreach (var hasLockeruser in hasLockerUsers)
            {
                if (hasLockeruser.RemainLockerTime != 0)
                {
                    hasLockeruser.RemainLockerTime -= 1;
                    Dao.User.Update(hasLockeruser);
                }
            }

            foreach (var checkInuser in checkInStatus)
            {
                if (checkInuser.RemainSeatTime != 0)
                {
                    checkInuser.RemainSeatTime -= 1;
                    Dao.User.Update(checkInuser);
                }

                else if(checkInuser.RemainSeatTime == 0)
                {
                    checkInuser.CheckInStatus = false;
                    Dao.User.Update(checkInuser);
                }
            }

            foreach (var studyRoomUser in studyRoomUsers)
            {
                if(studyRoomUser.RemainStudyRoomTime != 0)
                {
                    studyRoomUser.RemainStudyRoomTime -= 1;
                    Dao.User.Update(studyRoomUser);
                }
            }

            
        }
    }
}
