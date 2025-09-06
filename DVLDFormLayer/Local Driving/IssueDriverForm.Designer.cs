namespace DVLDFormLayer.Local_Driving
{
    partial class IssueDriverForm
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
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.controlVisionTestInfo1 = new DVLDFormLayer.UserControls.ControlVisionTestInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(154, 361);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(742, 97);
            this.txtNotes.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(32, 370);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 13);
            this.label.TabIndex = 160;
            this.label.Text = "Notes:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLDFormLayer.Properties.Resources.New_Driving_License_321;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(793, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 32);
            this.btnSave.TabIndex = 163;
            this.btnSave.Text = "   Issue";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDFormLayer.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(671, 488);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 32);
            this.btnClose.TabIndex = 162;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::DVLDFormLayer.Properties.Resources.Notes_32;
            this.pictureBox2.Location = new System.Drawing.Point(99, 363);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 161;
            this.pictureBox2.TabStop = false;
            // 
            // controlVisionTestInfo1
            // 
            this.controlVisionTestInfo1.LocalID = 0;
            this.controlVisionTestInfo1.Location = new System.Drawing.Point(3, 1);
            this.controlVisionTestInfo1.Name = "controlVisionTestInfo1";
            this.controlVisionTestInfo1.Size = new System.Drawing.Size(893, 354);
            this.controlVisionTestInfo1.TabIndex = 0;
            // 
            // IssueDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 532);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.controlVisionTestInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "IssueDriverForm";
            this.Text = "IssueDriverForm";
            this.Load += new System.EventHandler(this.IssueDriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ControlVisionTestInfo controlVisionTestInfo1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}