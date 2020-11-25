using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyCafe.Data;

namespace WindowsFormsApp1
{
    public class Credential
    {
        #region singleton
        private Credential()
        {
        }

        private static Credential _instance;

        public static Credential Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Credential();

                return _instance;
            }
        }
        #endregion

        public string PhoneNumber
        {
            get
            {
                return User.PhoneNumber;
            }
        }

        public User User { get; set; }
        

    }
}
