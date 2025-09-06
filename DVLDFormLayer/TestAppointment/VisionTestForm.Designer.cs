namespace DVLDFormLayer.TestAppointment
{
    partial class VisionTestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordApp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTestAppintment = new System.Windows.Forms.DataGridView();
            this.cmsEditeAppintMent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmEditeTestAppintment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlVisionTestInfo1 = new DVLDFormLayer.UserControls.ControlVisionTestInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppintment)).BeginInit();
            this.cmsEditeAppintMent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(267, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vision Test Appointment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecordApp
            // 
            this.lblRecordApp.AutoSize = true;
            this.lblRecordApp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordApp.Location = new System.Drawing.Point(91, 677);
            this.lblRecordApp.Name = "lblRecordApp";
            this.lblRecordApp.Size = new System.Drawing.Size(15, 16);
            this.lblRecordApp.TabIndex = 38;
            this.lblRecordApp.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 677);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "# Records:";
            // 
            // dgvTestAppintment
            // 
            this.dgvTestAppintment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTestAppintment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppintment.ContextMenuStrip = this.cmsEditeAppintMent;
            this.dgvTestAppintment.Location = new System.Drawing.Point(12, 525);
            this.dgvTestAppintment.Name = "dgvTestAppintment";
            this.dgvTestAppintment.Size = new System.Drawing.Size(910, 142);
            this.dgvTestAppintment.TabIndex = 39;
            // 
            // cmsEditeAppintMent
            // 
            this.cmsEditeAppintMent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmEditeTestAppintment,
            this.tsmTakeTest});
            this.cmsEditeAppintMent.Name = "cmsEdite";
            this.cmsEditeAppintMent.Size = new System.Drawing.Size(121, 48);
            this.cmsEditeAppintMent.Text = "Edite";
            this.cmsEditeAppintMent.Opening += new System.ComponentModel.CancelEventHandler(this.cmsEditeAppintMent_Opening);
            // 
            // TsmEditeTestAppintment
            // 
            this.TsmEditeTestAppintment.Image = global::DVLDFormLayer.Properties.Resources.edit_32;
            this.TsmEditeTestAppintment.Name = "TsmEditeTestAppintment";
            this.TsmEditeTestAppintment.Size = new System.Drawing.Size(120, 22);
            this.TsmEditeTestAppintment.Text = "Eddt";
            this.TsmEditeTestAppintment.Click += new System.EventHandler(this.TsmEditeTestAppintment_Click);
            // 
            // tsmTakeTest
            // 
            this.tsmTakeTest.Image = global::DVLDFormLayer.Properties.Resources.Test_32;
            this.tsmTakeTest.Name = "tsmTakeTest";
            this.tsmTakeTest.Size = new System.Drawing.Size(120, 22);
            this.tsmTakeTest.Text = "Take Test";
            this.tsmTakeTest.Click += new System.EventHandler(this.tsmTakeTest_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDFormLayer.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(810, 677);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 32);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DVLDFormLayer.Properties.Resources.AddAppointment_32;
            this.pictureBox2.Location = new System.Drawing.Point(861, 482);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDFormLayer.Properties.Resources.Vision_512;
            this.pictureBox1.Location = new System.Drawing.Point(385, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // controlVisionTestInfo1
            // 
            this.controlVisionTestInfo1.LocalID = 0;
            this.controlVisionTestInfo1.Location = new System.Drawing.Point(12, 128);
            this.controlVisionTestInfo1.Name = "controlVisionTestInfo1";
            this.controlVisionTestInfo1.Size = new System.Drawing.Size(893, 354);
            this.controlVisionTestInfo1.TabIndex = 16;
            // 
            // VisionTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 719);
            this.Controls.Add(this.dgvTestAppintment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordApp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.controlVisionTestInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "VisionTestForm";
            this.Text = "VisionTestForm";
            this.Load += new System.EventHandler(this.VisionTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppintment)).EndInit();
            this.cmsEditeAppintMent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private UserControls.ControlVisionTestInfo controlVisionTestInfo1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTestAppintment;
        private System.Windows.Forms.ContextMenuStrip cmsEditeAppintMent;
        private System.Windows.Forms.ToolStripMenuItem TsmEditeTestAppintment;
        private System.Windows.Forms.ToolStripMenuItem tsmTakeTest;
    }
}