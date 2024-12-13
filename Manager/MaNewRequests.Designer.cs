namespace APU_Printing_System__G24.Manager
{
    partial class MaNewRequest
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
            this.dgNewRequests = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.cbAssignTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNewRequests
            // 
            this.dgNewRequests.AllowUserToAddRows = false;
            this.dgNewRequests.AllowUserToDeleteRows = false;
            this.dgNewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNewRequests.Location = new System.Drawing.Point(0, 73);
            this.dgNewRequests.Name = "dgNewRequests";
            this.dgNewRequests.ReadOnly = true;
            this.dgNewRequests.RowHeadersWidth = 455;
            this.dgNewRequests.Size = new System.Drawing.Size(973, 384);
            this.dgNewRequests.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 18F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 508);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 56);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAssign.Font = new System.Drawing.Font("Consolas", 18F);
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(811, 508);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(147, 56);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbAssignTo
            // 
            this.cbAssignTo.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.cbAssignTo.FormattingEnabled = true;
            this.cbAssignTo.Location = new System.Drawing.Point(509, 524);
            this.cbAssignTo.Name = "cbAssignTo";
            this.cbAssignTo.Size = new System.Drawing.Size(282, 30);
            this.cbAssignTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label1.Location = new System.Drawing.Point(505, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Assign To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkBlue;
            this.label8.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 56);
            this.label8.TabIndex = 19;
            this.label8.Text = "New Requests";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkBlue;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(-5, -4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(976, 76);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // MaNewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 592);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAssignTo);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgNewRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaNewRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgNewRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNewRequests;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ComboBox cbAssignTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}