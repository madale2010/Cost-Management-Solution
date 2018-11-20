using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_Management_Solution
{
class Initiative
    {
        //Main Group
        private Double id;
        private String status;
        private DateTime createdDate;
        private String analyst;
        //Contract Group
        private String contractId;
        private String contractStartDate;
        private String contractEndDate;
        private String contractTier;
        private String contractAction;
        private String contractDistribution;
        private String contractDetails;
        //General Group 
        private String area;
        private String category;
        private String actionPlan;
        private String manufactureName;
        private String option;
        private String savingType;
        private String sharpsStatus;
        private String orgin;
        private String rationale;
        private String unspCode;
        private String skus;
        private DateTime approveDate;
        private DateTime presentedDate;
        private DateTime implementedDate;
        private DateTime tentativeDate;
        private DateTime rejectedDate;
        private String rejectedBy;
        //General Group - Tracking
        private DateTime trackingStartDate;
        private DateTime trackingEndDate;
        //General Group - Data Source
        private String source;
        private DateTime sourceStartDate;
        private DateTime sourceEndDate;
        private DateTime dataPulledDate;
        //Summary Group
        private Double spend;
        private Double savingsAmount;
        private Double savingsPercent;
        
        //Objects that go with initiative
        //Products
        private List<Product> products;
        private List<Product> proposedProducts;
        //Notes
        private List<Note> notes;
        //Tracking
        private List<Tracking> trackingList;
        //Broadjump
        private List<BroadJump> broadJumpItems;
        private List<BroadJumpSavings> bjSavingsItems;
        //Summary
        private List<Summary> summaryItems;


        

        public double Id { get => id; set => id = value; }
        public double Spend { get => spend; set => spend = value; }
        public double SavingsAmount { get => savingsAmount; set => savingsAmount = value; }
        public string Area { get => area; set => area = value; }
        public string Category { get => category; set => category = value; }
        public string ManufactureName { get => manufactureName; set => manufactureName = value; }
        public string Status { get => status; set => status = value; }
        public string Analyst { get => analyst; set => analyst = value; }
        public string Source { get => source; set => source = value; }
        public string SavingType { get => savingType; set => savingType = value; }
        public string Orgin { get => orgin; set => orgin = value; }
        public string Skus { get => skus; set => skus = value; }
        public string UnspCode { get => unspCode; set => unspCode = value; }
        public string Option { get => option; set => option = value; }
        public string ActionPlan { get => actionPlan; set => actionPlan = value; }

        public string Rationale { get => rationale; set => rationale = value; }
        public string RejectedBy { get => rejectedBy; set => rejectedBy = value; }

        public DateTime PresentedDate { get => presentedDate; set => presentedDate = value; }
        public DateTime RejectedDate { get => rejectedDate; set => rejectedDate = value; }
        public DateTime ApproveDate { get => approveDate; set => approveDate = value; }
        public DateTime ImplementedDate { get => implementedDate; set => implementedDate = value; }
        public DateTime TrackingStartDate { get => trackingStartDate; set => trackingStartDate = value; }
        public DateTime TrackingEndDate { get => trackingEndDate; set => trackingEndDate = value; }

        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public string ContractId { get => contractId; set => contractId = value; }
        public string ContractStartDate { get => contractStartDate; set => contractStartDate = value; }
        public string ContractEndDate { get => contractEndDate; set => contractEndDate = value; }
        public string ContractTier { get => contractTier; set => contractTier = value; }
        public string ContractAction { get => contractAction; set => contractAction = value; }
        public string ContractDistribution { get => contractDistribution; set => contractDistribution = value; }
        public string ContractDetails { get => contractDetails; set => contractDetails = value; }
        public double SavingsPercent { get => savingsPercent; set => savingsPercent = value; }
        public string SharpsStatus { get => sharpsStatus; set => sharpsStatus = value; }
        public DateTime TentativeDate { get => tentativeDate; set => tentativeDate = value; }
        public DateTime SourceStartDate { get => sourceStartDate; set => sourceStartDate = value; }
        public DateTime SourceEndDate { get => sourceEndDate; set => sourceEndDate = value; }
        public DateTime DataPulledDate { get => dataPulledDate; set => dataPulledDate = value; }
        public List<Product> Products { get => products; set => products = value; }
        public List<Product> ProposedProducts { get => proposedProducts; set => proposedProducts = value; }
        internal List<Note> Notes { get => notes; set => notes = value; }
        internal List<Tracking> TrackingList { get => trackingList; set => trackingList = value; }
        internal List<BroadJump> BroadJumpItems { get => broadJumpItems; set => broadJumpItems = value; }
        internal List<BroadJumpSavings> BjSavingsItems { get => bjSavingsItems; set => bjSavingsItems = value; }
        internal List<Summary> SummaryItems { get => summaryItems; set => summaryItems = value; }

        public void loadInitiative()
        {
            CostManagementForm mainForm = (CostManagementForm)Application.OpenForms[0];
            this.Id = Double.Parse(mainForm.InitiativeIdInput);
            this.Area = mainForm.AreaDropDown;
            this.Category = mainForm.CategoryInput;
            this.ManufactureName = mainForm.ManufactureInput;
            this.Status = mainForm.StatusDropDown;
            this.Analyst = mainForm.AnalystDropDown;
            this.Spend = Double.Parse("0");
            this.SavingType = mainForm.ContractDetailsDropDown;
            this.Orgin = mainForm.OriginDropDown;
            this.Skus = mainForm.SkusReducedInput;
            this.UnspCode = mainForm.UnspscInput;
            this.Option = mainForm.OptionDropDown;
            this.ActionPlan = mainForm.ActionPlanDropDown;
            this.TrackingStartDate = DateTime.Parse(mainForm.TrackingStartDatePicker);
            this.TrackingEndDate = DateTime.Parse(mainForm.TrackingLastDatePicker);
            this.DataPulledDate = DateTime.Parse(mainForm.DataDatePulledPicker);
            this.Source = mainForm.SourceInput;
            this.CreatedDate = DateTime.Parse(mainForm.DateCreatedPicker);
            this.Rationale = mainForm.RationaleInput;
            this.RejectedBy = mainForm.RejectedByDropDown;
        }
        public static Double getNextId()
        {
            OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
            OleDbCommand maxCommand = new OleDbCommand("SELECT max(INITIATIVE_ID) from INITIATIVE", con);
            con.Open();
            return (Double)maxCommand.ExecuteScalar()+1;
        }
        public void SaveInitiative()
        {

            OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
            OleDbCommand cmd = new OleDbCommand(Constants.DB.Insert.INITIATIVE, con);

            cmd.Parameters.AddWithValue("@initiativeId",this.id);
            cmd.Parameters.AddWithValue("@initStatus", this.status);
            cmd.Parameters.AddWithValue("@initArea", this.area);
            cmd.Parameters.AddWithValue("@initCategory", this.category);
            cmd.Parameters.AddWithValue("@mfgName", this.manufactureName);
            cmd.Parameters.AddWithValue("@analyst", this.analyst);
            cmd.Parameters.AddWithValue("@spend", this.spend);
            cmd.Parameters.AddWithValue("@savingsApproved", this.savingsAmount);
            cmd.Parameters.AddWithValue("@savingType", this.savingType);
            cmd.Parameters.AddWithValue("@orgin", this.orgin);
            cmd.Parameters.AddWithValue("@skus", this.skus);
            cmd.Parameters.AddWithValue("@unspscCode", this.unspCode);
            cmd.Parameters.AddWithValue("@selectedOption", this.option);
            cmd.Parameters.AddWithValue("@actionPlan", this.actionPlan);
            cmd.Parameters.AddWithValue("@planDate", this.createdDate);
            cmd.Parameters.AddWithValue("@presentedDate", this.presentedDate);
            cmd.Parameters.AddWithValue("@rejectDate", this.rejectedDate);
            cmd.Parameters.AddWithValue("@approvedDate", this.approveDate);
            cmd.Parameters.AddWithValue("@implementedDate", this.implementedDate);
            cmd.Parameters.AddWithValue("@trackingStartDate", this.trackingStartDate);
            cmd.Parameters.AddWithValue("@trackingEndDate", this.trackingEndDate);
            cmd.Parameters.AddWithValue("@dataDownloadDate", this.dataPulledDate);
            cmd.Parameters.AddWithValue("@dataDateRange", this.DataPulledDate);
            cmd.Parameters.AddWithValue("@dataSource", this.source);
            cmd.Parameters.AddWithValue("@introducedDate", this.createdDate);
            cmd.Parameters.AddWithValue("@rejectedBy", this.rejectedBy);
            cmd.Parameters.AddWithValue("@rationale", this.rationale);
            con.Open();

            int queryResults = cmd.ExecuteNonQuery();
        }
        public Initiative GetInitiative(Double parmId)
        {

            OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM INITIATIVE WHERE INITIATIVE_ID LIKE ? ", con);
            cmd.Parameters.AddWithValue("?", parmId);
            con.Open();
   
            OleDbDataReader Reader = cmd.ExecuteReader();
            //Console.WriteLine("here " + Reader.RecordsAffected.ToString());
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {

                    this.id = Double.Parse(ToStringNullSafe(Reader["initiative_Id"]));
                    this.status = ToStringNullSafe(Reader["init_status"]);
                    this.createdDate = ToDateSafe(Reader["introduced_Date"]);
                    this.analyst = ToStringNullSafe(Reader["analyst"]);

                    this.area = ToStringNullSafe(Reader["init_area"]);
                    this.category = ToStringNullSafe(Reader["init_category"]);
                    this.actionPlan = ToStringNullSafe(Reader["action_Plan"]);
                    this.manufactureName = ToStringNullSafe(Reader["mfg_Name"]);
                    this.option = ToStringNullSafe(Reader["selected_option"]);
                    this.savingType = ToStringNullSafe(Reader["saving_Type"]);
                    this.sharpsStatus = "";
                    this.orgin = ToStringNullSafe(Reader["orgin"]);
                    this.rationale = ToStringNullSafe(Reader["rationale"]);
                    this.unspCode = ToStringNullSafe(Reader["unspsc_Code"]);
                    this.skus = ToStringNullSafe(Reader["skus"]);
                    this.approveDate = ToDateSafe(Reader["approved_Date"]);
                    this.presentedDate = ToDateSafe(Reader["presented_Date"]);
                    this.implementedDate = ToDateSafe(Reader["implemented_Date"]);
                    this.rejectedDate = ToDateSafe(Reader["reject_Date"]);
                    this.rejectedBy = ToStringNullSafe(Reader["rejected_By"]);

                    this.trackingStartDate = ToDateSafe(Reader["tracking_Start_Date"]);
                    this.trackingEndDate = ToDateSafe(Reader["tracking_End_Date"]);

                    this.source = ToStringNullSafe(Reader["data_Source"]);
                    this.SourceStartDate = ToDateSafe("");
                    this.SourceEndDate = ToDateSafe("");
                    this.dataPulledDate = ToDateSafe("");
                    this.implementedDate = ToDateSafe("");

                    this.spend = Double.Parse(ToStringNullSafe(Reader["spend"]));
                    this.savingsAmount = Double.Parse(ToStringNullSafe(Reader["savings_Approved"]));
                }
            }
                return this;
        }
        private static string ToStringNullSafe(object value)
        {
            return (value ?? string.Empty).ToString();
        }
        private static DateTime ToDateSafe(object value)
        {
            if (ToStringNullSafe(value) == "")
            {
                return DateTime.Parse("01/01/1900");
            }
            else
            {
                return DateTime.Parse(ToStringNullSafe(value));
            }
        }
    }
}
