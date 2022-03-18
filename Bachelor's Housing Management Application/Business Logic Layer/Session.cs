using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_s_Housing_Management_Application.Business_Logic_Layer
{
    class Session
    {
        
        private static string userName;
        public static int count=1;
        public static void SetUserName(string x)
        {
            userName = x;
        }

        public static string GetUserName()
        {
            return userName;
        }


        public static void Clear()
        {
            userName = " ";
            count = 1;
        }
    }
}
