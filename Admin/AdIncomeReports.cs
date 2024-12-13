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

namespace APU_Printing_System__G24
{
    public partial class AdIncomeReports : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
        public AdIncomeReports()
        {
            InitializeComponent();
            Display_Data();
        }

        private void Display_Data()
        {
            string query = "SELECT PaymentID, RequestID, AmountPaid, PaymentDate FROM Payment";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, cnn);
            cnn.Open();
            // To create data adapter
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dgTotalIncome.DataSource = dataTable;
            cnn.Close();
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(cbMonth.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a Month!");
            }
            else
            {

                int selectedMonth = cbMonth.SelectedIndex + 1;

                string query = "SELECT PaymentID, RequestID, AmountPaid, PaymentDate FROM Payment WHERE MONTH(PaymentDate) = @SelectedMonth";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@SelectedMonth", selectedMonth);
                cnn.Open();
                System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dgTotalIncome.DataSource = dataTable;
                decimal totalIncome = dataTable.AsEnumerable().Sum(row => row.Field<decimal>("AmountPaid"));
                lbTotal.Text = "RM " + totalIncome.ToString();
                cnn.Close();

                this.Close();



            }
        }
    }
}
