using Bachelor_s_Housing_Management_Application.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_s_Housing_Management_Application.Business_Logic_Layer
{
    class AdService
    {
        public static void ReSeed(string x,int y)
        {
            ADDataAccess.ReSeed(x,y);
        }
        public static int GetFID()
        {
            return ADDataAccess.GetFID()+1;
        }

        public static void SetFID(int x)
        {
            ADDataAccess.SetFID(x);
        }

        public static int GetADCount()
        {
            return ADDataAccess.GetADCount();
        }

        public static int GetADCount(string location)
        {
            ADData a = new ADData() { Location = location };

            return ADDataAccess.GetADCount(a);
        }

        public static int GetADCount(string username, int x)
        {
            ADData a = new ADData() { Username = username };

            return ADDataAccess.GetADCount(a,x);
        }

        public static int AddPicture(string path)
        {
            ADData a = new ADData() {Path = path  };

            return ADDataAccess.AddPicture(a);
        }

        public static int GetPictureCount(int fid)
        {
            ADData a = new ADData() { FID = fid };
            return ADDataAccess.GetPictureCount(a);
        }

        public static string GetPicture(string target, int fid, int count)
        {
            ADData a = new ADData() { FID = fid };

            return ADDataAccess.GetPicture(target, a, count);
        }

        public static int AddAdvertisement(string username, string flatName, string location, string address, string rooms, string rent, string services, string status)
        {
            ADData a = new ADData() { Username = username, FlatName = flatName, Location = location, Address = address, Rooms = rooms, Rent = rent, Services = services, Status = status };
            return ADDataAccess.AddAdvertisement(a);
        }

        public static string GetADInfo(string target, string username, int count)
        {
            ADData a = new ADData() { Username = username };

            return ADDataAccess.GetADInfo(target, a, count);
        }

        public static string ADSearch(string target, string location, int count)
        {
            ADData a = new ADData() { Location = location };

            return ADDataAccess.ADSearch(target, a, count);
        }

        public static string GetADDetails(string target, int fid)
        {
            ADData a = new ADData() { FID = fid };

            return ADDataAccess.GetADDetails(target, a);
        }

        

        public static void DeleteAdvertisement(int FID)
        {
            ADDataAccess.DeleteAdvertisement(FID);
        }

        public static void ModifyAdvertisement(int fid, string status)
        {
            ADData a = new ADData() { FID = fid, Status = status };

            ADDataAccess.ModifyAdvertisement(a);
        }
    }
}
