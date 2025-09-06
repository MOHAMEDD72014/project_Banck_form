namespace project_Banck_form
{
    partial class Update
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
            this.txAcuntBalanceUP = new System.Windows.Forms.MaskedTextBox();
            this.txPhoneUP = new System.Windows.Forms.MaskedTextBox();
            this.txPinUP = new System.Windows.Forms.MaskedTextBox();
            this.txNameUP = new System.Windows.Forms.MaskedTextBox();
            this.txAcuntNumberUP = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txAcuntBalanceUP
            // 
            this.txAcuntBalanceUP.Location = new System.Drawing.Point(181, 229);
            this.txAcuntBalanceUP.Name = "txAcuntBalanceUP";
            this.txAcuntBalanceUP.Size = new System.Drawing.Size(139, 20);
            this.txAcuntBalanceUP.TabIndex = 25;
            // 
            // txPhoneUP
            // 
            this.txPhoneUP.Location = new System.Drawing.Point(181, 177);
            this.txPhoneUP.Name = "txPhoneUP";
            this.txPhoneUP.Size = new System.Drawing.Size(139, 20);
            this.txPhoneUP.TabIndex = 24;
            // 
            // txPinUP
            // 
            this.txPinUP.Location = new System.Drawing.Point(181, 128);
            this.txPinUP.Name = "txPinUP";
            this.txPinUP.Size = new System.Drawing.Size(139, 20);
            this.txPinUP.TabIndex = 23;
            // 
            // txNameUP
            // 
            this.txNameUP.Location = new System.Drawing.Point(181, 77);
            this.txNameUP.Name = "txNameUP";
            this.txNameUP.Size = new System.Drawing.Size(139, 20);
            this.txNameUP.TabIndex = 22;
            // 
            // txAcuntNumberUP
            // 
            this.txAcuntNumberUP.BeepOnError = true;
            this.txAcuntNumberUP.Location = new System.Drawing.Point(181, 31);
            this.txAcuntNumberUP.Name = "txAcuntNumberUP";
            this.txAcuntNumberUP.Size = new System.Drawing.Size(139, 20);
            this.txAcuntNumberUP.TabIndex = 21;
            this.txAcuntNumberUP.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pin Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Clint Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "acunt Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Acunt Number";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(318, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 33);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txAcuntBalanceUP);
            this.Controls.Add(this.txPhoneUP);
            this.Controls.Add(this.txPinUP);
            this.Controls.Add(this.txNameUP);
            this.Controls.Add(this.txAcuntNumberUP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txAcuntBalanceUP;
        private System.Windows.Forms.MaskedTextBox txPhoneUP;
        private System.Windows.Forms.MaskedTextBox txPinUP;
        private System.Windows.Forms.MaskedTextBox txNameUP;
        private System.Windows.Forms.MaskedTextBox txAcuntNumberUP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
    }
}