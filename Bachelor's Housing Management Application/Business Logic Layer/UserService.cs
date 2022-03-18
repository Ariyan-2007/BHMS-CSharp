using Bachelor_s_Housing_Management_Application.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_s_Housing_Management_Application.Business_Logic_Layer
{
    class UserService
    {
        public static int AddUserB(string username, string fullName, string password, string phoneNumber, string gender, string dob, string picture )
        {
            BData b = new BData() { Username = username, FullName = fullName, Password = password, PhoneNumber = phoneNumber, Gender = gender, DOB = dob, Picture = picture };
            return BDataAccess.AddUser(b);
        }

        public static void SetFID(int fid, string username)
        {
            BData b = new BData() { FID = fid, Username = username };
            BDataAccess.SetFID(b);
        }

        public static void ResetFID(string username)
        {
            BData b = new BData() { Username = username };
            BDataAccess.ResetFID(b);
        }

        public static int AddUserFO(string username, string fullName, string password, string phoneNumber, string gender, string dob, string address, string picture)
        {
            FOData f = new FOData() { Username = username, FullName = fullName, Password = password, PhoneNumber = phoneNumber, Gender = gender, DOB = dob, Address = address, Picture = picture };
            return FODataAccess.AddUser(f);
        }

        public static string GetUserInfoB(string target, string username)
        {
            BData b = new BData() { Username = username };

            return BDataAccess.GetUserInfo(target, b);
        }

        public static string GetUserInfoFO(string target, string username)
        {
            FOData f = new FOData() { Username = username };

            return FODataAccess.GetUserInfo(target, f);
        }

        public static void UpdateUserInfoB(string target, string update, string username)
        {

            BData b = new BData() { Username = username };

            BDataAccess.UpdateUserInfo(target, update, b);
        }

        public static void UpdateUserInfoFO(string target, string update, string username)
        {

            FOData f = new FOData() { Username = username };

            FODataAccess.UpdateUserInfo(target, update, f);
        }
    }
}
