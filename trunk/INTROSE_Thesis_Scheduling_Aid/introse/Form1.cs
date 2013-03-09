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
        AddDefenseSchedule form2;
        AddThesisGroup form3;

        private TimeSpan topleft;
        private List<String> intervals, day_names;
        private List<Label> time_table, days;

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
            int xpos, ypos, width, height;
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

                        e.Graphics.FillRectangle(Brushes.LightBlue, xpos, ypos, width, height);
                    }
                 }

                int freeTimeIndex = day_names.IndexOf(dwd.DayOfWeek.ToString());

                for (int j = 0; j < sdm.SelectedGroupFreeTimes[freeTimeIndex].Count; j++)
                {
                    if (dwd.DayOfWeek == sdm.SelectedGroupFreeTimes[freeTimeIndex].ElementAt(j).StartTime.DayOfWeek)
                    {
                        TimeSpan a = sdm.SelectedGroupFreeTimes[freeTimeIndex].ElementAt(j).EndTime.TimeOfDay - sdm.SelectedGroupFreeTimes[freeTimeIndex].ElementAt(j).StartTime.TimeOfDay;
                        height = a.Hours * 120 + a.Minutes * 2;

                        a = sdm.SelectedGroupFreeTimes[freeTimeIndex].ElementAt(j).StartTime.TimeOfDay - (new TimeSpan(8, 0, 0));
                        ypos = a.Hours * 120 + a.Minutes * 2;

                        e.Graphics.FillRectangle(Brushes.LightPink, xpos, ypos, width, height);
                    }
                }
            }
        }

        void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);

            if (e.Column != 0)
            {
                String day = days.ElementAt(e.Column - 1).Text.Split('\n')[0];

                int curr_day = Convert.ToInt32(days.ElementAt(e.Column - 1).Text.Split('\n')[1].Split('/')[1]);
                int curr_mo = Convert.ToInt32(days.ElementAt(e.Column - 1).Text.Split('\n')[1].Split('/')[0]);
                int curr_yr = Convert.ToInt32(days.ElementAt(e.Column - 1).Text.Split('\n')[1].Split('/')[2]);

                int curr_hr = Convert.ToInt32(time_table.ElementAt(e.Row).Text.Split(':')[0]);
                int curr_min = Convert.ToInt32(time_table.ElementAt(e.Row).Text.Split(':')[1]);

                DateTime curr = new DateTime(curr_yr, curr_mo, curr_day, curr_hr, curr_min, 0);

                for (int i = 0; i < sdm.ClusterDefScheds.Count; i++)
                {
                    if (sdm.ClusterDefScheds.ElementAt(i).StartTime.CompareTo(curr) <= 0 && sdm.ClusterDefScheds.ElementAt(i).EndTime.CompareTo(curr) > 0)
                    {
                        e.Graphics.FillRectangle(Brushes.LightBlue, e.CellBounds.X+1, e.CellBounds.Y+1, e.CellBounds.Width-1, e.CellBounds.Height-1);
                    }
                }


                for (int i = 0; i < sdm.SelectedGroupFreeTimes[day_names.IndexOf(day)].Count; i++)
                {
                    int comparisonWithStart = sdm.SelectedGroupFreeTimes[day_names.IndexOf(day)].ElementAt(i).StartTime.TimeOfDay.CompareTo(curr.TimeOfDay) ;
                    int comparisonwithEnd = sdm.SelectedGroupFreeTimes[day_names.IndexOf(day)].ElementAt(i).EndTime.TimeOfDay.CompareTo(curr.TimeOfDay);
                    if (comparisonWithStart <= 0 && comparisonwithEnd >= 0)
                        e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds.X + 1, e.CellBounds.Y + 1, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                }
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
        /*
        private void scroll_up()
        {
            TimeSpan interval = getInterval();
            topleft -= interval;
            if (topleft < new TimeSpan(8, 0, 0))
                topleft = new TimeSpan(8, 0, 0);

            time_table_update();
        }

        private void scroll_down()
        {
            TimeSpan interval = getInterval();
            TimeSpan max = new TimeSpan(topleft.Hours, topleft.Minutes, 0);
            topleft += interval;

            for (int i = 0; i < time_table.Count; i++)
                max += interval;

            if (max >= new TimeSpan(21, 0, 0))
                topleft -= interval;

            time_table_update();
        }
        
        private void time_scroll_up_MouseDown(object sender, EventArgs e)
        {
            scroll_up();
            timer1.Enabled = true;
            timer1.Start();
            scroll = true;
        }

        private void time_scroll_up_MouseUp(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void time_scroll_down_MouseDown(object sender, EventArgs e)
        {
            scroll_down();
            timer1.Enabled = true;
            timer1.Start();
            scroll = false;
        }

        private void time_scroll_down_MouseUp(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        */
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

        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scroll)
                scroll_up();
            else
                scroll_down();
        }
        */
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Console.WriteLine("ID: " + e.Node.Name);
            //Console.WriteLine(e.Node);
            if (e.Node.Level == 0)
            {
                DateTime start = Convert.ToDateTime(days.ElementAt(0).Text.Split('\n')[1]);
                DateTime end = Convert.ToDateTime(days.ElementAt(5).Text.Split('\n')[1]);
                currPanelistID = e.Node.Name;

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
        
        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Console.WriteLine("ID: " + e.Node.Name);
            Console.WriteLine(e.Node);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new AddDefenseSchedule();
            form2.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            form3 = new AddThesisGroup();
            form3.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            form3 = new AddThesisGroup();
            form3.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            form2 = new AddDefenseSchedule();
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
    }
}