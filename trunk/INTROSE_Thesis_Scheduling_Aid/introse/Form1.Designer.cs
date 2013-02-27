namespace introse
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.table_interval = new System.Windows.Forms.Label();
            this.interval_down = new System.Windows.Forms.PictureBox();
            this.interval_up = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.defenseweek_start = new System.Windows.Forms.DateTimePicker();
            this.time_scroll_down = new System.Windows.Forms.PictureBox();
            this.time_scroll_up = new System.Windows.Forms.PictureBox();
            this.day6 = new System.Windows.Forms.Label();
            this.day5 = new System.Windows.Forms.Label();
            this.day4 = new System.Windows.Forms.Label();
            this.day3 = new System.Windows.Forms.Label();
            this.day2 = new System.Windows.Forms.Label();
            this.day1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.time_table1 = new System.Windows.Forms.Label();
            this.time_table2 = new System.Windows.Forms.Label();
            this.time_table3 = new System.Windows.Forms.Label();
            this.time_table4 = new System.Windows.Forms.Label();
            this.time_table5 = new System.Windows.Forms.Label();
            this.time_table6 = new System.Windows.Forms.Label();
            this.time_table7 = new System.Windows.Forms.Label();
            this.time_table8 = new System.Windows.Forms.Label();
            this.time_table9 = new System.Windows.Forms.Label();
            this.time_table10 = new System.Windows.Forms.Label();
            this.time_table11 = new System.Windows.Forms.Label();
            this.time_table12 = new System.Windows.Forms.Label();
            this.time_table13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sort_panelists = new System.Windows.Forms.CheckedListBox();
            this.switch_sort = new System.Windows.Forms.Button();
            this.sort_section = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interval_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_scroll_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_scroll_up)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Defense Schedules";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.table_interval);
            this.splitContainer1.Panel1.Controls.Add(this.interval_down);
            this.splitContainer1.Panel1.Controls.Add(this.interval_up);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.defenseweek_start);
            this.splitContainer1.Panel1.Controls.Add(this.time_scroll_down);
            this.splitContainer1.Panel1.Controls.Add(this.time_scroll_up);
            this.splitContainer1.Panel1.Controls.Add(this.day6);
            this.splitContainer1.Panel1.Controls.Add(this.day5);
            this.splitContainer1.Panel1.Controls.Add(this.day4);
            this.splitContainer1.Panel1.Controls.Add(this.day3);
            this.splitContainer1.Panel1.Controls.Add(this.day2);
            this.splitContainer1.Panel1.Controls.Add(this.day1);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.splitContainer1.Panel2.Controls.Add(this.sort_panelists);
            this.splitContainer1.Panel2.Controls.Add(this.switch_sort);
            this.splitContainer1.Panel2.Controls.Add(this.sort_section);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(767, 528);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 0;
            // 
            // table_interval
            // 
            this.table_interval.Location = new System.Drawing.Point(0, 490);
            this.table_interval.Name = "table_interval";
            this.table_interval.Size = new System.Drawing.Size(119, 37);
            this.table_interval.TabIndex = 15;
            this.table_interval.Text = "Table Interval Length: 1hr";
            this.table_interval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interval_down
            // 
            this.interval_down.Image = global::introse.Properties.Resources.downarrow;
            this.interval_down.InitialImage = ((System.Drawing.Image)(resources.GetObject("interval_down.InitialImage")));
            this.interval_down.Location = new System.Drawing.Point(161, 490);
            this.interval_down.Name = "interval_down";
            this.interval_down.Size = new System.Drawing.Size(43, 38);
            this.interval_down.TabIndex = 14;
            this.interval_down.TabStop = false;
            this.interval_down.Click += new System.EventHandler(this.interval_down_Click);
            // 
            // interval_up
            // 
            this.interval_up.Image = global::introse.Properties.Resources.uparrow;
            this.interval_up.InitialImage = ((System.Drawing.Image)(resources.GetObject("interval_up.InitialImage")));
            this.interval_up.Location = new System.Drawing.Point(119, 490);
            this.interval_up.Name = "interval_up";
            this.interval_up.Size = new System.Drawing.Size(43, 38);
            this.interval_up.TabIndex = 13;
            this.interval_up.TabStop = false;
            this.interval_up.Click += new System.EventHandler(this.interval_up_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(403, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Thesis Defense Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defenseweek_start
            // 
            this.defenseweek_start.Location = new System.Drawing.Point(401, 509);
            this.defenseweek_start.Name = "defenseweek_start";
            this.defenseweek_start.Size = new System.Drawing.Size(200, 20);
            this.defenseweek_start.TabIndex = 11;
            this.defenseweek_start.ValueChanged += new System.EventHandler(this.defenseweek_start_ValueChanged);
            // 
            // time_scroll_down
            // 
            this.time_scroll_down.Image = global::introse.Properties.Resources.downarrow;
            this.time_scroll_down.InitialImage = ((System.Drawing.Image)(resources.GetObject("time_scroll_down.InitialImage")));
            this.time_scroll_down.Location = new System.Drawing.Point(42, 44);
            this.time_scroll_down.Name = "time_scroll_down";
            this.time_scroll_down.Size = new System.Drawing.Size(43, 38);
            this.time_scroll_down.TabIndex = 10;
            this.time_scroll_down.TabStop = false;
            this.time_scroll_down.Click += new System.EventHandler(this.time_scroll_down_Click);
            // 
            // time_scroll_up
            // 
            this.time_scroll_up.Image = global::introse.Properties.Resources.uparrow;
            this.time_scroll_up.InitialImage = ((System.Drawing.Image)(resources.GetObject("time_scroll_up.InitialImage")));
            this.time_scroll_up.Location = new System.Drawing.Point(0, 44);
            this.time_scroll_up.Name = "time_scroll_up";
            this.time_scroll_up.Size = new System.Drawing.Size(43, 38);
            this.time_scroll_up.TabIndex = 9;
            this.time_scroll_up.TabStop = false;
            this.time_scroll_up.Click += new System.EventHandler(this.time_scroll_up_Click);
            // 
            // day6
            // 
            this.day6.Location = new System.Drawing.Point(514, 44);
            this.day6.Name = "day6";
            this.day6.Size = new System.Drawing.Size(86, 35);
            this.day6.TabIndex = 8;
            this.day6.Text = "Saturday";
            this.day6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day5
            // 
            this.day5.Location = new System.Drawing.Point(427, 44);
            this.day5.Name = "day5";
            this.day5.Size = new System.Drawing.Size(86, 35);
            this.day5.TabIndex = 7;
            this.day5.Text = "Friday";
            this.day5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day4
            // 
            this.day4.Location = new System.Drawing.Point(342, 44);
            this.day4.Name = "day4";
            this.day4.Size = new System.Drawing.Size(86, 35);
            this.day4.TabIndex = 6;
            this.day4.Text = "Thursday";
            this.day4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day3
            // 
            this.day3.Location = new System.Drawing.Point(258, 44);
            this.day3.Name = "day3";
            this.day3.Size = new System.Drawing.Size(86, 35);
            this.day3.TabIndex = 5;
            this.day3.Text = "Wednesday";
            this.day3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day2
            // 
            this.day2.Location = new System.Drawing.Point(172, 44);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(86, 35);
            this.day2.TabIndex = 4;
            this.day2.Text = "Tuesday";
            this.day2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day1
            // 
            this.day1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.day1.Location = new System.Drawing.Point(86, 44);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(86, 35);
            this.day1.TabIndex = 3;
            this.day1.Text = "Monday";
            this.day1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.time_table1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.time_table2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.time_table3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.time_table4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.time_table5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.time_table6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.time_table7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.time_table8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.time_table9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.time_table10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.time_table11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.time_table12, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.time_table13, 0, 12);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 410);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // time_table1
            // 
            this.time_table1.Location = new System.Drawing.Point(3, 0);
            this.time_table1.Name = "time_table1";
            this.time_table1.Size = new System.Drawing.Size(80, 31);
            this.time_table1.TabIndex = 0;
            this.time_table1.Text = "8:00 AM";
            this.time_table1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table2
            // 
            this.time_table2.Location = new System.Drawing.Point(3, 31);
            this.time_table2.Name = "time_table2";
            this.time_table2.Size = new System.Drawing.Size(80, 31);
            this.time_table2.TabIndex = 1;
            this.time_table2.Text = "9:00 AM";
            this.time_table2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table3
            // 
            this.time_table3.Location = new System.Drawing.Point(3, 62);
            this.time_table3.Name = "time_table3";
            this.time_table3.Size = new System.Drawing.Size(80, 31);
            this.time_table3.TabIndex = 2;
            this.time_table3.Text = "10:00 AM";
            this.time_table3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table4
            // 
            this.time_table4.Location = new System.Drawing.Point(3, 93);
            this.time_table4.Name = "time_table4";
            this.time_table4.Size = new System.Drawing.Size(80, 31);
            this.time_table4.TabIndex = 3;
            this.time_table4.Text = "11:00 AM";
            this.time_table4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table5
            // 
            this.time_table5.Location = new System.Drawing.Point(3, 124);
            this.time_table5.Name = "time_table5";
            this.time_table5.Size = new System.Drawing.Size(80, 31);
            this.time_table5.TabIndex = 4;
            this.time_table5.Text = "12:00 NN";
            this.time_table5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table6
            // 
            this.time_table6.Location = new System.Drawing.Point(3, 155);
            this.time_table6.Name = "time_table6";
            this.time_table6.Size = new System.Drawing.Size(80, 31);
            this.time_table6.TabIndex = 5;
            this.time_table6.Text = "1:00 PM";
            this.time_table6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table7
            // 
            this.time_table7.Location = new System.Drawing.Point(3, 186);
            this.time_table7.Name = "time_table7";
            this.time_table7.Size = new System.Drawing.Size(80, 31);
            this.time_table7.TabIndex = 6;
            this.time_table7.Text = "2:00 PM";
            this.time_table7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table8
            // 
            this.time_table8.Location = new System.Drawing.Point(3, 217);
            this.time_table8.Name = "time_table8";
            this.time_table8.Size = new System.Drawing.Size(80, 31);
            this.time_table8.TabIndex = 7;
            this.time_table8.Text = "3:00 PM";
            this.time_table8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table9
            // 
            this.time_table9.Location = new System.Drawing.Point(3, 248);
            this.time_table9.Name = "time_table9";
            this.time_table9.Size = new System.Drawing.Size(80, 31);
            this.time_table9.TabIndex = 8;
            this.time_table9.Text = "4:00 PM";
            this.time_table9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table10
            // 
            this.time_table10.Location = new System.Drawing.Point(3, 279);
            this.time_table10.Name = "time_table10";
            this.time_table10.Size = new System.Drawing.Size(80, 31);
            this.time_table10.TabIndex = 9;
            this.time_table10.Text = "5:00 PM";
            this.time_table10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table11
            // 
            this.time_table11.Location = new System.Drawing.Point(3, 310);
            this.time_table11.Name = "time_table11";
            this.time_table11.Size = new System.Drawing.Size(80, 31);
            this.time_table11.TabIndex = 10;
            this.time_table11.Text = "6:00 PM";
            this.time_table11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table12
            // 
            this.time_table12.Location = new System.Drawing.Point(3, 341);
            this.time_table12.Name = "time_table12";
            this.time_table12.Size = new System.Drawing.Size(80, 31);
            this.time_table12.TabIndex = 11;
            this.time_table12.Text = "7:00 PM";
            this.time_table12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time_table13
            // 
            this.time_table13.Location = new System.Drawing.Point(3, 372);
            this.time_table13.Name = "time_table13";
            this.time_table13.Size = new System.Drawing.Size(80, 31);
            this.time_table13.TabIndex = 12;
            this.time_table13.Text = "8:00 PM";
            this.time_table13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.HotPink;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(601, 44);
            this.label8.TabIndex = 1;
            this.label8.Text = "HOY LORDD ANO TO";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sort_panelists
            // 
            this.sort_panelists.FormattingEnabled = true;
            this.sort_panelists.Items.AddRange(new object[] {
            "Di mo alam dahil sa yo",
            "Ako\'y di makakain",
            "Di rin makatulog",
            "Buhat ng iyong lokohin",
            "Kung ako\'y muling iibig",
            "Sana\'y di maging katulad mo",
            "Tulad mo na may pusong bato"});
            this.sort_panelists.Location = new System.Drawing.Point(0, 44);
            this.sort_panelists.Name = "sort_panelists";
            this.sort_panelists.Size = new System.Drawing.Size(160, 454);
            this.sort_panelists.TabIndex = 4;
            this.sort_panelists.Visible = false;
            // 
            // switch_sort
            // 
            this.switch_sort.Location = new System.Drawing.Point(0, 499);
            this.switch_sort.Name = "switch_sort";
            this.switch_sort.Size = new System.Drawing.Size(160, 29);
            this.switch_sort.TabIndex = 2;
            this.switch_sort.Text = "Switch Sort (Panelists)";
            this.switch_sort.UseVisualStyleBackColor = true;
            this.switch_sort.Click += new System.EventHandler(this.switch_sort_Click);
            // 
            // sort_section
            // 
            this.sort_section.FormattingEnabled = true;
            this.sort_section.Items.AddRange(new object[] {
            "Kahit san ka man ngayon",
            "Dinggin mo itong awitin",
            "Baka sakaling ika\'y magising",
            "Ang matigas mong damdamin"});
            this.sort_section.Location = new System.Drawing.Point(0, 44);
            this.sort_section.Name = "sort_section";
            this.sort_section.Size = new System.Drawing.Size(160, 454);
            this.sort_section.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thesis Groups";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Student/Panelist Schedules";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(773, 534);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thesis Groups";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.interval_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_scroll_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_scroll_up)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button switch_sort;
        public System.Windows.Forms.CheckedListBox sort_section;
        public System.Windows.Forms.CheckedListBox sort_panelists;
        private System.Windows.Forms.Label day6;
        private System.Windows.Forms.Label day5;
        private System.Windows.Forms.Label day4;
        private System.Windows.Forms.Label day3;
        private System.Windows.Forms.Label day2;
        private System.Windows.Forms.Label day1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox time_scroll_down;
        private System.Windows.Forms.PictureBox time_scroll_up;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker defenseweek_start;
        private System.Windows.Forms.Label table_interval;
        private System.Windows.Forms.PictureBox interval_down;
        private System.Windows.Forms.PictureBox interval_up;
        private System.Windows.Forms.Label time_table1;
        private System.Windows.Forms.Label time_table2;
        private System.Windows.Forms.Label time_table3;
        private System.Windows.Forms.Label time_table4;
        private System.Windows.Forms.Label time_table5;
        private System.Windows.Forms.Label time_table6;
        private System.Windows.Forms.Label time_table7;
        private System.Windows.Forms.Label time_table8;
        private System.Windows.Forms.Label time_table9;
        private System.Windows.Forms.Label time_table10;
        private System.Windows.Forms.Label time_table11;
        private System.Windows.Forms.Label time_table12;
        private System.Windows.Forms.Label time_table13;


    }
}

