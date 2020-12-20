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
        public EventService()
        {
            eventDataAccess = new EventDataAccess();
        }

        public List<Create_Event> GetCreateEvenstList()
        {
            return eventDataAccess.GetAllCreateEvents();
        }

        
    }
}
