namespace APU_Printing_System__G24.Manager
{
    partial class MaAcceptPayment
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenrateReceipt = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.cbTransitionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRequestID = new System.Windows.Forms.TextBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 18F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(48, 504);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 56);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenrateReceipt
            // 
            this.btnGenrateReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenrateReceipt.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGenrateReceipt.Font = new System.Drawing.Font("Consolas", 18F);
            this.btnGenrateReceipt.ForeColor = System.Drawing.Color.White;
            this.btnGenrateReceipt.Location = new System.Drawing.Point(439, 514);
            this.btnGenrateReceipt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenrateReceipt.Name = "btnGenrateReceipt";
            this.btnGenrateReceipt.Size = new System.Drawing.Size(323, 36);
            this.btnGenrateReceipt.TabIndex = 1;
            this.btnGenrateReceipt.Text = "Generate Receipt";
            this.btnGenrateReceipt.UseVisualStyleBackColor = false;
            this.btnGenrateReceipt.Click += new System.EventHandler(this.btnGenrateReceipt_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDone.Font = new System.Drawing.Font("Consolas", 18F);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(773, 504);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(147, 56);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cbTransitionType
            // 
            this.cbTransitionType.FormattingEnabled = true;
            this.cbTransitionType.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cbTransitionType.Location = new System.Drawing.Point(133, 360);
            this.cbTransitionType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTransitionType.Name = "cbTransitionType";
            this.cbTransitionType.Size = new System.Drawing.Size(282, 23);
            this.cbTransitionType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label1.Location = new System.Drawing.Point(129, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "RequestID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label2.Location = new System.Drawing.Point(129, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Transition Type ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label3.Location = new System.Drawing.Point(556, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label4.Location = new System.Drawing.Point(556, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "UserID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label5.Location = new System.Drawing.Point(129, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Price";
            // 
            // tbRequestID
            // 
            this.tbRequestID.BackColor = System.Drawing.Color.White;
            this.tbRequestID.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.tbRequestID.Location = new System.Drawing.Point(133, 160);
            this.tbRequestID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbRequestID.Multiline = true;
            this.tbRequestID.Name = "tbRequestID";
            this.tbRequestID.ReadOnly = true;
            this.tbRequestID.Size = new System.Drawing.Size(282, 28);
            this.tbRequestID.TabIndex = 9;
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.BackColor = System.Drawing.Color.White;
            this.tbTotalPrice.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.tbTotalPrice.Location = new System.Drawing.Point(133, 255);
            this.tbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTotalPrice.Multiline = true;
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(282, 28);
            this.tbTotalPrice.TabIndex = 14;
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(560, 252);
            this.dpDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(282, 23);
            this.dpDate.TabIndex = 13;
            // 
            // tbUserID
            // 
            this.tbUserID.BackColor = System.Drawing.Color.White;
            this.tbUserID.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.tbUserID.Location = new System.Drawing.Point(560, 160);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbUserID.Multiline = true;
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.ReadOnly = true;
            this.tbUserID.Size = new System.Drawing.Size(282, 28);
            this.tbUserID.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkBlue;
            this.label8.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(388, 56);
            this.label8.TabIndex = 19;
            this.label8.Text = "Accept Payment";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkBlue;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(-1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(976, 76);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // MaAcceptPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 592);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.tbRequestID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTransitionType);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnGenrateReceipt);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MaAcceptPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenrateReceipt;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox cbTransitionType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRequestID;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}