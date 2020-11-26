
#region using
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
#endregion

namespace StudyCafe.Data
{
    public partial class StudyRoomDao :SingleKeyDao<StudyRoom, int>
    {
        protected override Expression<Func<StudyRoom, int>> KeySelector => x => x.StudyRoomID;

        protected override Expression<Func<StudyRoom, bool>> IsKey(int key)
        {
            return x => x.StudyRoomID == key;
        }

        public StudyRoom GetByKey(int StudyRoomId)
        {
            using(var context = new KoreanStudyCafeEntities())
            {
                var query = from x in context.StudyRooms
                            where x.StudyRoomID == StudyRoomId
                            select x;

                return query.FirstOrDefault();

            }
        }
    }
}
