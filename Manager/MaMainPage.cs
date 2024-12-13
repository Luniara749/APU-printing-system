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

namespace APU_Printing_System__G24.Manager
{

    public partial class MaMainPage : Form
    {
        public PictureBox BackgroundPictureBox { get; set; }
        public Label lbWelocomeText { get; set; }
        public Label lbWelcomeBackground { get; set; }

        public MaMainPage()
        {
            InitializeComponent();
            BackgroundPictureBox = pcBackground;
            lbWelocomeText = lbWelcom;
            lbWelcomeBackground = lblWelcomeBg;
        }

        private void miNewRequests_Click(object sender, EventArgs e)
        {
            MaNewRequest maNewRequest = new MaNewRequest(this);
            maNewRequest.MdiParent = this;
            maNewRequest.StartPosition = FormStartPosition.CenterScreen;
            maNewRequest.Show();

            lbWelcom.Visible = false;
            lblWelcomeBg.Visible = false;
            pcBackground.Visible = false;
        }

        private void miInProgressReq_Click(object sender, EventArgs e)
        {
            MaWorkinProgress maWorkinProgress = new MaWorkinProgress(this);
            maWorkinProgress.MdiParent = this;
            maWorkinProgress.StartPosition = FormStartPosition.CenterScreen;
            maWorkinProgress.Show();

            lbWelcom.Visible = false;
            lblWelcomeBg.Visible = false;
            pcBackground.Visible = false;
        }

        private void miCompletedReq_Click(object sender, EventArgs e)
        {
            MaCompletedRequest maCompletedRequest = new MaCompletedRequest(this);
            maCompletedRequest.MdiParent = this;
            maCompletedRequest.StartPosition = FormStartPosition.CenterScreen;
            maCompletedRequest.Show();

            lbWelcom.Visible = false;
            lblWelcomeBg.Visible = false;
            pcBackground.Visible = false;
        }

        private void miAcceptPayment_Click(object sender, EventArgs e)
        {
            MaCompletedRequest maCompletedRequest = new MaCompletedRequest(this);
            maCompletedRequest.MdiParent = this;
            maCompletedRequest.StartPosition = FormStartPosition.CenterScreen;
            maCompletedRequest.Show();

            lbWelcom.Visible = false;
            lblWelcomeBg.Visible = false;
            pcBackground.Visible = false;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbWelcom.Visible = true;
            lblWelcomeBg.Visible = true;
            pcBackground.Visible = true;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logInForm logInForm1 = new logInForm();
            logInForm1.Show(this);
            this.Close();
        }
    }
}
