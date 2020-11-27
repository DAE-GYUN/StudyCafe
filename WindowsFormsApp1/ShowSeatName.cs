using StudyCafe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ShowSeatNumber
    {
        #region singleton
        private ShowSeatNumber()
        {
        }

        private static ShowSeatNumber _instance;

        public static ShowSeatNumber Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShowSeatNumber();

                return _instance;
            }
        }
        #endregion

        public string SeatName
        {
            get
            {
                return Seat.Name;
            }
        }

        public Seat Seat { get; set; }
    }
}
