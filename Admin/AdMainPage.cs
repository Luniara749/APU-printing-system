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

namespace APU_Printing_System__G24
{
    public partial class AdMainPage : Form
    {
        public PictureBox BackgroundPictureBox { get; set; }
        public Label lbWelocomeText { get; set; }
        public Label lbWelcomeBackground { get; set; }

        public AdMainPage()
        {
            InitializeComponent();
            BackgroundPictureBox = pcBackground;
            lbWelocomeText = lbWelcom;
            lbWelcomeBackground = lblWelcomeBg;

        }

        private void viewUsersProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdViewUsersProfile adViewUsers = new AdViewUsersProfile(this);
            adViewUsers.MdiParent = this;
            adViewUsers.StartPosition = FormStartPosition.CenterScreen;
            adViewUsers.Show();

            lbWelcom.Visible = false;
            lblWelcomeBg.Visible = false;
            pcBackground.Visible = false;
        }

        private void miAddNewUser_Click(object sender, EventArgs e)
        {


            AdAddnewUsers adAddnewUsers = new AdAddnewUsers(this);
            adAddnewUsers.MdiParent = this;
            adAddnewUsers.StartPosition = FormStartPosition.CenterScreen;

            adAddnewUsers.Show();

            lbWelcom.Visible = false;
            lblWelcomeBg.Visible = false;
            pcBackground.Visible = false;

        }

        private void miDeleteUser_Click(object sender, EventArgs e)
        {
            AdDeleteUsers adDeleteUsers = new AdDeleteUsers(this);
            adDeleteUsers.MdiParent = this;
            adDeleteUsers.StartPosition = FormStartPosition.CenterScreen;
            adDeleteUsers.Show();

            lbWelcom.Visible = false;
            lblWelcomeBg.Visible = false;
            pcBackground.Visible = false;
        }

        private void miTotalIncome_Click(object sender, EventArgs e)
        {
            lbWelcom.Visible = false;
            lblWelcomeBg.Visible = false;
            pcBackground.Visible = false;

            AdIncomeReports adIncomeReport = new AdIncomeReports();
            adIncomeReport.MdiParent = this;
            adIncomeReport.StartPosition = FormStartPosition.CenterScreen;
            adIncomeReport.Show();

          
        }

        private void miRequestsReport_Click(object sender, EventArgs e)
        {
            lbWelcom.Visible = false;
            lblWelcomeBg.Visible = false;
            pcBackground.Visible = false;

            AdRequestsReports adRequestsReport = new AdRequestsReports();
            adRequestsReport.MdiParent = this;
            adRequestsReport.StartPosition = FormStartPosition.CenterScreen;
            adRequestsReport.Show();

            
        }

        private void miUpdateUser_Click(object sender, EventArgs e)
        {
            AdViewUsersProfile adViewUsers = new AdViewUsersProfile(this);
            adViewUsers.MdiParent = this;
            adViewUsers.StartPosition = FormStartPosition.CenterScreen;
            adViewUsers.Show();

            lbWelcom.Visible = false;
            lblWelcomeBg.Visible = false;
            pcBackground.Visible = false;
        }

        private void miHome_Click(object sender, EventArgs e)
        {
            lbWelcom.Visible = true;
            lblWelcomeBg.Visible = true;
            pcBackground.Visible = true;
        }

        private void miLogOut_Click(object sender, EventArgs e)
        {
            logInForm logInForm1 = new logInForm();
            logInForm1.Show(this);
            this.Close();
        }  
    }
}