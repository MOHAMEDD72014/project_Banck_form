namespace DVLDFormLayer
{
    partial class PersonDetailsForm
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
            this.UserControlDetails = new DVLDFormLayer.PersonInformation();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserControlDetails
            // 
            this.UserControlDetails.Location = new System.Drawing.Point(12, 68);
            this.UserControlDetails.Name = "UserControlDetails";
            this.UserControlDetails.Size = new System.Drawing.Size(828, 220);
            this.UserControlDetails.TabIndex = 0;
            this.UserControlDetails.Load += new System.EventHandler(this.UserControlDetails_Load);
            // 
            // lblStats
            // 
            this.lblStats.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStats.Location = new System.Drawing.Point(299, 9);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(179, 41);
            this.lblStats.TabIndex = 83;
            this.lblStats.Text = "Person Details";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDFormLayer.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(649, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 32);
            this.btnClose.TabIndex = 108;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PersonDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 359);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.UserControlDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonDetailsForm";
            this.Text = "PersonDetailsForm";
            this.Load += new System.EventHandler(this.PersonDetailsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInformation UserControlDetails;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnClose;
    }
}