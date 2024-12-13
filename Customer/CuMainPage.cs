using APU_Printing_System__G24.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Printing_System__G24.Customer
{
    public partial class CuMainPage : Form
    {
        public PictureBox BackgroundPictureBox { get; set; }
        public Label lbWelocomeText { get; set; }
        public Label lbWelcomeBackground { get; set; }
        public CuMainPage()
        {
            InitializeComponent();
            BackgroundPictureBox = pcBackground;
            lbWelocomeText = lbWelcom;
            lbWelcomeBackground = lblWelcomeBg;
        }

        private void miAddNewRequest_Click(object sender, EventArgs e)
        {
            CuAddNewRequest cuAddNewRequest = new CuAddNewRequest(this);
            cuAddNewRequest.MdiParent = this;
            cuAddNewRequest.StartPosition = FormStartPosition.CenterScreen;
            cuAddNewRequest.Show();

            lbWelcom.Visible = false;
            lblWelcomeBg.Visible = false;
            pcBackground.Visible = false;

        }

        private void miPreviousRequest_Click(object sender, EventArgs e)
        {
            CuPreviousRequest cuPreviousRequest = new CuPreviousRequest(this);
            cuPreviousRequest.MdiParent = this;
            cuPreviousRequest.StartPosition = FormStartPosition.CenterScreen;
            cuPreviousRequest.Show();

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

