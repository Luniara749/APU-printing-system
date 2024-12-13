namespace APU_Printing_System__G24
{
    partial class AdMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdMainPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aPUManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHome = new System.Windows.Forms.ToolStripMenuItem();
            this.miLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.miUpdateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRequestsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.miTotalIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pcBackground = new System.Windows.Forms.PictureBox();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbWelcom = new System.Windows.Forms.Label();
            this.lblWelcomeBg = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPUManagerToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // aPUManagerToolStripMenuItem
            // 
            this.aPUManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHome,
            this.miLogOut});
            this.aPUManagerToolStripMenuItem.Name = "aPUManagerToolStripMenuItem";
            resources.ApplyResources(this.aPUManagerToolStripMenuItem, "aPUManagerToolStripMenuItem");
            // 
            // miHome
            // 
            this.miHome.Name = "miHome";
            resources.ApplyResources(this.miHome, "miHome");
            this.miHome.Click += new System.EventHandler(this.miHome_Click);
            // 
            // miLogOut
            // 
            this.miLogOut.Name = "miLogOut";
            resources.ApplyResources(this.miLogOut, "miLogOut");
            this.miLogOut.Click += new System.EventHandler(this.miLogOut_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddNewUser,
            this.miViewUsers,
            this.miUpdateUser,
            this.miDeleteUser});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            resources.ApplyResources(this.usersToolStripMenuItem, "usersToolStripMenuItem");
            // 
            // miAddNewUser
            // 
            this.miAddNewUser.Name = "miAddNewUser";
            resources.ApplyResources(this.miAddNewUser, "miAddNewUser");
            this.miAddNewUser.Click += new System.EventHandler(this.miAddNewUser_Click);
            // 
            // miViewUsers
            // 
            this.miViewUsers.Name = "miViewUsers";
            resources.ApplyResources(this.miViewUsers, "miViewUsers");
            this.miViewUsers.Click += new System.EventHandler(this.viewUsersProfileToolStripMenuItem_Click);
            // 
            // miUpdateUser
            // 
            this.miUpdateUser.Name = "miUpdateUser";
            resources.ApplyResources(this.miUpdateUser, "miUpdateUser");
            this.miUpdateUser.Click += new System.EventHandler(this.miUpdateUser_Click);
            // 
            // miDeleteUser
            // 
            this.miDeleteUser.Name = "miDeleteUser";
            resources.ApplyResources(this.miDeleteUser, "miDeleteUser");
            this.miDeleteUser.Click += new System.EventHandler(this.miDeleteUser_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRequestsReport,
            this.miTotalIncome});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            resources.ApplyResources(this.reportsToolStripMenuItem, "reportsToolStripMenuItem");
            // 
            // miRequestsReport
            // 
            this.miRequestsReport.Name = "miRequestsReport";
            resources.ApplyResources(this.miRequestsReport, "miRequestsReport");
            this.miRequestsReport.Click += new System.EventHandler(this.miRequestsReport_Click);
            // 
            // miTotalIncome
            // 
            this.miTotalIncome.Name = "miTotalIncome";
            resources.ApplyResources(this.miTotalIncome, "miTotalIncome");
            this.miTotalIncome.Click += new System.EventHandler(this.miTotalIncome_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // pcBackground
            // 
            this.pcBackground.Image = global::APU_Printing_System__G24.Properties.Resources.f8b443d2254a97dc6b27631da5dbe7cac9d449ebf22be7254ea01988d9e9e3ae2;
            resources.ApplyResources(this.pcBackground, "pcBackground");
            this.pcBackground.Name = "pcBackground";
            this.pcBackground.TabStop = false;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // lbWelcom
            // 
            resources.ApplyResources(this.lbWelcom, "lbWelcom");
            this.lbWelcom.BackColor = System.Drawing.Color.DarkBlue;
            this.lbWelcom.ForeColor = System.Drawing.Color.White;
            this.lbWelcom.Name = "lbWelcom";
            // 
            // lblWelcomeBg
            // 
            this.lblWelcomeBg.BackColor = System.Drawing.Color.DarkBlue;
            this.lblWelcomeBg.ForeColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.lblWelcomeBg, "lblWelcomeBg");
            this.lblWelcomeBg.Name = "lblWelcomeBg";
            // 
            // AdMainPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lbWelcom);
            this.Controls.Add(this.lblWelcomeBg);
            this.Controls.Add(this.pcBackground);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdMainPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miViewUsers;
        private System.Windows.Forms.ToolStripMenuItem miUpdateUser;
        private System.Windows.Forms.ToolStripMenuItem aPUManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRequestsReport;
        private System.Windows.Forms.ToolStripMenuItem miTotalIncome;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miHome;
        private System.Windows.Forms.ToolStripMenuItem miLogOut;
        private System.Windows.Forms.ToolStripMenuItem miAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem miDeleteUser;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PictureBox pcBackground;
        private System.Windows.Forms.Label lbWelcom;
        private System.Windows.Forms.Label lblWelcomeBg;
    }
}

