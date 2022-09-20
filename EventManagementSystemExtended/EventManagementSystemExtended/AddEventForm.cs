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
    public partial class AddEventForm : Form
    {
        public AddEventForm()
        {
            InitializeComponent();
        }

        public Events GetData()
        {
            return new Events(txtID.Text, txtStart.Text, txtEnd.Text, txtLocation.Text, txtCapacity.Text, txtCost.Text);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void lblLocation_Click(object sender, EventArgs e)
        {

        }
    }
}
