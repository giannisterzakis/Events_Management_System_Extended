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
    public partial class AddHospitalityForm : Form
    {
        public AddHospitalityForm()
        {
            InitializeComponent();
        }

        public Events GetData()
        {
            return new Hospitality(txtID.Text, txtStart.Text, txtEnd.Text, txtLocation.Text, txtCapacity.Text, txtCost.Text, txtMeal.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void AddHospitalityForm_Load(object sender, EventArgs e)
        {

        }
    }
}
