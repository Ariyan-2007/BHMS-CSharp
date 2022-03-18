using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_s_Housing_Management_Application.Data_Access_Layer
{
    class BDataAccess
    {
        public static int AddUser(BData b)
        {
            DataAccess da = new DataAccess();

            string sql = "INSERT INTO Bachelors_Info(Username,FullName,Password,Number,Gender,DateOfBirth,Picture) VALUES('" + b.Username + "','" + b.FullName + "','" + b.Password + "','" + b.PhoneNumber + "','" + b.Gender + "' ,'" + b.DOB + "' ,'" + b.Picture + "')";
            
            return da.ExecuteQuery(sql);
        }

        public static String GetUserInfo(string x, BData b)
        {
            DataAccess da = new DataAccess();
            string info = " ";
            string sql = "SELECT " + x + " FROM Bachelors_Info WHERE Username  = '" + b.Username + "'";
            
            SqlDataReader reader = da.GetData(sql);
            while (reader.Read())
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

        public static void UpdateUserInfo(string x, string y, BData b)
        {
            DataAccess da = new DataAccess();
            string sql;

            if (x == "Balance")
            {
                sql = "UPDATE Bachelors_Info SET " + x + " = " + float.Parse(y) + " WHERE Username = '" + b.Username + "'";
            }
            else
            {
                sql = "UPDATE Bachelors_Info SET " + x + " = '" + y + "' WHERE Username = '" + b.Username + "'";
            }

            da.ExecuteQuery(sql);
        }

        public static void SetFID(BData b)
        {
            DataAccess da = new DataAccess();

            string sql = "UPDATE Bachelors_Info SET FID = " + b.FID + " WHERE Username = '"+b.Username+"'";

            da.ExecuteQuery(sql);
        }

        public static void ResetFID(BData b)
        {
            DataAccess da = new DataAccess();

            string sql = "UPDATE Bachelors_Info SET FID = NULL WHERE Username = '" + b.Username + "'";

            da.ExecuteQuery(sql);
        }
    }
}
