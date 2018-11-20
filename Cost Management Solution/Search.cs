using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_Management_Solution
{
    public partial class Search : Form
    {

        public Boolean multiResults = false;
        public CostManagementForm mainForm = (CostManagementForm)Application.OpenForms[0];
        public Search()
        {
            InitializeComponent();
            searchInitiativeIdInput.Select();
          

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Get search criteria
            Double searchId = !String.IsNullOrWhiteSpace(searchInitiativeIdInput.Text) ? Double.Parse(searchInitiativeIdInput.Text) : 0;
            String searchAnalyst = searchAnalystDropDown.Text;
            String searchStatus = searchStatusDropDown.Text;
            String searchStartDate = searchStartDatePicker.Value.ToShortDateString();
            String searchEndDate = searchEndDatePicker.Value.ToShortDateString();
            

            if (searchTabControl.SelectedTab == searchTabControl.TabPages["searchAdvanceTab"])
            {
                String advProductId = searchAdvProductIdInput.Text;
                String advMfgId = searchAdvMfgIdInput.Text;
                if (!String.IsNullOrWhiteSpace(advProductId))
                {
                    preformAdvancedSearch("PMM_ID", advProductId);
                }
                else if (!String.IsNullOrWhiteSpace(advMfgId))
                {
                    preformAdvancedSearch("MRF_ID", advMfgId);
                }
                

            }
            else
            {


                //Determine what kind of search to do
                if (!String.IsNullOrWhiteSpace(searchStatus))
                {
                    preformMultiSearch("INIT_STATUS", searchStatus);
                }
                else if (!String.IsNullOrWhiteSpace(searchAnalyst))
                {
                    preformMultiSearch("ANALYST", searchAnalyst);
                }
                else if (searchByDateFlag.Checked)
                {
                    preformDateSearch("INTRODUCED_DATE", searchStartDate, searchEndDate);
                }
                else
                {

                    loadInitiative(searchId);

                }

            }
        }
        private void loadInitiative(Double id)
        {
            //Clear any values that may have previously been loaded
            mainForm.clearAll();
            Initiative initObj = new Initiative();
            initObj.GetInitiative(id);


            //Main Group
            if (initObj.Id > 0)
            {
                mainForm.InitiativeIdInput = initObj.Id.ToString();
                mainForm.AreaDropDown = initObj.Area;
                mainForm.CategoryInput = initObj.Category;
                mainForm.ManufactureInput = initObj.ManufactureName;
                mainForm.StatusDropDown = initObj.Status;
                mainForm.AnalystDropDown = initObj.Analyst;
                mainForm.TotalSpendInput = initObj.Spend.ToString();
                mainForm.ContractDetailsDropDown = initObj.SavingType;
                mainForm.OriginDropDown = initObj.Orgin;
                mainForm.SkusReducedInput = initObj.Skus;
                mainForm.UnspscInput = initObj.UnspCode;
                mainForm.OptionDropDown = initObj.Option;
                mainForm.ActionPlanDropDown = initObj.ActionPlan;
                mainForm.TrackingStartDatePicker = initObj.TrackingStartDate.ToShortDateString();
                mainForm.TrackingLastDatePicker = initObj.TrackingEndDate.ToShortDateString();
                //mainForm.SetSavingsAmount(initObj.;
                mainForm.DataDatePulledPicker = initObj.DataPulledDate.ToShortDateString();
                mainForm.SourceInput = initObj.Source;
                mainForm.DateCreatedPicker = initObj.CreatedDate.ToShortDateString();
                mainForm.RationaleInput = initObj.Rationale;
                mainForm.RejectedByDropDown = initObj.RejectedBy;
            }
            Product itemObj = new Product();
            List<Product> list = itemObj.getProductList(id);
            mainForm.Products = list;
            DataGridView productTable = mainForm.productsGridView;
            DataGridView usageTable = mainForm.usageGridView;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Image.FromFile(Constants.Images.STATUS_OK_SM);
            img.Image = image;
            img.HeaderText = "Status";
            img.Name = "img";
            productTable.Columns.Add(img);
            productTable.Columns["img"].DisplayIndex = 0;

            foreach (Product product in list)
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
                string[] usageRowData = new string[]
                {
                    product.ProductId,
                    product.ManufactureName,
                    product.ManufactureId,
                    product.Description,
                    product.getTotalUsage().ToString()
                        };
                usageTable.Rows.Add(usageRowData);
            }
            Note noteObj = new Note();
            List<Note> noteList = noteObj.getNotes(id);
            foreach (Note note in noteList)
            {
                DataGridView notesTable = mainForm.noteGridView;
                string[] rowData = new string[] { note.NoteDate, note.Person, note.Description };
                notesTable.Rows.Add(rowData);
            }
            Product proposedItemObj = new Product();
            List<Product> proposedItemList = proposedItemObj.getProposedProductList(id);
            DataGridView proposedItemsTable = mainForm.proposedGridView;
            //DataGridViewImageColumn proposedImg = new DataGridViewImageColumn();
            //Image proposedImage = Image.FromFile(Images.OFFLINE_SM);
            //proposedImg.Image = proposedImage;
            //proposedImg.HeaderText = "Status";
            //proposedImg.Name = "proposedImg";
            //proposedItemsTable.Columns.Add(proposedImg);
            //proposedItemsTable.Columns["proposedImg"].DisplayIndex = 0;
            foreach (Product proposedItem in proposedItemList)
            {

                string[] rowData = new string[] { proposedItem.ProductId,
                                                    proposedItem.DistributionId,
                                                    proposedItem.DistributionName,
                                                    proposedItem.ManufactureId,
                                                    proposedItem.ManufactureName,
                                                    proposedItem.Description,
                                                    proposedItem.UnitOfMeasure,
                                                    proposedItem.Packaging,
                                                    proposedItem.PackagingString,
                                                    proposedItem.UnitPrice.ToString(),
                                                    proposedItem.EachPrice.ToString() };
                proposedItemsTable.Rows.Add(rowData);
            }
            //List<Tracking> trackingList = Tracking.getTracking(searchId);
            //foreach (Tracking trackingLine in trackingList)
            //{
            //    DataGridView trackingTable = mainForm.trackingGridView;
            //    string[] rowData = new string[] {
            //        trackingLine.Quarter,
            //        trackingLine.QrtStartDate,
            //        trackingLine.QrtEndDate,
            //        trackingLine.Pmm,
            //        trackingLine.UnitOfMeasure,
            //        trackingLine.Packaging,
            //        trackingLine.EachPice,
            //        "",
            //        "",
            //        trackingLine.EachPice,
            //        trackingLine.ProposedEap,
            //        trackingLine.EapVariance,
            //        trackingLine.SvgsPerEach,
            //        trackingLine.TotalUsage,
            //        trackingLine.TotalSvgs

            //    };
            //    trackingTable.Rows.Add(rowData);
            //}
            List<Summary> summaryList = Summary.getSummaryList(id);
            DataGridView summaryListTable = mainForm.summaryGridView;
            foreach (Summary summaryItem in summaryList)
            {

                string[] rowData = new string[] { summaryItem.ProductId,
                                                    summaryItem.ProjectedSvgsAmt.ToString(),
                                                    summaryItem.VarianceProjectSvgs.ToString(),
                                                    summaryItem.TotalUsage.ToString(),
                                                    summaryItem.TotalSvgsAmt.ToString(),
                                                    summaryItem.PercentRealizedSvgs.ToString() };
                summaryListTable.Rows.Add(rowData);
            }
            List<BroadJump> broadJumpList = BroadJump.getBroadJumpList(id);
            DataGridView broadJumpListTable = mainForm.broadJumpGridView;
            foreach (BroadJump broadJumpItem in broadJumpList)
            {

                string[] rowData = new string[] { broadJumpItem.ProductId,
                                                    broadJumpItem.BroadjumpSvgsPerEach.ToString(),
                                                    broadJumpItem.RfiVsBroadjumpVar.ToString(),
                                                    broadJumpItem.TotalUsage.ToString(),
                                                    broadJumpItem.TotalSvgs.ToString()};
                summaryListTable.Rows.Add(rowData);
            }
            mainForm.Show();
            this.Close();
        }
        public void preformAdvancedSearch(String field, String criteria)
        {
            OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
            OleDbCommand cmd = new OleDbCommand("SELECT B.INITIATIVE_ID, B.INIT_STATUS,B.ANALYST, B.INTRODUCED_DATE FROM INITIATIVE_PRODUCTS A RIGHT JOIN INITIATIVE B ON  A.INITIATIVE_ID=B.INITIATIVE_ID WHERE A."+field+" = ? ;", con);
            cmd.Parameters.AddWithValue("?", criteria);
            con.Open();
            OleDbDataReader Reader = cmd.ExecuteReader();

            //Console.WriteLine("here " + Reader.RecordsAffected.ToString());
            if (Reader.HasRows)
            {

                multiResults = true;

                while (Reader.Read())
                {
                    string[] resultsRowData = new string[] {

                    ToStringNullSafe(Reader["initiative_Id"]),
                    ToStringNullSafe(Reader["init_status"]),
                   ToStringNullSafe(Reader["analyst"]),
                   Reader["introduced_Date"].ToString()};
                    searchResultsGridView.Rows.Add(resultsRowData);

                }

            }
        }
        public void preformMultiSearch(String field, String criteria)
        {
            OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM INITIATIVE WHERE "+field+" LIKE ? ", con);
            cmd.Parameters.AddWithValue("?", "%" + criteria + "%");
            con.Open();
            OleDbDataReader Reader = cmd.ExecuteReader();
           
            //Console.WriteLine("here " + Reader.RecordsAffected.ToString());
            if (Reader.HasRows)
            {

                multiResults = true;
                
                while (Reader.Read())
                {
                    string[] resultsRowData = new string[] {

                    ToStringNullSafe(Reader["initiative_Id"]),
                    ToStringNullSafe(Reader["init_status"]),
                    ToStringNullSafe(Reader["analyst"]),
                    Reader["introduced_Date"].ToString()};
                    searchResultsGridView.Rows.Add(resultsRowData);

                }
                
            }


        }
        public void preformDateSearch(String field, String first, String second)
        {
            OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM INITIATIVE WHERE " + field + " BETWEEN ? AND ? ", con);
            cmd.Parameters.AddWithValue("?", first);
            cmd.Parameters.AddWithValue("?", second);
            con.Open();
            OleDbDataReader Reader = cmd.ExecuteReader();

            //Console.WriteLine("here " + Reader.RecordsAffected.ToString());
            if (Reader.HasRows)
            {

                multiResults = true;

                while (Reader.Read())
                {
                    string[] resultsRowData = new string[] {

                    ToStringNullSafe(Reader["initiative_Id"]),
                    ToStringNullSafe(Reader["init_status"]),
                   ToStringNullSafe(Reader["analyst"]),
                   Reader["introduced_Date"].ToString()};
                    searchResultsGridView.Rows.Add(resultsRowData);

                }

            }


        }
        
        private static string ToStringNullSafe(object value)
        {
            return (value ?? string.Empty).ToString();
        }

        private void searchResultsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String searchId = searchResultsGridView.Rows[e.RowIndex].Cells[0].Value.ToString(); 
            loadInitiative(Double.Parse(searchId));
        }
    }
}
