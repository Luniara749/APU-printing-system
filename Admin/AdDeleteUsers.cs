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

namespace APU_Printing_System__G24.Admin
{
    public partial class AdDeleteUsers : Form
    {

        private AdMainPage mainPage;

        public static class SelectFromDATA
        {
            public static int data { get; set; }
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
        SqlCommand cmd;
        public AdDeleteUsers(AdMainPage mainPage)
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
            // create data adapter
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            dgDeleteUsers.DataSource = dataTable;
            cnn.Close();
        }

       

        private void dgDeleteUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgDeleteUsers.Rows[e.RowIndex];
            int UserId = int.Parse(row.Cells[0].Value.ToString());
            SelectFromDATA.data = UserId;
        }

        private void dgDeleteUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dgDeleteUsers.Rows[e.RowIndex];
            int User = int.Parse(row.Cells[0].Value.ToString());
            SelectFromDATA.data = User;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
            SqlCommand cmd;

            try
            {
                cnn.Open();

                // Delete related records in Payment table
                cmd = new SqlCommand("DELETE FROM Payment WHERE RequestID IN (SELECT RequestID FROM Requests WHERE CustomerID=@val);", cnn);
                cmd.Parameters.AddWithValue("@val", SelectFromDATA.data);
                cmd.ExecuteNonQuery();

                // Delete related records in Requests table
                cmd = new SqlCommand("DELETE FROM Requests WHERE CustomerID=@val;", cnn);
                cmd.Parameters.AddWithValue("@val", SelectFromDATA.data);
                cmd.ExecuteNonQuery();

                // Now, delete the user from the Users table
                cmd = new SqlCommand("DELETE FROM Users WHERE UserID=@val", cnn);
                cmd.Parameters.AddWithValue("@val", SelectFromDATA.data);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Successfully!");
                Display_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                cnn.Close();
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
