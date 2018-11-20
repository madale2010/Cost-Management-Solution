using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Management_Solution
{
    class Summary
    {
        private Double initiativeId;
        private String productId;
        private Double brmcEa;
        private Double brmcAmt;
        private Double hchHcmhEa;
        private Double hchHcmhAmt;
        private Double hvmcEa;
        private Double hvmcAmt;
        private Double lphEa;
        private Double lphAmt;
        private Double mvrmcEa;
        private Double mvrmcAmt;
        private Double wmaEa;
        private Double wmaAmt;
        private Double otherEa;
        private Double otherSvgs;
        private Double totalUsage;
        private Double totalSvgsAmt;
        private Double projectedSvgsAmt;
        private Double percentRealizedSvgs;
        private Double varianceProjectSvgs;

        public Double InitiativeId { get => initiativeId; set => initiativeId = value; }
        public String ProductId { get => productId; set => productId = value; }
        public Double BrmcEa { get => brmcEa; set => brmcEa = value; }
        public Double BrmcAmt { get => brmcAmt; set => brmcAmt = value; }
        public Double HchHcmhEa { get => hchHcmhEa; set => hchHcmhEa = value; }
        public Double HchHcmhAmt { get => hchHcmhAmt; set => hchHcmhAmt = value; }
        public Double HvmcEa { get => hvmcEa; set => hvmcEa = value; }
        public Double HvmcAmt { get => hvmcAmt; set => hvmcAmt = value; }
        public Double LphEa { get => lphEa; set => lphEa = value; }
        public Double LphAmt { get => lphAmt; set => lphAmt = value; }
        public Double MvrmcEa { get => mvrmcEa; set => mvrmcEa = value; }
        public Double MvrmcAmt { get => mvrmcAmt; set => mvrmcAmt = value; }
        public Double WmaEa { get => wmaEa; set => wmaEa = value; }
        public Double WmaAmt { get => wmaAmt; set => wmaAmt = value; }
        public Double OtherEa { get => otherEa; set => otherEa = value; }
        public Double OtherSvgs { get => otherSvgs; set => otherSvgs = value; }
        public Double TotalUsage { get => totalUsage; set => totalUsage = value; }
        public Double TotalSvgsAmt { get => totalSvgsAmt; set => totalSvgsAmt = value; }
        public Double ProjectedSvgsAmt { get => projectedSvgsAmt; set => projectedSvgsAmt = value; }
        public Double PercentRealizedSvgs { get => percentRealizedSvgs; set => percentRealizedSvgs = value; }
        public Double VarianceProjectSvgs { get => varianceProjectSvgs; set => varianceProjectSvgs = value; }

        public static List<Summary> getSummaryList(Double initiativeId)
        {
            OleDbDataReader Reader = DatabaseHelper.select(Constants.DB.Select.SUMMARY, initiativeId.ToString());
            List<Summary> results = new List<Summary>();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Summary currentItem = new Summary();
                    currentItem.initiativeId = Double.Parse(ToStringNullSafe(Reader["INITIATIVE_ID"]));
                    currentItem.productId = ToStringNullSafe(Reader["PMM_ID"]);
                    currentItem.brmcEa = Double.Parse(ToStringNullSafe(Reader["BRMC_EA"]));
                    currentItem.brmcAmt = Double.Parse(ToStringNullSafe(Reader["BRMC_AMT"]));
                    currentItem.hchHcmhEa = Double.Parse(ToStringNullSafe(Reader["HCH_HCMH_EA"]));
                    currentItem.hchHcmhAmt = Double.Parse(ToStringNullSafe(Reader["HCH_HCMH_AMT"]));
                    currentItem.hvmcEa = Double.Parse(ToStringNullSafe(Reader["HVMC_EA"]));
                    currentItem.hvmcAmt = Double.Parse(ToStringNullSafe(Reader["HVMC_AMT"]));
                    currentItem.lphEa = Double.Parse(ToStringNullSafe(Reader["LPH_EA"]));
                    currentItem.lphAmt = Double.Parse(ToStringNullSafe(Reader["LPH_AMT"]));
                    currentItem.mvrmcEa = Double.Parse(ToStringNullSafe(Reader["MVRMC_EA"]));
                    currentItem.mvrmcAmt = Double.Parse(ToStringNullSafe(Reader["MVRMC_AMT"]));
                    currentItem.wmaEa = Double.Parse(ToStringNullSafe(Reader["WMA_EA"]));
                    currentItem.wmaAmt = Double.Parse(ToStringNullSafe(Reader["WMA_AMT"]));
                    currentItem.otherEa = Double.Parse(ToStringNullSafe(Reader["OTHER_EA"]));
                    currentItem.otherSvgs = Double.Parse(ToStringNullSafe(Reader["OTHER_SVGS"]));
                    currentItem.totalUsage = Double.Parse(ToStringNullSafe(Reader["TOTAL_USAGE"]));
                    currentItem.totalSvgsAmt = Double.Parse(ToStringNullSafe(Reader["TOTAL_SVGS_AMT"]));
                    currentItem.projectedSvgsAmt = Double.Parse(ToStringNullSafe(Reader["PROJECTED_SVGS_AMT"]));
                    currentItem.percentRealizedSvgs = Double.Parse(ToStringNullSafe(Reader["PERCENT_REALIZED_SVGS"]));
                    currentItem.varianceProjectSvgs = Double.Parse(ToStringNullSafe(Reader["VARIANCE_PROJECT_SVGS"]));
                    results.Add(currentItem);
                }
            }
            return results;
        }
        private static string ToStringNullSafe(object value)
        {
            return (value ?? string.Empty).ToString();
        }
    }
}
