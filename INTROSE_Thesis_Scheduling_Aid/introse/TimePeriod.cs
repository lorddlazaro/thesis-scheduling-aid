using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introse
{
    public class TimePeriod
    {
        DateTime date;
        DateTime startTime;
        DateTime endTime;

        public TimePeriod(DateTime date, DateTime startTime, DateTime endTime) 
        {
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
        }

    }
}
