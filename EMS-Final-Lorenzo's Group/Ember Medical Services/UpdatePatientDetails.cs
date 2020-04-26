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
    public partial class Edit_Patient : Form
    {
        private Ember_medical_service_db ember_Medical_Services_Db;


        public Edit_Patient(Patient patient)
        {
            InitializeComponent();
            ember_Medical_Services_Db = new Ember_medical_service_db();
            PopulateFields(patient);
        }

        private void PopulateFields(Patient patient)
        {
            
            dtp_dob.Text.ToString();



            lbid.Text = patient.id.ToString();
            tb_ptfirstname.Text = patient.FirstName;
            tb_ptlastname.Text = patient.LastName;
            tb_emailaddress.Text = patient.Email;
            tb_phone.Text = patient.Phone;
            cb_gender.Text = patient.Gender;         
            dtp_dob.Value = patient.D_O_B;
            tb_address.Text = patient.Address;
            tb_firstname_em.Text = patient.FirstName_em;
            tb_lastname_em.Text = patient.LastName_em;
            tb_phone_em.Text = patient.Phone_em;
            tb_address_em.Text = patient.Address_em;
        
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // try
            // {
            ViewPatients viewPatients = new ViewPatients();
            Patient patient = new Patient();

            var id = int.Parse(lbid.Text);
            patient = ember_Medical_Services_Db.Patients.FirstOrDefault(q => q.id == id);
            patient.FirstName = tb_ptfirstname.Text;
            patient.LastName = tb_ptlastname.Text;
            patient.Email = tb_emailaddress.Text;
            patient.Gender = cb_gender.Text;
            patient.Phone = tb_phone.Text;
            patient.D_O_B = Convert.ToDateTime(dtp_dob.Value.ToString());
            patient.Address = tb_address.Text;
            patient.FirstName_em = tb_firstname_em.Text;
            patient.LastName_em = tb_lastname_em.Text;
            patient.Phone_em = tb_phone_em.Text;
            patient.Address_em = tb_address_em.Text;

            ember_Medical_Services_Db.SaveChanges();
            viewPatients.Refresh();
            Close();

           // }
           //    catch (Exception ex)
            //{
               // MessageBox.Show("Error");
            //}
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
