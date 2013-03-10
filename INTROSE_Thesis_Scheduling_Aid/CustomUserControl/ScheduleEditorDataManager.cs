using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomUserControl
{
    public class ScheduleEditorDataManager
    {
        private DBce dbHandler;
       
        public ScheduleEditorDataManager()
        {
            dbHandler = new DBce();
        }

        public void UpdateStudentList(TreeNodeCollection tree)
        {
            tree.Clear();
            String query = "select thesisgroupID, title FROM thesisgroup ORDER BY title;";
            List<String>[] groupsTable = dbHandler.Select(query, 2);

            int size = groupsTable[0].Count;
            if (size == 0)
                return;

            List<String>[] studentTable;
            TreeNode parent;
            TreeNodeCollection children;
            TreeNode currChild;

            for (int i = 0; i < size; i++)
            {
                parent = new TreeNode();
                parent.Name = groupsTable[0].ElementAt(i);
                parent.Text = groupsTable[1].ElementAt(i);
                children = parent.Nodes;
                children.Clear();

                query = "select studentID, lastName, firstName, MI FROM student WHERE thesisGroupID = " + groupsTable[0].ElementAt(i) + " ORDER BY lastName ;";
                Console.WriteLine("******* " + query);
                studentTable = dbHandler.Select(query, 4);
                for (int j = 0; j < studentTable[0].Count; j++)
                {
                    currChild = new TreeNode();
                    currChild.Name = studentTable[0].ElementAt(j);
                    currChild.Text = studentTable[1].ElementAt(j) + ", " + studentTable[2].ElementAt(j) + " " + studentTable[3].ElementAt(j) + ".";
                    children.Add(currChild);
                }
                tree.Add(parent);
            }
        }

        public void RefreshStudentClassScheds(String studentID) 
        {
        
        
        }
    }
}
