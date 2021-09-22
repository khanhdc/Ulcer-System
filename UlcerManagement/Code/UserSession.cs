using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UlcerManagement.Code
{
    [Serializable]
    public class UserSession
    {
        public string userName { get; set; }
        public int userID { get; set; }
        public int groupID { get; set; }
        public int addedBy { get; set; }
        public string  fullName { get; set; }
        public string profileImage { get; set; }
    }
}