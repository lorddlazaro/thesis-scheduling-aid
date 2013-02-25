using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace introse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            init();
            InitializeComponent();
            tableLayoutPanel1.CellPaint += tableLayoutPanel1_CellPaint;
        }

        private void init()
        {
            intervals = new List<String>();
            intervals.Add("1min");
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (switch_section.Text.Equals("Switch Sort (Panelists)"))
            {
                switch_section.Text = "Switch Sort (Sections)";
                sort_section.Visible = false;
                sort_panelists.Visible = true;

                // TESTING DB CLASS
                /*
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
                */
                // END OF TESTING
            }
            else
            {
                switch_section.Text = "Switch Sort (Panelists)";
                sort_panelists.Visible = false;
                sort_section.Visible = true;
            }
        }

        private void interval_up_Click(object sender, EventArgs e)
        {
            String curr = this.table_interval.Text.Substring(23);
            String put = "Table Interval Length: ";

            if (intervals.IndexOf(curr) == 4)
                return;
            put += intervals.ElementAt(intervals.IndexOf(curr) + 1);

            this.table_interval.Text = put;
        }

        private void interval_down_Click(object sender, EventArgs e)
        {
            String curr = this.table_interval.Text.Substring(23);
            String put = "Table Interval Length: ";

            if (intervals.IndexOf(curr) == 0)
                return;
            put += intervals.ElementAt(intervals.IndexOf(curr) - 1);

            this.table_interval.Text = put;
        }

        private void defenseweek_start_ValueChanged(object sender, EventArgs e)
        {
            day1.Text = defenseweek_start.Value.DayOfWeek.ToString();
            day2.Text = days.ElementAt((days.IndexOf(day1.Text) + 1) % 6);
            day3.Text = days.ElementAt((days.IndexOf(day2.Text) + 1) % 6);
            day4.Text = days.ElementAt((days.IndexOf(day3.Text) + 1) % 6);
            day5.Text = days.ElementAt((days.IndexOf(day4.Text) + 1) % 6);
            day6.Text = days.ElementAt((days.IndexOf(day5.Text) + 1) % 6);
        }

        private int topleft_hr;
        private int topleft_min;
        private List<String> intervals, days;
    }
}