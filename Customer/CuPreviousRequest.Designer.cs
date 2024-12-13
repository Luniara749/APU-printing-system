namespace APU_Printing_System__G24.Customer
{
    partial class CuPreviousRequest
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
            this.dgPreviousRequest = new System.Windows.Forms.DataGridView();
            this.lbWelcom = new System.Windows.Forms.Label();
            this.lblWelcomeBg = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPreviousRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPreviousRequest
            // 
            this.dgPreviousRequest.AllowUserToAddRows = false;
            this.dgPreviousRequest.AllowUserToDeleteRows = false;
            this.dgPreviousRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPreviousRequest.Location = new System.Drawing.Point(1, 78);
            this.dgPreviousRequest.Name = "dgPreviousRequest";
            this.dgPreviousRequest.ReadOnly = true;
            this.dgPreviousRequest.RowHeadersWidth = 270;
            this.dgPreviousRequest.Size = new System.Drawing.Size(968, 419);
            this.dgPreviousRequest.TabIndex = 0;
            // 
            // lbWelcom
            // 
            this.lbWelcom.AutoSize = true;
            this.lbWelcom.BackColor = System.Drawing.Color.DarkBlue;
            this.lbWelcom.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold);
            this.lbWelcom.ForeColor = System.Drawing.Color.White;
            this.lbWelcom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbWelcom.Location = new System.Drawing.Point(11, 10);
            this.lbWelcom.Name = "lbWelcom";
            this.lbWelcom.Size = new System.Drawing.Size(492, 56);
            this.lbWelcom.TabIndex = 28;
            this.lbWelcom.Text = "Previous Requests ";
            // 
            // lblWelcomeBg
            // 
            this.lblWelcomeBg.BackColor = System.Drawing.Color.DarkBlue;
            this.lblWelcomeBg.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWelcomeBg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWelcomeBg.Location = new System.Drawing.Point(-1, 1);
            this.lblWelcomeBg.Name = "lblWelcomeBg";
            this.lblWelcomeBg.Size = new System.Drawing.Size(976, 76);
            this.lblWelcomeBg.TabIndex = 27;
            this.lblWelcomeBg.Text = "label7";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(21, 522);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 56);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CuPreviousRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 592);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbWelcom);
            this.Controls.Add(this.lblWelcomeBg);
            this.Controls.Add(this.dgPreviousRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CuPreviousRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgPreviousRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPreviousRequest;
        private System.Windows.Forms.Label lbWelcom;
        private System.Windows.Forms.Label lblWelcomeBg;
        private System.Windows.Forms.Button btnBack;
    }
}