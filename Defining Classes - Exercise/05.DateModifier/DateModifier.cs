using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {

        public static int DifferenceBetweenTwoDates(string startDate, string endDate)
        {
            var firstDate = DateTime.Parse(startDate);
            var secondDate = DateTime.Parse(endDate);
            int days = (firstDate - secondDate).Days;
            return days;
        }
    }
}
