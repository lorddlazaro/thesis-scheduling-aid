using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        }
    
        /* This method will be called by the GUI to add multigrouped panelists to the tree.
         * */
        public void AddPanelistsToTree(TreeNodeCollection tree)
        {
            String query = "select panelistID from panelassignment group by panelistID having count(*) > 1;";
            List<String>[] parentList = dbHandler.Select(query, 1);
            List<String>[] parentInfo;
            List<String>[] childList;
            TreeNode parent;
            TreeNode[] child;
            TreeNodeCollection children;

            for (int i = 0; i < parentList[0].Count(); i++)
            {
                query = "Select firstName, MI, lastName from panelist where panelistid = " + parentList[0].ElementAt(i) + ";";
                parentInfo = dbHandler.Select(query, 3);

                query = "Select t.thesisgroupID,t.title from thesisgroup t, panelassignment p where t.thesisgroupid = p.thesisgroupid and p.panelistID =" + parentList[0].ElementAt(i) + ";";
                childList = dbHandler.Select(query, 2);

                parent = new TreeNode();
                child = new TreeNode[childList[0].Count()];
                children = parent.Nodes;

                parent.Name = parentList[0].ElementAt(i);
                parent.Text = parentInfo[0].ElementAt(0) + " " + parentInfo[1].ElementAt(0) + " " + parentInfo[2].ElementAt(0);

                for (int j = 0; j < childList[0].Count(); j++)
                {
                    child[j] = new TreeNode();
                    child[j].Name = childList[0].ElementAt(j);
                    child[j].Text = childList[1].ElementAt(j);
                    children.Add(child[j]);

                }
                tree.Add(parent);
            }
        }

        public void AddIsolatedGroupsToList(TreeNodeCollection tree)
        {
            String query = "select thesisgroupID,title from thesisgroup where thesisgroupID not in (select thesisgroupID from panelassignment where panelistID in (select panelistID from panelassignment group by panelistID having count(*) > 1));";
            List<String>[] list = dbHandler.Select(query, 2);
            TreeNode node;
            for (int i = 0; i < list[0].Count(); i++)
            {
                node = new TreeNode();

                node.Name = list[0].ElementAt(i);
                node.Text = list[1].ElementAt(i);

                tree.Add(node);
            }
        }

        /*The following two methods are the important ones for initializing the lists 
         * to be used for drawing the available times and defense schedules.
         * */

        /* This method will be called by the UI to refresh clusterDefSchedules when a cluster is selected.
         * Note: this was previously named initDefenseSchedules()
         * */
        public void RefreshClusterDefSchedules(DateTime startDate, DateTime endDate, String panelistID)
        {
            clusterDefScheds.Clear();
            List<String> groupIDs = new List<String>();
            String query = "select thesisGroupID from panelassignment where panelistID = '" + panelistID + "';";
            
            groupIDs = (dbHandler.Select(query, 1))[0];
       
            int size = groupIDs.Count;
            DefenseSchedule defSched;
       
            for (int i = 0; i < size; i++)
            {
                defSched = GetDefSched(startDate, endDate, groupIDs.ElementAt(i));
                if (defSched != null)
                    clusterDefScheds.Add(defSched);
            }
        }

        /* This method returns a DefenseSchedule object within the specified startDate and endDDate 
         * for the specified thesis group. If there is none, the method returns null.
         */
        private DefenseSchedule GetDefSched(DateTime startDate, DateTime endDate, String thesisGroupID)
        {
            String query = "SELECT defenseDateTime, place FROM defenseSchedule WHERE thesisGroupID = '" + thesisGroupID + "' AND defenseDateTime >='" + startDate.Date + "' AND defenseDateTime <='" + endDate.Date + "';";
        
            List<String>[] columns = dbHandler.Select(query, 2);

            if (columns[0].Count == 0)//If the query result is an empty set.
                return null;

            int defDuration = GetMinsDuration(thesisGroupID);
            if (defDuration == -1) //If course is neither THSST-1 nor THSST-3. There must be some input error.
                return null;

            DateTime startTime = Convert.ToDateTime(columns[0].ElementAt(0));
            DateTime endTime = startTime.AddMinutes(defDuration);
            String place = columns[1].ElementAt(0);
            String groupTitle;
            query = "SELECT title from thesisGroup WHERE thesisGroupID = '" + thesisGroupID + "';";
            groupTitle = dbHandler.Select(query, 1)[0].ElementAt(0);

            return new DefenseSchedule(startTime, endTime, place, groupTitle);
        }

        /* This method returns the defense schedule duration in minutes depending on the thesis group's course (THSST-1 or THSST-3)
         * This method is used in GetDefSched().
         */
        private int GetMinsDuration(String thesisGroupID)
        {
            const int thsst1DefDurationInMins = 60;
            const int thsst3DefDurationInMins = 120;


            String query = "SELECT course from thesisGroup where thesisGroupID = '" + thesisGroupID + "';";
            String course = dbHandler.Select(query, 1)[0].ElementAt(0);
            if (course.Equals("THSST-1"))
                return thsst1DefDurationInMins;
            else if (course.Equals("THSST-3"))
                return thsst3DefDurationInMins;

            return -1;
        }

        /* This method will be called by the UI to refresh selectedGroupFreeSlots when
         * a thesis group is selected, whether in tree view (for clusters) or listbox (for isolated groups).
         * The parameters are still to be changed.
         * */
        public void RefreshSelectedGroupFreeTimes(DateTime startDate, DateTime endDate, int thesisGroupID)
        {
            List<String> studentIDs = new List<String>();
            List<String> panelistIDs = new List<String>();
            List<String>[] columns;
            String query;
            int size;

            /*Start: 
             * Initialize the studentIDs and panelistIDs belonging to this thesis group.
             * */
            
            query = "SELECT studentID FROM Student WHERE thesisGroupID = '" + thesisGroupID + "';";

            columns = dbHandler.Select(query, 1);
            size = columns[0].Count;

            for (int i = 0; i < size; i++)
                studentIDs.Add(columns[0].ElementAt(i));

            query = "SELECT panelistID FROM PanelAssignment WHERE thesisGroupdID = '" + thesisGroupID + "';";
            columns = dbHandler.Select(query, 1);
            size = columns[0].Count;

            for (int i = 0; i < size; i++)
                panelistIDs.Add(columns[0].ElementAt(i));

            /* End */

            /*Start:
             * Gather all timeslots of these seven people, and place them inside a collection.
             * */

            


            /* End */




        }
    }
}
