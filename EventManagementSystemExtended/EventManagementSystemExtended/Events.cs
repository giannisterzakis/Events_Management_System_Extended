using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystemExtended
{
    public class Events
    {
        // Create private attributes
        private string id;
        private string startDate;
        private string endDate;
        private string location;
        private string capacity;
        private string cost;

        // Public properties to access private variables 
        public string ID { get => id; set => id = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string Location { get => location; set => location = value; }
        public string Capacity { get => capacity; set => capacity = value; }
        public string Cost { get => cost; set => cost = value; }

        // Constructor without any parameters
        public Events()
        {
            id = "Not set";
            startDate = "Not set";
            endDate = "Not set";
            location = "Not set";
            capacity = "Not set";
            cost = "Not set";
        }

        // Constructor with 6 parameters both string and int
        public Events(string pID, string pStartDate, string pEndDate, string pLocation, string pCapacity, string pCost)
        {
            id = pID;
            startDate = pStartDate;
            endDate = pEndDate;
            location = pLocation;
            capacity = pCapacity;
            cost = pCost;
        }

        //ToString Method
        public override string ToString()
        {
            return ID + "       " + StartDate + "     " + EndDate
                + "      " + Location + "          " + Capacity
                + "                   " + Cost;
        }
    }
}
