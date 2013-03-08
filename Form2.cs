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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void defenseScheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.defenseScheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNTROSEDBDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNTROSEDBDataSet.DefenseSchedule' table. You can move, or remove it, as needed.
            this.defenseScheduleTableAdapter.Fill(this.iNTROSEDBDataSet.DefenseSchedule);

        }
    }
}
