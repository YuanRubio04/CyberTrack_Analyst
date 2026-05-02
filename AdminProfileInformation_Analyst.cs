using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberTrack_Analyst
{
    public partial class AdminProfileInformation_Analyst : Form
    {
        public AdminProfileInformation_Analyst()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AdminProfileInformation_Analyst_Load(object sender, EventArgs e)
        {
            var user = new Repositories.User_Repository();
            User userinfo = user.GetUser(1); // Assuming you want to get the user with ID 1

                dgvProfilePersonalInformation_Analyst.Rows.Clear();
                // Add user information to the DataGridView
                dgvProfilePersonalInformation_Analyst.Rows.Add(userinfo.UserID, userinfo.FullName, userinfo.Email, userinfo.Role, userinfo.Department, userinfo.status);
               
            }
        }
    }
