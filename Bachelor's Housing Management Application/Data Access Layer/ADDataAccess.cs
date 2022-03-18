using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_s_Housing_Management_Application.Data_Access_Layer
{
    class ADDataAccess
    {
        public static void ReSeed(string x,int y)
        {
            DataAccess da = new DataAccess();
            string sql = "DBCC CHECKIDENT ('"+ x +"', RESEED, "+(y-1)+")";
            da.ExecuteQuery(sql);
        }
        public static int GetFID()
        {
            DataAccess da = new DataAccess();
            int id = 100;
            string sql = "SELECT max(FID) AS FID FROM Ad_Info";

            SqlDataReader reader = da.GetData(sql);
            while (reader.Read())
            {
                if (!(reader["FID"].Equals(System.DBNull.Value)))
                {
                    id = (int)reader["FID"];
                }
                
            }

            return id;
        }
        public static void SetFID(int x)
        {
            DataAccess da = new DataAccess();

            string sql = "UPDATE Picture_Info SET FID = " + x + " WHERE FID IS NULL";

            da.ExecuteQuery(sql);
        }

        public static int GetADCount()
        {
            DataAccess da = new DataAccess();
            int count = 0;
            string sql = "SELECT COUNT(Username) AS COUNT FROM Ad_Info";

            SqlDataReader reader = da.GetData(sql);
            while (reader.Read())
            {
                if (!(reader["COUNT"].Equals(System.DBNull.Value)))
                {
                    count = (int)reader["COUNT"];
                }

            }

            return count;
        }
        public static int GetADCount(ADData a)
        {
            DataAccess da = new DataAccess();
            int count = 0;
            string sql = "SELECT COUNT(Location) AS COUNT FROM Ad_Info WHERE Location ='"+a.Location+"'";

            SqlDataReader reader = da.GetData(sql);
            while (reader.Read())
            {
                if (!(reader["COUNT"].Equals(System.DBNull.Value)))
                {
                    count = (int)reader["COUNT"];
                }

            }

            return count;
        }

        public static int GetADCount(ADData a,int x)
        {
            DataAccess da = new DataAccess();
            int count = 0;
            string sql = "SELECT COUNT(Username) AS COUNT FROM Ad_Info WHERE Username ='" + a.Username + "'";

            SqlDataReader reader = da.GetData(sql);
            while (reader.Read())
            {
                if (!(reader["COUNT"].Equals(System.DBNull.Value)))
                {
                    count = (int)reader["COUNT"];
                }

            }

            return count;
        }

        public static String GetADInfo(string x, ADData a, int z)
        {
            DataAccess da = new DataAccess();
            string info = "";
            string sql = "SELECT " + x + " FROM Ad_Info WHERE Username  = '" + a.Username + "'";
            
            SqlDataReader reader = da.GetData(sql);

            for (int i = 0; i <= z; i++)
            {

                if (reader.Read() == true)
                    info = reader[x].ToString();

            }

            return info;
        }

        public static String ADSearch(string x, ADData a, int z)
        {
            DataAccess da = new DataAccess();
            string info = "";
            string sql = "SELECT " + x + " FROM Ad_Info WHERE Location  = '" + a.Location + "'";

            SqlDataReader reader = da.GetData(sql);

            for (int i = 0; i <= z; i++)
            {

                if (reader.Read() == true)
                    info = reader[x].ToString();

            }

            return info;
        }

        public static String GetADDetails(string x, ADData b)
        {
            DataAccess da = new DataAccess();
            string info = " ";
            string sql = "SELECT " + x + " FROM Ad_Info WHERE FID  = " + b.FID ;

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

        public static int AddPicture(ADData a)
        {
            DataAccess da = new DataAccess();

            string sql = "INSERT INTO Picture_Info(Path) VALUES('" + a.Path + "')";

            return da.ExecuteQuery(sql);
        }

        public static String GetPicture(string x, ADData a, int z)
        {
            DataAccess da = new DataAccess();
            string info = "";
            string sql = "SELECT " + x + " FROM Picture_Info WHERE FID  = " + a.FID ;

            SqlDataReader reader = da.GetData(sql);

            for (int i = 0; i <= z; i++)
            {

                if (reader.Read() == true)
                    info = reader[x].ToString();

            }

            return info;
        }

        public static int GetPictureCount(ADData a)
        {
            DataAccess da = new DataAccess();
            int count = 0;
            string sql = "SELECT COUNT(FID) AS COUNT FROM Picture_Info WHERE FID ="+a.FID;

            SqlDataReader reader = da.GetData(sql);
            while (reader.Read())
            {
                if (!(reader["COUNT"].Equals(System.DBNull.Value)))
                {
                    count = (int)reader["COUNT"];
                }

            }

            return count;
        }

        public static int AddAdvertisement(ADData a)
        {
            DataAccess da = new DataAccess();

            string sql = "INSERT INTO Ad_Info(Username,FlatName,Location,Address,Rooms,Rent,Services,Status) VALUES('" + a.Username + "','" + a.FlatName + "','" + a.Location + "','" + a.Address + "'," + Convert.ToInt32(a.Rooms) + " ," + float.Parse(a.Rent) + " ,'" + a.Services + "' ,'" + a.Status + "')";
            
            return da.ExecuteQuery(sql);
        }

        public static void DeleteAdvertisement(int x)
        {
            DataAccess da = new DataAccess();

            string sql1 = "DELETE FROM Picture_Info WHERE FID = "+x;

            da.ExecuteQuery(sql1);

            string sql2 = "DELETE FROM Ad_Info WHERE FID = "+ x;

            da.ExecuteQuery(sql2);
        }

        public static void ModifyAdvertisement(ADData a)
        {
            DataAccess da = new DataAccess();

            string sql = "UPDATE AD_Info SET Status = '"+a.Status+"' WHERE FID ="+a.FID;

            da.ExecuteQuery(sql);
        }

        
    }
}
