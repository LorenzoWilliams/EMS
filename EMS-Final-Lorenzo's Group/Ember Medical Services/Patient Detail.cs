using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ember_Medical_Services
{
    public partial class Patient_Details : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int Index;

        private Ember_medical_service_db ember_Medical_Services_Db;

        public string ID;
        public string PatientName ;
        public string FirstName;
        public string LastName;
        public string Email;
        public string Gender;
        public string Phone;
        public string DOB;
        public string Address;
        public string FirstNameEM;
        public string LastNameEM;
        public string PhoneEM;
        public string AddressEM;

        public Patient_Details()
        {
            InitializeComponent();
            ember_Medical_Services_Db = new Ember_medical_service_db();
            var patient = new Patient();


        }
   
        private void Patient_Details_Load(object sender, EventArgs e)
        {
            listPanel.Add(p_page1);
            listPanel.Add(p_page2);
            listPanel[Index].BringToFront();
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            if (Index > 0) 
                listPanel[--Index].BringToFront();
        }

        private void b_next_Click(object sender, EventArgs e)
        {
          
            var isValid = true;
           
            FirstName = tb_ptfirstname.Text;
            LastName = tb_ptlastname.Text;
            Email = tb_emailaddress.Text;
            Phone = tb_phone.Text;
            Address = gb_pt_address.Text;
            Gender = rb_male.Checked == true ? rb_male.Text : rb_female.Text;
            DOB = dTP_dob.Value.ToString();


            if (string.IsNullOrWhiteSpace(FirstName)||string.IsNullOrEmpty(LastName)||string.IsNullOrEmpty(Phone)
                ||string.IsNullOrEmpty(Address)||!(rb_male.Checked || rb_female.Checked)
               || string.IsNullOrEmpty(Email)|| string.IsNullOrEmpty(DOB))
            {
                isValid = false;
                MessageBox.Show("Please complete Form");
            }
 


            if (isValid == true)
            {
                
                if (Index < listPanel.Count - 1)
                    listPanel[++Index].BringToFront();
            }
      
        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();

            FirstName = tb_ptfirstname.Text;
            LastName = tb_ptlastname.Text;
            Email = tb_emailaddress.Text;
            Phone = tb_phone.Text;
            Address = gb_pt_address.Text;
            Gender = rb_male.Checked == true ? rb_male.Text : rb_female.Text;
            DOB = dTP_dob.Value.ToString();

            //get all data
            patient.FirstName = FirstName;
            patient.LastName = LastName;
            patient.Email = Email;
            patient.D_O_B = Convert.ToDateTime(DOB);
            patient.Gender = Gender;
            patient.Phone = Phone;
            patient.Address = Address;
            patient.FirstName_em = tb_firstname_em.Text;
            patient.LastName_em = tb_lastname_em.Text;
            patient.Phone = tb_em_phone.Text;
            patient.Address_em = gb_em_address.Text;
            ember_Medical_Services_Db.Patients.Add(patient);
            ember_Medical_Services_Db.SaveChanges();

            PatientName = tb_ptfirstname.Text + " " + tb_ptlastname.Text;
            MessageBox.Show($"{PatientName} Successfully Added");
            Close();
        }

    }
}
