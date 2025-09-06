namespace project_Banck_form
{
    partial class homeBank
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpShowClint = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAcunteNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAcuntBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpAddNewClinte = new System.Windows.Forms.TabPage();
            this.txAcuntBalance = new System.Windows.Forms.MaskedTextBox();
            this.txphon = new System.Windows.Forms.MaskedTextBox();
            this.txPin = new System.Windows.Forms.MaskedTextBox();
            this.txName = new System.Windows.Forms.MaskedTextBox();
            this.txAcuntNumber = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.TpUpdetClint = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.txUpdateSrch = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpDeleteClinte = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.btnSarch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxAcuntNumberDelete = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTranactions = new System.Windows.Forms.Button();
            this.btnUpdateClinte = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.TpShowClint.SuspendLayout();
            this.tpAddNewClinte.SuspendLayout();
            this.TpUpdetClint.SuspendLayout();
            this.tpDeleteClinte.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TpShowClint);
            this.tabControl1.Controls.Add(this.tpAddNewClinte);
            this.tabControl1.Controls.Add(this.TpUpdetClint);
            this.tabControl1.Controls.Add(this.tpDeleteClinte);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 10);
            this.tabControl1.Location = new System.Drawing.Point(215, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 440);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TpShowClint
            // 
            this.TpShowClint.Controls.Add(this.listView1);
            this.TpShowClint.Location = new System.Drawing.Point(4, 14);
            this.TpShowClint.Name = "TpShowClint";
            this.TpShowClint.Size = new System.Drawing.Size(672, 422);
            this.TpShowClint.TabIndex = 3;
            this.TpShowClint.Text = "show Clint";
            this.TpShowClint.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Gray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chAcunteNumber,
            this.chPin,
            this.chPhone,
            this.chAcuntBalance});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(672, 424);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 153;
            // 
            // chAcunteNumber
            // 
            this.chAcunteNumber.Text = "AcuntNumber";
            this.chAcunteNumber.Width = 135;
            // 
            // chPin
            // 
            this.chPin.Text = "Pin";
            this.chPin.Width = 87;
            // 
            // chPhone
            // 
            this.chPhone.Text = "Clinte Phone";
            this.chPhone.Width = 145;
            // 
            // chAcuntBalance
            // 
            this.chAcuntBalance.Text = "Acunt Balance";
            this.chAcuntBalance.Width = 244;
            // 
            // tpAddNewClinte
            // 
            this.tpAddNewClinte.Controls.Add(this.txAcuntBalance);
            this.tpAddNewClinte.Controls.Add(this.txphon);
            this.tpAddNewClinte.Controls.Add(this.txPin);
            this.tpAddNewClinte.Controls.Add(this.txName);
            this.tpAddNewClinte.Controls.Add(this.txAcuntNumber);
            this.tpAddNewClinte.Controls.Add(this.label5);
            this.tpAddNewClinte.Controls.Add(this.label4);
            this.tpAddNewClinte.Controls.Add(this.label3);
            this.tpAddNewClinte.Controls.Add(this.label2);
            this.tpAddNewClinte.Controls.Add(this.label1);
            this.tpAddNewClinte.Controls.Add(this.button4);
            this.tpAddNewClinte.Location = new System.Drawing.Point(4, 54);
            this.tpAddNewClinte.Name = "tpAddNewClinte";
            this.tpAddNewClinte.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddNewClinte.Size = new System.Drawing.Size(672, 384);
            this.tpAddNewClinte.TabIndex = 4;
            this.tpAddNewClinte.Text = "Add New Clint";
            this.tpAddNewClinte.UseVisualStyleBackColor = true;
            // 
            // txAcuntBalance
            // 
            this.txAcuntBalance.Location = new System.Drawing.Point(257, 257);
            this.txAcuntBalance.Name = "txAcuntBalance";
            this.txAcuntBalance.Size = new System.Drawing.Size(139, 20);
            this.txAcuntBalance.TabIndex = 15;
            this.txAcuntBalance.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txAcuntBalance_MaskInputRejected);
            this.txAcuntBalance.Validating += new System.ComponentModel.CancelEventHandler(this.txAcuntBalance_Validating);
            // 
            // txphon
            // 
            this.txphon.Location = new System.Drawing.Point(257, 205);
            this.txphon.Name = "txphon";
            this.txphon.Size = new System.Drawing.Size(139, 20);
            this.txphon.TabIndex = 14;
            this.txphon.Validating += new System.ComponentModel.CancelEventHandler(this.txphon_Validating);
            // 
            // txPin
            // 
            this.txPin.Location = new System.Drawing.Point(257, 156);
            this.txPin.Name = "txPin";
            this.txPin.Size = new System.Drawing.Size(139, 20);
            this.txPin.TabIndex = 13;
            this.txPin.Validating += new System.ComponentModel.CancelEventHandler(this.txPin_Validating);
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(257, 105);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(139, 20);
            this.txName.TabIndex = 12;
            this.txName.Validating += new System.ComponentModel.CancelEventHandler(this.txName_Validating);
            // 
            // txAcuntNumber
            // 
            this.txAcuntNumber.BeepOnError = true;
            this.txAcuntNumber.Location = new System.Drawing.Point(257, 59);
            this.txAcuntNumber.Name = "txAcuntNumber";
            this.txAcuntNumber.Size = new System.Drawing.Size(139, 20);
            this.txAcuntNumber.TabIndex = 11;
            this.txAcuntNumber.ValidatingType = typeof(int);
            this.txAcuntNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txAcuntNumber_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pin Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clint Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "acunt Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acunt Number";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(461, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "Add Clint";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TpUpdetClint
            // 
            this.TpUpdetClint.Controls.Add(this.label9);
            this.TpUpdetClint.Controls.Add(this.listView3);
            this.TpUpdetClint.Controls.Add(this.button3);
            this.TpUpdetClint.Controls.Add(this.txUpdateSrch);
            this.TpUpdetClint.Controls.Add(this.label8);
            this.TpUpdetClint.Location = new System.Drawing.Point(4, 54);
            this.TpUpdetClint.Name = "TpUpdetClint";
            this.TpUpdetClint.Padding = new System.Windows.Forms.Padding(3);
            this.TpUpdetClint.Size = new System.Drawing.Size(672, 384);
            this.TpUpdetClint.TabIndex = 2;
            this.TpUpdetClint.Text = "Update Clint";
            this.TpUpdetClint.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Update Form";
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3.GridLines = true;
            this.listView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(4, 52);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(672, 66);
            this.listView3.TabIndex = 5;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 153;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "AcuntNumber";
            this.columnHeader7.Width = 135;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Pin";
            this.columnHeader8.Width = 87;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Clinte Phone";
            this.columnHeader9.Width = 145;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Acunt Balance";
            this.columnHeader10.Width = 244;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(439, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sarch";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txUpdateSrch
            // 
            this.txUpdateSrch.Location = new System.Drawing.Point(283, 172);
            this.txUpdateSrch.Name = "txUpdateSrch";
            this.txUpdateSrch.Size = new System.Drawing.Size(140, 20);
            this.txUpdateSrch.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Acunt Number";
            // 
            // tpDeleteClinte
            // 
            this.tpDeleteClinte.Controls.Add(this.listView2);
            this.tpDeleteClinte.Controls.Add(this.label7);
            this.tpDeleteClinte.Controls.Add(this.btnSarch);
            this.tpDeleteClinte.Controls.Add(this.label6);
            this.tpDeleteClinte.Controls.Add(this.TxAcuntNumberDelete);
            this.tpDeleteClinte.Location = new System.Drawing.Point(4, 54);
            this.tpDeleteClinte.Name = "tpDeleteClinte";
            this.tpDeleteClinte.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeleteClinte.Size = new System.Drawing.Size(672, 384);
            this.tpDeleteClinte.TabIndex = 5;
            this.tpDeleteClinte.Text = "Delete Clint";
            this.tpDeleteClinte.UseVisualStyleBackColor = true;
            this.tpDeleteClinte.Click += new System.EventHandler(this.tpDeleteClinte_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 48);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(672, 69);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 153;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AcuntNumber";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pin";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Clinte Phone";
            this.columnHeader4.Width = 145;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Acunt Balance";
            this.columnHeader5.Width = 244;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Delete Clinte";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnSarch
            // 
            this.btnSarch.Location = new System.Drawing.Point(433, 178);
            this.btnSarch.Name = "btnSarch";
            this.btnSarch.Size = new System.Drawing.Size(75, 23);
            this.btnSarch.TabIndex = 2;
            this.btnSarch.Text = "Sarch";
            this.btnSarch.UseVisualStyleBackColor = true;
            this.btnSarch.Click += new System.EventHandler(this.btnSarch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Acunt Number";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxAcuntNumberDelete
            // 
            this.TxAcuntNumberDelete.Location = new System.Drawing.Point(253, 180);
            this.TxAcuntNumberDelete.Name = "TxAcuntNumberDelete";
            this.TxAcuntNumberDelete.Size = new System.Drawing.Size(140, 20);
            this.TxAcuntNumberDelete.TabIndex = 0;
            this.TxAcuntNumberDelete.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxAcuntNumberDelete_MaskInputRejected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnTranactions);
            this.panel1.Controls.Add(this.btnUpdateClinte);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(9, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 428);
            this.panel1.TabIndex = 1;
            // 
            // btnTranactions
            // 
            this.btnTranactions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranactions.Location = new System.Drawing.Point(51, 342);
            this.btnTranactions.Name = "btnTranactions";
            this.btnTranactions.Size = new System.Drawing.Size(121, 57);
            this.btnTranactions.TabIndex = 4;
            this.btnTranactions.Text = "Tranactions";
            this.btnTranactions.UseVisualStyleBackColor = true;
            this.btnTranactions.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUpdateClinte
            // 
            this.btnUpdateClinte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClinte.Location = new System.Drawing.Point(51, 269);
            this.btnUpdateClinte.Name = "btnUpdateClinte";
            this.btnUpdateClinte.Size = new System.Drawing.Size(121, 57);
            this.btnUpdateClinte.TabIndex = 3;
            this.btnUpdateClinte.Text = "Update Clint";
            this.btnUpdateClinte.UseVisualStyleBackColor = true;
            this.btnUpdateClinte.Click += new System.EventHandler(this.btnUpdateClinte_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(51, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 57);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Clint";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(51, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Clint";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Clint";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // homeBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "homeBank";
            this.Text = "homeBank";
            this.tabControl1.ResumeLayout(false);
            this.TpShowClint.ResumeLayout(false);
            this.tpAddNewClinte.ResumeLayout(false);
            this.tpAddNewClinte.PerformLayout();
            this.TpUpdetClint.ResumeLayout(false);
            this.TpUpdetClint.PerformLayout();
            this.tpDeleteClinte.ResumeLayout(false);
            this.tpDeleteClinte.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpUpdetClint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage TpShowClint;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAcunteNumber;
        private System.Windows.Forms.ColumnHeader chPin;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chAcuntBalance;
        private System.Windows.Forms.TabPage tpAddNewClinte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox txphon;
        private System.Windows.Forms.MaskedTextBox txPin;
        private System.Windows.Forms.MaskedTextBox txName;
        private System.Windows.Forms.MaskedTextBox txAcuntNumber;
        private System.Windows.Forms.MaskedTextBox txAcuntBalance;
        private System.Windows.Forms.Button btnUpdateClinte;
        private System.Windows.Forms.TabPage tpDeleteClinte;
        private System.Windows.Forms.MaskedTextBox TxAcuntNumberDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSarch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox txUpdateSrch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnTranactions;
    }
}