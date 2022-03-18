using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_s_Housing_Management_Application.Data_Access_Layer
{
    class DataAccess : IDisposable
    {
        SqlConnection con;
        SqlCommand command;
        public DataAccess()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["BHMS"].ConnectionString);
            con.Open();
        }


        public void Dispose()
        {
            con.Close();
        }

        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, con);
            return command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, con);
            return command.ExecuteNonQuery();
        }
    }
}
