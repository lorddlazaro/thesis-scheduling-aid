﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introse
{
    public class DefenseSchedule : TimePeriod
    {
        
        private String place;
        private String groupTitle;

        public String Place { get { return place; } }
        public String GroupTitle{ get{ return groupTitle;} }
        

        public DefenseSchedule(DateTime startTime, DateTime endTime, String place, String groupTitle)
            :base(startTime, endTime)
        {
            this.place = place;
            this.groupTitle = groupTitle;
        }
    }
}