using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ember_Medical_Services
{
    public partial class Patient_Details2 : Form
    {

        public string Username;
       


        public Patient_Details2()
        {
            InitializeComponent();
        }
    
       
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show($"{Username} Successfully Added");
        }

        private void b_back_Click(object sender, EventArgs e)
        {

        }
    }
}
