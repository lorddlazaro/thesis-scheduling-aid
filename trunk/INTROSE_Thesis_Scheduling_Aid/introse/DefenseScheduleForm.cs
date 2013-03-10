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
    public partial class DefenseScheduleForm : Form
    {
        DBce dbHandler;
        SchedulingDataManager sdm;
        List<Record> records;
        List<Record> unassignedGroups;
        //List<Record> newRecords;
        //List<Record> deletedRecords;
        //List<Record> changedRecords;
        Record currRecord;
        Form1 form;
        bool addMode;
        
        // Constructors

        public DefenseScheduleForm()
        {
            InitializeComponent();
        }
        public DefenseScheduleForm(Form1 form, string thesisgroupid)
        {
            this.sdm = form.Sdm;
            this.form= form;
            InitializeComponent();
            initData(thesisgroupid);
        }

        // Initialization and Updating

        // probably finished
        private void initData(string isolatedThesisTitle) {
            dbHandler = new DBce();

            if (isolatedThesisTitle.Length==0)
                fillLists();
            else
                fillLists(isolatedThesisTitle);
            if(unassignedGroups.Count() !=0)
                fillComboBox();

            this.Visible = true;
            addMode = false;
        }

        // probably finished
        private void fillComboBox() {
            ComboBox.ObjectCollection items = thesisTitleComboBox.Items;

            thesisTitleComboBox.BeginUpdate();
            thesisTitleComboBox.Items.Clear();

            foreach (Record record in unassignedGroups)
                items.Add(record.Title);

            thesisTitleComboBox.EndUpdate();
        }

        // probably finished
        private void fillLists() {
            // Fill Existing Records
            records = new List<Record>();
            unassignedGroups = new List<Record>();
            List<string>[] list;
            string assignedgroups="";

            Console.WriteLine("TEST");

            string query = "select d.defenseid, t.thesisgroupid, t.title, t.course, d.place, d.defensedatetime ";
            query += "from defenseschedule d, thesisgroup t where d.thesisgroupid = t.thesisgroupid ";
            query += "and t.thesisgroupid in (select thesisgroupid from panelassignment where panelistid =" +form.CurrPanelistID + ") order by title;";
            list = dbHandler.Select(query,6);

            Console.WriteLine("TEST1");

            for (int i = 0; i < list[0].Count(); i++) {

                records.Add(new Record(list[0].ElementAt(i), list[1].ElementAt(i), list[2].ElementAt(i), list[3].ElementAt(i), list[4].ElementAt(i), list[5].ElementAt(i).Split(' ')[0], list[5].ElementAt(i).Split(' ')[1] + " " + list[5].ElementAt(i).Split(' ')[2]));
                if (i == list[0].Count() - 1)
                    assignedgroups += "'"+list[1].ElementAt(i)+"'";
                else
                    assignedgroups += "'"+list[1].ElementAt(i) + "',";
            
            }


            //Fill Non-existing Records
            query = "select thesisgroupid, title, course from thesisgroup where thesisgroupid in ";
            query += "(select thesisgroupid from panelassignment where panelistid =" + form.CurrPanelistID;

            if (assignedgroups.Length != 0)
                query += " and thesisgroupid not in (" + assignedgroups + ")";
            
            query += ") order by title;";

            list = dbHandler.Select(query, 3);

            for (int i = 0; i < list[0].Count(); i++)
                unassignedGroups.Add(new Record(list[0].ElementAt(i), list[1].ElementAt(i), list[2].ElementAt(i)));

            if (records.Count > 0)
            {
                currentRecordNo.Text = "1";
                form.ChangeSelectedGroup(records.ElementAt(0).Thesisgroupid);
            }
            else
                currentRecordNo.Text = "0";
        }

        private void fillLists(string thesisTitle)
        {
            // Fill Existing Records
            records = new List<Record>();
            unassignedGroups = new List<Record>();
            List<string>[] list;
            string assignedgroups = "";

            string query = "select d.defenseid, t.thesisgroupid, t.title, t.course, d.place, d.defensedatetime ";
            query += "from defenseschedule d, thesisgroup t where d.thesisgroupid = t.thesisgroupid and t.thesisgroupid = " + thesisTitle + ";";
            list = dbHandler.Select(query, 6);

            if(list[0].Count()!=0){
                records.Add(new Record(list[0].ElementAt(0), list[1].ElementAt(0), list[2].ElementAt(0), list[3].ElementAt(0), list[4].ElementAt(0), list[5].ElementAt(0).Split(' ')[0], list[5].ElementAt(0).Split(' ')[1] + " " + list[5].ElementAt(0).Split(' ')[2]));
                assignedgroups = "'" + list[1].ElementAt(0) + "'";
            }

            //Fill Non-existing Records
            query = "select thesisgroupid, title, course from thesisgroup where thesisgroupid =" + thesisTitle;

            if (assignedgroups.Length != 0)
                query += " and thesisgroupid not in (" + assignedgroups + ")";

            list = dbHandler.Select(query, 3);

            if (list[0].Count() != 0)
                unassignedGroups.Add(new Record(list[0].ElementAt(0), list[1].ElementAt(0), list[2].ElementAt(0)));

            if (records.Count > 0)
            {
                currentRecordNo.Text = "1";
                form.ChangeSelectedGroup(records.ElementAt(0).Thesisgroupid);
            }
            else
                currentRecordNo.Text = "0";
        }

        // probably finished
        private void updateEnabledLeftRightButtons() 
        {
            int text = Convert.ToInt32(currentRecordNo.Text);

            if (text > 1)
                leftButton.Enabled = true;
            else
                leftButton.Enabled = false;
            if (text < records.Count())
                rightButton.Enabled = true;
            else
                rightButton.Enabled = false;
            if (addMode) {
                leftButton.Enabled = false;
                rightButton.Enabled = false;   
            }

        }

        // probably finished
        private void updateEnabledAddButton() {
            if (unassignedGroups.Count() == 0 || addMode)
                addButton.Enabled = false;
            else
                addButton.Enabled = true;
        }

        // probably finished
        private void clearComponentText() {
            thesisTitleTextBox.Clear();
            courseTextBox.Clear();
            placeTextBox.Clear();
            defenseDatePicker.Value = DateTime.Today;
            defenseTimePicker.Value = new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,0,0,0);
        }

        // probably finished
        private void updateComponents() {
            if (currRecord != null)
            {
                int year = Convert.ToInt16(currRecord.Date.Split('/')[2]);
                int month = Convert.ToInt16(currRecord.Date.Split('/')[1]);
                int day = Convert.ToInt16(currRecord.Date.Split('/')[0]);
                int hour = Convert.ToInt16(currRecord.Time.Split(':')[0]);
                int minute = Convert.ToInt16(currRecord.Time.Split(':')[1]);
                int second = Convert.ToInt16(currRecord.Time.Split(':')[2].Split(' ')[0]);

                Console.WriteLine(year +" "+month+" "+day);
                Console.WriteLine(hour + " " + minute + " " + second);


                DateTime dateTime = new DateTime(year,month,day,hour,minute,second,0);

                thesisTitleTextBox.Text = currRecord.Title;
                courseTextBox.Text = currRecord.Course;
                placeTextBox.Text = currRecord.Place;
                defenseDatePicker.Value = dateTime;
                defenseTimePicker.Value = dateTime;
            }
            else
                clearComponentText();
            totalRecord.Text= "of "+records.Count();

        }

        // Data methods

        // possibly incomplete
        private bool isInputValid(){
            
            thesisTitleComboBox.Focus();
            Boolean t = defenseTimePicker.Value.ToString().Split(' ')[2].Equals("PM");

            int curr_hr = Convert.ToInt32(defenseTimePicker.Value.ToString().Split(' ')[1].Split(':')[0]);
            int curr_min = Convert.ToInt32(defenseTimePicker.Value.ToString().Split(' ')[1].Split(':')[1]);
            if (t && curr_hr != 12)
                curr_hr += 12;
            TimeSpan curr = new TimeSpan(curr_hr, curr_min, 0);
            Console.WriteLine("hours:"+curr_hr);
            DateTime dateTime;

            TimePeriod timePeriod;

            if (curr < new TimeSpan(8, 0, 0))
            {
                MessageBox.Show("Invalid Time: You can only schedule from 8:00AM to 7:00PM for THSST-1 and 8:00AM to 8:00PM for THSST-3", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.WriteLine("time error1");
                return false;
               
            }

            dateTime = new DateTime(defenseDatePicker.Value.Year,defenseDatePicker.Value.Month,defenseDatePicker.Value.Day,defenseTimePicker.Value.Hour,defenseTimePicker.Value.Minute,0);

            if (courseTextBox.Text.Equals("THSST-1"))
            {
                timePeriod = new TimePeriod(dateTime, dateTime.AddHours(1));
                if (curr > new TimeSpan(20, 0, 0))
                {
                    MessageBox.Show("Invalid Time: You can only schedule from 8:00AM to 7:00PM for THSST-1 and 8:00AM to 8:00PM for THSST-3", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Console.WriteLine("time error2"); 
                    return false;

                    
                }
            }
            else
            {
                timePeriod = new TimePeriod(dateTime, dateTime.AddHours(2));
                if (curr > new TimeSpan(19, 0, 0))
                {
                    MessageBox.Show("Invalid Time: You can only schedule from 8:00AM to 7:00PM for THSST-1 and 8:00AM to 8:00PM for THSST-3", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Console.WriteLine("time error3");
                    return false;
                }
            }


            if (curr.Minutes % 5 != 0)
            {
                MessageBox.Show("Invalid Time: Must be in 5 minute intevals", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(defenseDatePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Invalid Date: Defenses can't be scheduled on a sunday.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            bool found=false;
            List<TimePeriod>[] list = sdm.SelectedGroupFreeTimes;


            Console.WriteLine("comparing " + timePeriod.StartTime + " " + timePeriod.EndTime + ".");
            foreach (TimePeriod freeTime in list[Convert.ToInt16(defenseDatePicker.Value.DayOfWeek) - 1])
            {
                Console.WriteLine("comparing "+freeTime.StartTime+" "+freeTime.EndTime+".");
                if (timePeriod.isWithin(freeTime))
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Error: Time conflict, please choose another time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                


            if (placeTextBox.Text.Length == 0) {
                if (MessageBox.Show("Warning: No venue specified, is this alright?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    return true;
            }
            
            return true;
        }
        
        // not started, probably never will
        //private void saveChanges() { }

        // Button-related Events

        // probably finished
        private void leftButton_Click(object sender, EventArgs e)
        {
            currentRecordNo.Text = Convert.ToString(Convert.ToInt32(currentRecordNo.Text) - 1);
            Console.WriteLine("LeftButton clicked");
        }

        // probably finished
        private void rightButton_Click(object sender, EventArgs e)
        {
            currentRecordNo.Text = Convert.ToString(Convert.ToInt32(currentRecordNo.Text) + 1);
            Console.WriteLine("RightButton clicked");
        }

        // probably finished
        private void addButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("AddButton clicked");

            thesisTitleTextBox.Visible = false;
            thesisTitleComboBox.Visible = true;

            addMode = true;
            clearComponentText();
            currentRecordNo.Text = Convert.ToString(records.Count() + 1);
            totalRecord.Text = "of "+Convert.ToString(records.Count() + 1);
        }

        // probably finished
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("DeleteButton clicked + addmode"+addMode);
            if (addMode)
            {
                if (MessageBox.Show("Are you sure you want to delete the new record?", "Delete new record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    thesisTitleTextBox.Visible = true;
                    thesisTitleComboBox.Visible = false;
                    addMode = false;
                    currentRecordNo.Text = Convert.ToString(records.Count());
                }
            }
            else
            {
                Console.WriteLine("Got inside");
                if (MessageBox.Show("Are you sure you want to delete the current record?", "Delete current record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Console.WriteLine("Got in");
                    Record record = records.ElementAt(Convert.ToInt16(currentRecordNo.Text) - 1);
                    //List<int> removeFromChanged = new List<int>();
                    //List<int> removeFromNew = new List<int>();

                    //deletedRecords.Add(record);
                    records.RemoveAt(Convert.ToInt16(currentRecordNo.Text) - 1);
                    unassignedGroups.Add(new Record(record.Thesisgroupid, record.Title, record.Course));
                    fillComboBox();
                    Console.WriteLine(record.Defenseid);
                    dbHandler.Delete("delete from defenseschedule where defenseid = " + record.Defenseid + ";");

                    //for(int i=0;i<changedRecords.Count();i++)
                    //  if(changedRecords.ElementAt(i).Defenseid == record.Defenseid)
                    //    removeFromChanged.Add(i);

                    //for(int i=0;i<newRecords.Count();i++)
                    //  if(newRecords.ElementAt(i).Defenseid == record.Defenseid)
                    //    removeFromNew.Add(i);

                    //for(int i=removeFromChanged.Count-1;i!=0;i--)
                    //    changedRecords.RemoveAt(i);
                    //for(int i=removeFromNew.Count-1;i!=0;i--)
                    //    newRecords.RemoveAt(i);


                    currentRecordNo.Text = Convert.ToString(records.Count());
                }
            }
            totalRecord.Text = "of " + Convert.ToString(records.Count());
        }

        // probably finished
        private void saveButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SaveButton clicked");
            placeTextBox.Focus();
            defenseTimePicker.Focus();
            placeTextBox.Focus();


            if (isInputValid() && MessageBox.Show("Confirm save?","Saving record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {
                if (addMode)
                {
                    if (thesisTitleComboBox.Text.Length != 0)
                    {
                        thesisTitleTextBox.Visible = true;
                        thesisTitleComboBox.Visible = false;
                        addMode = false;

                        Record record = null;
                        for (int i = 0; i < unassignedGroups.Count(); i++)
                            if (thesisTitleComboBox.Text == unassignedGroups.ElementAt(i).Title)
                            {
                                record = unassignedGroups.ElementAt(i);
                                records.Add(record);
                                unassignedGroups.RemoveAt(i);
                                break;
                            }

                        record.Date = defenseDatePicker.Value.Day + "/" + defenseDatePicker.Value.Month + "/" + defenseDatePicker.Value.Year;
                        record.Time = string.Format("{0:HH:mm:ss tt}", defenseTimePicker.Value);
                        record.Place = placeTextBox.Text;
                        Console.WriteLine("argh " + record.Time);

                        dbHandler.Insert("insert into defenseschedule (defensedatetime,place,thesisgroupid) values('" + record.Date + " " + record.Time + "','" + record.Place + "','" + record.Thesisgroupid + "');");
                        record.Defenseid = dbHandler.Select("select defenseid from defenseschedule where thesisgroupid =" + record.Thesisgroupid + ";", 1)[0].ElementAt(0);
                    }
                    else
                        MessageBox.Show("Error: No thesis group selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    Record record = records.ElementAt(Convert.ToInt16(currentRecordNo.Text) - 1);

                    record.Date = defenseDatePicker.Value.Day+"/"+defenseDatePicker.Value.Month+"/"+defenseDatePicker.Value.Year;
                    record.Time = string.Format("{0:HH:mm:ss tt}", defenseTimePicker.Value);
                    record.Place = placeTextBox.Text;
                    Console.WriteLine("argh "+record.Time);
                    dbHandler.Update("update defenseschedule set defensedatetime='"+record.Date+" "+record.Time+"', place='"+placeTextBox.Text+"' where defenseid="+record.Defenseid+";");
                }

                updateEnabledAddButton();
                updateEnabledLeftRightButtons();
                updateComponents();
            }
        }

        // probably finished
        private void currentRecordNo_TextChanged(object sender, EventArgs e)
        {
            int text = Convert.ToInt32(currentRecordNo.Text);

            updateEnabledAddButton();
            updateEnabledLeftRightButtons();

            try
            {
                form.ChangeSelectedGroup(records.ElementAt(text - 1).Thesisgroupid);
            }
            catch (Exception ex) { }
           
            if (text > 0 && text <= records.Count())
            {
                deleteButton.Enabled = true;
                if(!addMode)
                    currRecord = records.ElementAt(text - 1);
                updateComponents();
            }
            else
                if (text + records.Count() == 0)
                    deleteButton.Enabled = false;
            
        }


        private void thesisTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < unassignedGroups.Count; i++)
                if (thesisTitleComboBox.Text == unassignedGroups.ElementAt(i).Title)
                {
                    courseTextBox.Text = unassignedGroups.ElementAt(i).Course;
                    thesisTitleTextBox.Text = thesisTitleComboBox.SelectedText;
                    form.ChangeSelectedGroup(unassignedGroups.ElementAt(i).Thesisgroupid);
                    break;
                }

        }

        // Custom class RECORD stores information about defense schedule and thesis group

        private class Record
        {
            string defenseid;
            string thesisgroupid;
            string title;
            string course;
            string place;
            string date;
            string time;
            int index;

            public Record(){ }
            public Record(string did, string tgid, string title,string course, string place, string date, string time) {
                defenseid = did;
                thesisgroupid = tgid;
                this.title = title;
                this.course = course;
                this.place = place;
                this.date = date;
                this.time = time;
            }
            public Record(string tgid, string title, string course)
            {
                thesisgroupid = tgid;
                this.title = title;
                this.course = course;
            }

            public string Defenseid { get { return defenseid; } set { this.defenseid = value; } }
            public string Thesisgroupid { get { return thesisgroupid; } set { this.thesisgroupid = value; } }
            public string Title { get { return title; } set { this.title = value; } }
            public string Course { get { return course; } set { this.course = value; } }
            public string Place { get { return place; } set { this.place = value; } }
            public string Date { get { return date; } set { this.date = value; } }
            public string Time { get { return time; } set { this.time = value; } }

            public int Index { get { return index; } set { this.index = value; } }
        }
    }
}
