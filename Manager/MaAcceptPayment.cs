using APU_Printing_System__G24.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Printing_System__G24.Manager
{
    public partial class MaAcceptPayment : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-2C3RHV63;Initial Catalog=PrintingDatabase;Integrated Security=True");
        SqlCommand cmd;

        
        Payments pay = MaCompletedRequest.SelectedPayments;

        public MaAcceptPayment()
        {
            InitializeComponent();
            fillTextBox();
        }

        public void fillTextBox()
        {
            if (pay != null)
            {
                tbRequestID.Text = pay.RequestID.ToString();
                tbUserID.Text = pay.UserID.ToString();
                tbTotalPrice.Text = pay.TotalPrice.ToString();
            }
            else
            {
                MessageBox.Show("SelectedUser is null. Cannot fill text boxes.");
            }


        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            if (tbTotalPrice.Text != "" && dpDate.Text != "" && cbTransitionType.SelectedIndex > 0)
            {
                int isPaid = 1;
                DateTime paymentDate;

                // Try parsing the date from the DateTimePicker
                if (DateTime.TryParse(dpDate.Text, out paymentDate))
                {
                    cmd = new SqlCommand("INSERT INTO Payment(RequestID, AmountPaid, PaymentDate, TransactionType, CustomerID, isPaide) VALUES(@RID, @AP, @PD, @TT, @CID, @ISP)", cnn);
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@RID", tbRequestID.Text);
                    cmd.Parameters.AddWithValue("@AP", tbTotalPrice.Text);
                    cmd.Parameters.AddWithValue("@PD", paymentDate.ToString("yyyy-MM-dd")); // Format the date properly
                    cmd.Parameters.AddWithValue("@TT", cbTransitionType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CID", tbUserID.Text);
                    cmd.Parameters.AddWithValue("@ISP", isPaid);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Invalid date format. Please select a valid date.");
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void btnGenrateReceipt_Click(object sender, EventArgs e)
        {
            if (tbTotalPrice.Text != "" && dpDate.Text != "" && cbTransitionType.SelectedIndex > 0)
            {
                int isPaid = 1;
                DateTime paymentDate;

                // Try parsing the date from the DateTimePicker
                if (DateTime.TryParse(dpDate.Text, out paymentDate))
                {
                    cmd = new SqlCommand("INSERT INTO Payment(RequestID, AmountPaid, PaymentDate, TransactionType, CustomerID, isPaide) VALUES(@RID, @AP, @PD, @TT, @CID, @ISP)", cnn);
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@RID", tbRequestID.Text);
                    cmd.Parameters.AddWithValue("@AP", tbTotalPrice.Text);
                    cmd.Parameters.AddWithValue("@PD", paymentDate.ToString("yyyy-MM-dd")); // Format the date properly
                    cmd.Parameters.AddWithValue("@TT", cbTransitionType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CID", tbUserID.Text);
                    cmd.Parameters.AddWithValue("@ISP", isPaid);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Record Inserted Successfully");
                    MessageBox.Show("Recipt Printed");
                }
                else
                {
                    MessageBox.Show("Invalid date format. Please select a valid date.");
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
