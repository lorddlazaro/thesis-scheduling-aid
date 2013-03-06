using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introse
{
    public class TimePeriod
    {
        private DateTime startTime;
        private DateTime endTime;

        public DateTime StartTime { get { return startTime; } }
        public DateTime EndTime { get { return endTime; } }

        public TimePeriod(DateTime startTime, DateTime endTime) 
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }

    }
}
