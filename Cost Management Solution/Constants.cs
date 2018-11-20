using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Management_Solution
{
    class Constants 
    {
        public static String PREFIX_PATH = Environment.GetEnvironmentVariable("SUPPLY_CHAIN");
        public static String IMAGE_PATH = Environment.GetEnvironmentVariable("SC_IMG_PATH");
        public static String ACCESS_PATH = Environment.GetEnvironmentVariable("SC_DB_PATH");
        public static String ORGINAL_WB_PATH = Environment.GetEnvironmentVariable("SC_ORG_PATH");
        public static String FILE_PATH = Environment.GetEnvironmentVariable("SC_AD_PATH");
        public static String LOG_FILE = Environment.GetEnvironmentVariable("SC_LOG_PATH")+"Cost Management.log";
        public static String DB_CON_STRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ACCESS_PATH + "Supply Chain.accdb";

        public class DB
        {
            public class Insert
            {
                public const String INITIATIVE = "INSERT INTO INITIATIVE (INITIATIVE_ID,INIT_STATUS,INIT_AREA,INIT_CATEGORY,MFG_NAME,ANALYST,SPEND,SAVINGS_APPROVED,SAVING_TYPE,ORGIN,SKUS,UNSPSC_CODE,SELECTED_OPTION,ACTION_PLAN,PLAN_DATE,PRESENTED_DATE,REJECT_DATE,APPROVED_DATE,IMPLEMENTED_DATE,TRACKING_START_DATE,TRACKING_END_DATE,DATA_DOWNLOAD_DATE,DATA_DATE_RANGE,DATA_SOURCE,INTRODUCED_DATE,REJECTED_BY,RATIONALE) VALUES(@initiativeId,@initStatus,@initArea,@initCategory,@mfgName,@analyst,@spend,@savingsApproved,@savingType,@orgin,@skus,@unspscCode,@selectedOption,@actionPlan,@planDate,@presentedDate,@rejectDate,@approvedDate,@implementedDate,@trackingStartDate,@trackingEndDate,@dataDownloadDate,@dataDateRange,@dataSource,@introducedDate,@rejectedBy,@rationale); ";
                public const String CONTRACT = "INSERT INTO INITIATIVE_CONTRACT (INITIATIVE_ID,CONTRACT_ID,CONTRACT_VENDOR,CONTRACT_TYPE,CONTRACT_TIER,AWARD_DATE,START_DATE,END_DATE,SIGNED_DATE) VALUES (@initiativeId,@contractId,@contractVendor,@contractType,@contractTier,@awardDate,@startDate,@endDate,@signedDate);";
                public const String BROADJUMP = "INSERT INTO INITIATIVE_BROADJUMP (INITIATIVE_ID,PMM_ID,BROADJUMP_SVGS_PER_EACH,RFI_VS_BROADJUMP_VAR,BRMC_USAGE_EA,BRMC_SVGS,HCK_HCMH_USAGE,HCK_HCMH_SVGS,HVMC_USAGE,HVMC_SVGS,LPH_USAGE,LPH_SVGS,MVRMC_USAGE,MVRMC_SVGS,WMA_USAGE,WMA_SVGS,OTHER_USAGE,OTHER_SVGS,TOTAL_USAGE,TOTAL_SVGS) VALUES (@initiativeId,@pmmId,@broadjumpSvgsPerEach,@rfiVsBroadjumpVar,@brmcUsageEa,@brmcSvgs,@hckHcmhUsage,@hckHcmhSvgs,@hvmcUsage,@hvmcSvgs,@lphUsage,@lphSvgs,@mvrmcUsage,@mvrmcSvgs,@wmaUsage,@wmaSvgs,@otherUsage,@otherSvgs,@totalUsage,@totalSvgs);";
                public const String BROADJUMP_SAVINGS = "INSERT INTO INITIATIVE_BROADJUMP_SAVINGS (INITIATIVE_ID,PMM_ID,BROADJUMP_EAP,CURRENT_EAP,BRMC_USAGE_EA,BRMC_CURRENT_SPEND,BRMC_OP1_SVGS_PER_EA,BRMC_OP1_PROPOSED_SVGS,BRMC_OP2_SVGS_PER_EA,BRMC_OP2_PROPOSED_SVGS,HCK_HCMH_USAGE_EA,HCK_HCMH_CURRENT_SPEND,HCK_HCMH_OP1_SVGS_PER_EA,HCK_HCMH_OP1_PROPOSED_SVGS,HCK_HCMH_OP2_SVGS_PER_EA,HCK_HCMH_OP2_PROPOSED_SVGS,HVMC_USAGE_EA,HVMC_CURRENT_SPEND,HVMC_OP1_SVGS_PER_EA,HVMC_OP1_PROPOSED_SVGS,HVMC_OP2_SVGS_PER_EA,HVMC_OP2_PROPOSED_SVGS,LPH_USAGE_EA,LPH_CURRENT_SPEND,LPH_OP1_SVGS_PER_EA,LPH_OP1_PROPOSED_SVGS,LPH_OP2_SVGS_PER_EA,LPH_OP2_PROPOSED_SVGS,MVRMC_USAGE_EA,MVRMC_CURRENT_SPEND,MVRMC_OP1_SVGS_PER_EA,MVRMC_OP1_PROPOSED_SVGS,MVRMC_OP2_SVGS_PER_EA,MVRMC_OP2_PROPOSED_SVGS,WMA_USAGE_EA,WMA_CURRENT_SPEND,WMA_OP1_SVGS_PER_EA,WMA_OP1_PROPOSED_SVGS,WMA_OP2_SVGS_PER_EA,WMA_OP2_PROPOSED_SVGS,OTHER_WHS_USAGE_EA,OTHER_WHS_CURRENT_SPEND,OTHER_WHS_OP1_SVGS_PER_EA,OTHER_WHS_OP1_PROPOSED_SVGS,OTHER_WHS_OP2_SVGS_PER_EA,OTHER_WHS_OP2_PROPOSED_SVGS,CURRENT_SPEND_BY_PRODUCT,OPTION_1_SVGS,OPTION_2_SVGS,OPTION_1_PROPOSED_SPEND,OPTION_2_PROPOSED_SPEND,ORG_UTIL_USAGE_EA,TOTAL_BROADJUMP_SVGS) VALUES (@initiativeId,@pmmId,@broadjumpEap,@currentEap,@brmcUsageEa,@brmcCurrentSpend,@brmcOp1SvgsPerEa,@brmcOp1ProposedSvgs,@brmcOp2SvgsPerEa,@brmcOp2ProposedSvgs,@hckHcmhUsageEa,@hckHcmhCurrentSpend,@hckHcmhOp1SvgsPerEa,@hckHcmhOp1ProposedSvgs,@hckHcmhOp2SvgsPerEa,@hckHcmhOp2ProposedSvgs,@hvmcUsageEa,@hvmcCurrentSpend,@hvmcOp1SvgsPerEa,@hvmcOp1ProposedSvgs,@hvmcOp2SvgsPerEa,@hvmcOp2ProposedSvgs,@lphUsageEa,@lphCurrentSpend,@lphOp1SvgsPerEa,@lphOp1ProposedSvgs,@lphOp2SvgsPerEa,@lphOp2ProposedSvgs,@mvrmcUsageEa,@mvrmcCurrentSpend,@mvrmcOp1SvgsPerEa,@mvrmcOp1ProposedSvgs,@mvrmcOp2SvgsPerEa,@mvrmcOp2ProposedSvgs,@wmaUsageEa,@wmaCurrentSpend,@wmaOp1SvgsPerEa,@wmaOp1ProposedSvgs,@wmaOp2SvgsPerEa,@wmaOp2ProposedSvgs,@otherWhsUsageEa,@otherWhsCurrentSpend,@otherWhsOp1SvgsPerEa,@otherWhsOp1ProposedSvgs,@otherWhsOp2SvgsPerEa,@otherWhsOp2ProposedSvgs,@currentSpendByProduct,@option1Svgs,@option2Svgs,@option1ProposedSpend,@option2ProposedSpend,@orgUtilUsageEa,@totalBroadjumpSvgs);";
                public const String PRODUCTS = "INSERT INTO INITIATIVE_PRODUCTS (INITIATIVE_ID,PMM_ID,MFR,MRF_ID,DESCRIPTION,CONTRACT,UM,PKG,UMP,GL_ACCT,BRMC,HCK_HCMH,HVMC,LPH,MVRMC,WMA,OTHER,INV_AFF_WHS,INV_AFF_OR) VALUES (@initiativeId,@pmmId,@mfr,@mrfId,@description,@contract,@um,@pkg,@ump,@glAcct,@brmc,@hckHcmh,@hvmc,@lph,@mvrmc,@wma,@other,@invAffWhs,@invAffOr); ";
                public const String PROPOSED_PRODUCTS = "INSERT INTO INITIATIVE_PROPOSED_PRODUCTS (INITIATIVE_ID,PROPOSED_MFG_DESC,REFERENCE_PMM_NUM,PROSOSED_OPTION,PROPOSED_PMM_NUM,PROPOSED_DISTRIBUTION,PROPOSED_DIST_NUM,PROPOSED_MFG_NUM,PROPOSED_UM,PROPOSED_PKG,PROPOSED_PKG_STRING,PROPOSED_PRICE_PER_UM,PROPOSED_EAP) VALUES (@initiativeId,@proposedMfgDesc,@referencePmmNum,@prososedOption,@proposedPmmNum,@proposedDistribution,@proposedDistNum,@proposedMfgNum,@proposedUm,@proposedPkg,@proposedPkgString,@proposedPricePerUm,@proposedEap);";
                public const String NOTES = "INSERT INTO INITIATIVE_NOTES (INITIATIVE_ID,NOTE_DATE,PERSON,NOTE_DESC) VALUES (@initiativeId,@noteDate,@notePerson,@noteDescription);";
                public const String SUMMARY = "INSERT INTO INITIATIVE_UTILIZATION_SUMMARY (INITIATIVE_ID,PMM_ID,PROJECTED_SVGS_AMT,VARIANCE_PROJECT_SVGS,BRMC_EA,BRMC_AMT,HCH_HCMH_EA,HCH_HCMH_AMT,HVMC_EA,HVMC_AMT,LPH_EA,LPH_AMT,MVRMC_EA,MVRMC_AMT,WMA_EA,WMA_AMT,OTHER_EA,OTHER_SVGS,TOTAL_USAGE,TOTAL_SVGS_AMT,PERCENT_REALIZED_SVGS) VALUES (@initiativeId,@pmmId,@projectedSvgsAmt,@varianceProjectSvgs,@brmcEa,@brmcAmt,@hchHcmhEa,@hchHcmhAmt,@hvmcEa,@hvmcAmt,@lphEa,@lphAmt,@mvrmcEa,@mvrmcAmt,@wmaEa,@wmaAmt,@otherEa,@otherSvgs,@totalUsage,@totalSvgsAmt,@percentRealizedSvgs);";
                public const String TRACKING = "INSERT INTO INITIATIVE_TRACKING (INITIATIVE_ID,QUARTER,TOTAL_SVGS,TOTAL_USAGE,SVGS_PER_EACH,EAP_VARIANCE,PROPOSED_EAP,QRT_START_DATE,QRT_END_DATE,PMM_NUM,UM,PKG,UMP,BRMC,HCK_HCMH,HVMC,LPH,MVRMC,WMA,OTHER,EAP,BRMC_USAGE_EA,BRMC_SVGS,HCK_HCMH_USAGE_EA,HCK_HCMH_SVGS,HVMC_USAGE_EA,HVMC_SVGS,LPH_USAGE_EA,LPH_SVGS,MVRMC_USAGE_EA,MVRMC_SVGS,WMA_USAGE_EA,WMA_SVGS,OTHER_USAGE_EA,OTHER_SVGS) VALUES (@initiativeId,@quarter,@totalSvgs,@totalUsage,@svgsPerEach,@eapVariance,@proposedEap,@qrtStartDate,@qrtEndDate,@pmmNum,@um,@pkg,@ump,@brmc,@hckHcmh,@hvmc,@lph,@mvrmc,@wma,@other,@eap,@brmcUsageEa,@brmcSvgs,@hckHcmhUsageEa,@hckHcmhSvgs,@hvmcUsageEa,@hvmcSvgs,@lphUsageEa,@lphSvgs,@mvrmcUsageEa,@mvrmcSvgs,@wmaUsageEa,@wmaSvgs,@otherUsageEa,@otherSvgs);";
            }
            public class Select
            {
                public const String INITIATIVE = "SELECT * FROM INITIATIVE WHERE INITIATIVE_ID= ? ";
                public const String CONTRACT = "SELECT * FROM INITIATIVE_CONTRACT WHERE INITIATIVE_ID= ? ";
                public const String BROADJUMP = "SELECT * FROM INITIATIVE_BROADJUMP WHERE INITIATIVE_ID= ? ";
                public const String BROADJUMP_SAVINGS = "SELECT * FROM INITIATIVE_BROADJUMP_SAVINGS WHERE INITIATIVE_ID= ? ";
                public const String PRODUCTS = "SELECT * FROM INITIATIVE_PRODUCTS WHERE INITIATIVE_ID= ? ";
                public const String PROPOSED_PRODUCTS = "SELECT * FROM INITIATIVE_PROPOSED_PRODUCTS WHERE INITIATIVE_ID= ? ";
                public const String NOTES = "SELECT * FROM INITIATIVE_NOTES WHERE INITIATIVE_ID= ? ";
                public const String SUMMARY = "SELECT * FROM INITIATIVE_UTILIZATION_SUMMARY WHERE INITIATIVE_ID= ? ";
                public const String TRACKING = "SELECT * FROM INITIATIVE_TRACKING WHERE INITIATIVE_ID= ? ";
            }
            public class Search
            {
                public const String INIT_BY_STATUS = "SELECT * FROM INITIATIVE WHERE INIT_STATUS= ? ";
                public const String INIT_BY_ANALYST = "SELECT * FROM INITIATIVE WHERE ANALYST= ? ";
                public const String INIT_BY_ID = "SELECT * FROM INITIATIVE WHERE INITIATIVE_ID LIKE ? ";
                public const String INIT_BY_DATE = "SELECT * FROM INITIATIVE WHERE INITIATIVE_ID LIKE ? ";
            }

        }
        public class Images
        {
            public static String STATUS_OK_SM = IMAGE_PATH + "StatusAnnotations_Complete_and_ok_32xSM_color.png";
            public static String STATUS_OK_MD = IMAGE_PATH + "StatusAnnotations_Complete_and_ok_32xMD_color.png";
            public static String STATUS_OK_LG = IMAGE_PATH + "Annotations_Complete_and_ok_32xLG_color.png";
            public static String OFFLINE_SM = IMAGE_PATH + "Offline_16xSM.png";
            public static String OFFLINE_MD = IMAGE_PATH + "Offline_16xMD.png";
            public static String OFFLINE_LG = IMAGE_PATH + "Offline_16xLG.png";

        }
        public class SIHeaders
        {
            public const String FACILITY_NAME = "FacilityName";
            public const String FACILITY_ITEM_NUMBER = "FacilityItemNumber";
            public const String MANUFACTURER_NAME = "ManufacturerName";
            public const String MANUFACTURER_CATALOG_NUMBER = "ManufacturerCatalogNumber";
            public const String ITEM_DESCRIPTION = "ItemDescription";
            public const String MANAGED_CONTRACT_NUMBER = "ManagedContractNumber";
            public const String PO_UM = "POUOM";
            public const String STANDARD_PACKAGING = "StandardPackaging";
            public const String PO_QUANTITY = "POQuantity";
            public const String INVOICE_PRICE = "InvoicePrice";
            public const String DETAIL_GL_DEPT_CODE = "DetailGLDeptCode";
            public const String PO_PRICE = "POPrice";
            public const String DETAIL_GL_ACCOUNT = "DetailGLAccount";
            public const String TOTAL_SPEND = "TotalSpend";
            public const String VENDOR_NAME = "VendorName";
            public const String PO_DATE = "PODate";
            public const String PO_NUMBER = "PONumber";
            public const String COMMODITY = "Commodity";
            public const String CONTRACT_STATUS = "ContractStatus";
        }
        public class SIFacilities
        {
            public const String BSC = "Bristol Surgery Center";
            public const String TRH = "Tacoma Regional Hospital";
            public const String BRMC = "Wellmont Bristol Regional  Med Ctr";
            public const String HCMC = "Wellmont Hawkins County Memorial Ho";
            public const String HCM = "Wellmont Hancock County Hospital";
            public const String MV = "Wellmont Mountain View Medical Ctr";
            public const String WHS = "Wellmont Health System";
            public const String HVMC = "Wellmont Holston Valley Medical Cen";
            public const String LP = "Wellmont Lonesome Pine Hospital";
            public const String WMA = "Wellmont Medical Associates";
            public const String OTHER = "Wexford House";
        }
        public class BJHeaders
        {
            public const String PRODUCTID = "ProductID";
            public const String NAME = "Name";
            public const String SKU = "SKU";
            public const String MANUFACTURER = "Manufacturer";
            public const String MY_UNIT_PRICE = "My Unit Price";
            public const String AVG_UNIT_PRICE = "Avg Unit Price";
            public const String BELOW_AVERAGE = "Below Average";
            public const String CATEGORY = "Category";
            public const String LOWESTPRICE = "LowestPrice";
            public const String HIGHESTPRICE = "HighestPrice";
            public const String MYUOMPRICE = "MyUOMPrice";
            public const String LOWESTUOMPRICE = "LowestUOMPrice";
            public const String MEANUOMPRICE = "MeanUOMPrice";
            public const String HIGHESTUOMPRICE = "HighestUOMPrice";
            public const String INPUTQTY = "InputQty";
            public const String INPUTUOM = "InputUOM";
            public const String TOTAL = "total";
            public const String ISMYPRICE_ = "IsMyPrice";
            public const String MMIS_NUM = "MMIS #";
            public const String UNITS_PER_UOM = "Units Per UOM";
            public const String ANNUAL_UOM_QTY = "Annual UOM Qty";
            public const String CURRENT_UOM_WAP = "Current  UOM WAP";
            public const String ANNUAL_VOLUME = "Annual Volume";
            public const String PROPOSED_UOM_PRICE = "Proposed UOM Price";
            public const String PROPOSED_VOLUME = "Proposed Volume";
            public const String SAVINGS_AMOUNT = "Savings ($)";
            public const String SAVINGS_PERCENT = "Savings (%)";
        }
    }
}
