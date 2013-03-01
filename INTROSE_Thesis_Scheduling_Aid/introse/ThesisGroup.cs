using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introse
{
    public class ThesisGroup
    {
        int id;
        String title;
        String course;
        String section;
        String startSY;
        int startTerm;

        public ThesisGroup(int id, String title, String course, String section, String startSY, int startTerm) 
        {
            this.id = id;
            this.title = title;
            this.course = course;
            this.section = section;
            this.startSY = startSY;
            this.startTerm = startTerm;
        }
    }
}
