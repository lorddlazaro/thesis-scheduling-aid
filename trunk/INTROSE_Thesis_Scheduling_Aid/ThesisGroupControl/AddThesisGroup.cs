using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThesisGroupControl
{
    public partial class AddThesisGroup : UserControl
    {
        public AddThesisGroup()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            thesisAddTextBox.Visible = false;
            thesisSelectComboBox.Visible = true;

        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNTROSEDBDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Add A Thesis Group")
            {
                label5.Text = button1.Text;
                button1.Text = "Select A Thesis Group";
                thesisSelectComboBox.Visible = true;
                thesisAddTextBox.Visible = false;
            }
            else
            {
                label5.Text = button1.Text;
                button1.Text = "Add A Thesis Group";
                thesisSelectComboBox.Visible = false;
                thesisAddTextBox.Visible = true;
            }
        }
    }
}
