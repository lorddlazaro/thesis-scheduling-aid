namespace introse
{
    partial class AddThesisGroup
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label startSYLabel;
            System.Windows.Forms.Label startTermLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddThesisGroup));
            this.iNTROSEDBDataSet = new introse.INTROSEDBDataSet();
            this.thesisGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thesisGroupTableAdapter = new introse.INTROSEDBDataSetTableAdapters.ThesisGroupTableAdapter();
            this.tableAdapterManager = new introse.INTROSEDBDataSetTableAdapters.TableAdapterManager();
            this.thesisGroupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.thesisGroupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.startSYTextBox = new System.Windows.Forms.TextBox();
            this.startTermTextBox = new System.Windows.Forms.TextBox();
            titleLabel = new System.Windows.Forms.Label();
            courseLabel = new System.Windows.Forms.Label();
            sectionLabel = new System.Windows.Forms.Label();
            startSYLabel = new System.Windows.Forms.Label();
            startTermLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iNTROSEDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thesisGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thesisGroupBindingNavigator)).BeginInit();
            this.thesisGroupBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(6, 31);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Location = new System.Drawing.Point(6, 57);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(43, 13);
            courseLabel.TabIndex = 5;
            courseLabel.Text = "Course:";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(6, 83);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(46, 13);
            sectionLabel.TabIndex = 7;
            sectionLabel.Text = "Section:";
            // 
            // startSYLabel
            // 
            startSYLabel.AutoSize = true;
            startSYLabel.Location = new System.Drawing.Point(6, 109);
            startSYLabel.Name = "startSYLabel";
            startSYLabel.Size = new System.Drawing.Size(49, 13);
            startSYLabel.TabIndex = 9;
            startSYLabel.Text = "Start SY:";
            // 
            // startTermLabel
            // 
            startTermLabel.AutoSize = true;
            startTermLabel.Location = new System.Drawing.Point(6, 135);
            startTermLabel.Name = "startTermLabel";
            startTermLabel.Size = new System.Drawing.Size(59, 13);
            startTermLabel.TabIndex = 11;
            startTermLabel.Text = "Start Term:";
            // 
            // iNTROSEDBDataSet
            // 
            this.iNTROSEDBDataSet.DataSetName = "INTROSEDBDataSet";
            this.iNTROSEDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thesisGroupBindingSource
            // 
            this.thesisGroupBindingSource.DataMember = "ThesisGroup";
            this.thesisGroupBindingSource.DataSource = this.iNTROSEDBDataSet;
            // 
            // thesisGroupTableAdapter
            // 
            this.thesisGroupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DefenseCalendarTableAdapter = null;
            this.tableAdapterManager.DefenseScheduleTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.PanelAssignmentTableAdapter = null;
            this.tableAdapterManager.PanelistEventRecordTableAdapter = null;
            this.tableAdapterManager.PanelistTableAdapter = null;
            this.tableAdapterManager.StudentEventRecordTableAdapter = null;
            this.tableAdapterManager.StudentScheduleTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.ThesisGroupTableAdapter = this.thesisGroupTableAdapter;
            this.tableAdapterManager.TimeslotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = introse.INTROSEDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // thesisGroupBindingNavigator
            // 
            this.thesisGroupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.thesisGroupBindingNavigator.BindingSource = this.thesisGroupBindingSource;
            this.thesisGroupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.thesisGroupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.thesisGroupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.thesisGroupBindingNavigatorSaveItem});
            this.thesisGroupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.thesisGroupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.thesisGroupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.thesisGroupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.thesisGroupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.thesisGroupBindingNavigator.Name = "thesisGroupBindingNavigator";
            this.thesisGroupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.thesisGroupBindingNavigator.Size = new System.Drawing.Size(283, 25);
            this.thesisGroupBindingNavigator.TabIndex = 0;
            this.thesisGroupBindingNavigator.Text = "bindingNavigator1";
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
            // thesisGroupBindingNavigatorSaveItem
            // 
            this.thesisGroupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.thesisGroupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("thesisGroupBindingNavigatorSaveItem.Image")));
            this.thesisGroupBindingNavigatorSaveItem.Name = "thesisGroupBindingNavigatorSaveItem";
            this.thesisGroupBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.thesisGroupBindingNavigatorSaveItem.Text = "Save Data";
            this.thesisGroupBindingNavigatorSaveItem.Click += new System.EventHandler(this.thesisGroupBindingNavigatorSaveItem_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thesisGroupBindingSource, "title", true));
            this.titleTextBox.Location = new System.Drawing.Point(95, 28);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(173, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // courseTextBox
            // 
            this.courseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thesisGroupBindingSource, "course", true));
            this.courseTextBox.Location = new System.Drawing.Point(95, 54);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(173, 20);
            this.courseTextBox.TabIndex = 6;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thesisGroupBindingSource, "section", true));
            this.sectionTextBox.Location = new System.Drawing.Point(95, 80);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(173, 20);
            this.sectionTextBox.TabIndex = 8;
            // 
            // startSYTextBox
            // 
            this.startSYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thesisGroupBindingSource, "startSY", true));
            this.startSYTextBox.Location = new System.Drawing.Point(95, 106);
            this.startSYTextBox.Name = "startSYTextBox";
            this.startSYTextBox.Size = new System.Drawing.Size(173, 20);
            this.startSYTextBox.TabIndex = 10;
            // 
            // startTermTextBox
            // 
            this.startTermTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thesisGroupBindingSource, "startTerm", true));
            this.startTermTextBox.Location = new System.Drawing.Point(95, 132);
            this.startTermTextBox.Name = "startTermTextBox";
            this.startTermTextBox.Size = new System.Drawing.Size(173, 20);
            this.startTermTextBox.TabIndex = 12;
            // 
            // AddThesisGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 161);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(courseLabel);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(sectionLabel);
            this.Controls.Add(this.sectionTextBox);
            this.Controls.Add(startSYLabel);
            this.Controls.Add(this.startSYTextBox);
            this.Controls.Add(startTermLabel);
            this.Controls.Add(this.startTermTextBox);
            this.Controls.Add(this.thesisGroupBindingNavigator);
            this.Name = "AddThesisGroup";
            this.Text = "AddThesisGroup";
            this.Load += new System.EventHandler(this.AddThesisGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNTROSEDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thesisGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thesisGroupBindingNavigator)).EndInit();
            this.thesisGroupBindingNavigator.ResumeLayout(false);
            this.thesisGroupBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private INTROSEDBDataSet iNTROSEDBDataSet;
        private System.Windows.Forms.BindingSource thesisGroupBindingSource;
        private INTROSEDBDataSetTableAdapters.ThesisGroupTableAdapter thesisGroupTableAdapter;
        private INTROSEDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator thesisGroupBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton thesisGroupBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox startSYTextBox;
        private System.Windows.Forms.TextBox startTermTextBox;
    }
}