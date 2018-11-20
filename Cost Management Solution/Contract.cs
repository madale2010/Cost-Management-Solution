using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Management_Solution
{
    class Contract
    {
        private String initiativeId;
		private String approvedVendor;
		private String type;
		private String number;
		private String tier;
		private String awardDate;
		private String startDate;
		private String endDate;
		private String signedDate;

		public static Contract getContractInfo(Double parmId)
		{
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Q:\\share\\Materials Management\\Savings Tracking\\Adam Dale\\Automation\\Access\\Supply Chain.accdb");
			OleDbCommand cmd = con.CreateCommand();
			con.Open();
			cmd.CommandText = "SELECT * FROM INITIATIVE_CONTRACT WHERE INITIATIVE_ID='" + parmId + "'";
			cmd.Connection = con;
			OleDbDataReader Reader = cmd.ExecuteReader();
			Contract currentItem = new Contract();
			if (Reader.Read())
			{
					currentItem.initiativeId = Reader.GetString(0);
					currentItem.approvedVendor = Reader.IsDBNull(1) ? "" : Reader.GetString(1);
					currentItem.type = Reader.IsDBNull(2) ? "" : Reader.GetString(2);
					currentItem.number = Reader.IsDBNull(3) ? "" : Reader.GetString(6);
					currentItem.tier = Reader.IsDBNull(4) ? "" : Reader.GetString(4);
					currentItem.awardDate = Reader.IsDBNull(5) ? "" : Reader.GetString(5);
					currentItem.startDate = Reader.IsDBNull(6) ? "" : Reader.GetString(6);
					currentItem.endDate = Reader.IsDBNull(7) ? "" : Reader.GetString(7);
					currentItem.signedDate = Reader.IsDBNull(8) ? "" : Reader.GetString(8);   
			}
			return currentItem;
		}
    }
}
