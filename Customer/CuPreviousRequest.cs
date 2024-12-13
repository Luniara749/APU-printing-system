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

namespace APU_Printing_System__G24.Customer
{
    public partial class CuPreviousRequest : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
        private CuMainPage mainPage;
        public CuPreviousRequest(CuMainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
            Display_Data();

        }

        private void Display_Data()
        {
            con.Open();
            string data = SharedData.Data;
            SqlCommand cmd = new SqlCommand("Select UserID From Users Where Username = @Name", con);
            cmd.Parameters.AddWithValue("@Name", data);

            string UserID = cmd.ExecuteScalar().ToString();

            string querry = $"SELECT Requests.RequestID, Requests.Quantity, Requests.Urgent, Requests.RequestDate," +
                $"Requests.RequestStatus, Services.ServiceType, Payment.isPaide FROM Requests INNER JOIN Services" +
                $" ON Requests.ServiceID = Services.ServiceID LEFT JOIN Payment ON Requests.RequestID = Payment.RequestID WHERE Requests.CustomerID = {UserID} ORDER BY RequestDate DESC;";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dgPreviousRequest.DataSource = dtable;
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainPage.lbWelocomeText.Visible = true;
            mainPage.lbWelcomeBackground.Visible = true;
            mainPage.BackgroundPictureBox.Visible = true;

            this.Close();
        }
    }
}
