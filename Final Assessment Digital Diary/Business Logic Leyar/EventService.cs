using Final_Assessment_Digital_Diary.Data_Access_Leyar;
using Final_Assessment_Digital_Diary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assessment_Digital_Diary.Business_Logic_Leyar
{
    class EventService
    {
        EventDataAccess eventDataAccess;

        public object Event { get; private set; }
        public object Title { get; }

        public EventService()
        {
            eventDataAccess = new EventDataAccess();
        }

        public List<Create_Event> GetCreateEvenstList()
        {
            return eventDataAccess.GetAllCreateEvents();
        }

        public int AddNewEvent(string title,string importancy,string message,string date)
        {
            Create_Event create_Event = new Create_Event()
            { Title = title,
               Importancy = importancy,
                Message = message,
                Date = date,
            };
            return this.eventDataAccess.InsertEvent(create_Event);


        }

        public int UpdateEvent(int eventid, string message)
        {
            Create_Event create_Event = new Create_Event()
            {
                EventId = eventid,
                Message = message,

            };
            return this.eventDataAccess.UpdateEvent(create_Event);


        }

        public int DeleteEvent(int eventid)
        {
           
            return this.eventDataAccess.DeleteEvent(eventid);


        }
    }
}
