using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_17
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public int Password { get; set; }
        public string Email { get; set; }

        public UserInfo(string email, string username,int password )
        {
            Email = email;
            UserName = username;
            Password = password;

        }
        

    }
}
