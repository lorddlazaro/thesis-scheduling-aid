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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
                // TODO: Add Student to ThesisGroup DB TEAM TINGIN MGA PANGET :D
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNTROSEDBDataSet);

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNTROSEDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.iNTROSEDBDataSet.Student);

        }
    }
}
