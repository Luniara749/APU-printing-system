using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace APU_Printing_System__G24
{
    public partial class AdAddnewUsers : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
        SqlCommand cmd;

        private AdMainPage mainPage;
        public AdAddnewUsers(AdMainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }
        private void Clear_Textboxes()
        {
            tbUserName.Clear();
            tbPassword.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            cbUserRole.SelectedItem = null;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != "" && tbPassword.Text != "" && tbFirstName.Text != "" && tbLastName.Text != "" && cbUserRole.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO Users(UserName, Password, FirstName, LastName, UserRole) VALUES(@userName, @password, @firstName, @lastName, @userRole)", cnn);
                cnn.Open();
                cmd.Parameters.AddWithValue("@Username", tbUserName.Text.ToString());
                cmd.Parameters.AddWithValue("@Password", tbPassword.Text.ToString());
                cmd.Parameters.AddWithValue("@firstName", tbFirstName.Text.ToString());
                cmd.Parameters.AddWithValue("@lastName", tbLastName.Text.ToString());
                cmd.Parameters.AddWithValue("@UserRole", cbUserRole.SelectedItem.ToString().ToLower());
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Record Inserted Successfully");
                // Additional code to refresh or display the updated data if needed
                Clear_Textboxes();
            }
            else
            {
                MessageBox.Show("Please Provide Details for all fields!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            mainPage.lbWelocomeText.Visible = true;
            mainPage.lbWelcomeBackground.Visible = true;
            mainPage.BackgroundPictureBox.Visible = true;
            
        }
    }
}
