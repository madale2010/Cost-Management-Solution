using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Management_Solution
{
    class DatabaseHelper
    {
        private static OleDbConnection connection = new OleDbConnection(Constants.DB_CON_STRING);

        public OleDbConnection Connection { get => connection; set => connection = value; }
       
        
        public static int insert(OleDbCommand cmd)
        {
            int results = 0;
            cmd.Connection = connection;
            connection.Open();
            results = cmd.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Finished inserting record.");
            return results;

        }
        public static OleDbDataReader select(String query, String parmValue)
        {
            OleDbConnection con = new OleDbConnection(Constants.DB_CON_STRING);
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("?", parmValue);
            con.Open();
            connection.Close();
            return cmd.ExecuteReader();
        }
    }
}
