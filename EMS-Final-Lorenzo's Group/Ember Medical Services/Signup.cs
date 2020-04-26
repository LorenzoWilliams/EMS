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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Registration Successful {tb_firstname.Text} {tb_lastname.Text}");

         

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
