using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_s_Housing_Management_Application.Data_Access_Layer
{
    class ADData
    {
        public string FlatName { get; set; }
        public string Username { get; set; }
        public int FID { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Rooms { get; set; }
        public string Rent { get; set; }
        public string Services { get; set; }
        public string Status { get; set; }

        public int PID { get; set; }
        public string Path { get; set; }

    }
}
