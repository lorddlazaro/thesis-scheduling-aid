using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace CustomUserControl
{
    public partial class FreeTimeViewer : UserControl
    {
        private DateTime startOfTheWeek;
        private DateTime endOfTheWeek;

        private SchedulingDataManager schedulingDM;

        private List<Label> labelDates;

        private String currPanelistID;
        private String currGroupID;

        public FreeTimeViewer()
        {
            InitializeComponent();

            currPanelistID = "";
            currGroupID = "";

            labelDates = new List<Label>();
            labelDates.Add(labelDate1);
            labelDates.Add(labelDate2);
            labelDates.Add(labelDate3);
            labelDates.Add(labelDate4);
            labelDates.Add(labelDate5);
            labelDates.Add(labelDate6);

            datePicker_ValueChanged(new Object(), new EventArgs());

            schedulingDM = new SchedulingDataManager();
            treeViewClusters.BeginUpdate();
            schedulingDM.AddPanelistsToTree(treeViewClusters.Nodes);
            treeViewClusters.EndUpdate();
            treeViewClusters.ExpandAll();
        }

        //This method updates the date labels when the selected startDate is changed.
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            startOfTheWeek = datePicker.Value;
            if (startOfTheWeek.DayOfWeek.Equals(System.DayOfWeek.Sunday))
            {
                startOfTheWeek = datePicker.Value.AddDays(1);
                datePicker.Value = startOfTheWeek;
                MessageBox.Show("No school on Sundays.");
            }

            
            DateTime currDate = startOfTheWeek;
            int i;
            for (i = 0; i < labelDates.Count; i++ )
            {
                labelDates[i].TextAlign = ContentAlignment.MiddleCenter;
                labelDates[i].Text = currDate.DayOfWeek + "\n" + currDate.ToString("d");

                currDate = currDate.AddDays(1);
                if (currDate.DayOfWeek.Equals(System.DayOfWeek.Sunday))
                    currDate = currDate.AddDays(1);
            }
          
            endOfTheWeek = Convert.ToDateTime(labelDates[i-1].Text);
        }

        private void panelCalendar_Paint(object sender, PaintEventArgs e)
        {
            TestDrawRectangles(e.Graphics);
            DrawClusterDefScheds(e.Graphics);
            DrawFreeTimes(e.Graphics);
        }


        private void DrawClusterDefScheds(Graphics g) 
        {
            
        }

        private void DrawFreeTimes(Graphics g) 
        {
        
        }

        private void TestDrawRectangles(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, new Rectangle(112, 44, 100, 50));
        }

        private void treeViewClusters_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                int numTasks = 3;
                int progressBarIncrement = progressBar1.Maximum / numTasks;

                //Task1: Refresh Cluster Defense Schedules
                currPanelistID = e.Node.Name;
                schedulingDM.RefreshClusterDefSchedules(startOfTheWeek, endOfTheWeek, currPanelistID);
                UpdateProgressBar(progressBar1, progressBarIncrement);

                /*
                if (form2 != null)
                    try { form2.Dispose(); }
                    catch (Exception ex) { }
                form2 = new DefenseScheduleForm(this, "");
                 * */

                //Task 2: Deselect the currently selected thesis group if any.
                if(!currGroupID.Equals(""))
                    ChangeSelectedGroup(startOfTheWeek, endOfTheWeek, "");
                UpdateProgressBar(progressBar1, progressBarIncrement);

                //Task 3: Refresh 
                if (schedulingDM.ClusterDefScheds.Count > 0)
                    panelCalendar.Refresh();
                UpdateProgressBar(progressBar1, progressBarIncrement);

                UpdateProgressBar(progressBar1, progressBar1.Maximum); //Just to make the progress bar reach its maximum.
            }
            else if (e.Node.Level == 1)
            {
                int numTasks = 3;
                int progressBarIncrement = progressBar1.Maximum / numTasks;

                //Task 1: Change panelists if user clicked on another cluster.
                if (!e.Node.Parent.Name.Equals(currPanelistID))
                {
                    currPanelistID = e.Node.Parent.Name;
                    schedulingDM.RefreshClusterDefSchedules(startOfTheWeek, endOfTheWeek, currPanelistID);
                }
                UpdateProgressBar(progressBar1, progressBarIncrement);

                //Task 2: Change selected group if user clicked on a different one.
                if (!currGroupID.Equals(e.Node.Name))
                {
                    ChangeSelectedGroup(startOfTheWeek, endOfTheWeek, e.Node.Name);
                }
                UpdateProgressBar(progressBar1, progressBarIncrement);

                //Task 3: Refresh
                panelCalendar.Refresh();
                UpdateProgressBar(progressBar1, progressBarIncrement);

                UpdateProgressBar(progressBar1, progressBar1.Maximum); //Just to make the progress bar reach its maximum.
            }
        }

        //Updates the progress bar until its maximum. The bar is reset to zero only during the next time it is made to update.
        private void UpdateProgressBar(ProgressBar progressBar1, int increment) 
        {
            if (progressBar1.Value == progressBar1.Maximum)
                progressBar1.Value = progressBar1.Minimum;
            else if (progressBar1.Value + increment < progressBar1.Maximum)
                progressBar1.Value += increment;
            else
                progressBar1.Value = progressBar1.Maximum;

            progressBar1.Refresh();
        }
     
        //Changes the selectedGroupID to the new ID given in the parameter, then refreshes the list of free times in schedulingDM.
        public void ChangeSelectedGroup(DateTime start, DateTime end, String newThesisGroupID)
        {
            currGroupID = newThesisGroupID;
            if (newThesisGroupID.Equals(""))
                labelSelectedGroup.Text = "";
            else
                labelSelectedGroup.Text = "Selected Group: " + schedulingDM.GetGroupInfo(currGroupID);
            schedulingDM.RefreshSelectedGroupFreeTimes(start, end, currGroupID);

            /*For debugging purposes
            for (int currDay = 0; currDay < 6; currDay++)
            {
                Console.WriteLine("Day: " + currDay);
                for (int i = 0; i < sdm.SelectedGroupFreeTimes[currDay].Count; i++)
                    Console.WriteLine(sdm.SelectedGroupFreeTimes[currDay].ElementAt(i));
            }
            /*For debugging purposes*/
        }


    }
}
