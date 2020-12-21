using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Assessment_Digital_Diary.Entities;

namespace Final_Assessment_Digital_Diary.Data_Access_Leyar
{
    class EventDataAccess
    {
        DatabaseConnection databaseConnection;
        public EventDataAccess()
        {
            this.databaseConnection = new DatabaseConnection();
        }

        public List<Create_Event> GetAllCreateEvents()
        {
            string sql = "SELECT * FROM Events";
            SqlDataReader reader = databaseConnection.GetData(sql);

            List<Create_Event> events = new List<Create_Event>();

            while (reader.Read())
            {
                Create_Event create_Event = new Create_Event();
                create_Event.EventId = (int)reader["EventId"];
                create_Event.Title = reader["Title"].ToString();
                create_Event.Importancy = reader["Importancy"].ToString();
                create_Event.Message = reader["Message"].ToString();
                //create_Event.DateOfBirth = reader["DateOfBirth"].ToString();
                events.Add(create_Event);
            }

            return events;
        }

        public Create_Event GetEvent(int id)
        {
            string sql = "SELECT * FROM Events WHERE EventId=" + id;
            SqlDataReader reader = databaseConnection.GetData(sql);
            reader.Read();
            Create_Event create_Event = new Create_Event();
            create_Event.EventId = (int)reader["EventId"];
            create_Event.Title = reader["Title"].ToString();
            create_Event.Importancy = reader["Importancy"].ToString();
            create_Event.Message = reader["Message"].ToString();
            //create_Event.DateOfBirth = reader["DateOfBirth"].ToString();

            return create_Event;
        }


        public int InsertEvent(Create_Event create_Event)
        {
            string sql = "INSERT INTO Events(Title,Importancy,Message) VALUES('" + create_Event.Title + "','" + create_Event.Importancy + "','" + create_Event.Message + "')";
            int result = databaseConnection.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEvent(Create_Event create_Event)
        {
            string sql = "UPDATE Events SET Title='" + create_Event.Title + "',Importancy='" + create_Event.Importancy + "',Message='" + create_Event.Message + "',DateOfBirth='" + create_Event.DateOfBirth + "' WHERE Events=" + create_Event.EventId;
            int result = databaseConnection.ExecuteQuery(sql);
            return result;
        }

        public int DeleteEvent(int id)
        {
            string sql = "DELETE FROM Events WHERE EventId=" + id;
            int result = databaseConnection.ExecuteQuery(sql);
            return result;
        }

        

    }
}
