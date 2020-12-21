using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assessment_Digital_Diary.Entities
{
    class Create_Event
    {

        public int EventId { get; set; }
        public string Title { get; set; }

        public string Importancy { get; set; }

        public string Message { get; set; }

        public string DateOfBirth { get; set; }

        /*public static implicit operator Create_Event(Create_Event v)
        {
            throw new NotImplementedException();
        }*/
    }
}
