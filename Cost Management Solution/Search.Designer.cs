namespace Cost_Management_Solution
{
    partial class Search
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchAdvanceTab = new System.Windows.Forms.TabPage();
            this.searchAdvMfgIdInput = new System.Windows.Forms.TextBox();
            this.searchAdvProductIdLabel = new System.Windows.Forms.Label();
            this.searchAdvMfgIdLabel = new System.Windows.Forms.Label();
            this.searchAdvProductIdInput = new System.Windows.Forms.TextBox();
            this.searchBasicTab = new System.Windows.Forms.TabPage();
            this.searchDateRangeGroup = new System.Windows.Forms.GroupBox();
            this.searchByDateFlag = new System.Windows.Forms.CheckBox();
            this.searchEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.searchEndDateLabel = new System.Windows.Forms.Label();
            this.searchStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.searchInitiativeLabel = new System.Windows.Forms.Label();
            this.searchStatusDropDown = new System.Windows.Forms.ComboBox();
            this.searchInitiativeIdInput = new System.Windows.Forms.TextBox();
            this.searchAnalystDropDown = new System.Windows.Forms.ComboBox();
            this.searchStatusLabel = new System.Windows.Forms.Label();
            this.searchAnalystLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.searchTabControl = new System.Windows.Forms.TabControl();
            this.searchResultsGridView = new System.Windows.Forms.DataGridView();
            this.searchInitiativeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchAnalyst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchAdvanceTab.SuspendLayout();
            this.searchBasicTab.SuspendLayout();
            this.searchDateRangeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.searchTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Location = new System.Drawing.Point(4, 452);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(76, 30);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchAdvanceTab
            // 
            this.searchAdvanceTab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchAdvanceTab.Controls.Add(this.searchAdvMfgIdInput);
            this.searchAdvanceTab.Controls.Add(this.searchAdvProductIdLabel);
            this.searchAdvanceTab.Controls.Add(this.searchAdvMfgIdLabel);
            this.searchAdvanceTab.Controls.Add(this.searchAdvProductIdInput);
            this.searchAdvanceTab.Location = new System.Drawing.Point(4, 32);
            this.searchAdvanceTab.Name = "searchAdvanceTab";
            this.searchAdvanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchAdvanceTab.Size = new System.Drawing.Size(555, 223);
            this.searchAdvanceTab.TabIndex = 1;
            this.searchAdvanceTab.Text = "Advanced";
            // 
            // searchAdvMfgIdInput
            // 
            this.searchAdvMfgIdInput.Location = new System.Drawing.Point(138, 42);
            this.searchAdvMfgIdInput.Name = "searchAdvMfgIdInput";
            this.searchAdvMfgIdInput.Size = new System.Drawing.Size(100, 27);
            this.searchAdvMfgIdInput.TabIndex = 3;
            // 
            // searchAdvProductIdLabel
            // 
            this.searchAdvProductIdLabel.AutoSize = true;
            this.searchAdvProductIdLabel.Location = new System.Drawing.Point(6, 12);
            this.searchAdvProductIdLabel.Name = "searchAdvProductIdLabel";
            this.searchAdvProductIdLabel.Size = new System.Drawing.Size(85, 20);
            this.searchAdvProductIdLabel.TabIndex = 0;
            this.searchAdvProductIdLabel.Text = "Product Id";
            // 
            // searchAdvMfgIdLabel
            // 
            this.searchAdvMfgIdLabel.AutoSize = true;
            this.searchAdvMfgIdLabel.Location = new System.Drawing.Point(6, 42);
            this.searchAdvMfgIdLabel.Name = "searchAdvMfgIdLabel";
            this.searchAdvMfgIdLabel.Size = new System.Drawing.Size(120, 20);
            this.searchAdvMfgIdLabel.TabIndex = 1;
            this.searchAdvMfgIdLabel.Text = "Manufacture Id";
            // 
            // searchAdvProductIdInput
            // 
            this.searchAdvProductIdInput.Location = new System.Drawing.Point(138, 9);
            this.searchAdvProductIdInput.Name = "searchAdvProductIdInput";
            this.searchAdvProductIdInput.Size = new System.Drawing.Size(100, 27);
            this.searchAdvProductIdInput.TabIndex = 2;
            // 
            // searchBasicTab
            // 
            this.searchBasicTab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchBasicTab.Controls.Add(this.searchDateRangeGroup);
            this.searchBasicTab.Controls.Add(this.searchInitiativeLabel);
            this.searchBasicTab.Controls.Add(this.searchStatusDropDown);
            this.searchBasicTab.Controls.Add(this.searchInitiativeIdInput);
            this.searchBasicTab.Controls.Add(this.searchAnalystDropDown);
            this.searchBasicTab.Controls.Add(this.searchStatusLabel);
            this.searchBasicTab.Controls.Add(this.searchAnalystLabel);
            this.searchBasicTab.Location = new System.Drawing.Point(4, 32);
            this.searchBasicTab.Name = "searchBasicTab";
            this.searchBasicTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchBasicTab.Size = new System.Drawing.Size(555, 223);
            this.searchBasicTab.TabIndex = 0;
            this.searchBasicTab.Text = "Basic";
            // 
            // searchDateRangeGroup
            // 
            this.searchDateRangeGroup.Controls.Add(this.searchByDateFlag);
            this.searchDateRangeGroup.Controls.Add(this.searchEndDatePicker);
            this.searchDateRangeGroup.Controls.Add(this.searchEndDateLabel);
            this.searchDateRangeGroup.Controls.Add(this.searchStartDatePicker);
            this.searchDateRangeGroup.Controls.Add(this.label1);
            this.searchDateRangeGroup.Location = new System.Drawing.Point(246, 6);
            this.searchDateRangeGroup.Name = "searchDateRangeGroup";
            this.searchDateRangeGroup.Size = new System.Drawing.Size(236, 133);
            this.searchDateRangeGroup.TabIndex = 10;
            this.searchDateRangeGroup.TabStop = false;
            this.searchDateRangeGroup.Text = "Date Range";
            // 
            // searchByDateFlag
            // 
            this.searchByDateFlag.AutoSize = true;
            this.searchByDateFlag.Location = new System.Drawing.Point(11, 26);
            this.searchByDateFlag.Name = "searchByDateFlag";
            this.searchByDateFlag.Size = new System.Drawing.Size(147, 24);
            this.searchByDateFlag.TabIndex = 13;
            this.searchByDateFlag.Text = "Search by Date";
            this.searchByDateFlag.UseVisualStyleBackColor = true;
            // 
            // searchEndDatePicker
            // 
            this.searchEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchEndDatePicker.Location = new System.Drawing.Point(100, 97);
            this.searchEndDatePicker.Name = "searchEndDatePicker";
            this.searchEndDatePicker.Size = new System.Drawing.Size(128, 27);
            this.searchEndDatePicker.TabIndex = 12;
            // 
            // searchEndDateLabel
            // 
            this.searchEndDateLabel.AutoSize = true;
            this.searchEndDateLabel.Location = new System.Drawing.Point(7, 104);
            this.searchEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchEndDateLabel.Name = "searchEndDateLabel";
            this.searchEndDateLabel.Size = new System.Drawing.Size(79, 20);
            this.searchEndDateLabel.TabIndex = 8;
            this.searchEndDateLabel.Text = "End Date";
            // 
            // searchStartDatePicker
            // 
            this.searchStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchStartDatePicker.Location = new System.Drawing.Point(100, 61);
            this.searchStartDatePicker.Name = "searchStartDatePicker";
            this.searchStartDatePicker.Size = new System.Drawing.Size(128, 27);
            this.searchStartDatePicker.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start Date";
            // 
            // searchInitiativeLabel
            // 
            this.searchInitiativeLabel.AutoSize = true;
            this.searchInitiativeLabel.Location = new System.Drawing.Point(2, 23);
            this.searchInitiativeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchInitiativeLabel.Name = "searchInitiativeLabel";
            this.searchInitiativeLabel.Size = new System.Drawing.Size(88, 20);
            this.searchInitiativeLabel.TabIndex = 0;
            this.searchInitiativeLabel.Text = "Initiative Id";
            // 
            // searchStatusDropDown
            // 
            this.searchStatusDropDown.FormattingEnabled = true;
            this.searchStatusDropDown.Items.AddRange(new object[] {
            "Approved",
            "Discontinued",
            "Implemented",
            "Pending ",
            "Preliminary",
            "Presented",
            "Rejected",
            "Tracking Complete",
            "Trial"});
            this.searchStatusDropDown.Location = new System.Drawing.Point(97, 54);
            this.searchStatusDropDown.Name = "searchStatusDropDown";
            this.searchStatusDropDown.Size = new System.Drawing.Size(121, 28);
            this.searchStatusDropDown.TabIndex = 7;
            // 
            // searchInitiativeIdInput
            // 
            this.searchInitiativeIdInput.Location = new System.Drawing.Point(97, 20);
            this.searchInitiativeIdInput.Name = "searchInitiativeIdInput";
            this.searchInitiativeIdInput.Size = new System.Drawing.Size(121, 27);
            this.searchInitiativeIdInput.TabIndex = 1;
            // 
            // searchAnalystDropDown
            // 
            this.searchAnalystDropDown.FormattingEnabled = true;
            this.searchAnalystDropDown.Items.AddRange(new object[] {
            "Adam Dale",
            "Chrissy Smith",
            "Erin O\'Brien",
            "Gene Roberts",
            "Janice Holt",
            "Rick Jarrett"});
            this.searchAnalystDropDown.Location = new System.Drawing.Point(97, 96);
            this.searchAnalystDropDown.Name = "searchAnalystDropDown";
            this.searchAnalystDropDown.Size = new System.Drawing.Size(121, 28);
            this.searchAnalystDropDown.TabIndex = 6;
            // 
            // searchStatusLabel
            // 
            this.searchStatusLabel.AutoSize = true;
            this.searchStatusLabel.Location = new System.Drawing.Point(2, 62);
            this.searchStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchStatusLabel.Name = "searchStatusLabel";
            this.searchStatusLabel.Size = new System.Drawing.Size(57, 20);
            this.searchStatusLabel.TabIndex = 3;
            this.searchStatusLabel.Text = "Status";
            // 
            // searchAnalystLabel
            // 
            this.searchAnalystLabel.AutoSize = true;
            this.searchAnalystLabel.Location = new System.Drawing.Point(2, 96);
            this.searchAnalystLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchAnalystLabel.Name = "searchAnalystLabel";
            this.searchAnalystLabel.Size = new System.Drawing.Size(64, 20);
            this.searchAnalystLabel.TabIndex = 4;
            this.searchAnalystLabel.Text = "Analyst";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.searchTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.searchResultsGridView);
            this.splitContainer1.Size = new System.Drawing.Size(561, 446);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 3;
            // 
            // searchTabControl
            // 
            this.searchTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.searchTabControl.Controls.Add(this.searchBasicTab);
            this.searchTabControl.Controls.Add(this.searchAdvanceTab);
            this.searchTabControl.Location = new System.Drawing.Point(0, 3);
            this.searchTabControl.Name = "searchTabControl";
            this.searchTabControl.SelectedIndex = 0;
            this.searchTabControl.Size = new System.Drawing.Size(563, 259);
            this.searchTabControl.TabIndex = 4;
            // 
            // searchResultsGridView
            // 
            this.searchResultsGridView.AllowUserToAddRows = false;
            this.searchResultsGridView.AllowUserToDeleteRows = false;
            this.searchResultsGridView.AllowUserToResizeRows = false;
            this.searchResultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.searchInitiativeId,
            this.searchStatus,
            this.searchAnalyst,
            this.searchDateCreated});
            this.searchResultsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultsGridView.Location = new System.Drawing.Point(0, 0);
            this.searchResultsGridView.Name = "searchResultsGridView";
            this.searchResultsGridView.ReadOnly = true;
            this.searchResultsGridView.RowTemplate.Height = 24;
            this.searchResultsGridView.Size = new System.Drawing.Size(561, 180);
            this.searchResultsGridView.TabIndex = 0;
            this.searchResultsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResultsGridView_CellContentClick);
            // 
            // searchInitiativeId
            // 
            this.searchInitiativeId.HeaderText = "Initiative";
            this.searchInitiativeId.Name = "searchInitiativeId";
            this.searchInitiativeId.ReadOnly = true;
            this.searchInitiativeId.Width = 75;
            // 
            // searchStatus
            // 
            this.searchStatus.HeaderText = "Status";
            this.searchStatus.Name = "searchStatus";
            this.searchStatus.ReadOnly = true;
            this.searchStatus.Width = 150;
            // 
            // searchAnalyst
            // 
            this.searchAnalyst.HeaderText = "Analyst";
            this.searchAnalyst.Name = "searchAnalyst";
            this.searchAnalyst.ReadOnly = true;
            this.searchAnalyst.Width = 130;
            // 
            // searchDateCreated
            // 
            this.searchDateCreated.HeaderText = "Date Created";
            this.searchDateCreated.Name = "searchDateCreated";
            this.searchDateCreated.ReadOnly = true;
            this.searchDateCreated.Width = 140;
            // 
            // Search
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(559, 486);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.searchButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Search";
            this.searchAdvanceTab.ResumeLayout(false);
            this.searchAdvanceTab.PerformLayout();
            this.searchBasicTab.ResumeLayout(false);
            this.searchBasicTab.PerformLayout();
            this.searchDateRangeGroup.ResumeLayout(false);
            this.searchDateRangeGroup.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.searchTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TabPage searchAdvanceTab;
        private System.Windows.Forms.TextBox searchAdvMfgIdInput;
        private System.Windows.Forms.Label searchAdvProductIdLabel;
        private System.Windows.Forms.Label searchAdvMfgIdLabel;
        private System.Windows.Forms.TextBox searchAdvProductIdInput;
        private System.Windows.Forms.TabPage searchBasicTab;
        private System.Windows.Forms.GroupBox searchDateRangeGroup;
        private System.Windows.Forms.DateTimePicker searchEndDatePicker;
        private System.Windows.Forms.Label searchEndDateLabel;
        private System.Windows.Forms.DateTimePicker searchStartDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label searchInitiativeLabel;
        private System.Windows.Forms.ComboBox searchStatusDropDown;
        private System.Windows.Forms.TextBox searchInitiativeIdInput;
        private System.Windows.Forms.ComboBox searchAnalystDropDown;
        private System.Windows.Forms.Label searchStatusLabel;
        private System.Windows.Forms.Label searchAnalystLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TabControl searchTabControl;
        private System.Windows.Forms.DataGridView searchResultsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchInitiativeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchAnalyst;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchDateCreated;
        public System.Windows.Forms.CheckBox searchByDateFlag;
    }
}