using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystemExtended
{
    class Hospitality : Events
    {
        // Create private attribute
        private string eveningMeal;

        // Public property to access the private variable
        public string EveningMeal { get => eveningMeal; set => eveningMeal = value; }

        // Constructor without any parameters
        public Hospitality()
        {
            eveningMeal = "Not set";
        }

        // Constructor with 7 input parameters
        public Hospitality(string pID, string pStartDate, string pEndDate, string pLocation, string pCapacity, string pCost, string pEveningMeal) : base(pID, pStartDate, pEndDate, pLocation, pCapacity, pCost)
        {
            eveningMeal = pEveningMeal;
        }

        // Overriden ToString() Method
        public override string ToString()
        {
            return base.ToString() + "                  " + eveningMeal;
        }
    }
}
