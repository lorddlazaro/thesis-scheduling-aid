using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introse
{
    public class Panelist
    {
        String id;
        String fName;
        String mi;
        String lName;

        public Panelist(String id, String fName, String mi, String lName) {
            this.id = id;
            this.fName = fName;
            this.mi = mi;
            this.lName = lName;
        }

    }
}
