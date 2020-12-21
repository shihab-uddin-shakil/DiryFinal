using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiryFinal
{
    class UserDataServices
    {

        UserDataAccess userDataAccess;
        public UserDataServices()
        {
            this.userDataAccess = new UserDataAccess();
        }

        public bool LoginValidation(string username, string password)
        {
            return userDataAccess.LoginValidation(username, password);
        }
    }
}
