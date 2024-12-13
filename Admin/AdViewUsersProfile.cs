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
using static APU_Printing_System__G24.Admin.AdDeleteUsers;

namespace APU_Printing_System__G24.Admin
{

    public partial class AdViewUsersProfile : Form
    {

        private AdMainPage mainPage;


        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter ad;

        public static UserProfile SelectedUser;

        public AdViewUsersProfile(AdMainPage mainPage)
        {
            InitializeComponent();
            Display_Data();
            this.mainPage = mainPage;
        }

        private void Display_Data()
        {
            string query = "select * from Users";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, cnn);
            cnn.Open();
            // To create data adapter
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dgViewUsers.DataSource = dataTable;
            cnn.Close();
        }

        private void dgViewUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dgViewUsers.Rows[e.RowIndex];
            int userId = int.Parse(row.Cells[0].Value.ToString());
            SelectFromDATA.data = userId;
            UserProfile UserId = new UserProfile(userId);
            tbUpdateUser.Text = UserId.UserID.ToString();


        }

        private void dgViewUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgViewUsers.Rows[e.RowIndex];
            int userId = int.Parse(row.Cells[0].Value.ToString());
            SelectFromDATA.data = userId;
            UserProfile UserId = new UserProfile(userId);
            tbUpdateUser.Text = UserId.UserID.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgViewUsers.SelectedRows[0];

                int userId = int.Parse(row.Cells["UserID"].Value.ToString());
                string firstName = row.Cells["firstName"].Value.ToString();
                string lastName = row.Cells["lastName"].Value.ToString();
                string userName = row.Cells["Username"].Value.ToString();
                string password = row.Cells["Password"].Value.ToString();
                string userRole = row.Cells["UserRole"].Value.ToString();

                UserProfile SelectedUser = new UserProfile(userId, firstName, lastName, userName, password, userRole);
                AdViewUsersProfile.SelectedUser = SelectedUser;

                AdUpdateUser adUpdateUser = new AdUpdateUser();


                Form mainForm = Application.OpenForms.OfType<AdMainPage>().FirstOrDefault();
                if (mainForm != null)
                {
                    adUpdateUser.MdiParent = mainForm;
                    adUpdateUser.StartPosition = FormStartPosition.CenterScreen;
                    adUpdateUser.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Main form not found.");
                }

                //adUpdateUser.Show();

                //this.Close();
            }
            else
            {
                MessageBox.Show("Please select a user before clicking the Update button.");
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
