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

            days = new List<Label>();
            days.Add(day1);
            days.Add(day2);
            days.Add(day3);
            days.Add(day4);
            days.Add(day5);
            days.Add(day6);

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

            skedlist = new List<DateTime>();
            skedlist.Add(new DateTime(2013, 3, 6, 8, 30, 0));
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void draw_Rect(object sender, int day, int time_hr, int time_min, Boolean section, TableLayoutCellPaintEventArgs e)
        {

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
            DateTime curr = new DateTime(defenseweek_start.Value.Year, defenseweek_start.Value.Month, defenseweek_start.Value.Day);

            for (int i = 0; i < 6; i++, curr = curr.AddDays(1))
            {
                if (curr.DayOfWeek.ToString() == "Sunday")
                    curr = curr.AddDays(1);
                days.ElementAt(i).Text = curr.DayOfWeek.ToString() + "\n" + curr.ToString().Split(' ')[0];
            }
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
        private List<String> intervals;
        private List<Label> time_table, days;
        private bool scroll;
        private List<DateTime> skedlist;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scroll)
                scroll_up();
            else
                scroll_down();
        }
    }
}