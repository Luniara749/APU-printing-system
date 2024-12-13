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

namespace APU_Printing_System__G24.Manager
{
    public partial class MaWorkinProgress : Form
    {
        private MaMainPage mainPage;

        public MaWorkinProgress(MaMainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
            con.Open();


            string querry = "SELECT Requests.CustomerID, Requests.RequestID, Requests.Quantity, Requests.Urgent, Requests.RequestDate, Services.ServiceType FROM Requests INNER JOIN Services ON Requests.ServiceID = Services.ServiceID WHERE Requests.RequestStatus = 'In Progress' ORDER BY Requests.Urgent DESC;\r\n";
            //string querry = "SELECT Requests.RequestID, Requests.Quantity, Requests.Urgent, Requests.RequestDate, Services.ServiceType, Users.Username,Users.UserID FROM Requests INNER JOIN Services ON Requests.ServiceID = Services.ServiceID LEFT JOIN Users ON Requests.UserID = Users.UserID WHERE Requests.RequestStatus = 'In Progress' ORDER BY Requests.RequestID DESC;\r\n";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            dgWorkingProgress.DataSource = dtable;
            con.Close();
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
