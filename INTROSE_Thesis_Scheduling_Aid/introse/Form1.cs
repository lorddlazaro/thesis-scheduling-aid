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

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            init();
            tableLayoutPanel1.CellPaint += tableLayoutPanel1_CellPaint;
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

            scroll = true;

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
            
        }

        void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);

            if (e.Column != 0)
            {
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

        private TimeSpan topleft;
        private List<String> intervals;
        private List<Label> time_table, days;
        private bool scroll;
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

            DateTime start = Convert.ToDateTime(days.ElementAt(0).Text.Split('\n')[1]);
            DateTime end = Convert.ToDateTime(days.ElementAt(5).Text.Split('\n')[1]);
            currPanelistID = e.Node.Name;

            sdm.RefreshClusterDefSchedules(start,end,currPanelistID);
            //if(sdm.ClusterDefScheds.Count > 0)
            tableLayoutPanel1.Refresh();
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
    }
}