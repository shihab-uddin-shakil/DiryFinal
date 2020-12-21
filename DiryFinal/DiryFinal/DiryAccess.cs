using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiryFinal
{
    class DiryAccess
    {
        DataAccesscs dataAccess;
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["Task1"].ConnectionString;
        public DiryAccess()
        {
            this.dataAccess = new DataAccesscs();
        }

        public List<Diry> GetEvents()
        {
            string sql = "SELECT * FROM DiryTabel";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Diry> diries = new List<Diry>();
            while (reader.Read())
            {
                Diry diry = new Diry();
                diry.Number = (int)reader["Id"];
                diry.UserId = (int)reader["UserId"];
                diry.Experience = reader["Experience"].ToString();
                diry.Thought = reader["Thought"].ToString();
                diry.Fellings = reader["Fellings"].ToString();
                diry.Importance = reader["Importance"].ToString();
                // diry.Picture= reader["Picture"].ToString();
                diry.EventDate = reader["EventDate"].ToString();
                diries.Add(diry);
            }
            return diries;
        }
        public List<Diry> GetEvent()
        {
            string sql = "SELECT * FROM DiryTabel WHERE UserId=" + Utility.UserId;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Diry> diries = new List<Diry>();
            while (reader.Read())
            {
                Diry diry = new Diry();
                diry.Number = (int)reader["Id"];
                diry.UserId = (int)reader["UserId"];
                diry.Experience = reader["Experience"].ToString();
                diry.Thought = reader["Thought"].ToString();
                diry.Fellings = reader["Fellings"].ToString();
                diry.Importance = reader["Importance"].ToString();
                //diry.Picture = (byte[])reader["Picture"];
                diry.EventDate = reader["EventDate"].ToString();
                diries.Add(diry);
            }
            return diries;
        }
        public int InsertEvent(Diry diary)
        {
            var sql = "INSERT INTO DiryTabel(UserId,Experience,Thought,Fellings,Importance,Picture,EventDate) VALUES('" + Utility.UserId + "','" + diary.Experience + "','" + diary.Thought + "','" + diary.Fellings + "','" + diary.Importance + "','" + diary.Picture + "','" + diary.EventDate + "')";

            using (var sqlCon = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand(@sql, sqlCon);
                sqlCon.Open();
                var isInserted = cmd.ExecuteNonQuery();
                sqlCon.Close();
                return isInserted;
            }
        }

        public int UpdateEvent(Diry diry)
        {
            string sql = "UPDATE DiryTabel SET Experience='" + diry.Experience + "',Thought=" + diry.Thought + ",Fellings=" + diry.Fellings + ",Importance=" + diry.Importance + " Picture=" + diry.Picture + " EventDate=" + diry.EventDate + " WHERE ProductId=" + diry.Number;
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int DeleteEvent(int id)
        {
            string sql = "DELETE FROM DiryTabel WHERE Id=" + id;
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }
        public void CloseConnection()
        {
            this.dataAccess.CloseConnection();
        }

    }
}
