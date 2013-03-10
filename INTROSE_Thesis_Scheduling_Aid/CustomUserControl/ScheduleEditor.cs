using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomUserControl
{
    public partial class ScheduleEditor : UserControl
    {
        private String currStudent;
        private ScheduleEditorDataManager schedEditorDM;

        public ScheduleEditor()
        {
            InitializeComponent();

            currStudent = "";
            schedEditorDM = new ScheduleEditorDataManager();
            InitStudentListBox();
        }

        private void InitStudentListBox() 
        {
            schedEditorDM.UpdateStudentList(studentTreeView.Nodes);
        }

    }
}
