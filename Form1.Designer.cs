namespace Loan_App
{
    partial class Form1
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
            this.tbcLoan = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.btnCustomerCreateNewLoan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Customers = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.txtVoterID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLoanInfo = new System.Windows.Forms.TabPage();
            this.btnTransactionDelete = new System.Windows.Forms.Button();
            this.btnLoanDelete = new System.Windows.Forms.Button();
            this.txtLoan2PercentAmt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtLoan3PercentAmt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtLoanPrincipalOwed = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtLoanMonthlyInterest = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLoanTransactionID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpLoanPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLoanSavePayment = new System.Windows.Forms.Button();
            this.txtLoanMakePayment = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLoanSave = new System.Windows.Forms.Button();
            this.btnLoanReset = new System.Windows.Forms.Button();
            this.btnLoanNewLoan = new System.Windows.Forms.Button();
            this.dgvLoanTransactionInfo = new System.Windows.Forms.DataGridView();
            this.dgvLoanLoanInfo = new System.Windows.Forms.DataGridView();
            this.txtLoanNewLoanAmt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDateOfLoan = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLoanLastName = new System.Windows.Forms.TextBox();
            this.txtLoanFirstname = new System.Windows.Forms.TextBox();
            this.txtLoanCustomerID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLoanLoanID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabTxHistory = new System.Windows.Forms.TabPage();
            this.tbcLoan.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.tabLoanInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanTransactionInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanLoanInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcLoan
            // 
            this.tbcLoan.AccessibleName = "asdf";
            this.tbcLoan.Controls.Add(this.tabCustomer);
            this.tbcLoan.Controls.Add(this.tabLoanInfo);
            this.tbcLoan.Controls.Add(this.tabTxHistory);
            this.tbcLoan.Location = new System.Drawing.Point(5, 6);
            this.tbcLoan.Name = "tbcLoan";
            this.tbcLoan.SelectedIndex = 0;
            this.tbcLoan.Size = new System.Drawing.Size(1217, 650);
            this.tbcLoan.TabIndex = 0;
            this.tbcLoan.Click += new System.EventHandler(this.TbcLoan_Click);
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackColor = System.Drawing.Color.White;
            this.tabCustomer.Controls.Add(this.btnCustomerCreateNewLoan);
            this.tabCustomer.Controls.Add(this.btnReset);
            this.tabCustomer.Controls.Add(this.btnDelete);
            this.tabCustomer.Controls.Add(this.btnSave);
            this.tabCustomer.Controls.Add(this.btnSearch);
            this.tabCustomer.Controls.Add(this.label8);
            this.tabCustomer.Controls.Add(this.label7);
            this.tabCustomer.Controls.Add(this.Customers);
            this.tabCustomer.Controls.Add(this.dgvCustomers);
            this.tabCustomer.Controls.Add(this.dgvTransactions);
            this.tabCustomer.Controls.Add(this.dgvLoans);
            this.tabCustomer.Controls.Add(this.txtVoterID);
            this.tabCustomer.Controls.Add(this.txtEmail);
            this.tabCustomer.Controls.Add(this.dtpDOB);
            this.tabCustomer.Controls.Add(this.txtLastName);
            this.tabCustomer.Controls.Add(this.txtFirstName);
            this.tabCustomer.Controls.Add(this.txtCustomerID);
            this.tabCustomer.Controls.Add(this.label6);
            this.tabCustomer.Controls.Add(this.label5);
            this.tabCustomer.Controls.Add(this.label4);
            this.tabCustomer.Controls.Add(this.label3);
            this.tabCustomer.Controls.Add(this.label2);
            this.tabCustomer.Controls.Add(this.label1);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(1209, 624);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "Customer Info";
            this.tabCustomer.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // btnCustomerCreateNewLoan
            // 
            this.btnCustomerCreateNewLoan.Location = new System.Drawing.Point(22, 275);
            this.btnCustomerCreateNewLoan.Name = "btnCustomerCreateNewLoan";
            this.btnCustomerCreateNewLoan.Size = new System.Drawing.Size(373, 23);
            this.btnCustomerCreateNewLoan.TabIndex = 22;
            this.btnCustomerCreateNewLoan.Text = " Create New Loan";
            this.btnCustomerCreateNewLoan.UseVisualStyleBackColor = true;
            this.btnCustomerCreateNewLoan.Click += new System.EventHandler(this.BtnCustomerCreateNewLoan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(220, 236);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 236);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(224, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Loans";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(874, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Transactions";
            // 
            // Customers
            // 
            this.Customers.AutoSize = true;
            this.Customers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers.Location = new System.Drawing.Point(826, 17);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(56, 13);
            this.Customers.TabIndex = 15;
            this.Customers.Text = "Customers";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(504, 51);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(679, 238);
            this.dgvCustomers.TabIndex = 14;
            this.dgvCustomers.DoubleClick += new System.EventHandler(this.DgvCustomers_DoubleClick);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(621, 343);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.Size = new System.Drawing.Size(562, 245);
            this.dgvTransactions.TabIndex = 13;
            // 
            // dgvLoans
            // 
            this.dgvLoans.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(22, 343);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.Size = new System.Drawing.Size(562, 245);
            this.dgvLoans.TabIndex = 12;
            this.dgvLoans.DoubleClick += new System.EventHandler(this.DgvLoans_DoubleClick);
            // 
            // txtVoterID
            // 
            this.txtVoterID.Location = new System.Drawing.Point(127, 187);
            this.txtVoterID.Name = "txtVoterID";
            this.txtVoterID.Size = new System.Drawing.Size(200, 20);
            this.txtVoterID.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(127, 119);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(127, 85);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(127, 51);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(127, 17);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Voter ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // tabLoanInfo
            // 
            this.tabLoanInfo.Controls.Add(this.btnTransactionDelete);
            this.tabLoanInfo.Controls.Add(this.btnLoanDelete);
            this.tabLoanInfo.Controls.Add(this.txtLoan2PercentAmt);
            this.tabLoanInfo.Controls.Add(this.label22);
            this.tabLoanInfo.Controls.Add(this.txtLoan3PercentAmt);
            this.tabLoanInfo.Controls.Add(this.label21);
            this.tabLoanInfo.Controls.Add(this.txtLoanPrincipalOwed);
            this.tabLoanInfo.Controls.Add(this.label20);
            this.tabLoanInfo.Controls.Add(this.txtLoanMonthlyInterest);
            this.tabLoanInfo.Controls.Add(this.label19);
            this.tabLoanInfo.Controls.Add(this.txtLoanTransactionID);
            this.tabLoanInfo.Controls.Add(this.label18);
            this.tabLoanInfo.Controls.Add(this.label17);
            this.tabLoanInfo.Controls.Add(this.dtpLoanPaymentDate);
            this.tabLoanInfo.Controls.Add(this.label16);
            this.tabLoanInfo.Controls.Add(this.btnLoanSavePayment);
            this.tabLoanInfo.Controls.Add(this.txtLoanMakePayment);
            this.tabLoanInfo.Controls.Add(this.label15);
            this.tabLoanInfo.Controls.Add(this.btnLoanSave);
            this.tabLoanInfo.Controls.Add(this.btnLoanReset);
            this.tabLoanInfo.Controls.Add(this.btnLoanNewLoan);
            this.tabLoanInfo.Controls.Add(this.dgvLoanTransactionInfo);
            this.tabLoanInfo.Controls.Add(this.dgvLoanLoanInfo);
            this.tabLoanInfo.Controls.Add(this.txtLoanNewLoanAmt);
            this.tabLoanInfo.Controls.Add(this.label11);
            this.tabLoanInfo.Controls.Add(this.dtpDateOfLoan);
            this.tabLoanInfo.Controls.Add(this.label9);
            this.tabLoanInfo.Controls.Add(this.txtLoanLastName);
            this.tabLoanInfo.Controls.Add(this.txtLoanFirstname);
            this.tabLoanInfo.Controls.Add(this.txtLoanCustomerID);
            this.tabLoanInfo.Controls.Add(this.label12);
            this.tabLoanInfo.Controls.Add(this.label13);
            this.tabLoanInfo.Controls.Add(this.label14);
            this.tabLoanInfo.Controls.Add(this.txtLoanLoanID);
            this.tabLoanInfo.Controls.Add(this.label10);
            this.tabLoanInfo.Location = new System.Drawing.Point(4, 22);
            this.tabLoanInfo.Name = "tabLoanInfo";
            this.tabLoanInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoanInfo.Size = new System.Drawing.Size(1209, 624);
            this.tabLoanInfo.TabIndex = 1;
            this.tabLoanInfo.Text = " Loan Info";
            this.tabLoanInfo.UseVisualStyleBackColor = true;
            this.tabLoanInfo.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // btnTransactionDelete
            // 
            this.btnTransactionDelete.Location = new System.Drawing.Point(310, 517);
            this.btnTransactionDelete.Name = "btnTransactionDelete";
            this.btnTransactionDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTransactionDelete.TabIndex = 42;
            this.btnTransactionDelete.Text = "Delete";
            this.btnTransactionDelete.UseVisualStyleBackColor = true;
            this.btnTransactionDelete.Click += new System.EventHandler(this.BtnTransactionDelete_Click);
            // 
            // btnLoanDelete
            // 
            this.btnLoanDelete.Location = new System.Drawing.Point(265, 224);
            this.btnLoanDelete.Name = "btnLoanDelete";
            this.btnLoanDelete.Size = new System.Drawing.Size(100, 25);
            this.btnLoanDelete.TabIndex = 41;
            this.btnLoanDelete.Text = "Delete";
            this.btnLoanDelete.UseVisualStyleBackColor = true;
            this.btnLoanDelete.Click += new System.EventHandler(this.BtnLoanDelete_Click);
            // 
            // txtLoan2PercentAmt
            // 
            this.txtLoan2PercentAmt.Location = new System.Drawing.Point(163, 517);
            this.txtLoan2PercentAmt.Name = "txtLoan2PercentAmt";
            this.txtLoan2PercentAmt.Size = new System.Drawing.Size(50, 20);
            this.txtLoan2PercentAmt.TabIndex = 40;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 520);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(138, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "2% Monthly Interest Amount";
            // 
            // txtLoan3PercentAmt
            // 
            this.txtLoan3PercentAmt.Location = new System.Drawing.Point(163, 487);
            this.txtLoan3PercentAmt.Name = "txtLoan3PercentAmt";
            this.txtLoan3PercentAmt.Size = new System.Drawing.Size(50, 20);
            this.txtLoan3PercentAmt.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 490);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(138, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "3% Monthly Interest Amount";
            // 
            // txtLoanPrincipalOwed
            // 
            this.txtLoanPrincipalOwed.Location = new System.Drawing.Point(165, 370);
            this.txtLoanPrincipalOwed.Name = "txtLoanPrincipalOwed";
            this.txtLoanPrincipalOwed.Size = new System.Drawing.Size(200, 20);
            this.txtLoanPrincipalOwed.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 370);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Principal Owed";
            // 
            // txtLoanMonthlyInterest
            // 
            this.txtLoanMonthlyInterest.Location = new System.Drawing.Point(163, 400);
            this.txtLoanMonthlyInterest.Name = "txtLoanMonthlyInterest";
            this.txtLoanMonthlyInterest.Size = new System.Drawing.Size(200, 20);
            this.txtLoanMonthlyInterest.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 400);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Monthly Interest Amount";
            // 
            // txtLoanTransactionID
            // 
            this.txtLoanTransactionID.Location = new System.Drawing.Point(165, 340);
            this.txtLoanTransactionID.Name = "txtLoanTransactionID";
            this.txtLoanTransactionID.Size = new System.Drawing.Size(200, 20);
            this.txtLoanTransactionID.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 340);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Transaction ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 430);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Date Of Payment";
            // 
            // dtpLoanPaymentDate
            // 
            this.dtpLoanPaymentDate.Location = new System.Drawing.Point(163, 430);
            this.dtpLoanPaymentDate.Name = "dtpLoanPaymentDate";
            this.dtpLoanPaymentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpLoanPaymentDate.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(122, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 25);
            this.label16.TabIndex = 28;
            this.label16.Text = "Make Payment";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLoanSavePayment
            // 
            this.btnLoanSavePayment.Location = new System.Drawing.Point(225, 517);
            this.btnLoanSavePayment.Name = "btnLoanSavePayment";
            this.btnLoanSavePayment.Size = new System.Drawing.Size(75, 23);
            this.btnLoanSavePayment.TabIndex = 26;
            this.btnLoanSavePayment.Text = "Save";
            this.btnLoanSavePayment.UseVisualStyleBackColor = true;
            this.btnLoanSavePayment.Click += new System.EventHandler(this.BtnLoanSavePayment_Click);
            // 
            // txtLoanMakePayment
            // 
            this.txtLoanMakePayment.Location = new System.Drawing.Point(163, 460);
            this.txtLoanMakePayment.Name = "txtLoanMakePayment";
            this.txtLoanMakePayment.Size = new System.Drawing.Size(200, 20);
            this.txtLoanMakePayment.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 460);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Enter Payment Amount";
            // 
            // btnLoanSave
            // 
            this.btnLoanSave.Location = new System.Drawing.Point(20, 224);
            this.btnLoanSave.Name = "btnLoanSave";
            this.btnLoanSave.Size = new System.Drawing.Size(100, 25);
            this.btnLoanSave.TabIndex = 23;
            this.btnLoanSave.Text = "Save";
            this.btnLoanSave.UseVisualStyleBackColor = true;
            this.btnLoanSave.Click += new System.EventHandler(this.BtnLoanSave_Click);
            // 
            // btnLoanReset
            // 
            this.btnLoanReset.Location = new System.Drawing.Point(145, 224);
            this.btnLoanReset.Name = "btnLoanReset";
            this.btnLoanReset.Size = new System.Drawing.Size(100, 25);
            this.btnLoanReset.TabIndex = 22;
            this.btnLoanReset.Text = "Reset";
            this.btnLoanReset.UseVisualStyleBackColor = true;
            this.btnLoanReset.Click += new System.EventHandler(this.BtnLoanReset_Click);
            // 
            // btnLoanNewLoan
            // 
            this.btnLoanNewLoan.Location = new System.Drawing.Point(22, 255);
            this.btnLoanNewLoan.Name = "btnLoanNewLoan";
            this.btnLoanNewLoan.Size = new System.Drawing.Size(343, 25);
            this.btnLoanNewLoan.TabIndex = 21;
            this.btnLoanNewLoan.Text = "New Loan";
            this.btnLoanNewLoan.UseVisualStyleBackColor = true;
            this.btnLoanNewLoan.Click += new System.EventHandler(this.BtnLoanNewLoan_Click);
            // 
            // dgvLoanTransactionInfo
            // 
            this.dgvLoanTransactionInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanTransactionInfo.Location = new System.Drawing.Point(404, 319);
            this.dgvLoanTransactionInfo.Name = "dgvLoanTransactionInfo";
            this.dgvLoanTransactionInfo.ReadOnly = true;
            this.dgvLoanTransactionInfo.Size = new System.Drawing.Size(782, 280);
            this.dgvLoanTransactionInfo.TabIndex = 20;
            this.dgvLoanTransactionInfo.DoubleClick += new System.EventHandler(this.DgvLoanTransactionInfo_DoubleClick);
            // 
            // dgvLoanLoanInfo
            // 
            this.dgvLoanLoanInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanLoanInfo.Location = new System.Drawing.Point(404, 19);
            this.dgvLoanLoanInfo.Name = "dgvLoanLoanInfo";
            this.dgvLoanLoanInfo.ReadOnly = true;
            this.dgvLoanLoanInfo.Size = new System.Drawing.Size(782, 280);
            this.dgvLoanLoanInfo.TabIndex = 19;
            this.dgvLoanLoanInfo.DoubleClick += new System.EventHandler(this.DgvLoanLoanInfo_DoubleClick);
            // 
            // txtLoanNewLoanAmt
            // 
            this.txtLoanNewLoanAmt.Location = new System.Drawing.Point(127, 187);
            this.txtLoanNewLoanAmt.Name = "txtLoanNewLoanAmt";
            this.txtLoanNewLoanAmt.Size = new System.Drawing.Size(238, 20);
            this.txtLoanNewLoanAmt.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "New Loan Amount";
            // 
            // dtpDateOfLoan
            // 
            this.dtpDateOfLoan.Location = new System.Drawing.Point(127, 150);
            this.dtpDateOfLoan.Name = "dtpDateOfLoan";
            this.dtpDateOfLoan.Size = new System.Drawing.Size(238, 20);
            this.dtpDateOfLoan.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Date of Loan";
            // 
            // txtLoanLastName
            // 
            this.txtLoanLastName.Location = new System.Drawing.Point(127, 119);
            this.txtLoanLastName.Name = "txtLoanLastName";
            this.txtLoanLastName.Size = new System.Drawing.Size(238, 20);
            this.txtLoanLastName.TabIndex = 14;
            // 
            // txtLoanFirstname
            // 
            this.txtLoanFirstname.Location = new System.Drawing.Point(127, 85);
            this.txtLoanFirstname.Name = "txtLoanFirstname";
            this.txtLoanFirstname.Size = new System.Drawing.Size(238, 20);
            this.txtLoanFirstname.TabIndex = 13;
            // 
            // txtLoanCustomerID
            // 
            this.txtLoanCustomerID.Location = new System.Drawing.Point(127, 51);
            this.txtLoanCustomerID.Name = "txtLoanCustomerID";
            this.txtLoanCustomerID.Size = new System.Drawing.Size(238, 20);
            this.txtLoanCustomerID.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "First Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Customer ID";
            // 
            // txtLoanLoanID
            // 
            this.txtLoanLoanID.Location = new System.Drawing.Point(127, 17);
            this.txtLoanLoanID.Name = "txtLoanLoanID";
            this.txtLoanLoanID.Size = new System.Drawing.Size(238, 20);
            this.txtLoanLoanID.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Loan ID";
            // 
            // tabTxHistory
            // 
            this.tabTxHistory.Location = new System.Drawing.Point(4, 22);
            this.tabTxHistory.Name = "tabTxHistory";
            this.tabTxHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabTxHistory.Size = new System.Drawing.Size(1209, 624);
            this.tabTxHistory.TabIndex = 2;
            this.tabTxHistory.Text = "Transaction History";
            this.tabTxHistory.UseVisualStyleBackColor = true;
            this.tabTxHistory.Click += new System.EventHandler(this.TabTxHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 661);
            this.Controls.Add(this.tbcLoan);
            this.Name = "Form1";
            this.Text = " Loan Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcLoan.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.tabLoanInfo.ResumeLayout(false);
            this.tabLoanInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanTransactionInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanLoanInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcLoan;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabLoanInfo;
        private System.Windows.Forms.TabPage tabTxHistory;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Customers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.TextBox txtVoterID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoanLoanID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLoanLastName;
        private System.Windows.Forms.TextBox txtLoanFirstname;
        private System.Windows.Forms.TextBox txtLoanCustomerID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDateOfLoan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLoanNewLoanAmt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvLoanTransactionInfo;
        private System.Windows.Forms.DataGridView dgvLoanLoanInfo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnLoanSave;
        private System.Windows.Forms.Button btnLoanReset;
        private System.Windows.Forms.Button btnCustomerCreateNewLoan;
        private System.Windows.Forms.TextBox txtLoanTransactionID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpLoanPaymentDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLoanSavePayment;
        private System.Windows.Forms.TextBox txtLoanMakePayment;
        private System.Windows.Forms.Button btnLoanNewLoan;
        private System.Windows.Forms.TextBox txtLoan2PercentAmt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtLoan3PercentAmt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtLoanPrincipalOwed;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtLoanMonthlyInterest;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnLoanDelete;
        private System.Windows.Forms.Button btnTransactionDelete;
    }
}

