using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomUser.Model;

namespace RandomUser
{
    class GenerateUser
    {
        public results GetUser()
        {
            string URL = "https://randomuser.me/api/?results=10";
            ServiceUser serUser = new ServiceUser(URL);

            serUser.GetUsers();

            Users users = serUser.GetUsers();

            return users.results[0];
        }
    }
}
