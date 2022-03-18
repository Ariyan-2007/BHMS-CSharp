using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_s_Housing_Management_Application.Data_Access_Layer
{
    class FODataAccess
    {
        public static int AddUser(FOData f)
        {
            DataAccess da = new DataAccess();

            string sql = "INSERT INTO FlatOwners_Info(Username,FullName,Password,Number,Gender,DateOfBirth,Address,Picture) VALUES('" + f.Username + "','" + f.FullName + "','" + f.Password + "','" + f.PhoneNumber + "','" + f.Gender + "' ,'" + f.DOB + "' ,'" + f.Address + "' ,'" + f.Picture + "')";

            return da.ExecuteQuery(sql);
        }

        public static String GetUserInfo(string x, FOData f)
        {
            DataAccess da = new DataAccess();
            string info=" ";
            string sql = "SELECT " + x + " FROM FlatOwners_Info WHERE Username  = '" + f.Username + "'";

            SqlDataReader reader = da.GetData(sql);
            while(reader.Read())
            {
                if (!(reader[x].Equals(System.DBNull.Value)))
                {
                    info = reader[x].ToString();
                }
                else
                {
                    info = "0";
                }
            }

            return info;
        }

        public static void UpdateUserInfo(string x, string y, FOData f)
        {
            DataAccess da = new DataAccess();
            string sql;

            if (x == "Balance")
            {
                sql = "UPDATE FlatOwners_Info SET " + x + " = " + float.Parse(y) + " WHERE Username = '" + f.Username + "'";
            }
            else
            {
                sql = "UPDATE FlatOwners_Info SET " + x + " = '" + y + "' WHERE Username = '" + f.Username + "'";
            }

            da.ExecuteQuery(sql);
        }
    }
}
