using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyCafe.Data;

namespace WindowsFormsApp1
{
    class GetSeatName
    {
        #region singleton
        private GetSeatName()
        {
        }

        private static GetSeatName _instance;

        public static GetSeatName Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GetSeatName();

                return _instance;
            }
        }
        #endregion

        public Seat seat { get; set; }

    }
}
