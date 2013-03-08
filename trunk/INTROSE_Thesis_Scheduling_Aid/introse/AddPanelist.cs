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
    public partial class AddPanelist : Form
    {
        public AddPanelist()
        {
            InitializeComponent();
        }

        private void panelistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.panelistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNTROSEDBDataSet);

        }

        private void AddPanelist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNTROSEDBDataSet.Panelist' table. You can move, or remove it, as needed.
            this.panelistTableAdapter.Fill(this.iNTROSEDBDataSet.Panelist);

        }
    }
}
