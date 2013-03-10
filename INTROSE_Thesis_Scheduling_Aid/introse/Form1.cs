using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace introse
{
    public partial class Form1 : Form
    {
        DBce db = new DBce();
        SchedulingDataManager sdm = new SchedulingDataManager();
        String currPanelistID; //To keep track of which cluster is currently selected.
        DefenseScheduleForm form2;
        //AddThesisGroup form3;

        private TimeSpan topleft;
        private List<String> intervals, day_names;
        private List<Label> time_table, days;

        public string CurrPanelistID { get { return currPanelistID; } }

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            init();
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
        }

        private void init() 
        {
            currPanelistID = "";
            intervals = new List<String>();
            intervals.Add("5min");
            intervals.Add("10min");
            intervals.Add("15min");
            intervals.Add("30min");

            days = new List<Label>();
            days.Add(day1);
            days.Add(day2);
            days.Add(day3);
            days.Add(day4);
            days.Add(day5);
            days.Add(day6);

            day_names = new List<String>();
            day_names.Add("Monday");
            day_names.Add("Tuesday");
            day_names.Add("Wednesday");
            day_names.Add("Thursday");
            day_names.Add("Friday");
            day_names.Add("Saturday");

            defenseweek_start.Value = DateTime.Today;

            time_table = new List<Label>();
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                time_table.Add(new Label());
                time_table.ElementAt(i).Font = new Font("Segoe UI", 7);
                time_table.ElementAt(i).AutoSize = false;
                time_table.ElementAt(i).TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(time_table.ElementAt(i), 0, i);
            }

            topleft = new TimeSpan(8, 0, 0);
            time_table_update();

            treeView1.BeginUpdate();
            sdm.AddPanelistsToTree(treeView1.Nodes);
            treeView1.EndUpdate();
            treeView1.ExpandAll();
            treeView2.BeginUpdate();
            sdm.AddIsolatedGroupsToList(treeView2.Nodes);
            treeView2.EndUpdate();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            int xpos, ypos = 0, width = 108, height;
            int curr_day, curr_mo, curr_yr;
            DateTime dwd; // defense week date :D

            for (int i = 0; i < days.Count; i++)
            {
                curr_day = Convert.ToInt32(days.ElementAt(i).Text.Split('\n')[1].Split('/')[1]);
                curr_mo = Convert.ToInt32(days.ElementAt(i).Text.Split('\n')[1].Split('/')[0]);
                curr_yr = Convert.ToInt32(days.ElementAt(i).Text.Split('\n')[1].Split('/')[2]);

                dwd = new DateTime(curr_yr, curr_mo, curr_day);

                xpos = 108 * (i + 1); // x position of rectangle, columns 1-7
                width = 108; // width of 1 col = 108

                for (int j = 0; j < sdm.ClusterDefScheds.Count; j++)
                {
                    if (dwd.Day == sdm.ClusterDefScheds.ElementAt(j).StartTime.Day)
                    {
                        // 1 row = 5 mins = 10 pixels
                        TimeSpan a = sdm.ClusterDefScheds.ElementAt(j).EndTime.TimeOfDay - sdm.ClusterDefScheds.ElementAt(j).StartTime.TimeOfDay;
                        height = a.Hours * 120; // no minutes, defense length = 1 or 2 hours anyways, plus conversion to pixels

                        // ypos = pixel value of start time compared to 8:00 AM
                        a = sdm.ClusterDefScheds.ElementAt(j).StartTime.TimeOfDay - (new TimeSpan(8, 0, 0));
                        ypos = a.Hours * 120 + a.Minutes * 2;

                        //rectangle color
                        e.Graphics.FillRectangle(Brushes.LightBlue, xpos+1, ypos+1, width-1, height);
                        // rectangle borders
                        e.Graphics.DrawRectangle(new Pen(Color.Black), xpos, ypos+1, width, height); 
                    }
                 }

                int freeTimeIndex = day_names.IndexOf(dwd.DayOfWeek.ToString());

                for (int j = 0; j < sdm.SelectedGroupFreeTimes[freeTimeIndex].Count; j++)
                {
                    TimeSpan a = sdm.SelectedGroupFreeTimes[freeTimeIndex].ElementAt(j).EndTime.TimeOfDay - sdm.SelectedGroupFreeTimes[freeTimeIndex].ElementAt(j).StartTime.TimeOfDay;
                    height = a.Hours * 120 + a.Minutes * 2;

                    a = sdm.SelectedGroupFreeTimes[freeTimeIndex].ElementAt(j).StartTime.TimeOfDay - (new TimeSpan(8, 0, 0));
                    ypos = a.Hours * 120 + a.Minutes * 2;

                    //rectangle color
                    e.Graphics.FillRectangle(Brushes.LightPink, xpos+1, ypos+1, width-1, height);
                    // rectangle borders
                    e.Graphics.DrawRectangle(new Pen(Color.Black), xpos, ypos + 1, width, height);
                }
            }

            // draw vertical borders
            for (int i = 0; i < days.Count; i++)
            {
                xpos = 108 * (i + 1);
                ypos = 1;
                height = 1570;
                e.Graphics.DrawRectangle(new Pen(Color.Black), xpos, ypos, width, height);
            }

            // draw 30 min intervals
            xpos = 0;
            ypos = 1;
            width = 756;

            while (ypos <= 1570)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), xpos, ypos, width, ypos);
                ypos += 60;
            }

        }
        
        private void switch_sort_Click(object sender, EventArgs e)
        {
            if (switch_sort.Text.Equals("View Clustered Groups"))
            {
                switch_sort.Text = "View Isolated Groups";
                treeView2.Hide();
                treeView1.Show();
            }
            else
            {
                switch_sort.Text = "View Clustered Groups";
                treeView1.Hide();
                treeView2.Show();
            }
        }

        private void defenseweek_start_ValueChanged(object sender, EventArgs e)
        {
            if (defenseweek_start.Value.DayOfWeek.ToString() == "Sunday")
                defenseweek_start.Value = defenseweek_start.Value.AddDays(1);

            DateTime curr = new DateTime(defenseweek_start.Value.Year, defenseweek_start.Value.Month, defenseweek_start.Value.Day);

            for (int i = 0; i < 6; i++, curr = curr.AddDays(1))
            {
                if (curr.DayOfWeek.ToString() == "Sunday")
                    curr = curr.AddDays(1);
                days.ElementAt(i).Text = curr.DayOfWeek.ToString() + "\n" + curr.ToString().Split(' ')[0];
            }

            if (!currPanelistID.Equals("")) 
            {
                DateTime start = Convert.ToDateTime(days.ElementAt(0).Text.Split('\n')[1]);
                DateTime end = Convert.ToDateTime(days.ElementAt(5).Text.Split('\n')[1]);
                sdm.RefreshClusterDefSchedules(start, end, currPanelistID);
            }
          
            tableLayoutPanel1.Refresh();
        }
        
        private TimeSpan getInterval()
        {
                    return new TimeSpan(0, 5, 0);
        }

        private void time_table_update()
        {
            TimeSpan interval = getInterval();
            TimeSpan curr = new TimeSpan(0, 0, 0);

            foreach (Label i in time_table) 
            {
                i.Text = (topleft + curr) + "";
                curr += interval;
            }

            tableLayoutPanel1.Refresh();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Console.WriteLine("ID: " + e.Node.Name);
            //Console.WriteLine(e.Node);
            if (e.Node.Level == 0)
            {
                DateTime start = Convert.ToDateTime(days.ElementAt(0).Text.Split('\n')[1]);
                DateTime end = Convert.ToDateTime(days.ElementAt(5).Text.Split('\n')[1]);
                currPanelistID = e.Node.Name;

                form2 = new DefenseScheduleForm(sdm, this);
                form2.TopMost = true;

                sdm.RefreshClusterDefSchedules(start, end, currPanelistID);
                if (sdm.ClusterDefScheds.Count > 0)
                    tableLayoutPanel1.Refresh();
            }
            else if (e.Node.Level == 1)
            {
                currPanelistID = "";
                DateTime start = Convert.ToDateTime(days.ElementAt(0).Text.Split('\n')[1]);
                DateTime end = Convert.ToDateTime(days.ElementAt(5).Text.Split('\n')[1]);

                sdm.RefreshSelectedGroupFreeTimes(start, end, e.Node.Name);

                for (int currDay = 0; currDay < 6; currDay++) 
                {
                    Console.WriteLine("Day: "+currDay);
                    for (int i = 0; i < sdm.SelectedGroupFreeTimes[currDay].Count; i++)
                        Console.WriteLine(sdm.SelectedGroupFreeTimes[currDay].ElementAt(i));
                }


                tableLayoutPanel1.Refresh();
            }
        }

        public void childClick(string thesisgroupid) {
            DateTime start = Convert.ToDateTime(days.ElementAt(0).Text.Split('\n')[1]);
            DateTime end = Convert.ToDateTime(days.ElementAt(5).Text.Split('\n')[1]);

            sdm.RefreshSelectedGroupFreeTimes(start, end, thesisgroupid);

            for (int currDay = 0; currDay < 6; currDay++)
            {
                Console.WriteLine("Day: " + currDay);
                for (int i = 0; i < sdm.SelectedGroupFreeTimes[currDay].Count; i++)
                    Console.WriteLine(sdm.SelectedGroupFreeTimes[currDay].ElementAt(i));
            }


            tableLayoutPanel1.Refresh();
        }
        
        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Console.WriteLine("ID: " + e.Node.Name);
            Console.WriteLine(e.Node);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //form3 = new AddThesisGroup();
            //form3.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            form2 = new DefenseScheduleForm();
            form2.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
            if(toolStripButton1.Text.Equals("Collapse Clusters"))
            {
                  treeView1.CollapseAll();
                  toolStripButton1.Text = "Expand Clusters";
            }
            else
            {
                treeView1.ExpandAll();
                toolStripButton1.Text = "Collapse Clusters";
            }
        }

        private void splitContainer1_Panel1_MouseEnter(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Focus();
        }
    }
}