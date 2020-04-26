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
    public partial class ViewStaffs : Form
    {
        private Ember_medical_service_db ember_Medical_Services_Db;
        public ViewStaffs()
        {
            InitializeComponent();
            ember_Medical_Services_Db = new Ember_medical_service_db();
        }

        private void ViewStaffs_Load(object sender, EventArgs e)
        {
            var staffview = ember_Medical_Services_Db.staff_members.ToList();
            dg_staffmembers.DataSource = staffview;
        }
    }
}
