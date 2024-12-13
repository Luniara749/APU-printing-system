namespace APU_Printing_System__G24.Customer
{
    partial class CuMainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.apuUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHome = new System.Windows.Forms.ToolStripMenuItem();
            this.miLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddNewRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.miPreviousRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.lbWelcom = new System.Windows.Forms.Label();
            this.lblWelcomeBg = new System.Windows.Forms.Label();
            this.pcBackground = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apuUserToolStripMenuItem,
            this.miAddNewRequest,
            this.miPreviousRequest});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // apuUserToolStripMenuItem
            // 
            this.apuUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHome,
            this.miLogOut});
            this.apuUserToolStripMenuItem.Name = "apuUserToolStripMenuItem";
            this.apuUserToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.apuUserToolStripMenuItem.Text = "Apu User";
            // 
            // miHome
            // 
            this.miHome.Name = "miHome";
            this.miHome.Size = new System.Drawing.Size(180, 22);
            this.miHome.Text = "Home";
            this.miHome.Click += new System.EventHandler(this.miHome_Click);
            // 
            // miLogOut
            // 
            this.miLogOut.Name = "miLogOut";
            this.miLogOut.Size = new System.Drawing.Size(180, 22);
            this.miLogOut.Text = "Log out";
            this.miLogOut.Click += new System.EventHandler(this.miLogOut_Click);
            // 
            // miAddNewRequest
            // 
            this.miAddNewRequest.Name = "miAddNewRequest";
            this.miAddNewRequest.Size = new System.Drawing.Size(113, 22);
            this.miAddNewRequest.Text = "Add New Request";
            this.miAddNewRequest.Click += new System.EventHandler(this.miAddNewRequest_Click);
            // 
            // miPreviousRequest
            // 
            this.miPreviousRequest.Name = "miPreviousRequest";
            this.miPreviousRequest.Size = new System.Drawing.Size(109, 22);
            this.miPreviousRequest.Text = "Previous Request";
            this.miPreviousRequest.Click += new System.EventHandler(this.miPreviousRequest_Click);
            // 
            // lbWelcom
            // 
            this.lbWelcom.AutoSize = true;
            this.lbWelcom.BackColor = System.Drawing.Color.DarkBlue;
            this.lbWelcom.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold);
            this.lbWelcom.ForeColor = System.Drawing.Color.White;
            this.lbWelcom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbWelcom.Location = new System.Drawing.Point(11, 35);
            this.lbWelcom.Name = "lbWelcom";
            this.lbWelcom.Size = new System.Drawing.Size(466, 56);
            this.lbWelcom.TabIndex = 26;
            this.lbWelcom.Text = "Welcome Customer!";
            // 
            // lblWelcomeBg
            // 
            this.lblWelcomeBg.BackColor = System.Drawing.Color.DarkBlue;
            this.lblWelcomeBg.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWelcomeBg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWelcomeBg.Location = new System.Drawing.Point(-1, 26);
            this.lblWelcomeBg.Name = "lblWelcomeBg";
            this.lblWelcomeBg.Size = new System.Drawing.Size(976, 76);
            this.lblWelcomeBg.TabIndex = 25;
            this.lblWelcomeBg.Text = "label7";
            // 
            // pcBackground
            // 
            this.pcBackground.Image = global::APU_Printing_System__G24.Properties.Resources.f8b443d2254a97dc6b27631da5dbe7cac9d449ebf22be7254ea01988d9e9e3ae2;
            this.pcBackground.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pcBackground.Location = new System.Drawing.Point(1, 102);
            this.pcBackground.Name = "pcBackground";
            this.pcBackground.Size = new System.Drawing.Size(974, 553);
            this.pcBackground.TabIndex = 24;
            this.pcBackground.TabStop = false;
            // 
            // CuMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 621);
            this.Controls.Add(this.lbWelcom);
            this.Controls.Add(this.lblWelcomeBg);
            this.Controls.Add(this.pcBackground);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CuMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem apuUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHome;
        private System.Windows.Forms.ToolStripMenuItem miLogOut;
        private System.Windows.Forms.ToolStripMenuItem miAddNewRequest;
        private System.Windows.Forms.ToolStripMenuItem miPreviousRequest;
        private System.Windows.Forms.Label lbWelcom;
        private System.Windows.Forms.Label lblWelcomeBg;
        private System.Windows.Forms.PictureBox pcBackground;
    }
}