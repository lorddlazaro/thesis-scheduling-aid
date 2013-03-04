using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introse
{
    public class SchedulingDataManager
    {
        private DBce dbHandler;

        /*This will be used to draw the rectangles representing the defense schedules of
         * the currently selected thesis group. 
         * */
        private List<DefenseSchedule> clusterDefScheds;

        //This will be used to store the free times of the selected thesis group
        private List<TimePeriod> selectedGroupFreeTimes;

        //This will be used to draw the rectangles representing the free slots of the selected thesis group.
        //private List<TimePeriod> selectedGroupFreeSlots;

        //Getters

        public List<DefenseSchedule> ClusterDefScheds { get { return clusterDefScheds; } }
        public List<TimePeriod> SelectedGroupFreeTimes { get { return selectedGroupFreeTimes; } }

        public SchedulingDataManager()
        {
            clusterDefScheds = new List<DefenseSchedule>();
            selectedGroupFreeTimes = new List<TimePeriod>();
            dbHandler = new DBce();
            InitData();
        }

        private void InitData()
        {
            initMultiGroupPanelists();
            initPanelistGroupMap();

            //initIsolatedGroups();
        }

        /* This method will be called by the GUI to add multigrouped panelists to the tree.
         * */
        public void AddPanelistsToTree()
        {
        
        }

        public void AddGroupsToTree() 
        {
        
        }
       

        /*The following two methods are the important ones for initializing the lists 
         * to be used for drawing the available times and defense schedules.
         * */

        /* This method will be called by the UI to refresh clusterDefSchedules when a cluster is selected.
         * Note: this was previously named initDefenseSchedules()
         * */
        public void RefreshClusterDefSchedules(DateTime start, DateTime end, int panelistID)
        {

        }


        /* This method will be called by the UI to refresh selectedGroupFreeSlots when
         * a thesis group is selected, whether in tree view (for clusters) or listbox (for isolated groups).
         * The parameters are still to be changed.
         * */
        public void RefreshSelectedGroupFreeSlots(DateTime start, DateTime end, int groupID)
        {

        }


        //TO BE IMPLEMENTED FOR EDITING SCHEDULES

        /* This method will be called by the UI when the user desires to schedule a defense
         * for the selected thesis group. If the schedule is valid, the method will return true.
         * Otherwise, it will return false.
         * */
        public bool InsertScheduleIfValid(int groupIndex, DefenseSchedule defSched)
        {
            if (isScheduleValid(groupIndex, defSched))
            {
                return true;
            }

            return false;
        }


        /* This method is for checking whether a defense schedule is valid for a thesis group.
         * */
        private bool IsScheduleValid(int groupIndex, DefenseSchedule defSched)
        {

            return false;
        }



        //These last two methods are not used anymore, but algo inside could be reused.

        /* This method queries the database to get all the Panelists who are
         * involved with more than one thesis group. Objects are created for them and stored in
         * the attribute: multiGroupPanelists.
         * */
        private void InitMultiGroupPanelists()
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

            }
        }

        /* This method queries the database to get all the thesis groups who have the
         * panelist in the parameter as part of their panel. The method returns the list of 
         * such thesis groups.
         * */
        private List<ThesisGroup> GetGroupsWithPanelist(String panelistID)
        {
            String query = "SELECT thesisGroupID FROM panelassignment WHERE panelistId = '" + panelistID + "';";
            List<String>[] columns = dbHandler.Select(query, 1);

            List<ThesisGroup> groups = new List<ThesisGroup>();
            List<String>[] colsForGroupInfo;

            int size = columns[0].Count;
            for (int i = 0; i < size; i++)
            {
                query = "SELECT * FROM thesisgroup WHERE thesisGroupID = '" + columns[0].ElementAt(i) + "';";
                colsForGroupInfo = dbHandler.Select(query, 1);
            }
            return groups;
        }
        
    }
}
