﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCafe.Data
{
    public class Dao
    {
        public static InvoiceDao Invoice = new InvoiceDao();

        public static UserDao User = new UserDao();

        public static ItemDao Item = new ItemDao();

        public static SeatDao Seat = new SeatDao();

        public static StudyRoomDao StudyRoom = new StudyRoomDao();

        public static PictureDao Picture = new PictureDao();

        public static LockerDao Locker = new LockerDao();

        public static InvoiceLineDao InvoiceLine = new InvoiceLineDao();

        public static LogDao Log = new LogDao();

        
       
    }
}
