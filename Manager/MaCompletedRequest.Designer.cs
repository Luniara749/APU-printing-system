namespace APU_Printing_System__G24.Manager
{
    partial class MaCompletedRequest
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
            this.dgCompletedReq = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAcceptPayment = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompletedReq)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCompletedReq
            // 
            this.dgCompletedReq.AllowUserToAddRows = false;
            this.dgCompletedReq.AllowUserToDeleteRows = false;
            this.dgCompletedReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompletedReq.Location = new System.Drawing.Point(1, 77);
            this.dgCompletedReq.Name = "dgCompletedReq";
            this.dgCompletedReq.ReadOnly = true;
            this.dgCompletedReq.RowHeadersWidth = 355;
            this.dgCompletedReq.Size = new System.Drawing.Size(973, 326);
            this.dgCompletedReq.TabIndex = 0;
            this.dgCompletedReq.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCompletedReq_RowHeaderMouseClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 18F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(22, 510);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 56);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAcceptPayment
            // 
            this.btnAcceptPayment.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAcceptPayment.Font = new System.Drawing.Font("Consolas", 18F);
            this.btnAcceptPayment.ForeColor = System.Drawing.Color.White;
            this.btnAcceptPayment.Location = new System.Drawing.Point(738, 510);
            this.btnAcceptPayment.Name = "btnAcceptPayment";
            this.btnAcceptPayment.Size = new System.Drawing.Size(220, 56);
            this.btnAcceptPayment.TabIndex = 2;
            this.btnAcceptPayment.Text = "Accept Payment";
            this.btnAcceptPayment.UseVisualStyleBackColor = false;
            this.btnAcceptPayment.Click += new System.EventHandler(this.btnAcceptPayment_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkBlue;
            this.label8.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(466, 56);
            this.label8.TabIndex = 19;
            this.label8.Text = "Completed Request";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkBlue;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(976, 76);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // MaCompletedRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 592);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAcceptPayment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgCompletedReq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaCompletedRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgCompletedReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCompletedReq;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAcceptPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}