﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCafe.Data.Models
{
    public class StockControlModelPredict
    {
        public int UserCount { get; set; }
        public int Usage { get; set; }

        public string DayQuater { get; set; }

        public int BeverageId { get; set; }

        public DateTime Date { get; set; }
    }
}
