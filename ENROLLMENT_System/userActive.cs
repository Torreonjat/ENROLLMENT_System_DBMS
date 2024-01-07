using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENROLLMENT_System
{
    class userActive
    {
        public int userid { get; set; }
        public string Username { get; set; }

        public userActive(int userId, string username)
        {
            userid = userId;
            Username = username;
        }

        public static class CurrentUser
        {
            public static userActive User { get; set; }
        }
    }
}
