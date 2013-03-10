namespace introse
{
    partial class DefenseScheduleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.leftButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.currentRecordNo = new System.Windows.Forms.ToolStripTextBox();
            this.totalRecord = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rightButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.defenseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.defenseTimePicker = new System.Windows.Forms.DateTimePicker();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.thesisTitleTextBox = new System.Windows.Forms.TextBox();
            this.thesisTitleComboBox = new System.Windows.Forms.ComboBox();
            this.thesisTitleLabel = new System.Windows.Forms.Label();
            this.placeLabel = new System.Windows.Forms.Label();
            this.defenseDateLabel = new System.Windows.Forms.Label();
            this.DefenseTimeLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftButton,
            this.toolStripSeparator2,
            this.currentRecordNo,
            this.totalRecord,
            this.toolStripSeparator3,
            this.rightButton,
            this.toolStripSeparator1,
            this.addButton,
            this.deleteButton,
            this.saveButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(305, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // leftButton
            // 
            this.leftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftButton.Image = global::introse.Properties.Resources.tool_left;
            this.leftButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.leftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(25, 26);
            this.leftButton.Text = "toolStripButton2";
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // currentRecordNo
            // 
            this.currentRecordNo.Name = "currentRecordNo";
            this.currentRecordNo.ReadOnly = true;
            this.currentRecordNo.Size = new System.Drawing.Size(40, 29);
            this.currentRecordNo.TextChanged += new System.EventHandler(this.currentRecordNo_TextChanged);
            // 
            // totalRecord
            // 
            this.totalRecord.Name = "totalRecord";
            this.totalRecord.Size = new System.Drawing.Size(36, 26);
            this.totalRecord.Text = "of {0}";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // rightButton
            // 
            this.rightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightButton.Image = global::introse.Properties.Resources.tool_right;
            this.rightButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(26, 26);
            this.rightButton.Text = "toolStripButton1";
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButton.Image = global::introse.Properties.Resources.tool_add;
            this.addButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(25, 26);
            this.addButton.Text = "adds record";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = global::introse.Properties.Resources.tool_delete;
            this.deleteButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(25, 26);
            this.deleteButton.Text = "Deletes current record";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::introse.Properties.Resources.tool_save;
            this.saveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(25, 26);
            this.saveButton.Text = "Saves record";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // defenseDatePicker
            // 
            this.defenseDatePicker.Location = new System.Drawing.Point(89, 122);
            this.defenseDatePicker.Name = "defenseDatePicker";
            this.defenseDatePicker.Size = new System.Drawing.Size(200, 20);
            this.defenseDatePicker.TabIndex = 1;
            // 
            // defenseTimePicker
            // 
            this.defenseTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.defenseTimePicker.Location = new System.Drawing.Point(89, 148);
            this.defenseTimePicker.Name = "defenseTimePicker";
            this.defenseTimePicker.ShowUpDown = true;
            this.defenseTimePicker.Size = new System.Drawing.Size(200, 20);
            this.defenseTimePicker.TabIndex = 2;
            // 
            // placeTextBox
            // 
            this.placeTextBox.Location = new System.Drawing.Point(89, 96);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(200, 20);
            this.placeTextBox.TabIndex = 3;
            // 
            // thesisTitleTextBox
            // 
            this.thesisTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thesisTitleTextBox.Location = new System.Drawing.Point(89, 42);
            this.thesisTitleTextBox.Name = "thesisTitleTextBox";
            this.thesisTitleTextBox.ReadOnly = true;
            this.thesisTitleTextBox.Size = new System.Drawing.Size(200, 20);
            this.thesisTitleTextBox.TabIndex = 4;
            // 
            // thesisTitleComboBox
            // 
            this.thesisTitleComboBox.FormattingEnabled = true;
            this.thesisTitleComboBox.Location = new System.Drawing.Point(89, 42);
            this.thesisTitleComboBox.Name = "thesisTitleComboBox";
            this.thesisTitleComboBox.Size = new System.Drawing.Size(200, 21);
            this.thesisTitleComboBox.TabIndex = 5;
            this.thesisTitleComboBox.Visible = false;
            this.thesisTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.thesisTitleComboBox_SelectedIndexChanged);
            // 
            // thesisTitleLabel
            // 
            this.thesisTitleLabel.AutoSize = true;
            this.thesisTitleLabel.Location = new System.Drawing.Point(9, 44);
            this.thesisTitleLabel.Name = "thesisTitleLabel";
            this.thesisTitleLabel.Size = new System.Drawing.Size(61, 13);
            this.thesisTitleLabel.TabIndex = 6;
            this.thesisTitleLabel.Text = "ThesisTitle:";
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Location = new System.Drawing.Point(9, 98);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(41, 13);
            this.placeLabel.TabIndex = 7;
            this.placeLabel.Text = "Venue:";
            // 
            // defenseDateLabel
            // 
            this.defenseDateLabel.AutoSize = true;
            this.defenseDateLabel.Location = new System.Drawing.Point(9, 127);
            this.defenseDateLabel.Name = "defenseDateLabel";
            this.defenseDateLabel.Size = new System.Drawing.Size(76, 13);
            this.defenseDateLabel.TabIndex = 8;
            this.defenseDateLabel.Text = "Defense Date:";
            // 
            // DefenseTimeLabel
            // 
            this.DefenseTimeLabel.AutoSize = true;
            this.DefenseTimeLabel.Location = new System.Drawing.Point(9, 153);
            this.DefenseTimeLabel.Name = "DefenseTimeLabel";
            this.DefenseTimeLabel.Size = new System.Drawing.Size(76, 13);
            this.DefenseTimeLabel.TabIndex = 9;
            this.DefenseTimeLabel.Text = "Defense Time:";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Location = new System.Drawing.Point(9, 72);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(43, 13);
            this.courseLabel.TabIndex = 11;
            this.courseLabel.Text = "Course:";
            // 
            // courseTextBox
            // 
            this.courseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseTextBox.Location = new System.Drawing.Point(89, 70);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.ReadOnly = true;
            this.courseTextBox.Size = new System.Drawing.Size(200, 20);
            this.courseTextBox.TabIndex = 10;
            // 
            // DefenseScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 183);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.DefenseTimeLabel);
            this.Controls.Add(this.defenseDateLabel);
            this.Controls.Add(this.placeLabel);
            this.Controls.Add(this.thesisTitleLabel);
            this.Controls.Add(this.thesisTitleComboBox);
            this.Controls.Add(this.thesisTitleTextBox);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(this.defenseTimePicker);
            this.Controls.Add(this.defenseDatePicker);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DefenseScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DefenseScheduleForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton leftButton;
        private System.Windows.Forms.ToolStripTextBox currentRecordNo;
        private System.Windows.Forms.ToolStripLabel totalRecord;
        private System.Windows.Forms.ToolStripButton rightButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DateTimePicker defenseDatePicker;
        private System.Windows.Forms.DateTimePicker defenseTimePicker;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.TextBox thesisTitleTextBox;
        private System.Windows.Forms.ComboBox thesisTitleComboBox;
        private System.Windows.Forms.Label thesisTitleLabel;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.Label defenseDateLabel;
        private System.Windows.Forms.Label DefenseTimeLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.TextBox courseTextBox;
    }
}