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
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            init();
            tableLayoutPanel1.CellPaint += tableLayoutPanel1_CellPaint;
        }

        private void init() 
        {
            intervals = new List<String>();
            intervals.Add("5min");
            intervals.Add("10min");
            intervals.Add("30min");
            intervals.Add("1hr");

            days = new List<String>();
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesday");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");

            time_table = new List<Label>();
            time_table.Add(time_table1);
            time_table.Add(time_table2);
            time_table.Add(time_table3);
            time_table.Add(time_table4);
            time_table.Add(time_table5);
            time_table.Add(time_table6);
            time_table.Add(time_table7);
            time_table.Add(time_table8);
            time_table.Add(time_table9);
            time_table.Add(time_table10);
            time_table.Add(time_table11);
            time_table.Add(time_table12);
            time_table.Add(time_table13);

            topleft = new TimeSpan(8, 0, 0);
            time_table_update();

            scroll = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            /* 
             * check visible checkboxlist (sort_section/sort_panelists)
             * call draw_rect for every checked element sa resultset
             * redraw table every time checkboxlist changes, probably (still don't know how to)
             * 
             * 
             * Queries for DB:
             *  for sort_section (normal view):
             *      SELECT * from Timeslot ORDER BY startTime;
             *  for sort_panelists (clustered view):
             *      for each panelist
             *          SELECT * from Timeslot GROUP BY panelistID;
             *      SELECT (everyone else na walang panelist, i can't introdb lol)
             */
        }

        private void draw_Rect(object sender, int day, int time_hr, int time_min, Boolean section, TableLayoutCellPaintEventArgs e)
        {
            /*
             * int yval = e.CellBounds.Height / 14; // 14 hrs
             * 
             * // section = true, THSST-3 : section = false, THSST-1
             * int height = section? 2 : 1;
             * 
             * if (row == day)
             * e.Graphics.FillRectangle(Brushes.<someredcolor>, e.CellBounds.X, e.CellBounds.Y + yval * (time_hr + 1.0 * time_min / 60), e.CellBounds.Width, height*yval);
             * 
             */
        }
        
        void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
        }

        private void switch_sort_Click(object sender, EventArgs e)
        {
            if (switch_sort.Text.Equals("Switch Sort (Panelists)"))
            {
                switch_sort.Text = "Switch Sort (Sections)";
                sort_section.Visible = false;
                sort_panelists.Visible = true;

                // TESTING DB CLASS
                
                DBce db = new DBce();
                
                
                // OUTPUTS NUMBER OF ROWS TABLE THESISGROUP HAS
                
                System.Console.WriteLine(db.Count("Select count(*) from thesisgroup"));
                

                // OUTPUTS TITLES, COURSES AND SECTIONS FROM THESISGROUP
                
                List<String>[] list = db.Select("Select title, course, section from thesisgroup",3);
                for (int i = 0; i < 3; i++){
                    foreach (String field in list[i])
                        Console.Write(field + " ");
                    Console.WriteLine();
                }


                // WRITES THESISGROUPID AND SECTION INTO SORT_PANELIST CHECKEDBOX LIST
                
                list = db.Select("Select thesisgroupid,title, section from thesisgroup", 3);
                sort_panelists.BeginUpdate();
                sort_panelists.Items.Clear();
                ListBox.ObjectCollection items = sort_panelists.Items;


                for (int i = 0; i < list.Count(); i++)
                {
                    items.Add("");
                    for (int j = 0; j < 3; j++)
                        items[i] += list[j].ElementAt(i) + " ";

                }
                
                sort_panelists.EndUpdate();

                // END OF TESTING
            }
            else
            {
                switch_sort.Text = "Switch Sort (Panelists)";
                sort_panelists.Visible = false;
                sort_section.Visible = true;
            }
        }

        private void interval_up_Click(object sender, EventArgs e)
        {
            String curr = this.table_interval.Text.Substring(23);
            String put = "Table Interval Length: ";

            if (intervals.IndexOf(curr) == 3)
                return;
            put += intervals.ElementAt(intervals.IndexOf(curr) + 1);

            this.table_interval.Text = put;
            topleft = new TimeSpan(8, 0, 0);
            time_table_update();
        }

        private void interval_down_Click(object sender, EventArgs e)
        {
            String curr = this.table_interval.Text.Substring(23);
            String put = "Table Interval Length: ";

            if (intervals.IndexOf(curr) == 0)
                return;
            put += intervals.ElementAt(intervals.IndexOf(curr) - 1);

            this.table_interval.Text = put;
            topleft = new TimeSpan(8, 0, 0);
            time_table_update();
        }

        private void defenseweek_start_ValueChanged(object sender, EventArgs e)
        {
            if (defenseweek_start.Value.DayOfWeek.ToString() == "Sunday")
                day1.Text = "Monday";
            else
                day1.Text = defenseweek_start.Value.DayOfWeek.ToString();
            day2.Text = days.ElementAt((days.IndexOf(day1.Text) + 1) % 6);
            day3.Text = days.ElementAt((days.IndexOf(day2.Text) + 1) % 6);
            day4.Text = days.ElementAt((days.IndexOf(day3.Text) + 1) % 6);
            day5.Text = days.ElementAt((days.IndexOf(day4.Text) + 1) % 6);
            day6.Text = days.ElementAt((days.IndexOf(day5.Text) + 1) % 6);
        }

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

            for (int i = 0; i < 13; i++)
                max += interval;

            if (max >= new TimeSpan(21, 0, 0))
                topleft -= interval;

            time_table_update();
        }
        
        private void time_scroll_up_MouseDown(object sender, EventArgs e)
        {
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
            timer1.Enabled = true;
            timer1.Start();
            scroll = false;
        }

        private void time_scroll_down_MouseUp(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private TimeSpan getInterval()
        {
            String a = this.table_interval.Text.Substring(23);

            switch (intervals.IndexOf(a))
            {
                case 0:
                    return new TimeSpan(0, 5, 0);
                case 1:
                    return new TimeSpan(0, 10, 0);
                case 2:
                    return new TimeSpan(0, 30, 0);
                case 3:
                    return new TimeSpan(1, 0, 0);
                default:
                    return new TimeSpan(0, 0, 0);
            }
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
        }

        private TimeSpan topleft;
        private List<String> intervals, days;
        private List<Label> time_table;
        private bool scroll;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scroll)
                scroll_up();
            else
                scroll_down();
        }
    }
}