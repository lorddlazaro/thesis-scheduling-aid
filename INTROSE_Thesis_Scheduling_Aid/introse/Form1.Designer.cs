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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.day6 = new System.Windows.Forms.Label();
            this.day5 = new System.Windows.Forms.Label();
            this.day4 = new System.Windows.Forms.Label();
            this.day3 = new System.Windows.Forms.Label();
            this.day2 = new System.Windows.Forms.Label();
            this.day1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.sort_panelists = new System.Windows.Forms.CheckedListBox();
            this.switch_section = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
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
            this.splitContainer1.Panel2.Controls.Add(this.switch_section);
            this.splitContainer1.Panel2.Controls.Add(this.sort_section);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(767, 528);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 0;
            // 
            // table_interval
            // 
            this.table_interval.Location = new System.Drawing.Point(86, 494);
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
            this.interval_down.Location = new System.Drawing.Point(39, 491);
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
            this.interval_up.Location = new System.Drawing.Point(-3, 491);
            this.interval_up.Name = "interval_up";
            this.interval_up.Size = new System.Drawing.Size(43, 38);
            this.interval_up.TabIndex = 13;
            this.interval_up.TabStop = false;
            this.interval_up.Click += new System.EventHandler(this.interval_up_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(403, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Thesis Defense Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defenseweek_start
            // 
            this.defenseweek_start.Location = new System.Drawing.Point(401, 508);
            this.defenseweek_start.Name = "defenseweek_start";
            this.defenseweek_start.Size = new System.Drawing.Size(200, 20);
            this.defenseweek_start.TabIndex = 11;
            this.defenseweek_start.ValueChanged += new System.EventHandler(this.defenseweek_start_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::introse.Properties.Resources.downarrow;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 38);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::introse.Properties.Resources.uparrow;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 81);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 410);
            this.tableLayoutPanel1.TabIndex = 2;
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
            // switch_section
            // 
            this.switch_section.Location = new System.Drawing.Point(0, 499);
            this.switch_section.Name = "switch_section";
            this.switch_section.Size = new System.Drawing.Size(160, 29);
            this.switch_section.TabIndex = 2;
            this.switch_section.Text = "Switch Sort (Panelists)";
            this.switch_section.UseVisualStyleBackColor = true;
            this.switch_section.Click += new System.EventHandler(this.button1_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button switch_section;
        public System.Windows.Forms.CheckedListBox sort_section;
        public System.Windows.Forms.CheckedListBox sort_panelists;
        private System.Windows.Forms.Label day6;
        private System.Windows.Forms.Label day5;
        private System.Windows.Forms.Label day4;
        private System.Windows.Forms.Label day3;
        private System.Windows.Forms.Label day2;
        private System.Windows.Forms.Label day1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker defenseweek_start;
        private System.Windows.Forms.Label table_interval;
        private System.Windows.Forms.PictureBox interval_down;
        private System.Windows.Forms.PictureBox interval_up;


    }
}

