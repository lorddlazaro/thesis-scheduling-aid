namespace CustomUserControl
{
    partial class ScheduleEditor
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEditSched = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.studentLabel = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.studentTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // buttonEditSched
            // 
            this.buttonEditSched.Location = new System.Drawing.Point(334, 27);
            this.buttonEditSched.Name = "buttonEditSched";
            this.buttonEditSched.Size = new System.Drawing.Size(184, 25);
            this.buttonEditSched.TabIndex = 0;
            this.buttonEditSched.Text = "Edit  Class Schedules";
            this.buttonEditSched.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(280, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(283, 420);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(569, 58);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(212, 420);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(10, 39);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(52, 13);
            this.studentLabel.TabIndex = 4;
            this.studentLabel.Text = "Students:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(13, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // studentTreeView
            // 
            this.studentTreeView.Location = new System.Drawing.Point(13, 58);
            this.studentTreeView.Name = "studentTreeView";
            this.studentTreeView.Size = new System.Drawing.Size(235, 420);
            this.studentTreeView.TabIndex = 6;
            // 
            // ScheduleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.studentTreeView);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonEditSched);
            this.Name = "ScheduleEditor";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditSched;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TreeView studentTreeView;
    }
}
