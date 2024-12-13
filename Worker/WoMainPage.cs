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

namespace APU_Printing_System__G24.Worker
{
    public partial class WoMainPage : Form
    {
        public static class SelectFromDATA
        {
            public static int data { get; set; }
        }
        public WoMainPage()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5QJDVNE3\MSSQLSERVER1;Initial Catalog=PrintingDatabase;Integrated Security=True");
            con.Open();

            string data = SharedData.Data;
            string query = $"SELECT Requests.RequestID, Requests.Quantity,Requests.Urgent,Requests.RequestDate, Services.ServiceType FROM Requests INNER JOIN Services ON Requests.ServiceID = Services.ServiceID where Requests.RequestStatus = 'In Progress' and Requests.WorkerUserName = {data}  ORDER BY Requests.Urgent DESC";





            SqlDataAdapter adapter = new SqlDataAdapter(query,con);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

           
            requestsDataGridView.DataSource = dtable;

            
            con.Close();
        }
        private void requestsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.requestsDataGridView.Rows[e.RowIndex];
            int ReqID = int.Parse(row.Cells[0].Value.ToString());
            SelectFromDATA.data = ReqID;
        }

        private void requestsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = requestsDataGridView.Rows[e.RowIndex];
            int ReqID = int.Parse(row.Cells[0].Value.ToString());
            SelectFromDATA.data = ReqID;
        }
        private void btnComplete_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
            int ReqID = SelectFromDATA.data;
            SqlCommand cmd = new SqlCommand("update Requests set RequestStatus=@val where RequestID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ReqID);
            cmd.Parameters.AddWithValue("@val", btnComplete.Text);
            cmd.ExecuteNonQuery();
            if (ReqID == 0)
            {
                MessageBox.Show("Nothing Selected To Update!");
            }
            else
            {
                MessageBox.Show("Record Updated Successfully");
            }

            con.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logInForm logInForm1 = new logInForm();
            logInForm1.Show(this);
            this.Close();
        }
    }
}
