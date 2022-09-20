using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystemExtended
{
    public partial class Form1 : Form
    {
        //Test EventList class
        // Create newEvent
        EventList newEvent = new EventList();

        public Form1()
        {
            InitializeComponent();

            AddData();

            lstEvents.Items.Clear();

            foreach (Events e in newEvent.events)
            {
                // Polymorphism
                lstEvents.Items.Add(e.ToString());
                lstEvents.Items.Add("");
            }

            LoadEvents();
        }


        private void AddData()
        {
            //Test EventList class
            // Adding objects to the List
            newEvent.AddEvent(new Hospitality("24", "12/13/2020", "12/15/2020", "Mowbray ", "500", "70", "Yes"));
            newEvent.AddEvent(new Hospitality("72", "12/21/2020", "12/25/2020", "Penshaw ", "200", "40", "Yes"));
            newEvent.AddEvent(new Events("14", "12/04/2020", "12/10/2020", "St Peter's", "150", "30"));
            newEvent.AddEvent(new Events("56", "12/01/2020", "12/05/2020", "Seaburn  ", "100", "30"));
            newEvent.AddEvent(new Events("67", "12/08/2020", "12/12/2020", "Penshaw ", "300", "55"));
            newEvent.AddEvent(new Events("70", "12/19/2020", "12/20/2020", "Mowbray ", "250", "50"));
            newEvent.AddEvent(new Hospitality("53", "12/25/2020", "12/29/2020", "Penshaw ", "150", "35", "No"));
            newEvent.AddEvent(new Hospitality("47", "12/22/2020", "12/27/2020", "Mowbray ", "450", "90", "Yes"));
            newEvent.AddEvent(new Events("93", "12/03/2020", "12/05/2020", "Penshaw ", "150", "40"));
            newEvent.AddEvent(new Events("27", "12/13/2020", "12/15/2020", "Mowbray ", "250", "45"));
            newEvent.AddEvent(new Hospitality("44", "12/02/2020", "12/09/2020", "Mowbray ", "380", "75", "Yes"));
            
            // Remove objects from the List
            newEvent.DeleteEvent(new Hospitality("44", "12/25/2020", "12/29/2020", "St Peters", "100", "25", "No"));
        }
        public void LoadEvents()
        {
            // New List to hold the types of different Events
            List<string> eventTypes = new List<string>();

            foreach (Events thisEvent in newEvent.events)
            {
                // Get the type
                string s = thisEvent.GetType().Name;

                // Get the parent type
                string baseType = thisEvent.GetType().BaseType.Name;

                // check if type is in the ComboBox
                if (!eventTypes.Contains(s))
                {
                    eventTypes.Add(s);
                }
                // check if base is on List
                if (!eventTypes.Contains(baseType))
                {
                    eventTypes.Add(baseType);
                }
            }

            // Set Data source
            cboEvents.DataSource = eventTypes;
        }

        // ComboBox
        private void cboEvents_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Clear the lstEvents
            lstEvents.DataSource = null;
            lstEvents.Items.Clear();

            // iteratre through the List of Events
            foreach (var i in newEvent.events)
            {
                // determine the type that we are looking for
                if (i.GetType().Name == cboEvents.SelectedItem.ToString())
                {
                    lstEvents.Items.Add(i);
                }
                // Check if the base type is equal to the current selection
                else if (i.GetType().BaseType.Name == cboEvents.SelectedItem.ToString())
                {
                    lstEvents.Items.Add(i);
                }
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            Events newevent;

            AddEventForm addForm = new AddEventForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                newevent = addForm.GetData();  //get new Event information

                //add the Event to the List
                newEvent.AddEvent(newevent);

                LoadEvents();
            }
        }

        private void btnAddHospitalityEvent_Click(object sender, EventArgs e)
        {
            Events newevent;

            AddHospitalityForm addForm = new AddHospitalityForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                newevent = addForm.GetData();  //get new Event information

                //add the Event to the List
                newEvent.AddEvent(newevent);

                LoadEvents();
            }
        }

        private void lblLocation_Click(object sender, EventArgs e)
        {

        }

        private void lblCost_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

