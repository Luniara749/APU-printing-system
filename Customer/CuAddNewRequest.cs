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
    public partial class CuAddNewRequest : Form
    {
        private CuMainPage mainPage;

        public CuAddNewRequest(CuMainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;

        }
        public Boolean Urgent()
        {
            if (CheckboxUrgent.Checked == true)
            {

                return true;
            }
            else
            {
                return false;
            }

        }
        public int ServiceID()
        {
            if (cbServiceType.Text == "Printing A4 – Black and White")
            {
                return 1001;
            }
            else if (cbServiceType.Text == "Printing A4 – Color")
            {
                return 1002;
            }
            else if (cbServiceType.Text == "Binding – Comb Binding")
            {
                return 1003;
            }
            else if (cbServiceType.Text == "Binding – Thick Cover")
            {
                return 1004;
            }
            else if (cbServiceType.Text == "Poster printing (A0 – A3)")
            {
                return 1005;
            }
            else if (cbServiceType.Text == "Banner")
            {
                return 1006;
            }
            return -1;

        }

        private void UrgentCheck_CheckedChanged(object sender, EventArgs e)
        {
            double Totalprice = double.Parse(tbTotalPrice.Text);
            if (CheckboxUrgent.Checked == true)
            {
                Totalprice = Totalprice * 1.3;
                tbTotalPrice.Text = Totalprice.ToString();
            }
            else
            {
                Totalprice = Totalprice / 1.3;
                tbTotalPrice.Text = Totalprice.ToString();
            }
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            string ServiceType = cbServiceType.Text;
            string RequestStatus = "New";
            double Cost = double.Parse(tbTotalPrice.Text);
            Boolean Urgents = Urgent();
            int Quantity = int.Parse(tbQuantity.Text);
            string data = SharedData.Data;
            DateTime dateTime = dateTimePicker1.Value;
            int ServiceIDs = ServiceID();
            string WorkerUserName = "Pending";


            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select UserID From Users Where Username = @Name", con);
            cmd.Parameters.AddWithValue("@Name", data);

            string UserID = cmd.ExecuteScalar().ToString();



            SqlCommand cmd1 = new SqlCommand("INSERT INTO Requests (CustomerID,ServiceID, WorkerUserName, RequestStatus, Urgent, Cost, Quantity, RequestDate) " +
                "VALUES (@CustomerID, @ServiceID, @WorkerUserName, @RequestStatus, @Urgent, @Cost, @Quantity, @RequestDate)", con);
            cmd1.Parameters.AddWithValue("@CustomerID", UserID);
            cmd1.Parameters.AddWithValue("@ServiceID", ServiceIDs);
            cmd1.Parameters.AddWithValue("@WorkerUserName", WorkerUserName);
            cmd1.Parameters.AddWithValue("@RequestStatus", RequestStatus);
            cmd1.Parameters.AddWithValue("@Urgent", Urgents);
            cmd1.Parameters.AddWithValue("@Cost", Cost);
            cmd1.Parameters.AddWithValue("@Quantity", Quantity);
            cmd1.Parameters.AddWithValue("@RequestDate", dateTime);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Request Added");

        }

        private void cbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ServiceType = cbServiceType.Text;
            if (ServiceType == "Printing A4 – Black and White")
            {
                tbPrice.Text = "RM0.8/page";
            }
            if (ServiceType == "Printing A4 – Color")
            {
                tbPrice.Text = "RM2.50/page";
            }
            if (ServiceType == "Binding – Comb Binding")
            {
                tbPrice.Text = "RM5/book";
            }
            if (ServiceType == "Binding – Thick Cover")
            {
                tbPrice.Text = "RM15/book";
            }
            if (ServiceType == "Poster printing (A0 – A3)")
            {
                tbPrice.Text = "RM3/page";
            }
            if (ServiceType == "Banner")
            {
                tbPrice.Text = "RM10/page";
            }

        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
                if (cbServiceType.Text == "Printing A4 – Black and White")
                {
                    double Pricelabel = 0.8;
                    double Quantity = double.Parse(tbQuantity.Text);
                    double Totalprice = Quantity * Pricelabel;
                    tbTotalPrice.Text = Totalprice.ToString();
                }
                else if (cbServiceType.Text == "Printing A4 – Color")
                {
                    double Pricelabel = 2.5;
                    double Quantity = double.Parse(tbQuantity.Text);
                    double Totalprice = Quantity * Pricelabel;
                    tbTotalPrice.Text = Totalprice.ToString();
                }
                else if (cbServiceType.Text == "Binding – Comb Binding")
                {
                    double Pricelabel = 5;
                    double Quantity = double.Parse(tbQuantity.Text);
                    double Totalprice = Quantity * Pricelabel;
                    tbTotalPrice.Text = Totalprice.ToString();
                }
                else if (cbServiceType.Text == "Binding – Thick Cover")
                {
                    double Pricelabel = 15;
                    double Quantity = double.Parse(tbQuantity.Text);
                    double Totalprice = Quantity * Pricelabel;
                    tbTotalPrice.Text = Totalprice.ToString();
                }
                else if (cbServiceType.Text == "Poster printing (A0 – A3)")
                {
                    double Pricelabel = 3;
                    double Quantity = double.Parse(tbQuantity.Text);
                    double Totalprice = Quantity * Pricelabel;
                    tbTotalPrice.Text = Totalprice.ToString();
                }
                else if (cbServiceType.Text == "Banner")
                {
                    double Pricelabel = 10;
                    double Quantity = double.Parse(tbQuantity.Text);
                    double Totalprice = Quantity * Pricelabel;
                    tbTotalPrice.Text = Totalprice.ToString();
                }
                else if (cbServiceType.Text == null)
                {

                }
            
            

        }

        private void CheckboxUrgent_CheckedChanged(object sender, EventArgs e)
        {
            double Totalprice = double.Parse(tbTotalPrice.Text);
            if (CheckboxUrgent.Checked == true)
            {
                Totalprice = Totalprice * 1.3;
                tbTotalPrice.Text = Totalprice.ToString();
            }
            else
            {
                Totalprice = Totalprice / 1.3;
                tbTotalPrice.Text = Totalprice.ToString();
            }

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
