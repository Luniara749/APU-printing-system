using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APU_Printing_System__G24.Admin.AdViewUsersProfile;

namespace APU_Printing_System__G24.Admin
{
    public partial class AdUpdateUser : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter ad;

        UserProfile user = AdViewUsersProfile.SelectedUser;
        public AdUpdateUser()
        {
            InitializeComponent();
            fillTextBox();
        }

        public void fillTextBox()
        {
            if (user != null)
            {
                tbUserName.Text = user.UserName;
                tbFirstName.Text = user.FirstName;
                tbLastName.Text = user.LastName;
                tbPassword.Text = user.Password;
                cbUserRole.SelectedItem = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(user.UserRole);
            }
            else
            {
                MessageBox.Show("SelectedUser is null. Cannot fill text boxes.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != "" && tbFirstName.Text != "" && tbLastName.Text != "" && tbPassword.Text != "" && cbUserRole.SelectedIndex > 0)
            {
                cmd = new SqlCommand("UPDATE Users SET firstName=@firstName, lastName=@lastName, Username=@username, Password=@password, UserRole=@userRole WHERE UserID=@userId", cnn);
                cnn.Open();

                cmd.Parameters.AddWithValue("@userId", user.UserID); 
                cmd.Parameters.AddWithValue("@firstName", tbFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", tbLastName.Text);
                cmd.Parameters.AddWithValue("@username", tbUserName.Text);
                cmd.Parameters.AddWithValue("@password", tbPassword.Text);
                cmd.Parameters.AddWithValue("@userRole", cbUserRole.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                cnn.Close();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }


            this.Close();
        }
    }
}
