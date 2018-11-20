using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_Management_Solution
{
    public partial class CostManagementForm : Form
    {
        public List<Product> Products { get => products; set => products = value; }

        //Main Group
        public String InitiativeIdInput { get => initiativeIdInput.Text; set => initiativeIdInput.Text = value; }
        public String StatusDropDown { get => statusDropDown.Text; set => statusDropDown.Text = value; }
        public String DateCreatedPicker { get => dateCreatedPicker.Text; set => dateCreatedPicker.Text = value; }
        public String AnalystDropDown { get => analystDropDown.Text; set => analystDropDown.Text = value; }
        //Contract Group
        public String ContractIdInput { get => contractIdInput.Text; set => contractIdInput.Text = value; }
        public String ContractStartDatePicker { get => contractStartDatePicker.Text; set => contractStartDatePicker.Text = value; }
        public String ContractEndDatePicker { get => contractEndDatePicker.Text; set => contractEndDatePicker.Text = value; }
        public String ContractTierInput { get => contractTierInput.Text; set => contractTierInput.Text = value; }
        public String ContractDistributionDropDown { get => contractDistributionDropDown.Text; set => contractDistributionDropDown.Text = value; }
        public String ContractDetailsDropDown { get => contractDetailsDropDown.Text; set => contractDetailsDropDown.Text = value; }
        public String ContractActionInput { get => contractActionInput.Text; set => contractActionInput.Text = value; }
        //General Group
        public String AreaDropDown { get => areaDropDown.Text; set => areaDropDown.Text = value; }
        public String CategoryInput { get => categoryInput.Text; set => categoryInput.Text = value; }
        public String ActionPlanDropDown { get => actionPlanDropDown.Text; set => actionPlanDropDown.Text = value; }
        public String ManufactureInput { get => manufactureInput.Text; set => manufactureInput.Text = value; }
        public String OptionDropDown { get => optionDropDown.Text; set => optionDropDown.Text = value; }
        public String SavingsTypeDropDown { get => savingsTypeDropDown.Text; set => savingsTypeDropDown.Text = value; }
        public String SharpsStatusDropDown { get => sharpsStatusDropDown.Text; set => sharpsStatusDropDown.Text = value; }
        public String OriginDropDown { get => originDropDown.Text; set => originDropDown.Text = value; }
        public String RationaleInput { get => rationaleInput.Text; set => rationaleInput.Text = value; }
        public String UnspscInput { get => unspscInput.Text; set => unspscInput.Text = value; }
        public String SkusReducedInput { get => skusReducedInput.Text; set => skusReducedInput.Text = value; }
        public String DateApprovedPicker { get => dateApprovedPicker.Text; set => dateApprovedPicker.Text = value; }
        public String DatePresentedPicker { get => datePresentedPicker.Text; set => datePresentedPicker.Text = value; }
        public String DateImplimentedPicker { get => dateImplimentedPicker.Text; set => dateImplimentedPicker.Text = value; }
        public String TentativeDatePicker { get => tentativeDatePicker.Text; set => tentativeDatePicker.Text = value; }
        public String DateRejectedPicker { get => dateRejectedPicker.Text; set => dateRejectedPicker.Text = value; }
        public String RejectedByDropDown { get => rejectedByDropDown.Text; set => rejectedByDropDown.Text = value; }
        //General Group - Tracking
        public String TrackingStartDatePicker { get => trackingStartDatePicker.Text; set => trackingStartDatePicker.Text = value; }
        public String TrackingLastDatePicker { get => trackingLastDatePicker.Text; set => trackingLastDatePicker.Text = value; }
        //General Group - Data
        public String SourceInput { get => sourceInput.Text; set => sourceInput.Text = value; }
        public String DataStartDatePicker { get => dataStartDatePicker.Text; set => dataStartDatePicker.Text = value; }
        public String DataEndDatePicker { get => dataEndDatePicker.Text; set => dataEndDatePicker.Text = value; }
        public String DataDatePulledPicker { get => dataDatePulledPicker.Text; set => dataDatePulledPicker.Text = value; }
        public String ImUpdatedDatePicker { get => imUpdatedDatePicker.Text; set => imUpdatedDatePicker.Text = value; }
        //Summary Group
        public String TotalSavingsInput { get => totalSavingsInput.Text; set => totalSavingsInput.Text = value; }
        public String TotalSpendInput { get => totalSpendInput.Text; set => totalSpendInput.Text = value; }
        public String TotalSavingsPercent { get => totalSavingsPercentInput.Text; set => totalSavingsPercentInput.Text = value; }



public CostManagementForm()
        {
            InitializeComponent();
            
        initiativeIdInput.Text = Initiative.getNextId().ToString();
        }
        public void clearAll()
        {
            //Main Group
            initiativeIdInput.Clear();
            statusDropDown.ResetText();
            dateCreatedPicker.ResetText();
            analystDropDown.ResetText();
            //Contract Group
            contractIdInput.ResetText();
            contractStartDatePicker.ResetText();
            contractEndDatePicker.ResetText();
            contractTierInput.ResetText();
            contractDistributionDropDown.ResetText();
            contractDetailsDropDown.ResetText();
            contractActionInput.ResetText();
            //General
            areaDropDown.ResetText();
            categoryInput.Clear();
            actionPlanDropDown.ResetText();
            manufactureInput.Clear();
            optionDropDown.ResetText();
            savingsTypeDropDown.ResetText();
            sharpsStatusDropDown.ResetText();
            originDropDown.ResetText();
            rationaleInput.Clear();
            unspscInput.Clear();
            skusReducedInput.Clear();
            dateApprovedPicker.ResetText();
            datePresentedPicker.ResetText();
            dateImplimentedPicker.ResetText();
            tentativeDatePicker.ResetText();
            dateRejectedPicker.ResetText();
            rejectedByDropDown.ResetText();
            //General Group - Tracking
            trackingStartDatePicker.ResetText();
            trackingLastDatePicker.ResetText();
            //General Group - Data Source
            sourceInput.Clear();
            dataStartDatePicker.ResetText();
            dataEndDatePicker.ResetText();
            dataDatePulledPicker.ResetText();
            imUpdatedDatePicker.ResetText();
            //Summary Group
            totalSpendInput.Clear();
            totalSavingsInput.Clear();
            totalSavingsPercentInput.Clear();

            //Clear data grid views
            productsGridView.Rows.Clear();
            productsGridView.Refresh();
            proposedGridView.Rows.Clear();
            proposedGridView.Refresh();
            usageGridView.Rows.Clear();
            usageGridView.Refresh();
            trackingGridView.Rows.Clear();
            trackingGridView.Refresh();
            broadJumpGridView.Rows.Clear();
            broadJumpGridView.Refresh();
            summaryGridView.Rows.Clear();
            summaryGridView.Refresh();
            noteGridView.Rows.Clear();
            noteGridView.Refresh();

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search searchWindow = new Search();
            searchWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initiative currentInitiative = new Initiative();
            Note currentNote = new Note();
            currentNote.loadNotes();
            currentNote.insertNotes();
            currentInitiative.loadInitiative();
         
            currentInitiative.SaveInitiative();
        }
        //Import data from SI actions
        private void sIDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String fileName = OpenFileDialog.FileName;
                
                List<Product> productList = DataEngine.ProcessDataFile(fileName);
                this.Products = productList;
                DataGridView productTable = this.productsGridView;
               
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                Image image = Image.FromFile(Constants.Images.STATUS_OK_SM);
                img.Image = image;
                img.HeaderText = "Status";
                img.Name = "img";
                productTable.Columns.Add(img);
                productTable.Columns["img"].DisplayIndex = 0;

                foreach (Product product in productList)
                {

                    string[] productRowData = new string[] {

                    product.ProductId,
                    product.ManufactureName,
                    product.ManufactureId,
                    product.Description,
                    product.ContractId,
                    product.UnitOfMeasure,
                    product.Packaging,
                    product.EachPrice.ToString() };
                    productTable.Rows.Add(productRowData);

                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String fileName = OpenFileDialog.FileName;

                List<Product> productList = DataEngine.ProcessDataFile(fileName);
                products = productList;
                DataGridView productTable = this.productsGridView;

                DataGridViewImageColumn img = new DataGridViewImageColumn();
                Image image = Image.FromFile(Constants.Images.STATUS_OK_SM);
                img.Image = image;
                img.HeaderText = "Status";
                img.Name = "img";
                productTable.Columns.Add(img);
                productTable.Columns["img"].DisplayIndex = 0;

                Console.WriteLine("Number of records " + productList.Count);
                foreach (Product product in productList)
                {

                    string[] productRowData = new string[] {

                    product.ProductId,
                    product.ManufactureName,
                    product.ManufactureId,
                    product.Description,
                    product.UnitOfMeasure,
                    product.Packaging,
                    product.EachPrice.ToString("C"),
                    product.Price.ToString("C")
                    };
                    productTable.Rows.Add(productRowData);


                }
            }
        }
    private void usageGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get the product id
            if (usageGridView.Rows[e.RowIndex].Cells["usageManufactureId"].Value != null) {
                String mfgId = usageGridView.Rows[e.RowIndex].Cells["usageManufactureId"].Value.ToString();
                Product selectedProduct = this.Products.Find(product => product.ManufactureId == mfgId);
                usageBrmcInput.Text = selectedProduct.Brmc.ToString();
                usageHckhcmhInput.Text = selectedProduct.Hckhcmh.ToString();
                usageHvmcInput.Text = selectedProduct.Hckhcmh.ToString();
                usageLphInput.Text = selectedProduct.Lph.ToString();
                usageMvInput.Text = selectedProduct.Mvh.ToString();
                usageTckhInput.Text = selectedProduct.Tch.ToString();
                usageOtherInput.Text = selectedProduct.Other.ToString();
                usageWmaInput.Text = selectedProduct.Wma.ToString();
                usageTotalUsageInput.Text = selectedProduct.TotalUsage.ToString();
                    
                Console.WriteLine(productId);
            }
           
        }

        private void mainTabPage_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String fileName = OpenFileDialog.FileName;

                List<Product> productList = DataEngine.ProcessProposalFile(fileName);
                products = productList;
                DataGridView productTable = this.productsGridView;

                DataGridViewImageColumn img = new DataGridViewImageColumn();
                Image image = Image.FromFile(Constants.Images.STATUS_OK_SM);
                img.Image = image;
                img.HeaderText = "Status";
                img.Name = "img";
                productTable.Columns.Add(img);
                productTable.Columns["img"].DisplayIndex = 0;

                Console.WriteLine("Number of records " + productList.Count);
                foreach (Product product in productList)
                {

                    string[] productRowData = new string[] {

                    product.ProductId,
                    product.ManufactureName,
                    product.ManufactureId,
                    product.Description,
                    product.UnitOfMeasure,
                    product.Packaging,
                    product.EachPrice.ToString("C"),
                    product.Price.ToString("C")
                    };
                    productTable.Rows.Add(productRowData);


                }
            }
        }
    }
}
