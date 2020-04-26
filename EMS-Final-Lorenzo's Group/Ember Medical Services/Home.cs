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
    public partial class Home : Form
    {
        private  Ember_medical_service_db ember_Medical_Service_Db;
        private Login _login;

        public Home(Login login)
        {
            InitializeComponent();
            _login = login;
        }
        public Home()
        {
            InitializeComponent();
            customisedesign();
            hideSubMenu();
            ember_Medical_Services_Db = new Ember_medical_service_db();
        }

        private void customisedesign()
        {
            panel_patient.Visible = false;
            panel_staff.Visible = false;
            panel_appointment.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_patient.Visible == true)
                panel_patient.Visible = false;
            if (panel_staff.Visible == true)
                panel_staff.Visible = false;
            if (panel_appointment.Visible == true)
                panel_appointment.Visible = false;
        }
        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;

        }

        private void Patient_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_patient);
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_staff);
        }

        private void Appointment_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_appointment);
        }

        private void b_Report_Click(object sender, EventArgs e)
        {

        }

   
        private Ember_medical_service_db ember_Medical_Services_Db;

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void b_addStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff_Details());

            hideSubMenu();
        }

        private void b_makeAppointment_Click(object sender, EventArgs e)
        {
            openChildForm(new ScheduleAppointment());

            hideSubMenu();
        }

        private void b_ViewAppointment_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewAppointments());

            hideSubMenu();
        }

        private void bt_ptinfo_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewPatients());

            hideSubMenu(); 
        }

        private void bt_viewStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewStaffs());

            hideSubMenu();
        }

        private void bt_addpt_Click(object sender, EventArgs e)
        {
            openChildForm(new Patient_Details());

            hideSubMenu();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void B_bills_Click(object sender, EventArgs e)
        {

        }

    }
}
