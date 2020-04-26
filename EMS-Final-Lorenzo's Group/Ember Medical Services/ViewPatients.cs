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
    public partial class ViewPatients : Form
    {
        private Ember_medical_service_db ember_Medical_Services_Db;
        private Patient_Details patient_Details;

        public ViewPatients()
        {
            InitializeComponent();
            ember_Medical_Services_Db = new Ember_medical_service_db();
        }

        private void ViewPatients_Load(object sender, EventArgs e)
        {
            var patientview = ember_Medical_Services_Db.Patient_Details_View.ToList();
            dg_patientlist.DataSource = patientview;
            dg_patientlist.Columns[0].HeaderText = "ID";
            dg_patientlist.Columns[1].HeaderText = "FIRST NAME";
            dg_patientlist.Columns[2].HeaderText = "LAST NAME";
            dg_patientlist.Columns[3].HeaderText = "GENDER";
            dg_patientlist.Columns[4].HeaderText = "D.O.B";
            dg_patientlist.Columns[5].HeaderText = "ADDRESS";
            dg_patientlist.Columns[6].HeaderText = "EMAIL";
            dg_patientlist.Columns[7].HeaderText = "PHONE";
            dg_patientlist.Columns[8].HeaderText = "EMERGENCY FIRST NAME";
            dg_patientlist.Columns[9].HeaderText = "EMERGENCY LAST NAME";
            dg_patientlist.Columns[10].HeaderText = "EMERGENCY ADDRESS";
            dg_patientlist.Columns[11].HeaderText = "EMERGENCY PHONE";
        }

       
        private void bt_editpatient_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dg_patientlist.SelectedRows[0].Cells["ID"].Value;
            var patient = ember_Medical_Services_Db.Patients.FirstOrDefault(q => q.id == id);
            var editpatient = new Edit_Patient(patient);
            editpatient.MdiParent = this.MdiParent;
            editpatient.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void bt_deletepatient_Click(object sender, EventArgs e)
        {
            try
            {
            var id = (int)dg_patientlist.SelectedRows[0].Cells["ID"].Value;
            var patient = ember_Medical_Services_Db.Patients.FirstOrDefault(q => q.id == id);

           
                    ember_Medical_Services_Db.Patients.Remove(patient);
                    ember_Medical_Services_Db.SaveChanges();
               

               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void tb_pat_search_TextChanged(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please ");
            }
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            ViewPatients viewPatients = new ViewPatients();
            viewPatients.Refresh();
        }
    }
}
