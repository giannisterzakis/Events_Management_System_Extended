using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystemExtended
{
    class EventList
    {
        //declare private list for events        
        private List<Events> eventList;

        // Public Property        
        public List<Events> events { get => eventList; set => eventList = value; }

        //creating constructor to hold lists         
        public EventList()
        {
            eventList = new List<Events>();
        }

        //methods to add event to list        
        public void AddEvent(Events e)
        {
            // TO DO  
            // Add further validation  
            events.Add(e);
        }

        public void DeleteEvent(Events e)
        {
            // This functionality could be extended / improved.              
            events.Remove(e);
        }
    }
}
