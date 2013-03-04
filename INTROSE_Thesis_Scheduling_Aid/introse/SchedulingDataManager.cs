using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introse
{
    public class SchedulingDataManager
    {

        private List<Panelist> multiGroupPanelists;
        private DBce dbHandler;

        //This maps the thesis groups associated with a panelist.
        private Dictionary<Panelist, List<ThesisGroup>> panelistGroupMap;

        //This maps the index in the treeView to the appropriate Panelist
        private Dictionary<int, Panelist> indexPanelistMap;

        //This maps the index in the treeView to the appropriate ThesisGroup
        private Dictionary<int, ThesisGroup> indexThesisGroupMap;

        /*This will be used to draw the rectangles representing the defense schedules of
         * the currently selected thesis group. 
         * */
        private List<DefenseSchedule> clusterDefSchedules;

        //This will be used to draw the rectangles representing the free slots of the selected thesis group.
        private List<TimePeriod> selectedGroupFreeSlots;

        public SchedulingDataManager() 
        {
            multiGroupPanelists = new List<Panelist>();
            panelistGroupMap = new Dictionary<Panelist, List<ThesisGroup>>();
            indexPanelistMap = new Dictionary<int, Panelist>();
            indexThesisGroupMap = new Dictionary<int, ThesisGroup>();
            clusterDefSchedules = new List<DefenseSchedule>();
            selectedGroupFreeSlots = new List<TimePeriod>();
            dbHandler = new DBce();
            InitData();
        }

        private void InitData()
        {
            multiGroupPanelists.Clear();
            initMultiGroupPanelists();
            initPanelistGroupMap();

            //initIsolatedGroups();
        }

        /* This method queries the database to get all the Panelists who are
         * involved with more than one thesis group. Objects are created for them and stored in
         * the attribute: multiGroupPanelists.
         * */
        private void initMultiGroupPanelists()
        {
            //Get all panelistID's who are multi-grouped
            String query = "SELECT panelistID FROM panelassignment GROUP BY panelistID HAVING count(*) > 1";
        
            List<String> panelistIDs = new List<String>();
            List<String>[] columns = dbHandler.Select(query, 1);

            int size = columns[0].Count;
            for (int i = 0; i < size; i++) 
                panelistIDs.Add(columns[0].ElementAt(i));

            //Create the Panelist Objects for these multi-grouped panelists

            for (int i = 0; i < size; i++) 
            {
                query = "SELECT * FROM panelist where panelistID = '" + panelistIDs.ElementAt(i) + "';";
                columns = dbHandler.Select(query, 4);
                multiGroupPanelists.Add(new Panelist(columns[0].ElementAt(i), columns[1].ElementAt(i), columns[2].ElementAt(i), columns[3].ElementAt(i)));
                //should we initialize their schedules as well?
            }
        }
        
        /* This method initializes the Dictionary that maps a mulit-group panelist 
         * with the list of all thesis groups it is involved with. 
         * */
        private void initPanelistGroupMap() 
        {
            int size = multiGroupPanelists.Count;
            Panelist currPanelist;
            for (int i = 0; i < size; i++) 
            {
                currPanelist = multiGroupPanelists.ElementAt(i);
                panelistGroupMap.Add( currPanelist, getGroupsWithPanelist(currPanelist) );
            }
        }

        /* This method queries the database to get all the thesis groups who have the
         * panelist in the parameter as part of their panel. The method returns the list of 
         * such thesis groups.
         * */
        private List<ThesisGroup> getGroupsWithPanelist(Panelist panelist) 
        {
            String query = "SELECT thesisGroupID FROM panelassignment WHERE panelistId = '"+panelist.PanelistID+"';";
            List<String>[] columns = dbHandler.Select(query, 1);

            List<ThesisGroup> groups = new List<ThesisGroup>();
            List<String>[] colsForGroupInfo;

            int size = columns[0].Count;
            for (int i = 0; i < size; i++) 
            {
                query = "SELECT * FROM thesisgroup WHERE thesisGroupID = '" + columns[0].ElementAt(i) + "';";
                colsForGroupInfo = dbHandler.Select(query, 1);
                //groups.Add(new ThesisGroup(colsForGroupInfo[0].ElementAt(0), colsForGroupInfo[1].ElementAt(1)));
                //don't know what thesisgroup object should contain
            }
            return groups;
        }

        /* This method will be called by the UI to refresh clusterDefSchedules when a cluster is selected.
         * Note: this was previously named initDefenseSchedules()
         * */
        public void refreshClusterDefSchedules(DateTime start, DateTime end, int panelistIndex) 
        {
        
        }

        /* This method will be called by the UI to refresh selectedGroupFreeSlots when
         * a thesis group is selected.
         * */
        public void refreshSelectedGroupFreeSlots() 
        {
            
        }

        /* This method will be called by the UI when the user desires to schedule a defense
         * for the selected thesis group. If the schedule is valid, the method will return true.
         * Otherwise, it will return false.
         * */
        public bool insertScheduleIfValid(int groupIndex, DefenseSchedule defSched)
        {
            if(isScheduleValid(groupIndex, defSched))
            {
                return true;
            }
        
            return false;
        }

        /* This method is for checking whether a defense schedule is valid for a thesis group.
         * */
        private bool isScheduleValid(int groupIndex, DefenseSchedule defSched) 
        {

            return false;
        }

    }
}
