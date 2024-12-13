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

namespace APU_Printing_System__G24.Manager
{
    public partial class MaNewRequest : Form
    {

        private MaMainPage mainPage;
        public static class SelectFromDATA1
        {
            public static int data { get; set; }
        }
        public MaNewRequest(MaMainPage mainPage)
        {
            InitializeComponent();
            LoadDataIntoComboBox();
            this.mainPage = mainPage;

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
            con.Open();



            string querry = "SELECT Requests.RequestID, Requests.Quantity,Requests.Urgent,Requests.RequestDate, Services.ServiceType FROM Requests INNER JOIN Services ON Requests.ServiceID = Services.ServiceID where Requests.RequestStatus = 'New' ORDER BY Requests.Urgent DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            dgNewRequests.DataSource = dtable;
            con.Close();
        }
        private void LoadDataIntoComboBox()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
                string query = "SELECT FirstName, LastName FROM Users WHERE UserRole = 'Worker'";

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con);
                con.Open();
                // create data adapter
                System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                // this will query your database and return the result to your datatable
                da.Fill(dataTable);



                foreach (DataRow row in dataTable.Rows)
                {
                    // Combine first and last names and add to the ComboBox
                    string fullName = $"{row["FirstName"]} {row["LastName"]}";
                    cbAssignTo.Items.Add(fullName);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgNewRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgNewRequests.Rows[e.RowIndex];
            int X = int.Parse(row.Cells[0].Value.ToString());
            SelectFromDATA1.data = X;
        }

        private void dgNewRequests_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgNewRequests.Rows[e.RowIndex];
            int X = int.Parse(row.Cells[0].Value.ToString());
            SelectFromDATA1.data = X;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgNewRequests.SelectedRows.Count > 0)
            {
                // Get the selected Request ID from the DataGridView
                DataGridViewRow selectedRow = dgNewRequests.SelectedRows[0];
                int requestId = int.Parse(selectedRow.Cells[0].Value.ToString());

                // Get the selected Worker Name from the ComboBox
                string workerName = cbAssignTo.SelectedItem.ToString();

                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
                SqlCommand cmd;
                cmd = new SqlCommand("UPDATE Requests SET RequestStatus = 'Work In Progress', WorkerUserName = @workerName WHERE RequestID = @requestId", con);

                con.Open();

                cmd.Parameters.AddWithValue("@workerName", workerName);
                cmd.Parameters.AddWithValue("@requestId", requestId);

                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Record Updated Successfully");
            }
            else
            {
                MessageBox.Show("Please select a request from the DataGridView!");
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
