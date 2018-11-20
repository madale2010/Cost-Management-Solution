using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_Management_Solution
{
    public class Product
    {

        private Double initiativeId;

        private String productId;
        private String oldProductId;
        private String facilityName;
        private String distributionName;
        private String distributionId;

        private String manufactureName;
        private String manufactureId;
        private String description;
        private String contractId;
        private String unitOfMeasure;
        private String packaging;
        private String packagingString;
        private String glAccount;
        private String vendorName;
        private String unspscCode;

        private DateTime poDate;

        private Double price;
        private Double eachPrice;
        private Double unitPrice;
        private Double quantity;
        private Double totalUsage;

        private Double brmc = 0.0;
        private Double hckhcmh = 0.0;
        private Double hvmc = 0.0;
        private Double lph = 0.0;
        private Double mvh = 0.0;
        private Double tch = 0.0;
        private Double wma = 0.0;
        private Double other = 0.0;

        private PriceChecker priceCompare;


        public string ProductId { get => productId; set => productId = value; }
        public string FacilityName { get => facilityName; set => facilityName = value; }
        public double InitiativeId { get => initiativeId; set => initiativeId = value; }

        public string ManufactureName { get => manufactureName; set => manufactureName = value; }
        public string ManufactureId { get => manufactureId; set => manufactureId = value; }
        public string Description { get => description; set => description = value; }
        public string ContractId { get => contractId; set => contractId = value; }
        public string UnitOfMeasure { get => unitOfMeasure; set => unitOfMeasure = value; }
        public string Packaging { get => packaging; set => packaging = value; }
        public string GlAccount { get => glAccount; set => glAccount = value; }
        public string UnspscCode { get => unspscCode; set => unspscCode = value; }
        public string VendorName { get => vendorName; set => vendorName = value; }
        public string PackagingString { get => packagingString; set => packagingString = value; }

        public DateTime PoDate { get => poDate; set => poDate = value; }

        public double EachPrice { get => eachPrice; set => eachPrice = value; }

        public double Brmc { get => brmc; set => brmc = value; }
        public double Hckhcmh { get => hckhcmh; set => hckhcmh = value; }
        public double Hvmc { get => hvmc; set => hvmc = value; }
        public double Lph { get => lph; set => lph = value; }
        public double Mvh { get => mvh; set => mvh = value; }
        public double Wma { get => wma; set => wma = value; }
        public double Other { get => other; set => other = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public double Tch { get => tch; set => tch = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string OldProductId { get => oldProductId; set => oldProductId = value; }
        public string DistributionName { get => distributionName; set => distributionName = value; }
        public string DistributionId { get => distributionId; set => distributionId = value; }
        public double TotalUsage { get => totalUsage; set => totalUsage = value; }
        internal PriceChecker PriceCompare { get => priceCompare; set => priceCompare = value; }

        public double getTotalUsage()
        {
            //Add up all the total values
            totalUsage = this.brmc + this.hckhcmh + this.hvmc + this.lph + this.mvh + this.wma + this.other + this.tch;
            return totalUsage;
        }
        public List<Product> getProductList(Double parmId)
        {
            OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM INITIATIVE_PRODUCTS WHERE INITIATIVE_ID= ? ", con);
            cmd.Parameters.AddWithValue("?", parmId);
            con.Open();
            OleDbDataReader Reader = cmd.ExecuteReader();
            List<Product> results = new List<Product>();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Product currentItem = new Product();

                    currentItem.InitiativeId = Double.Parse(ToStringNullSafe(Reader["INITIATIVE_ID"]));
                    currentItem.ProductId = ToStringNullSafe(Reader["PMM_ID"]);
                    currentItem.ManufactureName = ToStringNullSafe(Reader["MFR"]);
                    currentItem.ManufactureId = ToStringNullSafe(Reader["MRF_ID"]);
                    currentItem.Description = ToStringNullSafe(Reader["DESCRIPTION"]);
                    currentItem.ContractId = ToStringNullSafe(Reader["CONTRACT"]);
                    currentItem.UnitOfMeasure = ToStringNullSafe(Reader["UM"]);
                    currentItem.Packaging = ToStringNullSafe(Reader["PKG"]);
                    currentItem.EachPrice = Double.Parse(ToStringNullSafe(Reader["UMP"]));
                    currentItem.Brmc = Double.Parse(ToStringNullSafe(Reader["BRMC"]));
                    currentItem.Hckhcmh = Double.Parse(ToStringNullSafe(Reader["HCK_HCMH"]));
                    currentItem.Hvmc = Double.Parse(ToStringNullSafe(Reader["HVMC"]));
                    currentItem.Lph = Double.Parse(ToStringNullSafe(Reader["LPH"]));
                    currentItem.Mvh = Double.Parse(ToStringNullSafe(Reader["MVRMC"]));
                    currentItem.Wma = Double.Parse(ToStringNullSafe(Reader["WMA"]));
                    currentItem.Other = Double.Parse(ToStringNullSafe(Reader["OTHER"]));
                    currentItem.GlAccount = ToStringNullSafe(Reader["GL_ACCT"]);
                    currentItem.TotalUsage = getTotalUsage();
                    results.Add(currentItem);
                }
            }
            return results;
        }
        public List<Product> getProposedProductList(Double parmId)
        {
            OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM INITIATIVE_PROPOSED_PRODUCTS WHERE INITIATIVE_ID= ? ", con);
            cmd.Parameters.AddWithValue("?", parmId);
            con.Open();
            OleDbDataReader Reader = cmd.ExecuteReader();
            List<Product> results = new List<Product>();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Product currentItem = new Product();
                    currentItem.InitiativeId = Double.Parse(ToStringNullSafe(Reader["INITIATIVE_ID"]));
                    currentItem.ProductId = ToStringNullSafe(Reader["PMM_ID"]);
                    currentItem.oldProductId = ToStringNullSafe(Reader["REFERENCE_PMM_ID"]);
                    currentItem.distributionName = ToStringNullSafe(Reader["DISTRIBUTION"]);
                    currentItem.distributionId = ToStringNullSafe(Reader["DIST_ID"]);
                    currentItem.ManufactureId = ToStringNullSafe(Reader["MFG_ID"]);
                    currentItem.Description = ToStringNullSafe(Reader["MFG_DESC"]);
                    currentItem.UnitOfMeasure = ToStringNullSafe(Reader["UM"]);
                    currentItem.Packaging = ToStringNullSafe(Reader["PKG"]);
                    currentItem.PackagingString = ToStringNullSafe(Reader["PKG_STRING"]);
                    currentItem.UnitPrice = Double.Parse(ToStringNullSafe(Reader["EAP"]));
                    currentItem.EachPrice = Double.Parse(ToStringNullSafe(Reader["EAP"]));

                    results.Add(currentItem);
                }
            }
            return results;
        }
            /*
             * Method to determine which facility the producted was used in
             */
            public void setFacilityUsage()
        {
            switch (this.facilityName)
            {
                case Constants.SIFacilities.BRMC:
                    this.brmc += this.quantity;
                    break;
                case Constants.SIFacilities.BSC:
                    this.brmc += this.quantity;
                    break;
                case Constants.SIFacilities.HCM:
                    this.hckhcmh += this.quantity;
                    break;
                case Constants.SIFacilities.HCMC:
                    this.hckhcmh += this.quantity;
                    break;
                case Constants.SIFacilities.HVMC:
                    this.hvmc += this.quantity;
                    break;
                case Constants.SIFacilities.LP:
                    this.lph += this.quantity;
                    break;
                case Constants.SIFacilities.MV:
                    this.mvh += this.quantity;
                    break;
                case Constants.SIFacilities.TRH:
                    this.tch += this.quantity;
                    break;
                case Constants.SIFacilities.OTHER:
                    this.other += this.quantity;
                    break;
                case Constants.SIFacilities.WHS:
                    this.wma += this.quantity;
                    break;
                case Constants.SIFacilities.WMA:
                    this.wma += this.quantity;
                    break;
                default:
                    this.other += this.quantity;
                    break;
            }
        }
        private static string ToStringNullSafe(object value)
        {
            return (value ?? string.Empty).ToString();
        }
        private static DateTime ToDateSafe(object value)
        {
            if (ToStringNullSafe(value) == "")
            {
                return DateTime.Today;
            }
            else
            {
                return DateTime.Parse(ToStringNullSafe(value));
            }
        }
    }

}