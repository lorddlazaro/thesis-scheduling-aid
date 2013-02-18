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
            InitializeComponent();
            tableLayoutPanel1.CellPaint += tableLayoutPanel1_CellPaint;
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
            }
            else
            {
                switch_section.Text = "Switch Sort (Panelists)";
                sort_panelists.Visible = false;
                sort_section.Visible = true;
            }
        }
    }
}