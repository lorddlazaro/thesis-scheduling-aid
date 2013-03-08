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
    public partial class AddThesisGroup : Form
    {
        public AddThesisGroup()
        {
            InitializeComponent();
        }

        private void thesisGroupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.thesisGroupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNTROSEDBDataSet);

        }

        private void AddThesisGroup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNTROSEDBDataSet.ThesisGroup' table. You can move, or remove it, as needed.
            this.thesisGroupTableAdapter.Fill(this.iNTROSEDBDataSet.ThesisGroup);

        }
    }
}
