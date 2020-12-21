using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiryFinal
{
    class UserDataAccess
    {

        DataAccesscs dataAccesscs;
        public UserDataAccess()
        {
            this.dataAccesscs = new DataAccesscs();
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE UserName='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = dataAccesscs.GetData(sql);
            if (reader.Read())
            {
                Utility.UserId = int.Parse(reader["Id"].ToString());
                return true;
            }
            this.dataAccesscs.CloseConnection();

            return false;
        }
    }
}
