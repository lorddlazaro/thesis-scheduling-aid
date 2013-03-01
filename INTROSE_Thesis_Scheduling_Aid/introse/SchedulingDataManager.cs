using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introse
{
    public class SchedulingDataManager
    {
        private List<Panelist> multiGroupPanelists;
        private Dictionary<Panelist, ThesisGroup> panelistGroupMap;
        private Dictionary<int, Panelist> indexMap;
        private List<DefenseSchedule> defenseScheds;
        private List<ThesisGroup> isolatedGroups;
        private DBce db;

        //Getters
        public List <Panelist> MultiGroupPanelists{get{return multiGroupPanelists;}}
        public Dictionary<Panelist, ThesisGroup> PanelistGroupMap{ get{return panelistGroupMap;}}
        public Dictionary<int, Panelist> IndexMa{get{return indexMap;}}      
        public List<DefenseSchedule> DefenseScheds{ get{return defenseScheds;}}

        public SchedulingDataManager()
        {
            db = new DBce();
            multiGroupPanelists = new List<Panelist>();
            panelistGroupMap = new Dictionary<Panelist, ThesisGroup>();
            indexMap = new Dictionary<int, Panelist>();
            defenseScheds = new List<DefenseSchedule>();
            isolatedGroups = new List<ThesisGroup>();

            initData();
        }

        private void initData()
        {
            initMultiGroupPanelists();
            initIsolatedGroups();
        }

        /*Fills up the multiGroupPanelists attribute with Panelist objects representing the panelists
        who are involved with more than one thesis group. */
        private void initMultiGroupPanelists()
        {
            multiGroupPanelists.Clear();
            String query = "select panelistID from panelAssignment group by panelistID having count(*) > 1;";
            List<string> [] panelistIDs =  db.Select(query, 1);
            List<string>[] panelistInfo;
            for(int i=0;i<panelistIDs[0].Count;i++)
            {
                query = "select * from paenlists where panelistID = "+panelistIDs[0].ElementAt(i)+";";
                panelistInfo = db.Select(query, 4);
                multiGroupPanelists.Add(new Panelist(panelistInfo[0].ElementAt(0), panelistInfo[1].ElementAt(0), panelistInfo[2].ElementAt(0), panelistInfo[3].ElementAt(0)));
            }

        }

        private void initIsolatedGroups() 
        {
        
        }

        public void initDefenseSchedules(DateTime start, DateTime end, )

    }
}
