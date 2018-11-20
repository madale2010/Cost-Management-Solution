using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Management_Solution
{
    class BroadJump
    {
        private Double initiativeId;
        private String productId;
        private Double broadjumpSvgsPerEach;
        private Double rfiVsBroadjumpVar;
        private Double brmcUsageEa;
        private Double brmcSvgs;
        private Double hckHcmhUsage;
        private Double hckHcmhSvgs;
        private Double hvmcUsage;
        private Double hvmcSvgs;
        private Double lphUsage;
        private Double lphSvgs;
        private Double mvrmcUsage;
        private Double mvrmcSvgs;
        private Double wmaUsage;
        private Double wmaSvgs;
        private Double otherUsage;
        private Double otherSvgs;
        private Double totalUsage;
        private Double totalSvgs;

        public double InitiativeId { get => initiativeId; set => initiativeId = value; }
        public string ProductId { get => productId; set => productId = value; }
        public double BroadjumpSvgsPerEach { get => broadjumpSvgsPerEach; set => broadjumpSvgsPerEach = value; }
        public double RfiVsBroadjumpVar { get => rfiVsBroadjumpVar; set => rfiVsBroadjumpVar = value; }
        public double BrmcUsageEa { get => brmcUsageEa; set => brmcUsageEa = value; }
        public double BrmcSvgs { get => brmcSvgs; set => brmcSvgs = value; }
        public double HckHcmhUsage { get => hckHcmhUsage; set => hckHcmhUsage = value; }
        public double HckHcmhSvgs { get => hckHcmhSvgs; set => hckHcmhSvgs = value; }
        public double HvmcUsage { get => hvmcUsage; set => hvmcUsage = value; }
        public double HvmcSvgs { get => hvmcSvgs; set => hvmcSvgs = value; }
        public double LphUsage { get => lphUsage; set => lphUsage = value; }
        public double LphSvgs { get => lphSvgs; set => lphSvgs = value; }
        public double MvrmcUsage { get => mvrmcUsage; set => mvrmcUsage = value; }
        public double MvrmcSvgs { get => mvrmcSvgs; set => mvrmcSvgs = value; }
        public double WmaUsage { get => wmaUsage; set => wmaUsage = value; }
        public double WmaSvgs { get => wmaSvgs; set => wmaSvgs = value; }
        public double OtherUsage { get => otherUsage; set => otherUsage = value; }
        public double OtherSvgs { get => otherSvgs; set => otherSvgs = value; }
        public double TotalUsage { get => totalUsage; set => totalUsage = value; }
        public double TotalSvgs { get => totalSvgs; set => totalSvgs = value; }

        public static List<BroadJump> getBroadJumpList(Double initiativeId)
        {
            OleDbDataReader Reader = DatabaseHelper.select(Constants.DB.Select.BROADJUMP, initiativeId.ToString());
            List<BroadJump> results = new List<BroadJump>();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    BroadJump currentItem = new BroadJump();
                    currentItem.initiativeId = ToDoubleSafe(Reader["INITIATIVE_ID"]);
                    currentItem.productId = ToStringNullSafe(Reader["PMM_ID"]);
                    currentItem.broadjumpSvgsPerEach = ToDoubleSafe(Reader["BROADJUMP_SVGS_PER_EACH"]);
                    currentItem.rfiVsBroadjumpVar = ToDoubleSafe(Reader["RFI_VS_BROADJUMP_VAR"]);
                    currentItem.brmcUsageEa = ToDoubleSafe(Reader["BRMC_USAGE_EA"]);
                    currentItem.brmcSvgs = ToDoubleSafe(Reader["BRMC_SVGS"]);
                    currentItem.hckHcmhUsage = ToDoubleSafe(Reader["HCK_HCMH_USAGE"]);
                    currentItem.hckHcmhSvgs = ToDoubleSafe(Reader["HCK_HCMH_SVGS"]);
                    currentItem.hvmcUsage = ToDoubleSafe(Reader["HVMC_USAGE"]);
                    currentItem.hvmcSvgs = ToDoubleSafe(Reader["HVMC_SVGS"]);
                    currentItem.lphUsage = ToDoubleSafe(Reader["LPH_USAGE"]);
                    currentItem.lphSvgs = ToDoubleSafe(Reader["LPH_SVGS"]);
                    currentItem.mvrmcUsage = ToDoubleSafe(Reader["MVRMC_USAGE"]);
                    currentItem.mvrmcSvgs = ToDoubleSafe(Reader["MVRMC_SVGS"]);
                    currentItem.wmaUsage = ToDoubleSafe(Reader["WMA_USAGE"]);
                    currentItem.wmaSvgs = ToDoubleSafe(Reader["WMA_SVGS"]);
                    currentItem.otherUsage = ToDoubleSafe(Reader["OTHER_USAGE"]);
                    currentItem.otherSvgs = ToDoubleSafe(Reader["OTHER_SVGS"]);
                    currentItem.totalUsage = ToDoubleSafe(Reader["TOTAL_USAGE"]);
                    currentItem.totalSvgs = ToDoubleSafe(Reader["TOTAL_SVGS"]);
                    results.Add(currentItem);
                }
            }
            return results;
        }
        private static string ToStringNullSafe(object value)
        {
            return (value ?? string.Empty).ToString();
        }
        private static Double ToDoubleSafe(object value)
        {
            return Double.Parse(ToStringNullSafe(value));
        }
    }
}
