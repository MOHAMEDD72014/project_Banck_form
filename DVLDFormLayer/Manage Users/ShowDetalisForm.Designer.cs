namespace DVLDFormLayer.Manage_Users
{
    partial class ShowDetalisForm
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
            this.personInformation1 = new DVLDFormLayer.PersonInformation();
            this.userCuntrolInformatinUser1 = new DVLDFormLayer.UserControls.UserCuntrolInformatinUser();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personInformation1
            // 
            this.personInformation1.Location = new System.Drawing.Point(12, 12);
            this.personInformation1.Name = "personInformation1";
            this.personInformation1.Size = new System.Drawing.Size(840, 220);
            this.personInformation1.TabIndex = 0;
            // 
            // userCuntrolInformatinUser1
            // 
            this.userCuntrolInformatinUser1.Location = new System.Drawing.Point(12, 238);
            this.userCuntrolInformatinUser1.Name = "userCuntrolInformatinUser1";
            this.userCuntrolInformatinUser1.Size = new System.Drawing.Size(839, 79);
            this.userCuntrolInformatinUser1.TabIndex = 1;
            this.userCuntrolInformatinUser1.UserID = 0;
            this.userCuntrolInformatinUser1.Load += new System.EventHandler(this.userCuntrolInformatinUser1_Load);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DVLDFormLayer.Properties.Resources.cross_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(713, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 32);
            this.button2.TabIndex = 134;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShowDetalisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 385);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userCuntrolInformatinUser1);
            this.Controls.Add(this.personInformation1);
            this.Name = "ShowDetalisForm";
            this.Text = "ShowDetalisForm";
            this.Load += new System.EventHandler(this.ShowDetalisForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInformation personInformation1;
        private UserControls.UserCuntrolInformatinUser userCuntrolInformatinUser1;
        private System.Windows.Forms.Button button2;
    }
}