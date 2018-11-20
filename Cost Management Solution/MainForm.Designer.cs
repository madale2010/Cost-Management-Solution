using System.Collections.Generic;

namespace Cost_Management_Solution
{
    partial class CostManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostManagementForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sIDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.broadJumpDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelWorkbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.rejectedByDropDown = new System.Windows.Forms.ComboBox();
            this.unspscInput = new System.Windows.Forms.TextBox();
            this.rationaleInput = new System.Windows.Forms.TextBox();
            this.originDropDown = new System.Windows.Forms.ComboBox();
            this.savingsTypeDropDown = new System.Windows.Forms.ComboBox();
            this.optionDropDown = new System.Windows.Forms.ComboBox();
            this.manufactureInput = new System.Windows.Forms.TextBox();
            this.categoryInput = new System.Windows.Forms.TextBox();
            this.actionPlanDropDown = new System.Windows.Forms.ComboBox();
            this.sharpsStatusDropDown = new System.Windows.Forms.ComboBox();
            this.areaDropDown = new System.Windows.Forms.ComboBox();
            this.skusReducedInput = new System.Windows.Forms.TextBox();
            this.dateApprovedPicker = new System.Windows.Forms.DateTimePicker();
            this.datePresentedPicker = new System.Windows.Forms.DateTimePicker();
            this.dateImplimentedPicker = new System.Windows.Forms.DateTimePicker();
            this.tentativeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateRejectedPicker = new System.Windows.Forms.DateTimePicker();
            this.datePresentedLabel = new System.Windows.Forms.Label();
            this.tentativeDateLabel = new System.Windows.Forms.Label();
            this.actionPlanLabel = new System.Windows.Forms.Label();
            this.rejectedByLabel = new System.Windows.Forms.Label();
            this.dateRejectedLabel = new System.Windows.Forms.Label();
            this.dateApprovedLabel = new System.Windows.Forms.Label();
            this.dateImplimentedLabel = new System.Windows.Forms.Label();
            this.rationaleLabel = new System.Windows.Forms.Label();
            this.unspscLabel = new System.Windows.Forms.Label();
            this.skusReducedLabel = new System.Windows.Forms.Label();
            this.orginLabel = new System.Windows.Forms.Label();
            this.sharpsStatusLabel = new System.Windows.Forms.Label();
            this.savingsTypeLabel = new System.Windows.Forms.Label();
            this.optionLabel = new System.Windows.Forms.Label();
            this.manufactureLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalSavingsPercentInput = new System.Windows.Forms.TextBox();
            this.totalSavingsPercentLabel = new System.Windows.Forms.Label();
            this.totalSavingsInput = new System.Windows.Forms.TextBox();
            this.totalSpendInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalSpendLabel = new System.Windows.Forms.Label();
            this.contractGroupBox = new System.Windows.Forms.GroupBox();
            this.contractActionInput = new System.Windows.Forms.TextBox();
            this.contractDetailsDropDown = new System.Windows.Forms.ComboBox();
            this.contractDistributionDropDown = new System.Windows.Forms.ComboBox();
            this.contractManufactureInput = new System.Windows.Forms.TextBox();
            this.contractIdInput = new System.Windows.Forms.TextBox();
            this.contractTierInput = new System.Windows.Forms.TextBox();
            this.contractEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.contractStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.contractDistributionLabel = new System.Windows.Forms.Label();
            this.contractManufacture = new System.Windows.Forms.Label();
            this.contractTierLabel = new System.Windows.Forms.Label();
            this.contractIdLabel = new System.Windows.Forms.Label();
            this.contractDetailsLabel = new System.Windows.Forms.Label();
            this.contractEndDateLabel = new System.Windows.Forms.Label();
            this.contractStartDateLabel = new System.Windows.Forms.Label();
            this.contractActionLabel = new System.Windows.Forms.Label();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.analystDropDown = new System.Windows.Forms.ComboBox();
            this.initiativeIdLabel = new System.Windows.Forms.Label();
            this.dateCreatedPicker = new System.Windows.Forms.DateTimePicker();
            this.initiativeStatusLabel = new System.Windows.Forms.Label();
            this.statusDropDown = new System.Windows.Forms.ComboBox();
            this.dateCreatedLabel = new System.Windows.Forms.Label();
            this.initiativeIdInput = new System.Windows.Forms.TextBox();
            this.analystLabel = new System.Windows.Forms.Label();
            this.trackingGroupBox = new System.Windows.Forms.GroupBox();
            this.trackingLastDatePicker = new System.Windows.Forms.DateTimePicker();
            this.trackingStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startTrackingDateLabel = new System.Windows.Forms.Label();
            this.lastTrackingDate = new System.Windows.Forms.Label();
            this.dataSourceGroupBox = new System.Windows.Forms.GroupBox();
            this.sourceInput = new System.Windows.Forms.TextBox();
            this.imUpdatedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dataDatePulledPicker = new System.Windows.Forms.DateTimePicker();
            this.dataEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dataStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSourceLabel = new System.Windows.Forms.Label();
            this.dataStartDateLabel = new System.Windows.Forms.Label();
            this.dataEndDateLabel = new System.Windows.Forms.Label();
            this.dateDataPulledLabel = new System.Windows.Forms.Label();
            this.imUpdatedDateLabel = new System.Windows.Forms.Label();
            this.productsTabPage = new System.Windows.Forms.TabPage();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufactureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPackaging = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productEachPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proposalTabPage = new System.Windows.Forms.TabPage();
            this.proposedGridView = new System.Windows.Forms.DataGridView();
            this.proposedPmm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proposedManufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proposedManufactureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proposedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proposedUnitOfMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proposedPackaging = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proposedEachPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proposedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usageTabPage = new System.Windows.Forms.TabPage();
            this.usageSplitContainer = new System.Windows.Forms.SplitContainer();
            this.usageGridView = new System.Windows.Forms.DataGridView();
            this.usageProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usageManufactureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usageManufactureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usageDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usageTotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usageTotalUsageInput = new System.Windows.Forms.TextBox();
            this.usageHckhcmhInput = new System.Windows.Forms.TextBox();
            this.usageHvmcInput = new System.Windows.Forms.TextBox();
            this.usageLphInput = new System.Windows.Forms.TextBox();
            this.usageOtherInput = new System.Windows.Forms.TextBox();
            this.usageWmaInput = new System.Windows.Forms.TextBox();
            this.usageMvInput = new System.Windows.Forms.TextBox();
            this.usageTckhInput = new System.Windows.Forms.TextBox();
            this.usageBrmcInput = new System.Windows.Forms.TextBox();
            this.usageTotalUsage = new System.Windows.Forms.Label();
            this.usageWmaLabel = new System.Windows.Forms.Label();
            this.usageOtherLabel = new System.Windows.Forms.Label();
            this.usageTckhLabel = new System.Windows.Forms.Label();
            this.usageMvLabel = new System.Windows.Forms.Label();
            this.usageLphLabel = new System.Windows.Forms.Label();
            this.usageHvmcLabel = new System.Windows.Forms.Label();
            this.usageHckHcmhLabel = new System.Windows.Forms.Label();
            this.usageBrmcLabel = new System.Windows.Forms.Label();
            this.trackingTabPage = new System.Windows.Forms.TabPage();
            this.trackingGridView = new System.Windows.Forms.DataGridView();
            this.trackingMfgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingBrmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingHckHcmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingHvmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingMV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingTh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingWma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broadjumpTabPage = new System.Windows.Forms.TabPage();
            this.broadJumpGridView = new System.Windows.Forms.DataGridView();
            this.bjProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bjEachPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bjCurrentEachPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bjTotalUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bjTotalSavings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryTabPage = new System.Windows.Forms.TabPage();
            this.summaryGridView = new System.Windows.Forms.DataGridView();
            this.summaryProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summarySavingsAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryDelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryTotalUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryTotalSavings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryRealizedSavings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesTabPage = new System.Windows.Forms.TabPage();
            this.noteGridView = new System.Windows.Forms.DataGridView();
            this.noteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.contractGroupBox.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.trackingGroupBox.SuspendLayout();
            this.dataSourceGroupBox.SuspendLayout();
            this.productsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.proposalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proposedGridView)).BeginInit();
            this.usageTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usageSplitContainer)).BeginInit();
            this.usageSplitContainer.Panel1.SuspendLayout();
            this.usageSplitContainer.Panel2.SuspendLayout();
            this.usageSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usageGridView)).BeginInit();
            this.trackingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackingGridView)).BeginInit();
            this.broadjumpTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.broadJumpGridView)).BeginInit();
            this.summaryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryGridView)).BeginInit();
            this.notesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1253, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1,
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 27);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem1.Image")));
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(195, 28);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(192, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.importDataToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sIDataToolStripMenuItem,
            this.vendorDataToolStripMenuItem,
            this.broadJumpDataToolStripMenuItem});
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.importDataToolStripMenuItem.Text = "Import";
            // 
            // sIDataToolStripMenuItem
            // 
            this.sIDataToolStripMenuItem.Name = "sIDataToolStripMenuItem";
            this.sIDataToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.sIDataToolStripMenuItem.Text = "SI Data";
            this.sIDataToolStripMenuItem.Click += new System.EventHandler(this.sIDataToolStripMenuItem_Click);
            // 
            // vendorDataToolStripMenuItem
            // 
            this.vendorDataToolStripMenuItem.Name = "vendorDataToolStripMenuItem";
            this.vendorDataToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.vendorDataToolStripMenuItem.Text = "Vendor Data";
            // 
            // broadJumpDataToolStripMenuItem
            // 
            this.broadJumpDataToolStripMenuItem.Name = "broadJumpDataToolStripMenuItem";
            this.broadJumpDataToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.broadJumpDataToolStripMenuItem.Text = "BroadJump Data";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelWorkbookToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // excelWorkbookToolStripMenuItem
            // 
            this.excelWorkbookToolStripMenuItem.Name = "excelWorkbookToolStripMenuItem";
            this.excelWorkbookToolStripMenuItem.Size = new System.Drawing.Size(206, 28);
            this.excelWorkbookToolStripMenuItem.Text = "Excel Workbook";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 27);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(152, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.mainTabPage);
            this.tabControl.Controls.Add(this.productsTabPage);
            this.tabControl.Controls.Add(this.proposalTabPage);
            this.tabControl.Controls.Add(this.usageTabPage);
            this.tabControl.Controls.Add(this.trackingTabPage);
            this.tabControl.Controls.Add(this.broadjumpTabPage);
            this.tabControl.Controls.Add(this.summaryTabPage);
            this.tabControl.Controls.Add(this.notesTabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 91);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1253, 684);
            this.tabControl.TabIndex = 1;
            // 
            // mainTabPage
            // 
            this.mainTabPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainTabPage.Controls.Add(this.generalGroupBox);
            this.mainTabPage.Controls.Add(this.summaryGroupBox);
            this.mainTabPage.Controls.Add(this.contractGroupBox);
            this.mainTabPage.Controls.Add(this.mainGroupBox);
            this.mainTabPage.Controls.Add(this.trackingGroupBox);
            this.mainTabPage.Controls.Add(this.dataSourceGroupBox);
            this.mainTabPage.Location = new System.Drawing.Point(4, 29);
            this.mainTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.mainTabPage.Size = new System.Drawing.Size(1245, 651);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Main";
            this.mainTabPage.Click += new System.EventHandler(this.mainTabPage_Click);
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.rejectedByDropDown);
            this.generalGroupBox.Controls.Add(this.unspscInput);
            this.generalGroupBox.Controls.Add(this.rationaleInput);
            this.generalGroupBox.Controls.Add(this.originDropDown);
            this.generalGroupBox.Controls.Add(this.savingsTypeDropDown);
            this.generalGroupBox.Controls.Add(this.optionDropDown);
            this.generalGroupBox.Controls.Add(this.manufactureInput);
            this.generalGroupBox.Controls.Add(this.categoryInput);
            this.generalGroupBox.Controls.Add(this.actionPlanDropDown);
            this.generalGroupBox.Controls.Add(this.sharpsStatusDropDown);
            this.generalGroupBox.Controls.Add(this.areaDropDown);
            this.generalGroupBox.Controls.Add(this.skusReducedInput);
            this.generalGroupBox.Controls.Add(this.dateApprovedPicker);
            this.generalGroupBox.Controls.Add(this.datePresentedPicker);
            this.generalGroupBox.Controls.Add(this.dateImplimentedPicker);
            this.generalGroupBox.Controls.Add(this.tentativeDatePicker);
            this.generalGroupBox.Controls.Add(this.dateRejectedPicker);
            this.generalGroupBox.Controls.Add(this.datePresentedLabel);
            this.generalGroupBox.Controls.Add(this.tentativeDateLabel);
            this.generalGroupBox.Controls.Add(this.actionPlanLabel);
            this.generalGroupBox.Controls.Add(this.rejectedByLabel);
            this.generalGroupBox.Controls.Add(this.dateRejectedLabel);
            this.generalGroupBox.Controls.Add(this.dateApprovedLabel);
            this.generalGroupBox.Controls.Add(this.dateImplimentedLabel);
            this.generalGroupBox.Controls.Add(this.rationaleLabel);
            this.generalGroupBox.Controls.Add(this.unspscLabel);
            this.generalGroupBox.Controls.Add(this.skusReducedLabel);
            this.generalGroupBox.Controls.Add(this.orginLabel);
            this.generalGroupBox.Controls.Add(this.sharpsStatusLabel);
            this.generalGroupBox.Controls.Add(this.savingsTypeLabel);
            this.generalGroupBox.Controls.Add(this.optionLabel);
            this.generalGroupBox.Controls.Add(this.manufactureLabel);
            this.generalGroupBox.Controls.Add(this.categoryLabel);
            this.generalGroupBox.Controls.Add(this.areaLabel);
            this.generalGroupBox.Location = new System.Drawing.Point(8, 229);
            this.generalGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.generalGroupBox.Size = new System.Drawing.Size(627, 341);
            this.generalGroupBox.TabIndex = 5;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            this.generalGroupBox.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // rejectedByDropDown
            // 
            this.rejectedByDropDown.FormattingEnabled = true;
            this.rejectedByDropDown.Items.AddRange(new object[] {
            "ELT",
            "End User",
            "Management",
            "Service Line"});
            this.rejectedByDropDown.Location = new System.Drawing.Point(482, 288);
            this.rejectedByDropDown.Name = "rejectedByDropDown";
            this.rejectedByDropDown.Size = new System.Drawing.Size(129, 28);
            this.rejectedByDropDown.TabIndex = 42;
            // 
            // unspscInput
            // 
            this.unspscInput.Location = new System.Drawing.Point(482, 56);
            this.unspscInput.Name = "unspscInput";
            this.unspscInput.Size = new System.Drawing.Size(129, 27);
            this.unspscInput.TabIndex = 41;
            // 
            // rationaleInput
            // 
            this.rationaleInput.Location = new System.Drawing.Point(166, 295);
            this.rationaleInput.Name = "rationaleInput";
            this.rationaleInput.Size = new System.Drawing.Size(136, 27);
            this.rationaleInput.TabIndex = 40;
            // 
            // originDropDown
            // 
            this.originDropDown.FormattingEnabled = true;
            this.originDropDown.Items.AddRange(new object[] {
            "Broadjump",
            "Contract Review",
            "GPO",
            "Medline",
            "New Tech",
            "Pre-Commit",
            "Product Review",
            "Recalls",
            "Vanderbilt",
            "WMA"});
            this.originDropDown.Location = new System.Drawing.Point(166, 261);
            this.originDropDown.Name = "originDropDown";
            this.originDropDown.Size = new System.Drawing.Size(136, 28);
            this.originDropDown.TabIndex = 39;
            // 
            // savingsTypeDropDown
            // 
            this.savingsTypeDropDown.FormattingEnabled = true;
            this.savingsTypeDropDown.Items.AddRange(new object[] {
            "Broadjump",
            "Cost Savings",
            "End-User Request",
            "Other",
            "Sku Reduction",
            "Standardization",
            "Tier Optimization",
            "Vanderbilt",
            "WMA"});
            this.savingsTypeDropDown.Location = new System.Drawing.Point(166, 193);
            this.savingsTypeDropDown.Name = "savingsTypeDropDown";
            this.savingsTypeDropDown.Size = new System.Drawing.Size(136, 28);
            this.savingsTypeDropDown.TabIndex = 38;
            // 
            // optionDropDown
            // 
            this.optionDropDown.FormattingEnabled = true;
            this.optionDropDown.Location = new System.Drawing.Point(166, 159);
            this.optionDropDown.Name = "optionDropDown";
            this.optionDropDown.Size = new System.Drawing.Size(136, 28);
            this.optionDropDown.TabIndex = 37;
            // 
            // manufactureInput
            // 
            this.manufactureInput.Location = new System.Drawing.Point(166, 126);
            this.manufactureInput.Name = "manufactureInput";
            this.manufactureInput.Size = new System.Drawing.Size(136, 27);
            this.manufactureInput.TabIndex = 36;
            // 
            // categoryInput
            // 
            this.categoryInput.Location = new System.Drawing.Point(166, 59);
            this.categoryInput.Name = "categoryInput";
            this.categoryInput.Size = new System.Drawing.Size(136, 27);
            this.categoryInput.TabIndex = 35;
            // 
            // actionPlanDropDown
            // 
            this.actionPlanDropDown.FormattingEnabled = true;
            this.actionPlanDropDown.Items.AddRange(new object[] {
            "Review",
            "SC Flip",
            "Send To ELT",
            "Send To Service Line",
            "TBA",
            "Trial"});
            this.actionPlanDropDown.Location = new System.Drawing.Point(166, 92);
            this.actionPlanDropDown.Name = "actionPlanDropDown";
            this.actionPlanDropDown.Size = new System.Drawing.Size(136, 28);
            this.actionPlanDropDown.TabIndex = 34;
            // 
            // sharpsStatusDropDown
            // 
            this.sharpsStatusDropDown.FormattingEnabled = true;
            this.sharpsStatusDropDown.Items.AddRange(new object[] {
            "N/A",
            "Non-Safe Sharps",
            "Safe Sharps"});
            this.sharpsStatusDropDown.Location = new System.Drawing.Point(166, 227);
            this.sharpsStatusDropDown.Name = "sharpsStatusDropDown";
            this.sharpsStatusDropDown.Size = new System.Drawing.Size(136, 28);
            this.sharpsStatusDropDown.TabIndex = 33;
            // 
            // areaDropDown
            // 
            this.areaDropDown.FormattingEnabled = true;
            this.areaDropDown.Items.AddRange(new object[] {
            "Anesthesia",
            "Birthplace",
            "Breast Center",
            "Cardiology",
            "Cath Lab",
            "Dialysis",
            "Echo",
            "Emergency Dept",
            "Endoscopy",
            "EVS",
            "Lab",
            "LTC",
            "Med Surge",
            "Multiple",
            "Oncology",
            "OR",
            "Physical Therapy",
            "Picc Team",
            "PPI",
            "Radiology",
            "Respiratory",
            "SPD",
            "Telemetry",
            "WMA",
            "Wound Care"});
            this.areaDropDown.Location = new System.Drawing.Point(166, 25);
            this.areaDropDown.Name = "areaDropDown";
            this.areaDropDown.Size = new System.Drawing.Size(136, 28);
            this.areaDropDown.TabIndex = 32;
            // 
            // skusReducedInput
            // 
            this.skusReducedInput.Location = new System.Drawing.Point(482, 90);
            this.skusReducedInput.Name = "skusReducedInput";
            this.skusReducedInput.Size = new System.Drawing.Size(129, 27);
            this.skusReducedInput.TabIndex = 31;
            // 
            // dateApprovedPicker
            // 
            this.dateApprovedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateApprovedPicker.Location = new System.Drawing.Point(482, 123);
            this.dateApprovedPicker.Name = "dateApprovedPicker";
            this.dateApprovedPicker.Size = new System.Drawing.Size(129, 27);
            this.dateApprovedPicker.TabIndex = 30;
            // 
            // datePresentedPicker
            // 
            this.datePresentedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePresentedPicker.Location = new System.Drawing.Point(482, 156);
            this.datePresentedPicker.Name = "datePresentedPicker";
            this.datePresentedPicker.Size = new System.Drawing.Size(129, 27);
            this.datePresentedPicker.TabIndex = 29;
            // 
            // dateImplimentedPicker
            // 
            this.dateImplimentedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateImplimentedPicker.Location = new System.Drawing.Point(482, 188);
            this.dateImplimentedPicker.Name = "dateImplimentedPicker";
            this.dateImplimentedPicker.Size = new System.Drawing.Size(129, 27);
            this.dateImplimentedPicker.TabIndex = 28;
            // 
            // tentativeDatePicker
            // 
            this.tentativeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tentativeDatePicker.Location = new System.Drawing.Point(482, 221);
            this.tentativeDatePicker.Name = "tentativeDatePicker";
            this.tentativeDatePicker.Size = new System.Drawing.Size(129, 27);
            this.tentativeDatePicker.TabIndex = 27;
            // 
            // dateRejectedPicker
            // 
            this.dateRejectedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRejectedPicker.Location = new System.Drawing.Point(482, 254);
            this.dateRejectedPicker.Name = "dateRejectedPicker";
            this.dateRejectedPicker.Size = new System.Drawing.Size(129, 27);
            this.dateRejectedPicker.TabIndex = 26;
            // 
            // datePresentedLabel
            // 
            this.datePresentedLabel.AutoSize = true;
            this.datePresentedLabel.Location = new System.Drawing.Point(335, 167);
            this.datePresentedLabel.Name = "datePresentedLabel";
            this.datePresentedLabel.Size = new System.Drawing.Size(126, 20);
            this.datePresentedLabel.TabIndex = 23;
            this.datePresentedLabel.Text = "Date Presented";
            // 
            // tentativeDateLabel
            // 
            this.tentativeDateLabel.AutoSize = true;
            this.tentativeDateLabel.Location = new System.Drawing.Point(335, 228);
            this.tentativeDateLabel.Name = "tentativeDateLabel";
            this.tentativeDateLabel.Size = new System.Drawing.Size(118, 20);
            this.tentativeDateLabel.TabIndex = 22;
            this.tentativeDateLabel.Text = "Tentative Date";
            // 
            // actionPlanLabel
            // 
            this.actionPlanLabel.AutoSize = true;
            this.actionPlanLabel.Location = new System.Drawing.Point(21, 100);
            this.actionPlanLabel.Name = "actionPlanLabel";
            this.actionPlanLabel.Size = new System.Drawing.Size(94, 20);
            this.actionPlanLabel.TabIndex = 21;
            this.actionPlanLabel.Text = "Action Plan";
            // 
            // rejectedByLabel
            // 
            this.rejectedByLabel.AutoSize = true;
            this.rejectedByLabel.Location = new System.Drawing.Point(335, 294);
            this.rejectedByLabel.Name = "rejectedByLabel";
            this.rejectedByLabel.Size = new System.Drawing.Size(100, 20);
            this.rejectedByLabel.TabIndex = 18;
            this.rejectedByLabel.Text = "Rejected By";
            // 
            // dateRejectedLabel
            // 
            this.dateRejectedLabel.AutoSize = true;
            this.dateRejectedLabel.Location = new System.Drawing.Point(335, 261);
            this.dateRejectedLabel.Name = "dateRejectedLabel";
            this.dateRejectedLabel.Size = new System.Drawing.Size(116, 20);
            this.dateRejectedLabel.TabIndex = 17;
            this.dateRejectedLabel.Text = "Date Rejected";
            // 
            // dateApprovedLabel
            // 
            this.dateApprovedLabel.AutoSize = true;
            this.dateApprovedLabel.Location = new System.Drawing.Point(335, 128);
            this.dateApprovedLabel.Name = "dateApprovedLabel";
            this.dateApprovedLabel.Size = new System.Drawing.Size(120, 20);
            this.dateApprovedLabel.TabIndex = 16;
            this.dateApprovedLabel.Text = "Date Approved";
            // 
            // dateImplimentedLabel
            // 
            this.dateImplimentedLabel.AutoSize = true;
            this.dateImplimentedLabel.Location = new System.Drawing.Point(335, 199);
            this.dateImplimentedLabel.Name = "dateImplimentedLabel";
            this.dateImplimentedLabel.Size = new System.Drawing.Size(140, 20);
            this.dateImplimentedLabel.TabIndex = 15;
            this.dateImplimentedLabel.Text = "Date Implimented";
            // 
            // rationaleLabel
            // 
            this.rationaleLabel.AutoSize = true;
            this.rationaleLabel.Location = new System.Drawing.Point(21, 302);
            this.rationaleLabel.Name = "rationaleLabel";
            this.rationaleLabel.Size = new System.Drawing.Size(79, 20);
            this.rationaleLabel.TabIndex = 13;
            this.rationaleLabel.Text = "Rationale";
            // 
            // unspscLabel
            // 
            this.unspscLabel.AutoSize = true;
            this.unspscLabel.Location = new System.Drawing.Point(335, 63);
            this.unspscLabel.Name = "unspscLabel";
            this.unspscLabel.Size = new System.Drawing.Size(83, 20);
            this.unspscLabel.TabIndex = 8;
            this.unspscLabel.Text = "UNSPSC ";
            // 
            // skusReducedLabel
            // 
            this.skusReducedLabel.AutoSize = true;
            this.skusReducedLabel.Location = new System.Drawing.Point(335, 97);
            this.skusReducedLabel.Name = "skusReducedLabel";
            this.skusReducedLabel.Size = new System.Drawing.Size(121, 20);
            this.skusReducedLabel.TabIndex = 7;
            this.skusReducedLabel.Text = "Sku\'s Reduced";
            // 
            // orginLabel
            // 
            this.orginLabel.AutoSize = true;
            this.orginLabel.Location = new System.Drawing.Point(21, 269);
            this.orginLabel.Name = "orginLabel";
            this.orginLabel.Size = new System.Drawing.Size(54, 20);
            this.orginLabel.TabIndex = 6;
            this.orginLabel.Text = "Origin";
            // 
            // sharpsStatusLabel
            // 
            this.sharpsStatusLabel.AutoSize = true;
            this.sharpsStatusLabel.Location = new System.Drawing.Point(21, 237);
            this.sharpsStatusLabel.Name = "sharpsStatusLabel";
            this.sharpsStatusLabel.Size = new System.Drawing.Size(115, 20);
            this.sharpsStatusLabel.TabIndex = 5;
            this.sharpsStatusLabel.Text = "Sharps Status";
            // 
            // savingsTypeLabel
            // 
            this.savingsTypeLabel.AutoSize = true;
            this.savingsTypeLabel.Location = new System.Drawing.Point(21, 201);
            this.savingsTypeLabel.Name = "savingsTypeLabel";
            this.savingsTypeLabel.Size = new System.Drawing.Size(109, 20);
            this.savingsTypeLabel.TabIndex = 4;
            this.savingsTypeLabel.Text = "Savings Type";
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.Location = new System.Drawing.Point(21, 167);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(58, 20);
            this.optionLabel.TabIndex = 3;
            this.optionLabel.Text = "Option";
            // 
            // manufactureLabel
            // 
            this.manufactureLabel.AutoSize = true;
            this.manufactureLabel.Location = new System.Drawing.Point(21, 133);
            this.manufactureLabel.Name = "manufactureLabel";
            this.manufactureLabel.Size = new System.Drawing.Size(102, 20);
            this.manufactureLabel.TabIndex = 2;
            this.manufactureLabel.Text = "Manufacture";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(21, 66);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(76, 20);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(21, 33);
            this.areaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(44, 20);
            this.areaLabel.TabIndex = 0;
            this.areaLabel.Text = "Area";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalSavingsPercentInput);
            this.summaryGroupBox.Controls.Add(this.totalSavingsPercentLabel);
            this.summaryGroupBox.Controls.Add(this.totalSavingsInput);
            this.summaryGroupBox.Controls.Add(this.totalSpendInput);
            this.summaryGroupBox.Controls.Add(this.label1);
            this.summaryGroupBox.Controls.Add(this.totalSpendLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(888, 8);
            this.summaryGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.summaryGroupBox.Size = new System.Drawing.Size(310, 158);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // totalSavingsPercentInput
            // 
            this.totalSavingsPercentInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSavingsPercentInput.Location = new System.Drawing.Point(175, 109);
            this.totalSavingsPercentInput.Margin = new System.Windows.Forms.Padding(4);
            this.totalSavingsPercentInput.Name = "totalSavingsPercentInput";
            this.totalSavingsPercentInput.ReadOnly = true;
            this.totalSavingsPercentInput.Size = new System.Drawing.Size(124, 27);
            this.totalSavingsPercentInput.TabIndex = 5;
            // 
            // totalSavingsPercentLabel
            // 
            this.totalSavingsPercentLabel.AutoSize = true;
            this.totalSavingsPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSavingsPercentLabel.Location = new System.Drawing.Point(16, 118);
            this.totalSavingsPercentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalSavingsPercentLabel.Name = "totalSavingsPercentLabel";
            this.totalSavingsPercentLabel.Size = new System.Drawing.Size(88, 20);
            this.totalSavingsPercentLabel.TabIndex = 4;
            this.totalSavingsPercentLabel.Text = "Savings %";
            // 
            // totalSavingsInput
            // 
            this.totalSavingsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSavingsInput.Location = new System.Drawing.Point(175, 68);
            this.totalSavingsInput.Margin = new System.Windows.Forms.Padding(4);
            this.totalSavingsInput.Name = "totalSavingsInput";
            this.totalSavingsInput.ReadOnly = true;
            this.totalSavingsInput.Size = new System.Drawing.Size(124, 27);
            this.totalSavingsInput.TabIndex = 3;
            // 
            // totalSpendInput
            // 
            this.totalSpendInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSpendInput.Location = new System.Drawing.Point(175, 26);
            this.totalSpendInput.Margin = new System.Windows.Forms.Padding(4);
            this.totalSpendInput.Name = "totalSpendInput";
            this.totalSpendInput.ReadOnly = true;
            this.totalSpendInput.Size = new System.Drawing.Size(124, 27);
            this.totalSpendInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Savings";
            // 
            // totalSpendLabel
            // 
            this.totalSpendLabel.AutoSize = true;
            this.totalSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSpendLabel.Location = new System.Drawing.Point(16, 35);
            this.totalSpendLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalSpendLabel.Name = "totalSpendLabel";
            this.totalSpendLabel.Size = new System.Drawing.Size(98, 20);
            this.totalSpendLabel.TabIndex = 0;
            this.totalSpendLabel.Text = "Total Spend";
            // 
            // contractGroupBox
            // 
            this.contractGroupBox.Controls.Add(this.contractActionInput);
            this.contractGroupBox.Controls.Add(this.contractDetailsDropDown);
            this.contractGroupBox.Controls.Add(this.contractDistributionDropDown);
            this.contractGroupBox.Controls.Add(this.contractManufactureInput);
            this.contractGroupBox.Controls.Add(this.contractIdInput);
            this.contractGroupBox.Controls.Add(this.contractTierInput);
            this.contractGroupBox.Controls.Add(this.contractEndDatePicker);
            this.contractGroupBox.Controls.Add(this.contractStartDatePicker);
            this.contractGroupBox.Controls.Add(this.contractDistributionLabel);
            this.contractGroupBox.Controls.Add(this.contractManufacture);
            this.contractGroupBox.Controls.Add(this.contractTierLabel);
            this.contractGroupBox.Controls.Add(this.contractIdLabel);
            this.contractGroupBox.Controls.Add(this.contractDetailsLabel);
            this.contractGroupBox.Controls.Add(this.contractEndDateLabel);
            this.contractGroupBox.Controls.Add(this.contractStartDateLabel);
            this.contractGroupBox.Controls.Add(this.contractActionLabel);
            this.contractGroupBox.Location = new System.Drawing.Point(347, 8);
            this.contractGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractGroupBox.Name = "contractGroupBox";
            this.contractGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.contractGroupBox.Size = new System.Drawing.Size(506, 213);
            this.contractGroupBox.TabIndex = 3;
            this.contractGroupBox.TabStop = false;
            this.contractGroupBox.Text = "Contract";
            // 
            // contractActionInput
            // 
            this.contractActionInput.Location = new System.Drawing.Point(367, 94);
            this.contractActionInput.Name = "contractActionInput";
            this.contractActionInput.Size = new System.Drawing.Size(132, 27);
            this.contractActionInput.TabIndex = 46;
            // 
            // contractDetailsDropDown
            // 
            this.contractDetailsDropDown.FormattingEnabled = true;
            this.contractDetailsDropDown.Items.AddRange(new object[] {
            "Custom",
            "GPO",
            "Local",
            "Vanderbilt Loc"});
            this.contractDetailsDropDown.Location = new System.Drawing.Point(126, 162);
            this.contractDetailsDropDown.Name = "contractDetailsDropDown";
            this.contractDetailsDropDown.Size = new System.Drawing.Size(133, 28);
            this.contractDetailsDropDown.TabIndex = 45;
            // 
            // contractDistributionDropDown
            // 
            this.contractDistributionDropDown.FormattingEnabled = true;
            this.contractDistributionDropDown.Items.AddRange(new object[] {
            "Cardinal",
            "Direct",
            "Henry Schein",
            "Mckesson Ltc",
            "Medline",
            "Other",
            "Supply Works"});
            this.contractDistributionDropDown.Location = new System.Drawing.Point(126, 95);
            this.contractDistributionDropDown.Name = "contractDistributionDropDown";
            this.contractDistributionDropDown.Size = new System.Drawing.Size(133, 28);
            this.contractDistributionDropDown.TabIndex = 42;
            // 
            // contractManufactureInput
            // 
            this.contractManufactureInput.Location = new System.Drawing.Point(126, 129);
            this.contractManufactureInput.Name = "contractManufactureInput";
            this.contractManufactureInput.Size = new System.Drawing.Size(133, 27);
            this.contractManufactureInput.TabIndex = 44;
            // 
            // contractIdInput
            // 
            this.contractIdInput.Location = new System.Drawing.Point(126, 29);
            this.contractIdInput.Name = "contractIdInput";
            this.contractIdInput.Size = new System.Drawing.Size(133, 27);
            this.contractIdInput.TabIndex = 43;
            // 
            // contractTierInput
            // 
            this.contractTierInput.Location = new System.Drawing.Point(367, 29);
            this.contractTierInput.Name = "contractTierInput";
            this.contractTierInput.Size = new System.Drawing.Size(132, 27);
            this.contractTierInput.TabIndex = 42;
            // 
            // contractEndDatePicker
            // 
            this.contractEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contractEndDatePicker.Location = new System.Drawing.Point(367, 61);
            this.contractEndDatePicker.Name = "contractEndDatePicker";
            this.contractEndDatePicker.Size = new System.Drawing.Size(132, 27);
            this.contractEndDatePicker.TabIndex = 24;
            // 
            // contractStartDatePicker
            // 
            this.contractStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contractStartDatePicker.Location = new System.Drawing.Point(126, 62);
            this.contractStartDatePicker.Name = "contractStartDatePicker";
            this.contractStartDatePicker.Size = new System.Drawing.Size(133, 27);
            this.contractStartDatePicker.TabIndex = 23;
            // 
            // contractDistributionLabel
            // 
            this.contractDistributionLabel.AutoSize = true;
            this.contractDistributionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractDistributionLabel.Location = new System.Drawing.Point(8, 103);
            this.contractDistributionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractDistributionLabel.Name = "contractDistributionLabel";
            this.contractDistributionLabel.Size = new System.Drawing.Size(95, 20);
            this.contractDistributionLabel.TabIndex = 7;
            this.contractDistributionLabel.Text = "Distribution";
            // 
            // contractManufacture
            // 
            this.contractManufacture.AutoSize = true;
            this.contractManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractManufacture.Location = new System.Drawing.Point(8, 138);
            this.contractManufacture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractManufacture.Name = "contractManufacture";
            this.contractManufacture.Size = new System.Drawing.Size(102, 20);
            this.contractManufacture.TabIndex = 6;
            this.contractManufacture.Text = "Manufacture";
            // 
            // contractTierLabel
            // 
            this.contractTierLabel.AutoSize = true;
            this.contractTierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractTierLabel.Location = new System.Drawing.Point(281, 36);
            this.contractTierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractTierLabel.Name = "contractTierLabel";
            this.contractTierLabel.Size = new System.Drawing.Size(38, 20);
            this.contractTierLabel.TabIndex = 5;
            this.contractTierLabel.Text = "Tier";
            // 
            // contractIdLabel
            // 
            this.contractIdLabel.AutoSize = true;
            this.contractIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractIdLabel.Location = new System.Drawing.Point(8, 37);
            this.contractIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractIdLabel.Name = "contractIdLabel";
            this.contractIdLabel.Size = new System.Drawing.Size(91, 20);
            this.contractIdLabel.TabIndex = 4;
            this.contractIdLabel.Text = "Contract Id";
            // 
            // contractDetailsLabel
            // 
            this.contractDetailsLabel.AutoSize = true;
            this.contractDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractDetailsLabel.Location = new System.Drawing.Point(8, 170);
            this.contractDetailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractDetailsLabel.Name = "contractDetailsLabel";
            this.contractDetailsLabel.Size = new System.Drawing.Size(62, 20);
            this.contractDetailsLabel.TabIndex = 3;
            this.contractDetailsLabel.Text = "Details";
            // 
            // contractEndDateLabel
            // 
            this.contractEndDateLabel.AutoSize = true;
            this.contractEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractEndDateLabel.Location = new System.Drawing.Point(281, 71);
            this.contractEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractEndDateLabel.Name = "contractEndDateLabel";
            this.contractEndDateLabel.Size = new System.Drawing.Size(79, 20);
            this.contractEndDateLabel.TabIndex = 2;
            this.contractEndDateLabel.Text = "End Date";
            // 
            // contractStartDateLabel
            // 
            this.contractStartDateLabel.AutoSize = true;
            this.contractStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractStartDateLabel.Location = new System.Drawing.Point(8, 71);
            this.contractStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractStartDateLabel.Name = "contractStartDateLabel";
            this.contractStartDateLabel.Size = new System.Drawing.Size(86, 20);
            this.contractStartDateLabel.TabIndex = 1;
            this.contractStartDateLabel.Text = "Start Date";
            // 
            // contractActionLabel
            // 
            this.contractActionLabel.AutoSize = true;
            this.contractActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractActionLabel.Location = new System.Drawing.Point(281, 101);
            this.contractActionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractActionLabel.Name = "contractActionLabel";
            this.contractActionLabel.Size = new System.Drawing.Size(56, 20);
            this.contractActionLabel.TabIndex = 0;
            this.contractActionLabel.Text = "Action";
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.analystDropDown);
            this.mainGroupBox.Controls.Add(this.initiativeIdLabel);
            this.mainGroupBox.Controls.Add(this.dateCreatedPicker);
            this.mainGroupBox.Controls.Add(this.initiativeStatusLabel);
            this.mainGroupBox.Controls.Add(this.statusDropDown);
            this.mainGroupBox.Controls.Add(this.dateCreatedLabel);
            this.mainGroupBox.Controls.Add(this.initiativeIdInput);
            this.mainGroupBox.Controls.Add(this.analystLabel);
            this.mainGroupBox.Location = new System.Drawing.Point(8, 8);
            this.mainGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.mainGroupBox.Size = new System.Drawing.Size(259, 176);
            this.mainGroupBox.TabIndex = 2;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Main";
            // 
            // analystDropDown
            // 
            this.analystDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analystDropDown.FormattingEnabled = true;
            this.analystDropDown.Items.AddRange(new object[] {
            "Adam Dale",
            "Chrissy Smith",
            "Erin O\'Brien",
            "Gene Roberts",
            "Janice Holt",
            "Rick Jarrett"});
            this.analystDropDown.Location = new System.Drawing.Point(118, 127);
            this.analystDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.analystDropDown.Name = "analystDropDown";
            this.analystDropDown.Size = new System.Drawing.Size(127, 28);
            this.analystDropDown.TabIndex = 7;
            // 
            // initiativeIdLabel
            // 
            this.initiativeIdLabel.AutoSize = true;
            this.initiativeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initiativeIdLabel.Location = new System.Drawing.Point(6, 29);
            this.initiativeIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initiativeIdLabel.Name = "initiativeIdLabel";
            this.initiativeIdLabel.Size = new System.Drawing.Size(88, 20);
            this.initiativeIdLabel.TabIndex = 0;
            this.initiativeIdLabel.Text = "Initiative Id";
            // 
            // dateCreatedPicker
            // 
            this.dateCreatedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCreatedPicker.Location = new System.Drawing.Point(118, 92);
            this.dateCreatedPicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateCreatedPicker.Name = "dateCreatedPicker";
            this.dateCreatedPicker.Size = new System.Drawing.Size(127, 27);
            this.dateCreatedPicker.TabIndex = 6;
            // 
            // initiativeStatusLabel
            // 
            this.initiativeStatusLabel.AutoSize = true;
            this.initiativeStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initiativeStatusLabel.Location = new System.Drawing.Point(8, 68);
            this.initiativeStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initiativeStatusLabel.Name = "initiativeStatusLabel";
            this.initiativeStatusLabel.Size = new System.Drawing.Size(57, 20);
            this.initiativeStatusLabel.TabIndex = 1;
            this.initiativeStatusLabel.Text = "Status";
            // 
            // statusDropDown
            // 
            this.statusDropDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.statusDropDown.FormattingEnabled = true;
            this.statusDropDown.Items.AddRange(new object[] {
            "Approved",
            "Discontinued",
            "Implemented",
            "Pending ",
            "Preliminary",
            "Presented",
            "Rejected",
            "Tracking Complete",
            "Trial"});
            this.statusDropDown.Location = new System.Drawing.Point(118, 57);
            this.statusDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.statusDropDown.Name = "statusDropDown";
            this.statusDropDown.Size = new System.Drawing.Size(127, 28);
            this.statusDropDown.TabIndex = 5;
            // 
            // dateCreatedLabel
            // 
            this.dateCreatedLabel.AutoSize = true;
            this.dateCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedLabel.Location = new System.Drawing.Point(6, 99);
            this.dateCreatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateCreatedLabel.Name = "dateCreatedLabel";
            this.dateCreatedLabel.Size = new System.Drawing.Size(109, 20);
            this.dateCreatedLabel.TabIndex = 2;
            this.dateCreatedLabel.Text = "Date Created";
            // 
            // initiativeIdInput
            // 
            this.initiativeIdInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.initiativeIdInput.Enabled = false;
            this.initiativeIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initiativeIdInput.Location = new System.Drawing.Point(118, 22);
            this.initiativeIdInput.Margin = new System.Windows.Forms.Padding(4);
            this.initiativeIdInput.MaxLength = 15;
            this.initiativeIdInput.Name = "initiativeIdInput";
            this.initiativeIdInput.ShortcutsEnabled = false;
            this.initiativeIdInput.Size = new System.Drawing.Size(81, 27);
            this.initiativeIdInput.TabIndex = 4;
            this.initiativeIdInput.WordWrap = false;
            // 
            // analystLabel
            // 
            this.analystLabel.AutoSize = true;
            this.analystLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analystLabel.Location = new System.Drawing.Point(8, 135);
            this.analystLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.analystLabel.Name = "analystLabel";
            this.analystLabel.Size = new System.Drawing.Size(64, 20);
            this.analystLabel.TabIndex = 3;
            this.analystLabel.Text = "Analyst";
            // 
            // trackingGroupBox
            // 
            this.trackingGroupBox.Controls.Add(this.trackingLastDatePicker);
            this.trackingGroupBox.Controls.Add(this.trackingStartDatePicker);
            this.trackingGroupBox.Controls.Add(this.startTrackingDateLabel);
            this.trackingGroupBox.Controls.Add(this.lastTrackingDate);
            this.trackingGroupBox.Location = new System.Drawing.Point(888, 209);
            this.trackingGroupBox.Name = "trackingGroupBox";
            this.trackingGroupBox.Size = new System.Drawing.Size(286, 92);
            this.trackingGroupBox.TabIndex = 6;
            this.trackingGroupBox.TabStop = false;
            this.trackingGroupBox.Text = "Tracking";
            // 
            // trackingLastDatePicker
            // 
            this.trackingLastDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.trackingLastDatePicker.Location = new System.Drawing.Point(98, 55);
            this.trackingLastDatePicker.Name = "trackingLastDatePicker";
            this.trackingLastDatePicker.Size = new System.Drawing.Size(129, 27);
            this.trackingLastDatePicker.TabIndex = 22;
            // 
            // trackingStartDatePicker
            // 
            this.trackingStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.trackingStartDatePicker.Location = new System.Drawing.Point(98, 26);
            this.trackingStartDatePicker.Name = "trackingStartDatePicker";
            this.trackingStartDatePicker.Size = new System.Drawing.Size(129, 27);
            this.trackingStartDatePicker.TabIndex = 21;
            // 
            // startTrackingDateLabel
            // 
            this.startTrackingDateLabel.AutoSize = true;
            this.startTrackingDateLabel.Location = new System.Drawing.Point(6, 31);
            this.startTrackingDateLabel.Name = "startTrackingDateLabel";
            this.startTrackingDateLabel.Size = new System.Drawing.Size(86, 20);
            this.startTrackingDateLabel.TabIndex = 19;
            this.startTrackingDateLabel.Text = "Start Date";
            // 
            // lastTrackingDate
            // 
            this.lastTrackingDate.AutoSize = true;
            this.lastTrackingDate.Location = new System.Drawing.Point(6, 60);
            this.lastTrackingDate.Name = "lastTrackingDate";
            this.lastTrackingDate.Size = new System.Drawing.Size(83, 20);
            this.lastTrackingDate.TabIndex = 20;
            this.lastTrackingDate.Text = "Last Date";
            // 
            // dataSourceGroupBox
            // 
            this.dataSourceGroupBox.Controls.Add(this.sourceInput);
            this.dataSourceGroupBox.Controls.Add(this.imUpdatedDatePicker);
            this.dataSourceGroupBox.Controls.Add(this.dataDatePulledPicker);
            this.dataSourceGroupBox.Controls.Add(this.dataEndDatePicker);
            this.dataSourceGroupBox.Controls.Add(this.dataStartDatePicker);
            this.dataSourceGroupBox.Controls.Add(this.dataSourceLabel);
            this.dataSourceGroupBox.Controls.Add(this.dataStartDateLabel);
            this.dataSourceGroupBox.Controls.Add(this.dataEndDateLabel);
            this.dataSourceGroupBox.Controls.Add(this.dateDataPulledLabel);
            this.dataSourceGroupBox.Controls.Add(this.imUpdatedDateLabel);
            this.dataSourceGroupBox.Location = new System.Drawing.Point(888, 357);
            this.dataSourceGroupBox.Name = "dataSourceGroupBox";
            this.dataSourceGroupBox.Size = new System.Drawing.Size(286, 206);
            this.dataSourceGroupBox.TabIndex = 24;
            this.dataSourceGroupBox.TabStop = false;
            this.dataSourceGroupBox.Text = "Data Source";
            // 
            // sourceInput
            // 
            this.sourceInput.Location = new System.Drawing.Point(147, 38);
            this.sourceInput.Name = "sourceInput";
            this.sourceInput.Size = new System.Drawing.Size(129, 27);
            this.sourceInput.TabIndex = 42;
            // 
            // imUpdatedDatePicker
            // 
            this.imUpdatedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.imUpdatedDatePicker.Location = new System.Drawing.Point(147, 170);
            this.imUpdatedDatePicker.Name = "imUpdatedDatePicker";
            this.imUpdatedDatePicker.Size = new System.Drawing.Size(129, 27);
            this.imUpdatedDatePicker.TabIndex = 26;
            // 
            // dataDatePulledPicker
            // 
            this.dataDatePulledPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDatePulledPicker.Location = new System.Drawing.Point(147, 136);
            this.dataDatePulledPicker.Name = "dataDatePulledPicker";
            this.dataDatePulledPicker.Size = new System.Drawing.Size(129, 27);
            this.dataDatePulledPicker.TabIndex = 25;
            // 
            // dataEndDatePicker
            // 
            this.dataEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataEndDatePicker.Location = new System.Drawing.Point(147, 104);
            this.dataEndDatePicker.Name = "dataEndDatePicker";
            this.dataEndDatePicker.Size = new System.Drawing.Size(129, 27);
            this.dataEndDatePicker.TabIndex = 24;
            // 
            // dataStartDatePicker
            // 
            this.dataStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataStartDatePicker.Location = new System.Drawing.Point(147, 71);
            this.dataStartDatePicker.Name = "dataStartDatePicker";
            this.dataStartDatePicker.Size = new System.Drawing.Size(129, 27);
            this.dataStartDatePicker.TabIndex = 23;
            // 
            // dataSourceLabel
            // 
            this.dataSourceLabel.AutoSize = true;
            this.dataSourceLabel.Location = new System.Drawing.Point(6, 45);
            this.dataSourceLabel.Name = "dataSourceLabel";
            this.dataSourceLabel.Size = new System.Drawing.Size(62, 20);
            this.dataSourceLabel.TabIndex = 9;
            this.dataSourceLabel.Text = "Source";
            // 
            // dataStartDateLabel
            // 
            this.dataStartDateLabel.AutoSize = true;
            this.dataStartDateLabel.Location = new System.Drawing.Point(6, 83);
            this.dataStartDateLabel.Name = "dataStartDateLabel";
            this.dataStartDateLabel.Size = new System.Drawing.Size(86, 20);
            this.dataStartDateLabel.TabIndex = 10;
            this.dataStartDateLabel.Text = "Start Date";
            // 
            // dataEndDateLabel
            // 
            this.dataEndDateLabel.AutoSize = true;
            this.dataEndDateLabel.Location = new System.Drawing.Point(6, 111);
            this.dataEndDateLabel.Name = "dataEndDateLabel";
            this.dataEndDateLabel.Size = new System.Drawing.Size(79, 20);
            this.dataEndDateLabel.TabIndex = 11;
            this.dataEndDateLabel.Text = "End Date";
            // 
            // dateDataPulledLabel
            // 
            this.dateDataPulledLabel.AutoSize = true;
            this.dateDataPulledLabel.Location = new System.Drawing.Point(6, 143);
            this.dateDataPulledLabel.Name = "dateDataPulledLabel";
            this.dateDataPulledLabel.Size = new System.Drawing.Size(96, 20);
            this.dateDataPulledLabel.TabIndex = 12;
            this.dateDataPulledLabel.Text = "Date Pulled";
            // 
            // imUpdatedDateLabel
            // 
            this.imUpdatedDateLabel.AutoSize = true;
            this.imUpdatedDateLabel.Location = new System.Drawing.Point(6, 177);
            this.imUpdatedDateLabel.Name = "imUpdatedDateLabel";
            this.imUpdatedDateLabel.Size = new System.Drawing.Size(135, 20);
            this.imUpdatedDateLabel.TabIndex = 14;
            this.imUpdatedDateLabel.Text = "IM Updated Date";
            // 
            // productsTabPage
            // 
            this.productsTabPage.Controls.Add(this.productsGridView);
            this.productsTabPage.Location = new System.Drawing.Point(4, 29);
            this.productsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.productsTabPage.Name = "productsTabPage";
            this.productsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.productsTabPage.Size = new System.Drawing.Size(1245, 680);
            this.productsTabPage.TabIndex = 1;
            this.productsTabPage.Text = "Products";
            this.productsTabPage.UseVisualStyleBackColor = true;
            // 
            // productsGridView
            // 
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productManufacture,
            this.productManufactureId,
            this.productDescription,
            this.productUM,
            this.productPackaging,
            this.productEachPrice,
            this.productPrice});
            this.productsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsGridView.Location = new System.Drawing.Point(4, 4);
            this.productsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.RowTemplate.Height = 24;
            this.productsGridView.Size = new System.Drawing.Size(1237, 672);
            this.productsGridView.TabIndex = 0;
            // 
            // productId
            // 
            this.productId.HeaderText = "PMM";
            this.productId.Name = "productId";
            // 
            // productManufacture
            // 
            this.productManufacture.HeaderText = "MFG";
            this.productManufacture.Name = "productManufacture";
            // 
            // productManufactureId
            // 
            this.productManufactureId.HeaderText = "MFG #";
            this.productManufactureId.Name = "productManufactureId";
            // 
            // productDescription
            // 
            this.productDescription.HeaderText = "Description";
            this.productDescription.Name = "productDescription";
            // 
            // productUM
            // 
            this.productUM.HeaderText = "UM";
            this.productUM.Name = "productUM";
            // 
            // productPackaging
            // 
            this.productPackaging.HeaderText = "PKG";
            this.productPackaging.Name = "productPackaging";
            // 
            // productEachPrice
            // 
            this.productEachPrice.HeaderText = "Price (EA)";
            this.productEachPrice.Name = "productEachPrice";
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            // 
            // proposalTabPage
            // 
            this.proposalTabPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.proposalTabPage.Controls.Add(this.proposedGridView);
            this.proposalTabPage.Location = new System.Drawing.Point(4, 29);
            this.proposalTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.proposalTabPage.Name = "proposalTabPage";
            this.proposalTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.proposalTabPage.Size = new System.Drawing.Size(1245, 680);
            this.proposalTabPage.TabIndex = 3;
            this.proposalTabPage.Text = "Proposal";
            // 
            // proposedGridView
            // 
            this.proposedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proposedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proposedPmm,
            this.proposedManufacture,
            this.proposedManufactureId,
            this.proposedDescription,
            this.proposedUnitOfMeasure,
            this.proposedPackaging,
            this.proposedEachPrice,
            this.proposedPrice});
            this.proposedGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proposedGridView.Location = new System.Drawing.Point(4, 4);
            this.proposedGridView.Margin = new System.Windows.Forms.Padding(4);
            this.proposedGridView.Name = "proposedGridView";
            this.proposedGridView.RowTemplate.Height = 24;
            this.proposedGridView.Size = new System.Drawing.Size(1237, 672);
            this.proposedGridView.TabIndex = 0;
            // 
            // proposedPmm
            // 
            this.proposedPmm.HeaderText = "PMM";
            this.proposedPmm.Name = "proposedPmm";
            // 
            // proposedManufacture
            // 
            this.proposedManufacture.HeaderText = "MFG";
            this.proposedManufacture.Name = "proposedManufacture";
            // 
            // proposedManufactureId
            // 
            this.proposedManufactureId.HeaderText = "MFG #";
            this.proposedManufactureId.Name = "proposedManufactureId";
            // 
            // proposedDescription
            // 
            this.proposedDescription.HeaderText = "Description";
            this.proposedDescription.Name = "proposedDescription";
            // 
            // proposedUnitOfMeasure
            // 
            this.proposedUnitOfMeasure.HeaderText = "UM";
            this.proposedUnitOfMeasure.Name = "proposedUnitOfMeasure";
            // 
            // proposedPackaging
            // 
            this.proposedPackaging.HeaderText = "PKG";
            this.proposedPackaging.Name = "proposedPackaging";
            // 
            // proposedEachPrice
            // 
            this.proposedEachPrice.HeaderText = "Price (EA)";
            this.proposedEachPrice.Name = "proposedEachPrice";
            // 
            // proposedPrice
            // 
            this.proposedPrice.HeaderText = "Price";
            this.proposedPrice.Name = "proposedPrice";
            // 
            // usageTabPage
            // 
            this.usageTabPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.usageTabPage.Controls.Add(this.usageSplitContainer);
            this.usageTabPage.Location = new System.Drawing.Point(4, 29);
            this.usageTabPage.Name = "usageTabPage";
            this.usageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usageTabPage.Size = new System.Drawing.Size(1245, 680);
            this.usageTabPage.TabIndex = 5;
            this.usageTabPage.Text = "Usage";
            // 
            // usageSplitContainer
            // 
            this.usageSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usageSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.usageSplitContainer.Name = "usageSplitContainer";
            // 
            // usageSplitContainer.Panel1
            // 
            this.usageSplitContainer.Panel1.Controls.Add(this.usageGridView);
            // 
            // usageSplitContainer.Panel2
            // 
            this.usageSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.usageSplitContainer.Panel2.Controls.Add(this.usageTotalUsageInput);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageHckhcmhInput);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageHvmcInput);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageLphInput);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageOtherInput);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageWmaInput);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageMvInput);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageTckhInput);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageBrmcInput);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageTotalUsage);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageWmaLabel);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageOtherLabel);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageTckhLabel);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageMvLabel);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageLphLabel);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageHvmcLabel);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageHckHcmhLabel);
            this.usageSplitContainer.Panel2.Controls.Add(this.usageBrmcLabel);
            this.usageSplitContainer.Size = new System.Drawing.Size(1239, 674);
            this.usageSplitContainer.SplitterDistance = 1022;
            this.usageSplitContainer.TabIndex = 0;
            // 
            // usageGridView
            // 
            this.usageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usageProductId,
            this.usageManufactureName,
            this.usageManufactureId,
            this.usageDesc,
            this.usageTotalQty});
            this.usageGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usageGridView.Location = new System.Drawing.Point(0, 0);
            this.usageGridView.Name = "usageGridView";
            this.usageGridView.RowTemplate.Height = 24;
            this.usageGridView.Size = new System.Drawing.Size(1022, 674);
            this.usageGridView.TabIndex = 0;
            this.usageGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usageGridView_CellClick);
            // 
            // usageProductId
            // 
            this.usageProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.usageProductId.HeaderText = "Product Id";
            this.usageProductId.Name = "usageProductId";
            this.usageProductId.Width = 105;
            // 
            // usageManufactureName
            // 
            this.usageManufactureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.usageManufactureName.HeaderText = "Manufacture";
            this.usageManufactureName.Name = "usageManufactureName";
            this.usageManufactureName.Width = 131;
            // 
            // usageManufactureId
            // 
            this.usageManufactureId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.usageManufactureId.HeaderText = "Manufacture Id";
            this.usageManufactureId.Name = "usageManufactureId";
            this.usageManufactureId.Width = 136;
            // 
            // usageDesc
            // 
            this.usageDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usageDesc.HeaderText = "Description";
            this.usageDesc.Name = "usageDesc";
            // 
            // usageTotalQty
            // 
            this.usageTotalQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.usageTotalQty.HeaderText = "Usage";
            this.usageTotalQty.Name = "usageTotalQty";
            this.usageTotalQty.Width = 86;
            // 
            // usageTotalUsageInput
            // 
            this.usageTotalUsageInput.Location = new System.Drawing.Point(149, 308);
            this.usageTotalUsageInput.Name = "usageTotalUsageInput";
            this.usageTotalUsageInput.Size = new System.Drawing.Size(49, 27);
            this.usageTotalUsageInput.TabIndex = 18;
            // 
            // usageHckhcmhInput
            // 
            this.usageHckhcmhInput.Location = new System.Drawing.Point(149, 74);
            this.usageHckhcmhInput.Name = "usageHckhcmhInput";
            this.usageHckhcmhInput.Size = new System.Drawing.Size(49, 27);
            this.usageHckhcmhInput.TabIndex = 17;
            // 
            // usageHvmcInput
            // 
            this.usageHvmcInput.Location = new System.Drawing.Point(149, 107);
            this.usageHvmcInput.Name = "usageHvmcInput";
            this.usageHvmcInput.Size = new System.Drawing.Size(49, 27);
            this.usageHvmcInput.TabIndex = 16;
            // 
            // usageLphInput
            // 
            this.usageLphInput.Location = new System.Drawing.Point(149, 140);
            this.usageLphInput.Name = "usageLphInput";
            this.usageLphInput.Size = new System.Drawing.Size(49, 27);
            this.usageLphInput.TabIndex = 15;
            // 
            // usageOtherInput
            // 
            this.usageOtherInput.Location = new System.Drawing.Point(149, 275);
            this.usageOtherInput.Name = "usageOtherInput";
            this.usageOtherInput.Size = new System.Drawing.Size(49, 27);
            this.usageOtherInput.TabIndex = 14;
            // 
            // usageWmaInput
            // 
            this.usageWmaInput.Location = new System.Drawing.Point(149, 242);
            this.usageWmaInput.Name = "usageWmaInput";
            this.usageWmaInput.Size = new System.Drawing.Size(49, 27);
            this.usageWmaInput.TabIndex = 13;
            // 
            // usageMvInput
            // 
            this.usageMvInput.Location = new System.Drawing.Point(149, 176);
            this.usageMvInput.Name = "usageMvInput";
            this.usageMvInput.Size = new System.Drawing.Size(49, 27);
            this.usageMvInput.TabIndex = 12;
            // 
            // usageTckhInput
            // 
            this.usageTckhInput.Location = new System.Drawing.Point(149, 209);
            this.usageTckhInput.Name = "usageTckhInput";
            this.usageTckhInput.Size = new System.Drawing.Size(49, 27);
            this.usageTckhInput.TabIndex = 11;
            // 
            // usageBrmcInput
            // 
            this.usageBrmcInput.Location = new System.Drawing.Point(149, 41);
            this.usageBrmcInput.Name = "usageBrmcInput";
            this.usageBrmcInput.Size = new System.Drawing.Size(49, 27);
            this.usageBrmcInput.TabIndex = 10;
            // 
            // usageTotalUsage
            // 
            this.usageTotalUsage.AutoSize = true;
            this.usageTotalUsage.Location = new System.Drawing.Point(25, 315);
            this.usageTotalUsage.Name = "usageTotalUsage";
            this.usageTotalUsage.Size = new System.Drawing.Size(99, 20);
            this.usageTotalUsage.TabIndex = 8;
            this.usageTotalUsage.Text = "Total Usage";
            // 
            // usageWmaLabel
            // 
            this.usageWmaLabel.AutoSize = true;
            this.usageWmaLabel.Location = new System.Drawing.Point(25, 249);
            this.usageWmaLabel.Name = "usageWmaLabel";
            this.usageWmaLabel.Size = new System.Drawing.Size(50, 20);
            this.usageWmaLabel.TabIndex = 7;
            this.usageWmaLabel.Text = "WMA";
            // 
            // usageOtherLabel
            // 
            this.usageOtherLabel.AutoSize = true;
            this.usageOtherLabel.Location = new System.Drawing.Point(25, 282);
            this.usageOtherLabel.Name = "usageOtherLabel";
            this.usageOtherLabel.Size = new System.Drawing.Size(68, 20);
            this.usageOtherLabel.TabIndex = 6;
            this.usageOtherLabel.Text = "OTHER";
            // 
            // usageTckhLabel
            // 
            this.usageTckhLabel.AutoSize = true;
            this.usageTckhLabel.Location = new System.Drawing.Point(25, 216);
            this.usageTckhLabel.Name = "usageTckhLabel";
            this.usageTckhLabel.Size = new System.Drawing.Size(55, 20);
            this.usageTckhLabel.TabIndex = 5;
            this.usageTckhLabel.Text = "TCKH";
            // 
            // usageMvLabel
            // 
            this.usageMvLabel.AutoSize = true;
            this.usageMvLabel.Location = new System.Drawing.Point(25, 183);
            this.usageMvLabel.Name = "usageMvLabel";
            this.usageMvLabel.Size = new System.Drawing.Size(72, 20);
            this.usageMvLabel.TabIndex = 4;
            this.usageMvLabel.Text = "MVRMC";
            // 
            // usageLphLabel
            // 
            this.usageLphLabel.AutoSize = true;
            this.usageLphLabel.Location = new System.Drawing.Point(25, 147);
            this.usageLphLabel.Name = "usageLphLabel";
            this.usageLphLabel.Size = new System.Drawing.Size(43, 20);
            this.usageLphLabel.TabIndex = 3;
            this.usageLphLabel.Text = "LPH";
            // 
            // usageHvmcLabel
            // 
            this.usageHvmcLabel.AutoSize = true;
            this.usageHvmcLabel.Location = new System.Drawing.Point(25, 114);
            this.usageHvmcLabel.Name = "usageHvmcLabel";
            this.usageHvmcLabel.Size = new System.Drawing.Size(59, 20);
            this.usageHvmcLabel.TabIndex = 2;
            this.usageHvmcLabel.Text = "HVMC";
            // 
            // usageHckHcmhLabel
            // 
            this.usageHckHcmhLabel.AutoSize = true;
            this.usageHckHcmhLabel.Location = new System.Drawing.Point(25, 81);
            this.usageHckHcmhLabel.Name = "usageHckHcmhLabel";
            this.usageHckHcmhLabel.Size = new System.Drawing.Size(102, 20);
            this.usageHckHcmhLabel.TabIndex = 1;
            this.usageHckHcmhLabel.Text = "HCK/HCMH";
            // 
            // usageBrmcLabel
            // 
            this.usageBrmcLabel.AutoSize = true;
            this.usageBrmcLabel.Location = new System.Drawing.Point(25, 48);
            this.usageBrmcLabel.Name = "usageBrmcLabel";
            this.usageBrmcLabel.Size = new System.Drawing.Size(59, 20);
            this.usageBrmcLabel.TabIndex = 0;
            this.usageBrmcLabel.Text = "BRMC";
            // 
            // trackingTabPage
            // 
            this.trackingTabPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackingTabPage.Controls.Add(this.trackingGridView);
            this.trackingTabPage.Location = new System.Drawing.Point(4, 29);
            this.trackingTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.trackingTabPage.Name = "trackingTabPage";
            this.trackingTabPage.Size = new System.Drawing.Size(1245, 680);
            this.trackingTabPage.TabIndex = 2;
            this.trackingTabPage.Text = "Tracking";
            // 
            // trackingGridView
            // 
            this.trackingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trackingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trackingMfgId,
            this.trackingBrmc,
            this.trackingHckHcmh,
            this.trackingHvmc,
            this.trackingLP,
            this.trackingMV,
            this.trackingTh,
            this.trackingOther,
            this.trackingWma});
            this.trackingGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackingGridView.Location = new System.Drawing.Point(0, 0);
            this.trackingGridView.Name = "trackingGridView";
            this.trackingGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.trackingGridView.RowTemplate.Height = 24;
            this.trackingGridView.Size = new System.Drawing.Size(1245, 680);
            this.trackingGridView.TabIndex = 0;
            // 
            // trackingMfgId
            // 
            this.trackingMfgId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.trackingMfgId.HeaderText = "Manufacture Id";
            this.trackingMfgId.Name = "trackingMfgId";
            this.trackingMfgId.Width = 136;
            // 
            // trackingBrmc
            // 
            this.trackingBrmc.HeaderText = "BRMC";
            this.trackingBrmc.Name = "trackingBrmc";
            // 
            // trackingHckHcmh
            // 
            this.trackingHckHcmh.HeaderText = "HCK/HCMH";
            this.trackingHckHcmh.Name = "trackingHckHcmh";
            // 
            // trackingHvmc
            // 
            this.trackingHvmc.HeaderText = "HVMC";
            this.trackingHvmc.Name = "trackingHvmc";
            // 
            // trackingLP
            // 
            this.trackingLP.HeaderText = "LP";
            this.trackingLP.Name = "trackingLP";
            // 
            // trackingMV
            // 
            this.trackingMV.HeaderText = "MV";
            this.trackingMV.Name = "trackingMV";
            // 
            // trackingTh
            // 
            this.trackingTh.HeaderText = "TH";
            this.trackingTh.Name = "trackingTh";
            // 
            // trackingOther
            // 
            this.trackingOther.HeaderText = "OTHER";
            this.trackingOther.Name = "trackingOther";
            // 
            // trackingWma
            // 
            this.trackingWma.HeaderText = "WMA";
            this.trackingWma.Name = "trackingWma";
            // 
            // broadjumpTabPage
            // 
            this.broadjumpTabPage.Controls.Add(this.broadJumpGridView);
            this.broadjumpTabPage.Location = new System.Drawing.Point(4, 29);
            this.broadjumpTabPage.Name = "broadjumpTabPage";
            this.broadjumpTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.broadjumpTabPage.Size = new System.Drawing.Size(1245, 680);
            this.broadjumpTabPage.TabIndex = 7;
            this.broadjumpTabPage.Text = "BroadJump";
            this.broadjumpTabPage.UseVisualStyleBackColor = true;
            // 
            // broadJumpGridView
            // 
            this.broadJumpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.broadJumpGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bjProductId,
            this.bjEachPrice,
            this.bjCurrentEachPrice,
            this.bjTotalUsage,
            this.bjTotalSavings});
            this.broadJumpGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.broadJumpGridView.Location = new System.Drawing.Point(3, 3);
            this.broadJumpGridView.Name = "broadJumpGridView";
            this.broadJumpGridView.RowTemplate.Height = 24;
            this.broadJumpGridView.Size = new System.Drawing.Size(1239, 674);
            this.broadJumpGridView.TabIndex = 0;
            // 
            // bjProductId
            // 
            this.bjProductId.HeaderText = "Product Id";
            this.bjProductId.Name = "bjProductId";
            // 
            // bjEachPrice
            // 
            this.bjEachPrice.HeaderText = "Price (EA)";
            this.bjEachPrice.Name = "bjEachPrice";
            // 
            // bjCurrentEachPrice
            // 
            this.bjCurrentEachPrice.HeaderText = "Current Price (EA)";
            this.bjCurrentEachPrice.Name = "bjCurrentEachPrice";
            // 
            // bjTotalUsage
            // 
            this.bjTotalUsage.HeaderText = "Total Usage (EA)";
            this.bjTotalUsage.Name = "bjTotalUsage";
            // 
            // bjTotalSavings
            // 
            this.bjTotalSavings.HeaderText = "Total Savings";
            this.bjTotalSavings.Name = "bjTotalSavings";
            // 
            // summaryTabPage
            // 
            this.summaryTabPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.summaryTabPage.Controls.Add(this.summaryGridView);
            this.summaryTabPage.Location = new System.Drawing.Point(4, 29);
            this.summaryTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.summaryTabPage.Name = "summaryTabPage";
            this.summaryTabPage.Size = new System.Drawing.Size(1245, 680);
            this.summaryTabPage.TabIndex = 4;
            this.summaryTabPage.Text = "Summary";
            // 
            // summaryGridView
            // 
            this.summaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summaryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.summaryProductId,
            this.summarySavingsAmt,
            this.summaryDelta,
            this.summaryTotalUsage,
            this.summaryTotalSavings,
            this.summaryRealizedSavings});
            this.summaryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryGridView.Location = new System.Drawing.Point(0, 0);
            this.summaryGridView.Name = "summaryGridView";
            this.summaryGridView.RowTemplate.Height = 24;
            this.summaryGridView.Size = new System.Drawing.Size(1245, 680);
            this.summaryGridView.TabIndex = 0;
            // 
            // summaryProductId
            // 
            this.summaryProductId.HeaderText = "Product Id";
            this.summaryProductId.Name = "summaryProductId";
            // 
            // summarySavingsAmt
            // 
            this.summarySavingsAmt.HeaderText = "Savings Amount";
            this.summarySavingsAmt.Name = "summarySavingsAmt";
            // 
            // summaryDelta
            // 
            this.summaryDelta.HeaderText = "Delta";
            this.summaryDelta.Name = "summaryDelta";
            // 
            // summaryTotalUsage
            // 
            this.summaryTotalUsage.HeaderText = "Total Usage";
            this.summaryTotalUsage.Name = "summaryTotalUsage";
            // 
            // summaryTotalSavings
            // 
            this.summaryTotalSavings.HeaderText = "Total Savings";
            this.summaryTotalSavings.Name = "summaryTotalSavings";
            // 
            // summaryRealizedSavings
            // 
            this.summaryRealizedSavings.HeaderText = "Realized Savings";
            this.summaryRealizedSavings.Name = "summaryRealizedSavings";
            // 
            // notesTabPage
            // 
            this.notesTabPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.notesTabPage.Controls.Add(this.noteGridView);
            this.notesTabPage.ForeColor = System.Drawing.SystemColors.Control;
            this.notesTabPage.Location = new System.Drawing.Point(4, 29);
            this.notesTabPage.Name = "notesTabPage";
            this.notesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.notesTabPage.Size = new System.Drawing.Size(1245, 680);
            this.notesTabPage.TabIndex = 6;
            this.notesTabPage.Text = "Notes";
            // 
            // noteGridView
            // 
            this.noteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noteGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteDate,
            this.notePerson,
            this.noteDesc});
            this.noteGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteGridView.Location = new System.Drawing.Point(3, 3);
            this.noteGridView.Name = "noteGridView";
            this.noteGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.noteGridView.RowTemplate.Height = 24;
            this.noteGridView.Size = new System.Drawing.Size(1239, 674);
            this.noteGridView.TabIndex = 0;
            // 
            // noteDate
            // 
            this.noteDate.HeaderText = "Date";
            this.noteDate.Name = "noteDate";
            // 
            // notePerson
            // 
            this.notePerson.HeaderText = "Person";
            this.notePerson.Name = "notePerson";
            // 
            // noteDesc
            // 
            this.noteDesc.HeaderText = "Description";
            this.noteDesc.Name = "noteDesc";
            this.noteDesc.Width = 964;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator6,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator8,
            this.helpToolStripButton,
            this.toolStripSeparator7,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(1253, 56);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(64, 53);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(64, 53);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(64, 53);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(64, 53);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 56);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(64, 53);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(64, 53);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(64, 53);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 56);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(64, 53);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 56);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 53);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 53);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // CostManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 695);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CostManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cost Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.contractGroupBox.ResumeLayout(false);
            this.contractGroupBox.PerformLayout();
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.trackingGroupBox.ResumeLayout(false);
            this.trackingGroupBox.PerformLayout();
            this.dataSourceGroupBox.ResumeLayout(false);
            this.dataSourceGroupBox.PerformLayout();
            this.productsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.proposalTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proposedGridView)).EndInit();
            this.usageTabPage.ResumeLayout(false);
            this.usageSplitContainer.Panel1.ResumeLayout(false);
            this.usageSplitContainer.Panel2.ResumeLayout(false);
            this.usageSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usageSplitContainer)).EndInit();
            this.usageSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usageGridView)).EndInit();
            this.trackingTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackingGridView)).EndInit();
            this.broadjumpTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.broadJumpGridView)).EndInit();
            this.summaryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.summaryGridView)).EndInit();
            this.notesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noteGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.TabPage productsTabPage;
        private System.Windows.Forms.TabPage proposalTabPage;
        private System.Windows.Forms.TabPage trackingTabPage;
        private System.Windows.Forms.TabPage summaryTabPage;
        private System.Windows.Forms.Label initiativeIdLabel;
        private System.Windows.Forms.Label initiativeStatusLabel;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.GroupBox contractGroupBox;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.ComboBox analystDropDown;
        private System.Windows.Forms.DateTimePicker dateCreatedPicker;
        private System.Windows.Forms.ComboBox statusDropDown;
        private System.Windows.Forms.Label dateCreatedLabel;
        private System.Windows.Forms.TextBox initiativeIdInput;
        private System.Windows.Forms.Label analystLabel;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.Label contractTierLabel;
        private System.Windows.Forms.Label contractIdLabel;
        private System.Windows.Forms.Label contractDetailsLabel;
        private System.Windows.Forms.Label contractEndDateLabel;
        private System.Windows.Forms.Label contractStartDateLabel;
        private System.Windows.Forms.Label contractActionLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn proposedPmm;
        private System.Windows.Forms.DataGridViewTextBoxColumn proposedManufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn proposedManufactureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn proposedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn proposedUnitOfMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn proposedPackaging;
        private System.Windows.Forms.DataGridViewTextBoxColumn proposedEachPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn proposedPrice;
        private System.Windows.Forms.GroupBox dataSourceGroupBox;
        private System.Windows.Forms.Label dataSourceLabel;
        private System.Windows.Forms.Label dataStartDateLabel;
        private System.Windows.Forms.Label dataEndDateLabel;
        private System.Windows.Forms.Label dateDataPulledLabel;
        private System.Windows.Forms.Label imUpdatedDateLabel;
        private System.Windows.Forms.GroupBox trackingGroupBox;
        private System.Windows.Forms.Label startTrackingDateLabel;
        private System.Windows.Forms.Label lastTrackingDate;
        private System.Windows.Forms.Label datePresentedLabel;
        private System.Windows.Forms.Label tentativeDateLabel;
        private System.Windows.Forms.Label actionPlanLabel;
        private System.Windows.Forms.Label rejectedByLabel;
        private System.Windows.Forms.Label dateRejectedLabel;
        private System.Windows.Forms.Label dateApprovedLabel;
        private System.Windows.Forms.Label dateImplimentedLabel;
        private System.Windows.Forms.Label rationaleLabel;
        private System.Windows.Forms.Label unspscLabel;
        private System.Windows.Forms.Label skusReducedLabel;
        private System.Windows.Forms.Label orginLabel;
        private System.Windows.Forms.Label sharpsStatusLabel;
        private System.Windows.Forms.Label savingsTypeLabel;
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.Label manufactureLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.TextBox totalSavingsPercentInput;
        private System.Windows.Forms.Label totalSavingsPercentLabel;
        private System.Windows.Forms.TextBox totalSavingsInput;
        private System.Windows.Forms.TextBox totalSpendInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalSpendLabel;
        private System.Windows.Forms.Label contractDistributionLabel;
        private System.Windows.Forms.Label contractManufacture;
        private System.Windows.Forms.DateTimePicker dateApprovedPicker;
        private System.Windows.Forms.DateTimePicker datePresentedPicker;
        private System.Windows.Forms.DateTimePicker dateImplimentedPicker;
        private System.Windows.Forms.DateTimePicker tentativeDatePicker;
        private System.Windows.Forms.DateTimePicker dateRejectedPicker;
        private System.Windows.Forms.DateTimePicker trackingLastDatePicker;
        private System.Windows.Forms.DateTimePicker trackingStartDatePicker;
        private System.Windows.Forms.TextBox skusReducedInput;
        private System.Windows.Forms.ComboBox savingsTypeDropDown;
        private System.Windows.Forms.ComboBox optionDropDown;
        private System.Windows.Forms.TextBox manufactureInput;
        private System.Windows.Forms.TextBox categoryInput;
        private System.Windows.Forms.ComboBox actionPlanDropDown;
        private System.Windows.Forms.ComboBox sharpsStatusDropDown;
        private System.Windows.Forms.ComboBox areaDropDown;
        private System.Windows.Forms.TextBox unspscInput;
        private System.Windows.Forms.TextBox rationaleInput;
        private System.Windows.Forms.ComboBox originDropDown;
        private System.Windows.Forms.TextBox sourceInput;
        private System.Windows.Forms.DateTimePicker imUpdatedDatePicker;
        private System.Windows.Forms.DateTimePicker dataDatePulledPicker;
        private System.Windows.Forms.DateTimePicker dataEndDatePicker;
        private System.Windows.Forms.DateTimePicker dataStartDatePicker;
        private System.Windows.Forms.TextBox contractActionInput;
        private System.Windows.Forms.ComboBox contractDetailsDropDown;
        private System.Windows.Forms.ComboBox contractDistributionDropDown;
        private System.Windows.Forms.TextBox contractManufactureInput;
        private System.Windows.Forms.TextBox contractIdInput;
        private System.Windows.Forms.TextBox contractTierInput;
        private System.Windows.Forms.DateTimePicker contractEndDatePicker;
        private System.Windows.Forms.DateTimePicker contractStartDatePicker;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ComboBox rejectedByDropDown;
        private System.Windows.Forms.TabPage usageTabPage;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sIDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem broadJumpDataToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelWorkbookToolStripMenuItem;
        public System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn summarySavingsAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryTotalUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryTotalSavings;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryRealizedSavings;
        private System.Windows.Forms.TabPage notesTabPage;
        private System.Windows.Forms.TabPage broadjumpTabPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn bjProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bjEachPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bjCurrentEachPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bjTotalUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn bjTotalSavings;
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.DataGridView proposedGridView;
        public System.Windows.Forms.DataGridView trackingGridView;
        public System.Windows.Forms.DataGridView noteGridView;
        public System.Windows.Forms.DataGridView broadJumpGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingMfgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingBrmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingHckHcmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingHvmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingMV;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingTh;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingWma;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn notePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDesc;
        private System.Windows.Forms.SplitContainer usageSplitContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn usageProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn usageManufactureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn usageManufactureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn usageDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn usageTotalQty;
        private System.Windows.Forms.TextBox usageTotalUsageInput;
        private System.Windows.Forms.TextBox usageHckhcmhInput;
        private System.Windows.Forms.TextBox usageHvmcInput;
        private System.Windows.Forms.TextBox usageLphInput;
        private System.Windows.Forms.TextBox usageOtherInput;
        private System.Windows.Forms.TextBox usageWmaInput;
        private System.Windows.Forms.TextBox usageMvInput;
        private System.Windows.Forms.TextBox usageTckhInput;
        private System.Windows.Forms.TextBox usageBrmcInput;
        private System.Windows.Forms.Label usageTotalUsage;
        private System.Windows.Forms.Label usageWmaLabel;
        private System.Windows.Forms.Label usageOtherLabel;
        private System.Windows.Forms.Label usageTckhLabel;
        private System.Windows.Forms.Label usageMvLabel;
        private System.Windows.Forms.Label usageLphLabel;
        private System.Windows.Forms.Label usageHvmcLabel;
        private System.Windows.Forms.Label usageHckHcmhLabel;
        private System.Windows.Forms.Label usageBrmcLabel;
        public System.Windows.Forms.DataGridView usageGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufactureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPackaging;
        private System.Windows.Forms.DataGridViewTextBoxColumn productEachPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private List<Product> products;
        public System.Windows.Forms.DataGridView summaryGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

