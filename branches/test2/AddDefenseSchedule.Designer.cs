﻿namespace introse
{
    partial class AddDefenseSchedule
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label placeLabel;
            System.Windows.Forms.Label thesisGroupIDLabel;
            System.Windows.Forms.Label defenseDateTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDefenseSchedule));
            this.iNTROSEDBDataSet = new introse.INTROSEDBDataSet();
            this.defenseScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defenseScheduleTableAdapter = new introse.INTROSEDBDataSetTableAdapters.DefenseScheduleTableAdapter();
            this.tableAdapterManager = new introse.INTROSEDBDataSetTableAdapters.TableAdapterManager();
            this.defenseScheduleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.defenseScheduleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.thesisGroupIDTextBox = new System.Windows.Forms.TextBox();
            this.defenseDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.defenseDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            placeLabel = new System.Windows.Forms.Label();
            thesisGroupIDLabel = new System.Windows.Forms.Label();
            defenseDateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iNTROSEDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseScheduleBindingNavigator)).BeginInit();
            this.defenseScheduleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // placeLabel
            // 
            placeLabel.Location = new System.Drawing.Point(8, 62);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new System.Drawing.Size(100, 20);
            placeLabel.TabIndex = 5;
            placeLabel.Text = "Venue:";
            placeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thesisGroupIDLabel
            // 
            thesisGroupIDLabel.Location = new System.Drawing.Point(8, 36);
            thesisGroupIDLabel.Name = "thesisGroupIDLabel";
            thesisGroupIDLabel.Size = new System.Drawing.Size(100, 20);
            thesisGroupIDLabel.TabIndex = 7;
            thesisGroupIDLabel.Text = "Thesis Group ID:";
            thesisGroupIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defenseDateTimeLabel
            // 
            defenseDateTimeLabel.Location = new System.Drawing.Point(8, 88);
            defenseDateTimeLabel.Name = "defenseDateTimeLabel";
            defenseDateTimeLabel.Size = new System.Drawing.Size(100, 20);
            defenseDateTimeLabel.TabIndex = 8;
            defenseDateTimeLabel.Text = "Defense Date:";
            defenseDateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iNTROSEDBDataSet
            // 
            this.iNTROSEDBDataSet.DataSetName = "INTROSEDBDataSet";
            this.iNTROSEDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // defenseScheduleBindingSource
            // 
            this.defenseScheduleBindingSource.DataMember = "DefenseSchedule";
            this.defenseScheduleBindingSource.DataSource = this.iNTROSEDBDataSet;
            // 
            // defenseScheduleTableAdapter
            // 
            this.defenseScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DefenseCalendarTableAdapter = null;
            this.tableAdapterManager.DefenseScheduleTableAdapter = this.defenseScheduleTableAdapter;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.PanelAssignmentTableAdapter = null;
            this.tableAdapterManager.PanelistEventRecordTableAdapter = null;
            this.tableAdapterManager.PanelistTableAdapter = null;
            this.tableAdapterManager.StudentEventRecordTableAdapter = null;
            this.tableAdapterManager.StudentScheduleTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.ThesisGroupTableAdapter = null;
            this.tableAdapterManager.TimeslotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = introse.INTROSEDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // defenseScheduleBindingNavigator
            // 
            this.defenseScheduleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.defenseScheduleBindingNavigator.BindingSource = this.defenseScheduleBindingSource;
            this.defenseScheduleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.defenseScheduleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.defenseScheduleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.defenseScheduleBindingNavigatorSaveItem});
            this.defenseScheduleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.defenseScheduleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.defenseScheduleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.defenseScheduleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.defenseScheduleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.defenseScheduleBindingNavigator.Name = "defenseScheduleBindingNavigator";
            this.defenseScheduleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.defenseScheduleBindingNavigator.Size = new System.Drawing.Size(305, 25);
            this.defenseScheduleBindingNavigator.TabIndex = 0;
            this.defenseScheduleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // defenseScheduleBindingNavigatorSaveItem
            // 
            this.defenseScheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.defenseScheduleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("defenseScheduleBindingNavigatorSaveItem.Image")));
            this.defenseScheduleBindingNavigatorSaveItem.Name = "defenseScheduleBindingNavigatorSaveItem";
            this.defenseScheduleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.defenseScheduleBindingNavigatorSaveItem.Text = "Save Data";
            this.defenseScheduleBindingNavigatorSaveItem.Click += new System.EventHandler(this.defenseScheduleBindingNavigatorSaveItem_Click);
            // 
            // placeTextBox
            // 
            this.placeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.defenseScheduleBindingSource, "place", true));
            this.placeTextBox.Location = new System.Drawing.Point(114, 62);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(179, 20);
            this.placeTextBox.TabIndex = 6;
            // 
            // thesisGroupIDTextBox
            // 
            this.thesisGroupIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.defenseScheduleBindingSource, "thesisGroupID", true));
            this.thesisGroupIDTextBox.Location = new System.Drawing.Point(114, 36);
            this.thesisGroupIDTextBox.Name = "thesisGroupIDTextBox";
            this.thesisGroupIDTextBox.Size = new System.Drawing.Size(179, 20);
            this.thesisGroupIDTextBox.TabIndex = 8;
            // 
            // defenseDateTimeDateTimePicker
            // 
            this.defenseDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.defenseScheduleBindingSource, "defenseDateTime", true));
            this.defenseDateTimeDateTimePicker.Location = new System.Drawing.Point(114, 88);
            this.defenseDateTimeDateTimePicker.Name = "defenseDateTimeDateTimePicker";
            this.defenseDateTimeDateTimePicker.Size = new System.Drawing.Size(179, 20);
            this.defenseDateTimeDateTimePicker.TabIndex = 9;
            // 
            // defenseDateTimePicker1
            // 
            this.defenseDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.defenseScheduleBindingSource, "defenseDateTime", true));
            this.defenseDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.defenseDateTimePicker1.Location = new System.Drawing.Point(114, 113);
            this.defenseDateTimePicker1.Name = "defenseDateTimePicker1";
            this.defenseDateTimePicker1.ShowUpDown = true;
            this.defenseDateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.defenseDateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 19);
            this.label1.TabIndex = 11;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Defense Time:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddDefenseSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 164);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defenseDateTimePicker1);
            this.Controls.Add(this.defenseDateTimeDateTimePicker);
            this.Controls.Add(defenseDateTimeLabel);
            this.Controls.Add(placeLabel);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(thesisGroupIDLabel);
            this.Controls.Add(this.thesisGroupIDTextBox);
            this.Controls.Add(this.defenseScheduleBindingNavigator);
            this.Name = "AddDefenseSchedule";
            this.Text = "Oh lol lookie cookie";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNTROSEDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseScheduleBindingNavigator)).EndInit();
            this.defenseScheduleBindingNavigator.ResumeLayout(false);
            this.defenseScheduleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private INTROSEDBDataSet iNTROSEDBDataSet;
        private System.Windows.Forms.BindingSource defenseScheduleBindingSource;
        private INTROSEDBDataSetTableAdapters.DefenseScheduleTableAdapter defenseScheduleTableAdapter;
        private INTROSEDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator defenseScheduleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton defenseScheduleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.TextBox thesisGroupIDTextBox;
        private System.Windows.Forms.DateTimePicker defenseDateTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker defenseDateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}