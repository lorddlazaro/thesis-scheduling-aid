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
    public partial class AddDefenseSchedule : Form
    {
        public AddDefenseSchedule()
        {
            InitializeComponent();
        }

        private void defenseScheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Boolean t = defenseDateTimePicker1.Value.ToString().Split(' ')[2].Equals("PM");

            int curr_hr = Convert.ToInt32(defenseDateTimePicker1.Value.ToString().Split(' ')[1].Split(':')[0]);
            int curr_min = Convert.ToInt32(defenseDateTimePicker1.Value.ToString().Split(' ')[1].Split(':')[1]);
            TimeSpan curr = new TimeSpan(curr_hr + (t? 12 : 0), curr_min, 0);

            if (curr >= new TimeSpan(8, 0, 0) && curr <= new TimeSpan(21, 0, 0))
            {
                label2.BackColor = Color.FromArgb(240, 240, 240);
                label1.BackColor = Color.FromArgb(240, 240, 240);
                label1.Text = "";

                this.Validate();
                this.defenseScheduleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.iNTROSEDBDataSet);
            }
            else
            {
                label2.BackColor = Color.Crimson;
                label1.BackColor = Color.Crimson;
                label1.Text = "Invalid Time!";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNTROSEDBDataSet.DefenseSchedule' table. You can move, or remove it, as needed.
            this.defenseScheduleTableAdapter.Fill(this.iNTROSEDBDataSet.DefenseSchedule);

        }
    }
}
