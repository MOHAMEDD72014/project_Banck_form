namespace DVLDFormLayer.Test_Types
{
    partial class ManageTestTyps
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
            this.dgvManageTestTypes = new System.Windows.Forms.DataGridView();
            this.MenueType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblRecordMAT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Edite = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTestTypes)).BeginInit();
            this.MenueType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageTestTypes
            // 
            this.dgvManageTestTypes.AllowUserToAddRows = false;
            this.dgvManageTestTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageTestTypes.ContextMenuStrip = this.MenueType;
            this.dgvManageTestTypes.Location = new System.Drawing.Point(10, 172);
            this.dgvManageTestTypes.Name = "dgvManageTestTypes";
            this.dgvManageTestTypes.RowHeadersVisible = false;
            this.dgvManageTestTypes.Size = new System.Drawing.Size(800, 265);
            this.dgvManageTestTypes.TabIndex = 38;
            // 
            // MenueType
            // 
            this.MenueType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edite});
            this.MenueType.Name = "MenueType";
            this.MenueType.Size = new System.Drawing.Size(181, 48);
            // 
            // lblRecordMAT
            // 
            this.lblRecordMAT.AutoSize = true;
            this.lblRecordMAT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordMAT.Location = new System.Drawing.Point(96, 459);
            this.lblRecordMAT.Name = "lblRecordMAT";
            this.lblRecordMAT.Size = new System.Drawing.Size(15, 16);
            this.lblRecordMAT.TabIndex = 37;
            this.lblRecordMAT.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "# Records:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(250, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 41);
            this.label1.TabIndex = 34;
            this.label1.Text = "Manage Test Types";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edite
            // 
            this.Edite.Image = global::DVLDFormLayer.Properties.Resources.edit_321;
            this.Edite.Name = "Edite";
            this.Edite.Size = new System.Drawing.Size(180, 22);
            this.Edite.Text = "Edit Test Type";
            this.Edite.Click += new System.EventHandler(this.Edite_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDFormLayer.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(690, 454);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 32);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDFormLayer.Properties.Resources.TestType_512;
            this.pictureBox1.Location = new System.Drawing.Point(343, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // ManageTestTyps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 494);
            this.Controls.Add(this.dgvManageTestTypes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecordMAT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ManageTestTyps";
            this.Text = "ManageTestTyps";
            this.Load += new System.EventHandler(this.ManageTestTyps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTestTypes)).EndInit();
            this.MenueType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManageTestTypes;
        private System.Windows.Forms.ContextMenuStrip MenueType;
        private System.Windows.Forms.ToolStripMenuItem Edite;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecordMAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}