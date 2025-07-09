using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    public struct HireDate
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

        public HireDate(int day, int month, int year)
        {
            Day = (day >= 1 && day <= 31) ? day : 1;
            Month = (month >= 1 && month <= 12) ? month : 1;
            Year = (year >= 1900) ? year : 2000;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }


}
