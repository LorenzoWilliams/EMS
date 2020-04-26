using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Ember_Medical_Services
{
    public partial class Login : Form
    {
        private Ember_medical_service_db ember_Medical_Services_Db;

        public Login()
        {
            InitializeComponent();
            ember_Medical_Services_Db = new Ember_medical_service_db();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = tb_username.Text.Trim();
                var password = tb_password.Text;

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder sBuilder = new StringBuilder();

                for(int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                var hashed_password = sBuilder.ToString();

                var user = ember_Medical_Services_Db.Users.FirstOrDefault(q => q.username == username && q.password == hashed_password);
                if(user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var home = new Home(this);
                    home.Show();
                    Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incorrect Username or Password. Please try again");
            }
        }
        
    }
}
