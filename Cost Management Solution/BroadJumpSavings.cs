using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Management_Solution
{
    class BroadJumpSavings
    {
        private Double initiativeId;
        private String pmmId;
        private Double broadjumpEap;
        private Double currentEap;
        private Double brmcUsageEa;
        private Double brmcCurrentSpend;
        private Double brmcOp1SvgsPerEa;
        private Double brmcOp1ProposedSvgs;
        private Double brmcOp2SvgsPerEa;
        private Double brmcOp2ProposedSvgs;
        private Double hckHcmhUsageEa;
        private Double hckHcmhCurrentSpend;
        private Double hckHcmhOp1SvgsPerEa;
        private Double hckHcmhOp1ProposedSvgs;
        private Double hckHcmhOp2SvgsPerEa;
        private Double hckHcmhOp2ProposedSvgs;
        private Double hvmcUsageEa;
        private Double hvmcCurrentSpend;
        private Double hvmcOp1SvgsPerEa;
        private Double hvmcOp1ProposedSvgs;
        private Double hvmcOp2SvgsPerEa;
        private Double hvmcOp2ProposedSvgs;
        private Double lphUsageEa;
        private Double lphCurrentSpend;
        private Double lphOp1SvgsPerEa;
        private Double lphOp1ProposedSvgs;
        private Double lphOp2SvgsPerEa;
        private Double lphOp2ProposedSvgs;
        private Double mvrmcUsageEa;
        private Double mvrmcCurrentSpend;
        private Double mvrmcOp1SvgsPerEa;
        private Double mvrmcOp1ProposedSvgs;
        private Double mvrmcOp2SvgsPerEa;
        private Double mvrmcOp2ProposedSvgs;
        private Double wmaUsageEa;
        private Double wmaCurrentSpend;
        private Double wmaOp1SvgsPerEa;
        private Double wmaOp1ProposedSvgs;
        private Double wmaOp2SvgsPerEa;
        private Double wmaOp2ProposedSvgs;
        private Double otherWhsUsageEa;
        private Double otherWhsCurrentSpend;
        private Double otherWhsOp1SvgsPerEa;
        private Double otherWhsOp1ProposedSvgs;
        private Double otherWhsOp2SvgsPerEa;
        private Double otherWhsOp2ProposedSvgs;
        private Double currentSpendByProduct;
        private Double option1Svgs;
        private Double option2Svgs;
        private Double option1ProposedSpend;
        private Double option2ProposedSpend;
        private Double orgUtilUsageEa;
        private Double totalBroadjumpSvgs;

        public double InitiativeId { get => initiativeId; set => initiativeId = value; }
        public string PmmId { get => pmmId; set => pmmId = value; }
        public double BroadjumpEap { get => broadjumpEap; set => broadjumpEap = value; }
        public double CurrentEap { get => currentEap; set => currentEap = value; }
        public double BrmcUsageEa { get => brmcUsageEa; set => brmcUsageEa = value; }
        public double BrmcCurrentSpend { get => brmcCurrentSpend; set => brmcCurrentSpend = value; }
        public double BrmcOp1SvgsPerEa { get => brmcOp1SvgsPerEa; set => brmcOp1SvgsPerEa = value; }
        public double BrmcOp1ProposedSvgs { get => brmcOp1ProposedSvgs; set => brmcOp1ProposedSvgs = value; }
        public double BrmcOp2SvgsPerEa { get => brmcOp2SvgsPerEa; set => brmcOp2SvgsPerEa = value; }
        public double BrmcOp2ProposedSvgs { get => brmcOp2ProposedSvgs; set => brmcOp2ProposedSvgs = value; }
        public double HckHcmhUsageEa { get => hckHcmhUsageEa; set => hckHcmhUsageEa = value; }
        public double HckHcmhCurrentSpend { get => hckHcmhCurrentSpend; set => hckHcmhCurrentSpend = value; }
        public double HckHcmhOp1SvgsPerEa { get => hckHcmhOp1SvgsPerEa; set => hckHcmhOp1SvgsPerEa = value; }
        public double HckHcmhOp1ProposedSvgs { get => hckHcmhOp1ProposedSvgs; set => hckHcmhOp1ProposedSvgs = value; }
        public double HckHcmhOp2SvgsPerEa { get => hckHcmhOp2SvgsPerEa; set => hckHcmhOp2SvgsPerEa = value; }
        public double HckHcmhOp2ProposedSvgs { get => hckHcmhOp2ProposedSvgs; set => hckHcmhOp2ProposedSvgs = value; }
        public double HvmcUsageEa { get => hvmcUsageEa; set => hvmcUsageEa = value; }
        public double HvmcCurrentSpend { get => hvmcCurrentSpend; set => hvmcCurrentSpend = value; }
        public double HvmcOp1SvgsPerEa { get => hvmcOp1SvgsPerEa; set => hvmcOp1SvgsPerEa = value; }
        public double HvmcOp1ProposedSvgs { get => hvmcOp1ProposedSvgs; set => hvmcOp1ProposedSvgs = value; }
        public double HvmcOp2SvgsPerEa { get => hvmcOp2SvgsPerEa; set => hvmcOp2SvgsPerEa = value; }
        public double HvmcOp2ProposedSvgs { get => hvmcOp2ProposedSvgs; set => hvmcOp2ProposedSvgs = value; }
        public double LphUsageEa { get => lphUsageEa; set => lphUsageEa = value; }
        public double LphCurrentSpend { get => lphCurrentSpend; set => lphCurrentSpend = value; }
        public double LphOp1SvgsPerEa { get => lphOp1SvgsPerEa; set => lphOp1SvgsPerEa = value; }
        public double LphOp1ProposedSvgs { get => lphOp1ProposedSvgs; set => lphOp1ProposedSvgs = value; }
        public double LphOp2SvgsPerEa { get => lphOp2SvgsPerEa; set => lphOp2SvgsPerEa = value; }
        public double LphOp2ProposedSvgs { get => lphOp2ProposedSvgs; set => lphOp2ProposedSvgs = value; }
        public double MvrmcUsageEa { get => mvrmcUsageEa; set => mvrmcUsageEa = value; }
        public double MvrmcCurrentSpend { get => mvrmcCurrentSpend; set => mvrmcCurrentSpend = value; }
        public double MvrmcOp1SvgsPerEa { get => mvrmcOp1SvgsPerEa; set => mvrmcOp1SvgsPerEa = value; }
        public double MvrmcOp1ProposedSvgs { get => mvrmcOp1ProposedSvgs; set => mvrmcOp1ProposedSvgs = value; }
        public double MvrmcOp2SvgsPerEa { get => mvrmcOp2SvgsPerEa; set => mvrmcOp2SvgsPerEa = value; }
        public double MvrmcOp2ProposedSvgs { get => mvrmcOp2ProposedSvgs; set => mvrmcOp2ProposedSvgs = value; }
        public double WmaUsageEa { get => wmaUsageEa; set => wmaUsageEa = value; }
        public double WmaCurrentSpend { get => wmaCurrentSpend; set => wmaCurrentSpend = value; }
        public double WmaOp1SvgsPerEa { get => wmaOp1SvgsPerEa; set => wmaOp1SvgsPerEa = value; }
        public double WmaOp1ProposedSvgs { get => wmaOp1ProposedSvgs; set => wmaOp1ProposedSvgs = value; }
        public double WmaOp2SvgsPerEa { get => wmaOp2SvgsPerEa; set => wmaOp2SvgsPerEa = value; }
        public double WmaOp2ProposedSvgs { get => wmaOp2ProposedSvgs; set => wmaOp2ProposedSvgs = value; }
        public double OtherWhsUsageEa { get => otherWhsUsageEa; set => otherWhsUsageEa = value; }
        public double OtherWhsCurrentSpend { get => otherWhsCurrentSpend; set => otherWhsCurrentSpend = value; }
        public double OtherWhsOp1SvgsPerEa { get => otherWhsOp1SvgsPerEa; set => otherWhsOp1SvgsPerEa = value; }
        public double OtherWhsOp1ProposedSvgs { get => otherWhsOp1ProposedSvgs; set => otherWhsOp1ProposedSvgs = value; }
        public double OtherWhsOp2SvgsPerEa { get => otherWhsOp2SvgsPerEa; set => otherWhsOp2SvgsPerEa = value; }
        public double OtherWhsOp2ProposedSvgs { get => otherWhsOp2ProposedSvgs; set => otherWhsOp2ProposedSvgs = value; }
        public double CurrentSpendByProduct { get => currentSpendByProduct; set => currentSpendByProduct = value; }
        public double Option1Svgs { get => option1Svgs; set => option1Svgs = value; }
        public double Option2Svgs { get => option2Svgs; set => option2Svgs = value; }
        public double Option1ProposedSpend { get => option1ProposedSpend; set => option1ProposedSpend = value; }
        public double Option2ProposedSpend { get => option2ProposedSpend; set => option2ProposedSpend = value; }
        public double OrgUtilUsageEa { get => orgUtilUsageEa; set => orgUtilUsageEa = value; }
        public double TotalBroadjumpSvgs { get => totalBroadjumpSvgs; set => totalBroadjumpSvgs = value; }
        public List<BroadJumpSavings> getBroadJumpSavingsList(Double initiativeId)
        {
            OleDbDataReader Reader = DatabaseHelper.select(Constants.DB.Select.SUMMARY, initiativeId.ToString());
            List<BroadJumpSavings> results = new List<BroadJumpSavings>();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    BroadJumpSavings currentItem = new BroadJumpSavings();
                    currentItem.hckHcmhCurrentSpend = ToDoubleSafe(Reader["HCK_HCMH_CURRENT_SPEND"]);
                    currentItem.hckHcmhOp1SvgsPerEa = ToDoubleSafe(Reader["HCK_HCMH_OP1_SVGS_PER_EA"]);
                    currentItem.hckHcmhOp1ProposedSvgs = ToDoubleSafe(Reader["HCK_HCMH_OP1_PROPOSED_SVGS"]);
                    currentItem.hckHcmhOp2SvgsPerEa = ToDoubleSafe(Reader["HCK_HCMH_OP2_SVGS_PER_EA"]);
                    currentItem.hckHcmhOp2ProposedSvgs = ToDoubleSafe(Reader["HCK_HCMH_OP2_PROPOSED_SVGS"]);
                    currentItem.hvmcUsageEa = ToDoubleSafe(Reader["HVMC_USAGE_EA"]);
                    currentItem.hvmcCurrentSpend = ToDoubleSafe(Reader["HVMC_CURRENT_SPEND"]);
                    currentItem.hvmcOp1SvgsPerEa = ToDoubleSafe(Reader["HVMC_OP1_SVGS_PER_EA"]);
                    currentItem.hvmcOp1ProposedSvgs = ToDoubleSafe(Reader["HVMC_OP1_PROPOSED_SVGS"]);
                    currentItem.hvmcOp2SvgsPerEa = ToDoubleSafe(Reader["HVMC_OP2_SVGS_PER_EA"]);
                    currentItem.hvmcOp2ProposedSvgs = ToDoubleSafe(Reader["HVMC_OP2_PROPOSED_SVGS"]);
                    currentItem.lphUsageEa = ToDoubleSafe(Reader["LPH_USAGE_EA"]);
                    currentItem.lphCurrentSpend = ToDoubleSafe(Reader["LPH_CURRENT_SPEND"]);
                    currentItem.lphOp1SvgsPerEa = ToDoubleSafe(Reader["LPH_OP1_SVGS_PER_EA"]);
                    currentItem.lphOp1ProposedSvgs = ToDoubleSafe(Reader["LPH_OP1_PROPOSED_SVGS"]);
                    currentItem.lphOp2SvgsPerEa = ToDoubleSafe(Reader["LPH_OP2_SVGS_PER_EA"]);
                    currentItem.lphOp2ProposedSvgs = ToDoubleSafe(Reader["LPH_OP2_PROPOSED_SVGS"]);
                    currentItem.mvrmcUsageEa = ToDoubleSafe(Reader["MVRMC_USAGE_EA"]);
                    currentItem.mvrmcCurrentSpend = ToDoubleSafe(Reader["MVRMC_CURRENT_SPEND"]);
                    currentItem.mvrmcOp1SvgsPerEa = ToDoubleSafe(Reader["MVRMC_OP1_SVGS_PER_EA"]);
                    currentItem.mvrmcOp1ProposedSvgs = ToDoubleSafe(Reader["MVRMC_OP1_PROPOSED_SVGS"]);
                    currentItem.mvrmcOp2SvgsPerEa = ToDoubleSafe(Reader["MVRMC_OP2_SVGS_PER_EA"]);
                    currentItem.mvrmcOp2ProposedSvgs = ToDoubleSafe(Reader["MVRMC_OP2_PROPOSED_SVGS"]);
                    currentItem.wmaUsageEa = ToDoubleSafe(Reader["WMA_USAGE_EA"]);
                    currentItem.wmaCurrentSpend = ToDoubleSafe(Reader["WMA_CURRENT_SPEND"]);
                    currentItem.wmaOp1SvgsPerEa = ToDoubleSafe(Reader["WMA_OP1_SVGS_PER_EA"]);
                    currentItem.wmaOp1ProposedSvgs = ToDoubleSafe(Reader["WMA_OP1_PROPOSED_SVGS"]);
                    currentItem.wmaOp2SvgsPerEa = ToDoubleSafe(Reader["WMA_OP2_SVGS_PER_EA"]);
                    currentItem.wmaOp2ProposedSvgs = ToDoubleSafe(Reader["WMA_OP2_PROPOSED_SVGS"]);
                    currentItem.otherWhsUsageEa = ToDoubleSafe(Reader["OTHER_WHS_USAGE_EA"]);
                    currentItem.otherWhsCurrentSpend = ToDoubleSafe(Reader["OTHER_WHS_CURRENT_SPEND"]);
                    currentItem.otherWhsOp1SvgsPerEa = ToDoubleSafe(Reader["OTHER_WHS_OP1_SVGS_PER_EA"]);
                    currentItem.otherWhsOp1ProposedSvgs = ToDoubleSafe(Reader["OTHER_WHS_OP1_PROPOSED_SVGS"]);
                    currentItem.otherWhsOp2SvgsPerEa = ToDoubleSafe(Reader["OTHER_WHS_OP2_SVGS_PER_EA"]);
                    currentItem.otherWhsOp2ProposedSvgs = ToDoubleSafe(Reader["OTHER_WHS_OP2_PROPOSED_SVGS"]);
                    currentItem.currentSpendByProduct = ToDoubleSafe(Reader["CURRENT_SPEND_BY_PRODUCT"]);
                    currentItem.option1Svgs = ToDoubleSafe(Reader["OPTION_1_SVGS"]);
                    currentItem.option2Svgs = ToDoubleSafe(Reader["OPTION_2_SVGS"]);
                    currentItem.option1ProposedSpend = ToDoubleSafe(Reader["OPTION_1_PROPOSED_SPEND"]);
                    currentItem.option2ProposedSpend = ToDoubleSafe(Reader["OPTION_2_PROPOSED_SPEND"]);
                    currentItem.orgUtilUsageEa = ToDoubleSafe(Reader["ORG_UTIL_USAGE_EA"]);
                    currentItem.totalBroadjumpSvgs = ToDoubleSafe(Reader["TOTAL_BROADJUMP_SVGS"]);
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
