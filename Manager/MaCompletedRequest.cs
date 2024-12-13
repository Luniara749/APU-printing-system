using APU_Printing_System__G24.Admin;
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
    public partial class MaCompletedRequest : Form
    {
        
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter ad;

        private MaMainPage mainPage;
        public static Payments SelectedPayments;
        public MaCompletedRequest(MaMainPage mainPage)
        {
            InitializeComponent();
            Display_Data();
            this.mainPage = mainPage;
        }
        private void Display_Data()
        {
            string query = "SELECT Requests.CustomerID, Requests.RequestID, Requests.Quantity, Requests.RequestDate, Requests.Cost, Services.ServiceType FROM Requests INNER JOIN Services ON Requests.ServiceID = Services.ServiceID WHERE Requests.RequestStatus = 'Completed' ORDER BY Requests.Urgent DESC;\r\n";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, cnn);
            cnn.Open();
            // To create data adapter
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dgCompletedReq.DataSource = dataTable;
            cnn.Close();
        }
        private void dgCompletedReq_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dgCompletedReq.Rows[e.RowIndex];
            int userID = int.Parse(row.Cells[0].Value.ToString());
            SelectFromDATA.data = userID;
            SelectedPayments = new Payments(userID);
        }

        private void btnAcceptPayment_Click(object sender, EventArgs e)
        {
            if (SelectedPayments != null)
            {
                DataGridViewRow row = dgCompletedReq.SelectedRows[0];

                int userId = int.Parse(row.Cells["CustomerID"].Value.ToString());
                int reqId = int.Parse(row.Cells["RequestID"].Value.ToString());
                double totalPrice = double.Parse(row.Cells["cost"].Value.ToString());

                Payments SelectedPayments = new Payments(userId, reqId, totalPrice);
                MaCompletedRequest.SelectedPayments = SelectedPayments;

                MaAcceptPayment maAcceptPayment = new MaAcceptPayment();
                maAcceptPayment.Show();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
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