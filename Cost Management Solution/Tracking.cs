using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Management_Solution
{
    class Tracking
    {
        private Double id;
		private Double initiativeId;
		private String quarter;
		private String qrtStartDate;
		private String qrtEndDate;
		private String pmm;
		private String unitOfMeasure;
		private String packaging;
		private String eachPice;
		private String brmc;
		private String hckHcmh;
		private String hvmc;
		private String lph;
		private String mvrmc;
		private String wma;
		private String other;
		private String eap;
		private String proposedEap;
		private String eapVariance;
		private String svgsPerEach;
		private String brmcUsageEa;
		private String brmcSvgs;
		private String hckHcmhUsageEa;
		private String hckHcmhSvgs;
		private String hvmcUsageEa;
		private String hvmcSvgs;
		private String lphUsageEa;
		private String lphSvgs;
		private String mvrmcUsageEa;
		private String mvrmcSvgs;
		private String wmaUsageEa;
		private String wmaSvgs;
		private String otherUsageEa;
		private String otherSvgs;
		private String totalUsage;
		private String totalSvgs;

        public double Id { get => id; set => id = value; }
        public double InitiativeId { get => initiativeId; set => initiativeId = value; }
        public string Quarter { get => quarter; set => quarter = value; }
        public string QrtStartDate { get => qrtStartDate; set => qrtStartDate = value; }
        public string QrtEndDate { get => qrtEndDate; set => qrtEndDate = value; }
        public string Pmm { get => pmm; set => pmm = value; }
        public string UnitOfMeasure { get => unitOfMeasure; set => unitOfMeasure = value; }
        public string Packaging { get => packaging; set => packaging = value; }
        public string EachPice { get => eachPice; set => eachPice = value; }
        public string Brmc { get => brmc; set => brmc = value; }
        public string HckHcmh { get => hckHcmh; set => hckHcmh = value; }
        public string Hvmc { get => hvmc; set => hvmc = value; }
        public string Lph { get => lph; set => lph = value; }
        public string Mvrmc { get => mvrmc; set => mvrmc = value; }
        public string Wma { get => wma; set => wma = value; }
        public string Other { get => other; set => other = value; }
        public string Eap { get => eap; set => eap = value; }
        public string ProposedEap { get => proposedEap; set => proposedEap = value; }
        public string EapVariance { get => eapVariance; set => eapVariance = value; }
        public string SvgsPerEach { get => svgsPerEach; set => svgsPerEach = value; }
        public string BrmcUsageEa { get => brmcUsageEa; set => brmcUsageEa = value; }
        public string BrmcSvgs { get => brmcSvgs; set => brmcSvgs = value; }
        public string HckHcmhUsageEa { get => hckHcmhUsageEa; set => hckHcmhUsageEa = value; }
        public string HckHcmhSvgs { get => hckHcmhSvgs; set => hckHcmhSvgs = value; }
        public string HvmcUsageEa { get => hvmcUsageEa; set => hvmcUsageEa = value; }
        public string HvmcSvgs { get => hvmcSvgs; set => hvmcSvgs = value; }
        public string LphUsageEa { get => lphUsageEa; set => lphUsageEa = value; }
        public string LphSvgs { get => lphSvgs; set => lphSvgs = value; }
        public string MvrmcUsageEa { get => mvrmcUsageEa; set => mvrmcUsageEa = value; }
        public string MvrmcSvgs { get => mvrmcSvgs; set => mvrmcSvgs = value; }
        public string WmaUsageEa { get => wmaUsageEa; set => wmaUsageEa = value; }
        public string WmaSvgs { get => wmaSvgs; set => wmaSvgs = value; }
        public string OtherUsageEa { get => otherUsageEa; set => otherUsageEa = value; }
        public string OtherSvgs { get => otherSvgs; set => otherSvgs = value; }
        public string TotalUsage { get => totalUsage; set => totalUsage = value; }
        public string TotalSvgs { get => totalSvgs; set => totalSvgs = value; }

        public static List<Tracking> getTracking(String parmId)
		{
            OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
			OleDbCommand cmd = con.CreateCommand();
			con.Open();
			cmd.CommandText = "SELECT * FROM INITIATIVE_TRACKING WHERE INITIATIVE_ID='" + parmId + "'";
			cmd.Connection = con;
			OleDbDataReader Reader = cmd.ExecuteReader();
			List<Tracking> results = new List<Tracking>();
			if (Reader.HasRows)
			{
				while (Reader.Read())
				{
					Tracking currentObj = new Tracking();
					currentObj.quarter = Reader.IsDBNull(2) ? "" : Reader.GetString(2);
					currentObj.qrtStartDate = Reader.IsDBNull(3) ? "" : Reader.GetString(3);
					currentObj.qrtEndDate = Reader.IsDBNull(4) ? "" : Reader.GetString(4);
					currentObj.pmm = Reader.IsDBNull(5) ? "" : Reader.GetString(5);
					currentObj.unitOfMeasure = Reader.IsDBNull(6) ? "" : Reader.GetString(6);
					currentObj.packaging = Reader.IsDBNull(7) ? "" : Reader.GetString(7);
					currentObj.eachPice = Reader.IsDBNull(8) ? "" : Reader.GetString(8);
					currentObj.brmc = Reader.IsDBNull(9) ? "" : Reader.GetString(9);
					currentObj.hckHcmh = Reader.IsDBNull(10) ? "" : Reader.GetString(10);
					currentObj.hvmc = Reader.IsDBNull(11) ? "" : Reader.GetString(11);
					currentObj.lph = Reader.IsDBNull(12) ? "" : Reader.GetString(12);
					currentObj.mvrmc = Reader.IsDBNull(13) ? "" : Reader.GetString(13);
					currentObj.wma = Reader.IsDBNull(14) ? "" : Reader.GetString(14);
					currentObj.other = Reader.IsDBNull(15) ? "" : Reader.GetString(15);
					currentObj.proposedEap = Reader.IsDBNull(16) ? "" : Reader.GetString(16);
					currentObj.eapVariance = Reader.IsDBNull(17) ? "" : Reader.GetString(17);
					currentObj.svgsPerEach = Reader.IsDBNull(18) ? "" : Reader.GetString(18);
					currentObj.brmcUsageEa = Reader.IsDBNull(19) ? "" : Reader.GetString(19);
					currentObj.brmcSvgs = Reader.IsDBNull(20) ? "" : Reader.GetString(20);
					currentObj.hckHcmhUsageEa = Reader.IsDBNull(21) ? "" : Reader.GetString(21);
					currentObj.hckHcmhSvgs = Reader.IsDBNull(22) ? "" : Reader.GetString(22);
					currentObj.hvmcUsageEa = Reader.IsDBNull(23) ? "" : Reader.GetString(23);
					currentObj.hvmcSvgs = Reader.IsDBNull(24) ? "" : Reader.GetString(24);
					currentObj.lphUsageEa = Reader.IsDBNull(25) ? "" : Reader.GetString(25);
					currentObj.lphSvgs = Reader.IsDBNull(26) ? "" : Reader.GetString(26);
					currentObj.mvrmcUsageEa = Reader.IsDBNull(27) ? "" : Reader.GetString(27);
					currentObj.mvrmcSvgs = Reader.IsDBNull(28) ? "" : Reader.GetString(28);
					currentObj.wmaUsageEa = Reader.IsDBNull(29) ? "" : Reader.GetString(29);
					currentObj.wmaSvgs = Reader.IsDBNull(30) ? "" : Reader.GetString(30);
					currentObj.otherUsageEa = Reader.IsDBNull(31) ? "" : Reader.GetString(31);
					currentObj.otherSvgs = Reader.IsDBNull(32) ? "" : Reader.GetString(32);
					currentObj.totalUsage = Reader.IsDBNull(33) ? "" : Reader.GetString(33);
					currentObj.totalSvgs = Reader.IsDBNull(34) ? "" : Reader.GetString(34);


					results.Add(currentObj);
				}
			}
			return results;
		}
    }
}
