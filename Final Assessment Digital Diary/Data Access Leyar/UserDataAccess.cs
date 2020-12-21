using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assessment_Digital_Diary.Data_Access_Leyar
{
    class UserDataAccess
    {
        private DatabaseConnection databaseConnection;
        public UserDataAccess()
        {
            this.databaseConnection = new DatabaseConnection();
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='"+username+"' AND Password='"+password+"'";
            SqlDataReader reader = databaseConnection.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            else
                return false;
        }
    }
}
