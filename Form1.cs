using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Loan_App
{
    public partial class Form1 : Form
    {
        int inCustID = 0;
        int inLoanID = 0;
        int currentMonth = DateTime.Now.Month;
        decimal inputAmount = 0;
        //string strConnectionString = @"Data Source=LAPTOP-MHAJFLRE;Initial Catalog=""Loan Application Philippines"";Integrated Security=True;MultipleActiveResultSets=False;Connect Timeout=30;TrustServerCertificate=False;Application Name=""Microsoft SQL Server Data Tools, SQL Server Object Explorer""";
        //string strConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Albert\source\repos\Loan App\Database2.mdf"";Integrated Security=True";

        string strConnectionString = Properties.Settings.Default.LoanAppDBConnectionString;


            public Form1()
        {
            InitializeComponent();

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e) //section 1
        {
            clear();
        }

        void clear() //section 2
        {
            txtCustomerID.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = txtLastName.Text = txtVoterID.Text = "";
            dtpDOB.Value = DateTime.Now;
            dgvLoans.DataSource = DBNull.Value;
            dgvTransactions.DataSource = DBNull.Value;


            inCustID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            FillCustomerDGV();


        }

        void FillCustomerDGV() //section 3
        {
            try
            {


                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {

                    sqlCon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("dgvCustomerInfo", sqlCon);
                    sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;


                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);
                    dgvCustomers.DataSource = dtbl;

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection not made");

            }
        }

        private void Form1_Load(object sender, EventArgs e) //section 4
        {
            
            FillCustomerDGV();
            clear();
            FillCustomerDGV();
        }

        private void BtnSave_Click(object sender, EventArgs e) //section5
        {
            try
            {

                if (ValidateForm())
                {
                    int customerid = 0;


                    if (txtCustomerID.Text.Length>0)
                    {
                        inCustID = int.Parse(txtCustomerID.Text.Trim());

                    }

                    using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("CustomerAddorEdit", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@customerid", inCustID);
                        sqlCmd.Parameters.AddWithValue("@firstname", txtFirstName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@lastname", txtLastName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@voterid", txtVoterID.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                        customerid = Convert.ToInt32(sqlCmd.ExecuteScalar());

                      
                            SqlDataAdapter sqlDa = new SqlDataAdapter("[dbo].[LoansAndTransactionsView]", sqlCon);
                            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                            sqlDa.SelectCommand.Parameters.AddWithValue("@customerid", customerid);

                            DataSet ds = new DataSet();
                            sqlDa.Fill(ds);

                            DataRow dr = ds.Tables[0].Rows[0];

                            txtCustomerID.Text = dr["customerid"].ToString();
                            txtFirstName.Text = dr["firstname"].ToString();
                            txtLastName.Text = dr["lastname"].ToString();
                            txtEmail.Text = dr["email"].ToString();
                            txtVoterID.Text = dr["voterid"].ToString();
                            dtpDOB.Value = Convert.ToDateTime(dr["Date of Birth"].ToString());


                            dgvLoans.DataSource = ds.Tables[1];
                            dgvTransactions.DataSource = ds.Tables[2];
                        


                    }



                    MessageBox.Show("Record saved successfully");
                  
                   FillCustomerDGV();
                    //FillLoansTransactionsDGV();

                



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }





        }



        bool ValidateForm() //section6
        {
            bool isValid = true;
            if ((txtFirstName.Text.Trim() == "") || (txtLastName.Text.Trim() == ""))
            {
                MessageBox.Show("Name is missing");
                isValid = false;
            }

            


            return isValid;
        }

        private void BtnSearch_Click(object sender, EventArgs e) //section 7
        {
            try
            {
                CustomerSearchDGV();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message \n\nCustomerSearchDGV");


            }
        }

        void CustomerSearchDGV() //section 8
        {

            using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
            {

                sqlCon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("dgvCustomerInfo", sqlCon);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);
                dgvCustomers.DataSource = dtbl;
                DataView dv = dtbl.DefaultView;

                StringBuilder sb = new StringBuilder();


                if (txtCustomerID.Text != "")
                {

                    sb.Append("Convert([customerid], System.String) like '%" + txtCustomerID.Text.Trim() + "%'");

                }
                if (txtFirstName.Text.Length > 0)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(" and ");

                    }
                    sb.Append("firstname like '%" + txtFirstName.Text.Trim() + "%'");
                }
                if (txtLastName.Text.Length > 0)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(" and ");

                    }
                    sb.Append("lastname like '%" + txtLastName.Text.Trim() + "%'");

                }
                if (txtVoterID.Text.Length > 0)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(" and ");

                    }
                    sb.Append("voterid like '%" + txtVoterID.Text.Trim() + "%'");
                }
                if (txtEmail.Text.Length > 0)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(" and ");

                    }
                    sb.Append("email like '%" + txtEmail.Text.Trim() + "%'");
                }


                


                dv.RowFilter = sb.ToString();

            }



        }




        private void DgvCustomers_DoubleClick(object sender, EventArgs e) //section9
        {
            try
            {


                FillLoansTransactionsDGV();
                FillLoansTabLoansAndTransactionsDGV();

                DataGridViewRow row = dgvLoans.CurrentRow;
                inCustID = int.Parse(txtCustomerID.Text.Trim());
                txtLoanCustomerID.Text = txtCustomerID.Text.Trim();
                txtLoanFirstname.Text = txtFirstName.Text.Trim();
                txtLoanLastName.Text = txtLastName.Text.Trim();


                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
            catch
            {

            }
        }

        public void FillLoansTransactionsDGV() //section10
        {
            try
            {
               

                    if (dgvCustomers.CurrentRow.Index != -1)
                    {
                        DataGridViewRow _dgvCurrentRow = dgvCustomers.CurrentRow;

                        inCustID = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);

                        using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                        {
                            sqlCon.Open();
                            SqlDataAdapter sqlDa = new SqlDataAdapter("[dbo].[LoansAndTransactionsView]", sqlCon);
                            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                            sqlDa.SelectCommand.Parameters.AddWithValue("@customerid", inCustID);

                            DataSet ds = new DataSet();
                            sqlDa.Fill(ds);

                            DataRow dr = ds.Tables[0].Rows[0];

                            txtCustomerID.Text = dr["customerid"].ToString();
                            txtFirstName.Text = dr["firstname"].ToString();
                            txtLastName.Text = dr["lastname"].ToString();
                            txtEmail.Text = dr["email"].ToString();
                            txtVoterID.Text = dr["voterid"].ToString();
                            dtpDOB.Value = Convert.ToDateTime(dr["Date of Birth"].ToString());


                            dgvLoans.DataSource = ds.Tables[1];
                            dgvTransactions.DataSource = ds.Tables[2];
                        }
                    }
            }
            catch
            {
               

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) //section11
        {
            deleteCustomer();
        }

        public void deleteCustomer () //section12
        {
            if (MessageBox.Show("Are you sure you want to delete this customer?", "Loan Application", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("deleteCustomer", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@customerid", txtCustomerID.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    clear();
                    FillCustomerDGV();
                    MessageBox.Show("Deleted Successfully");


                }
            }
           
                
        }

        private void TabTxHistory_Click(object sender, EventArgs e)
        {

        }

        private void DgvLoans_DoubleClick(object sender, EventArgs e) //section13
        {
            try

            {
                DataGridViewRow dgvRow = new DataGridViewRow();

                if (!dgvRow.IsNewRow)
                    FillLoansTabDGV_ByLoanID();


                else
                {
                    FillLoanInfoTab();
                    txtLoanLoanID.Text = "";
                }
            }
            catch (Exception er)
            {
               // MessageBox.Show("No loans created");
                    }
        }

        public void FillLoansTabDGV_ByLoanID()
        {
            if (dgvLoans.CurrentRow.Index != -1)
            {
                DataGridViewRow _dgvCurrentRow = dgvLoans.CurrentRow;
                inLoanID = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);

                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("[dbo].[LoansTabViewbyID]", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@loanid", inLoanID);

                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds);

                    DataRow dr = ds.Tables[0].Rows[0];

                    txtLoanLoanID.Text = dr["loanid"].ToString();
                    txtLoanCustomerID.Text = dr["customerid"].ToString();
                    txtLoanFirstname.Text = dr["firstname"].ToString();
                    txtLastName.Text = dr["lastname"].ToString();

                    dtpDateOfLoan.Value = Convert.ToDateTime(dr["Date Given"].ToString());


                    dgvLoanLoanInfo.DataSource = ds.Tables[1];
                    dgvLoanTransactionInfo.DataSource = ds.Tables[2];
                    tbcLoan.SelectedIndex = 1;
                }


            }
         else
            {
                FillLoanInfoTab();
                txtLoanLoanID.Text = "";
            }

        }

        public void FillLoansTabLoansAndTransactionsDGV() //section14 
        {
            try
            {
                inCustID = int.Parse(txtCustomerID.Text);




                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("[dbo].[LoansAndTransactionsView]", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@customerid", inCustID);

                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds);

                    DataRow dr = ds.Tables[0].Rows[0];


                    dgvLoanLoanInfo.DataSource = ds.Tables[1];
                    dgvLoanTransactionInfo.DataSource = ds.Tables[2];
                }
            }
            catch
            {

            }

        }

        private void BtnCustomerCreateNewLoan_Click(object sender, EventArgs e)
        {
            try
            {

                FillLoanInfoTab();
                txtLoanLoanID.Text = "";
                txtLoanNewLoanAmt.Text = "";
            }
            catch
            {
                MessageBox.Show("Please choose Customer", "Error 11");

            }
           
        }

        void FillLoanInfoTab()
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
            {
                DataGridViewRow row = dgvLoans.CurrentRow;
                inCustID = int.Parse(txtCustomerID.Text.Trim());
                txtLoanCustomerID.Text = txtCustomerID.Text.Trim();
                txtLoanFirstname.Text = txtFirstName.Text.Trim();
                txtLoanLastName.Text = txtLastName.Text.Trim();
               
                FillLoansTabLoansAndTransactionsDGV();
                tbcLoan.SelectedIndex = 1;
            }
        }

        private void BtnLoanSave_Click(object sender, EventArgs e) ////section15
        {
            try
            {

                if (txtLoanNewLoanAmt.Text.Length > 0)
                {

                    decimal NewLoanAmt = decimal.Parse(txtLoanNewLoanAmt.Text.Trim());
                    using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                    {
                        sqlCon.Open();
                        inCustID = int.Parse(txtLoanCustomerID.Text.Trim());
                        decimal LoanAmt = decimal.Parse(txtLoanNewLoanAmt.Text.Trim());
                        decimal AmountPaid = decimal.Parse(txtLoanNewLoanAmt.Text.Trim());
                        decimal interestOwed;
                        interestOwed = LoanAmt * (decimal).05;

                        SqlDataAdapter sqlDa = new SqlDataAdapter("dbo.LoanAdd", sqlCon);
                        sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sqlDa.SelectCommand.Parameters.AddWithValue("@customerid", inCustID);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@date", dtpLoanPaymentDate.Value);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@loanamt", LoanAmt);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@interestrate", 5);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@totalowed", LoanAmt);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@interestowed", interestOwed);


                        sqlDa.SelectCommand.ExecuteNonQuery();

                        // clearLoan();
                        int lastRow = dgvLoanLoanInfo.Rows.Count - 1;
                        dgvLoanLoanInfo.Rows[lastRow].Selected = true;
                        FillLoanInfoTab();
                        FillLoansTransactionsDGV();


                    }
                    MessageBox.Show("Loan Saved Successfully");

                }
                else MessageBox.Show("Please enter an amount");
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);

            }

            clearLoanTransactionTxtbox();

        }

        void clearLoanTransactionTxtbox()
        {
            txtLoanNewLoanAmt.Text = "";
            txtLoanPrincipalOwed.Text = "";
            txtLoanMonthlyInterest.Text = "";
            txtLoan3PercentAmt.Text = "";
            txtLoan2PercentAmt.Text = "";
        }

         void clearLoantxt() //section16
        {
            txtLoanLoanID.Text = "";
            txtLoanCustomerID.Text = "";
            txtLoanFirstname.Text = "";
            txtLoanLastName.Text = "";
            txtLoanNewLoanAmt.Text = "";

            
        }

        void clearLoandgv()

        {
            dtpLoanPaymentDate.Value = DateTime.Now;
            dgvLoanLoanInfo.DataSource = DBNull.Value;
            dgvLoanTransactionInfo.DataSource = DBNull.Value;
            dgvLoans.DataSource = DBNull.Value;
            dgvTransactions.DataSource = DBNull.Value;
        }

        void clearLoanTransactiontxt()
        {
            txtLoanMonthlyInterest.Text = "";
            txtLoanPrincipalOwed.Text = "";
            dtpLoanPaymentDate.Value = DateTime.Now;
            txtLoan3PercentAmt.Text = "";
            txtLoan2PercentAmt.Text = "";
            txtLoanTransactionID.Text = "";
        }

        private void BtnLoanNewLoan_Click(object sender, EventArgs e)
        {
            try
            {
                FillLoanInfoTab();
                txtLoanLoanID.Text = "";
                txtLoanNewLoanAmt.Text = "";
                clearLoanTransactionTxtbox();
            }
            catch(Exception er)
            {
                MessageBox.Show("Please select a customer on Custmoer Info Tab", "Error MEssage");

            }



        }

        private void BtnLoanReset_Click(object sender, EventArgs e)
        {
            clearLoan();
        }

        void clearLoan()
        {
            clearLoantxt();
            clearLoandgv();
            clearLoanTransactiontxt();  
        }

        private void BtnLoanDelete_Click(object sender, EventArgs e)
        {
            deleteLoan();
           // FillLoansDGV_AllLoans();
        }

        public void deleteLoan()
        {
            try
            {
                //  inLoanID = int.Parse(txtLoanLoanID.Text);
                if (MessageBox.Show("Are you sure you want to delete this Loan?", "Loan Application", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                    {
                        inCustID = int.Parse(txtLoanCustomerID.Text);
                        DataGridViewRow rows = dgvLoanLoanInfo.CurrentRow;
                        inLoanID = Convert.ToInt32(txtLoanLoanID.Text);


                        sqlCon.Open();

                        SqlCommand sqlCmd = new SqlCommand("deleteLoan", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@loanid", inLoanID);
                        sqlCmd.ExecuteNonQuery();
                       
                  
                       
                        MessageBox.Show("Loan Deleted Successfully");
                        clearLoan();
                        FillLoanInfoTab();
                        FillLoansTransactionsDGV();

                    }
                }
               }
             catch (Exception er)
              {
                  MessageBox.Show("Please select a loan");

              }
        }

        private void DgvLoanLoanInfo_DoubleClick(object sender, EventArgs e)
        {

            try
            {

                if (dgvLoanLoanInfo.CurrentRow.Index != -1)
                {
                    DataGridViewRow _dgvCurrentRow = dgvLoanLoanInfo.CurrentRow;
                    inLoanID = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);

                    using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                    {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("[dbo].[LoansTabViewbyID]", sqlCon);
                        sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sqlDa.SelectCommand.Parameters.AddWithValue("@loanid", inLoanID);

                        DataSet ds = new DataSet();
                        sqlDa.Fill(ds);

                        DataRow dr = ds.Tables[0].Rows[0];

                        txtLoanLoanID.Text = dr["loanid"].ToString();
                        txtLoanCustomerID.Text = dr["customerid"].ToString();
                        txtLoanFirstname.Text = dr["firstname"].ToString();
                        txtLoanLastName.Text = dr["lastname"].ToString();

                        dtpDateOfLoan.Value = Convert.ToDateTime(dr["Date Given"].ToString());

                        _dgvCurrentRow.Selected = true;
                        dgvLoanLoanInfo.DataSource = ds.Tables[1];
                        dgvLoanTransactionInfo.DataSource = ds.Tables[2];
                        tbcLoan.SelectedIndex = 1;
                        FillLoanTab_LoanInfoTxtbox();
                        //FillLoansTabLoansAndTransactionsDGV();
                        
                    }


                }
                else
                {
                    FillLoanInfoTab();
                    txtLoanLoanID.Text = "";
                }

            }
            catch
            {

            }

        }

        void FillLoansDGV_AllLoans()
        {



            try
            {

               
                  

                    using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                    {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("ViewAllLoans", sqlCon);
                        sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
              
                        DataSet ds = new DataSet();
                        sqlDa.Fill(ds);

                        DataRow dr = ds.Tables[0].Rows[0];

                        txtCustomerID.Text = dr["customerid"].ToString();
                        txtFirstName.Text = dr["firstname"].ToString();
                        txtLastName.Text = dr["lastname"].ToString();
                        txtEmail.Text = dr["email"].ToString();
                        txtVoterID.Text = dr["voterid"].ToString();
                        dtpDOB.Value = Convert.ToDateTime(dr["Date of Birth"].ToString());


                    dgvLoanLoanInfo.DataSource = ds.Tables[1];
                        dgvLoanTransactionInfo.DataSource = ds.Tables[2];
                    }
                
            }
            catch
            {

                MessageBox.Show("this didn't work");

            }
        }

        void dbvLoanTabNullTables()
        {
            dgvLoanLoanInfo.DataSource = DBNull.Value;
            dgvLoanTransactionInfo.DataSource = DBNull.Value;
        }

        private void BtnLoanSavePayment_Click(object sender, EventArgs e)
        {

            
            

            try
            {

                saveTransaction();
                updateLoanFromTransactionSave();

                FillLoanTab_LoanInfoTxtbox();

                txtLoanMakePayment.Text = "";
                txtLoanPrincipalOwed.Text = "";
                txtLoanMonthlyInterest.Text = "";
                clearLoantxt();
                dgvLoanTransactionInfo.DataSource = DBNull.Value;
                FillLoansTabLoansAndTransactionsDGV();


            }

            catch (Exception er)
            {
               // MessageBox.Show(er.Message);

            }

            txtLoan3PercentAmt.Text = "";
            txtLoan2PercentAmt.Text = "";
            

        }

     

        void updateLoanFromTransactionSave()
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
            {
                if (txtLoanLoanID.Text.Length > 0)
                {
                    inLoanID = int.Parse(txtLoanLoanID.Text.Trim());
                }
                else
                {
                    DataGridViewRow _dgvCurrentRow = dgvLoanTransactionInfo.CurrentRow;
                    inLoanID = Convert.ToInt32(_dgvCurrentRow.Cells[4].Value);
                }
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("dbo.updateLoanFromTransactions", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@loanid", inLoanID);
                sqlDa.SelectCommand.Parameters.AddWithValue("@currentMonth", currentMonth);
                sqlDa.SelectCommand.ExecuteNonQuery();

                 SqlDataAdapter DAtwo = new SqlDataAdapter("dbo.updateLoanFromTransactionsMonthlyInterest", sqlCon);

                DAtwo.SelectCommand.CommandType = CommandType.StoredProcedure;
                DAtwo.SelectCommand.Parameters.AddWithValue("@loanid", inLoanID);
                DAtwo.SelectCommand.Parameters.AddWithValue("@currentMonth", currentMonth);
                DAtwo.SelectCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdapterThree = new SqlDataAdapter("dbo.updateLoanFromTransactionInterestOwed", sqlCon);

                dataAdapterThree.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapterThree.SelectCommand.Parameters.AddWithValue("@loanid", inLoanID);
                dataAdapterThree.SelectCommand.Parameters.AddWithValue("@currentMonth", currentMonth);
                dataAdapterThree.SelectCommand.ExecuteNonQuery();

                dbvLoanTabNullTables();

                FillLoanInfoTab();
                FillLoansTransactionsDGV();
            }

        }


        void FillLoanTab_LoanInfoTxtbox()
        {

            if (dgvLoanLoanInfo.CurrentRow.Index != -1)

            {

                DataGridViewRow _dgvCurrentRow = dgvLoanLoanInfo.CurrentRow;

                inLoanID = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);



                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))

                {

                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("[dbo].[LoansTabViewbyID]", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@loanid", inLoanID);



                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds);



                    DataRow dr = ds.Tables[0].Rows[0];



                    txtLoanLoanID.Text = dr["loanid"].ToString();
                    txtLoanCustomerID.Text = dr["customerid"].ToString();
                    txtLoanFirstname.Text = dr["firstname"].ToString();
                    txtLastName.Text = dr["lastname"].ToString();
                    dtpDateOfLoan.Value = Convert.ToDateTime(dr["Date Given"].ToString());

                     txtLoanPrincipalOwed.Text = dr["Total Owed"].ToString();
                     txtLoanMonthlyInterest.Text = dr["Interest Owed"].ToString();


                    
                        string strmonthlyint = dr["Monthly Interest Amount"].ToString();
                    double Threepcnt= double.Parse(strmonthlyint);
                    Threepcnt = (Threepcnt * 0.6);
                    txtLoan3PercentAmt.Text = Threepcnt.ToString();


                    
                    double twopcnt = double.Parse(strmonthlyint);
                    twopcnt = (twopcnt * 0.4);
                    txtLoan2PercentAmt.Text = twopcnt.ToString();





                  //    dgvLoanLoanInfo.DataSource = ds.Tables[1];


                 //   dgvLoanTransactionInfo.DataSource = ds.Tables[2];

                    tbcLoan.SelectedIndex = 1;

                }






            }

            else

            {

                FillLoanInfoTab();

                txtLoanLoanID.Text = "";

            }
        }

        void saveTransaction()
        {
            if (txtLoanMakePayment.Text.Length > 0)
            {

 
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    inCustID = int.Parse(txtLoanCustomerID.Text.Trim());
                    inLoanID = int.Parse(txtLoanLoanID.Text.Trim());

                  
                    decimal AmountPaid = decimal.Parse(txtLoanMakePayment.Text.Trim());
                    decimal InterestPaid;
                    decimal MonthlyInterestAmount;
                       if ( decimal.Parse(txtLoanMonthlyInterest.Text.Trim())<0)
                    {
                        MonthlyInterestAmount = 0;
                            }

                       else
                    {
                        MonthlyInterestAmount = decimal.Parse(txtLoanMonthlyInterest.Text.Trim());
                            }


                  

         

                    SqlDataAdapter sqlDa = new SqlDataAdapter("dbo.transactionAdd", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@customerid", inCustID);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@loanid", inLoanID);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@datepaid", dtpLoanPaymentDate.Value);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@amountpaid", AmountPaid);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@firstname", txtLoanFirstname.Text);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@lastname", txtLoanLastName.Text);




                    if (dtpLoanPaymentDate.Value.Month < currentMonth)
                    {
                        sqlDa.SelectCommand.Parameters.AddWithValue("@Principalpaid", AmountPaid);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@interestpaid", 0);
                    }

                    else
                    {

                        if (AmountPaid >= MonthlyInterestAmount)
                        {
                            InterestPaid = MonthlyInterestAmount;
                            sqlDa.SelectCommand.Parameters.AddWithValue("@interestpaid", InterestPaid);
                            sqlDa.SelectCommand.Parameters.AddWithValue("@Principalpaid", AmountPaid - MonthlyInterestAmount);
                        }

                        else
                        {
                            InterestPaid = AmountPaid;
                            sqlDa.SelectCommand.Parameters.AddWithValue("@interestpaid", InterestPaid);
                            sqlDa.SelectCommand.Parameters.AddWithValue("@Principalpaid", 0);
                        }
                    }



                    sqlDa.SelectCommand.ExecuteNonQuery();


                    //clearLoan();

                    dbvLoanTabNullTables();

                    FillLoanInfoTab();
                    FillLoansTransactionsDGV();

                   // txtLoanLoanID.Text = "";
                    txtLoanPrincipalOwed.Text = "";
                   // txtLoanMonthlyInterest.Text = "";


                }
                MessageBox.Show("Transaction Saved Successfully");

            }
            else MessageBox.Show("Please enter an amount");
        
    }


        void FillLoanTab_TransactionDGVbyLoanID()
        {

        }

        private void BtnTransactionDelete_Click(object sender, EventArgs e)
        {
            



                if (MessageBox.Show("Are you sure you want to delete this transaction?", "Loan Application", MessageBoxButtons.OKCancel) == DialogResult.OK)

                {

                    try
                    {

                        using (SqlConnection sqlCon = new SqlConnection(strConnectionString))

                        {


                            DataGridViewRow rows = dgvLoanTransactionInfo.CurrentRow; // input transaction DGV in loan tab
                            int inTransactionID;
                            inTransactionID = Convert.ToInt32(rows.Cells[0].Value);

                            sqlCon.Open();

                            SqlCommand sqlCmd = new SqlCommand("deleteTransaction", sqlCon); // create deleteTransaction stored procedure
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@transactionid", inTransactionID);
                            sqlCmd.ExecuteNonQuery();


                            updateLoanFromTransactionSave();

                            MessageBox.Show("Transaction Deleted Successfully");

                            clearLoan();

                            FillLoanInfoTab();

                            txtLoanPrincipalOwed.Text = "";
                            txtLoanMonthlyInterest.Text = "";
                                                                                                                                  
                        }


                    }
                    catch (Exception er)

                    {

                        MessageBox.Show("No Transactions Selected");                                               
                    }
                }          


        }

        private void TbcLoan_Click(object sender, EventArgs e)
        {
            txtLoanNewLoanAmt.Text = "";
            txtLoanMakePayment.Text = "";
        }

        private void DgvLoanTransactionInfo_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                if (dgvLoanTransactionInfo.CurrentRow.Index != -1)
                {
                    int inTransactionID;
                    DataGridViewRow _dgvCurrentRow = dgvLoanTransactionInfo.CurrentRow;
                    inLoanID = Convert.ToInt32(_dgvCurrentRow.Cells[4].Value);

                  

                    using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                    {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("[dbo].[LoansTabViewbyID]", sqlCon);
                        sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sqlDa.SelectCommand.Parameters.AddWithValue("@loanid", inLoanID);

                        DataSet ds = new DataSet();
                        sqlDa.Fill(ds);

                        DataRow dr = ds.Tables[0].Rows[0];

                        txtLoanLoanID.Text = dr["loanid"].ToString();
                        txtLoanCustomerID.Text = dr["customerid"].ToString();
                        txtLoanFirstname.Text = dr["firstname"].ToString();
                        txtLoanLastName.Text = dr["lastname"].ToString();

                        dtpDateOfLoan.Value = Convert.ToDateTime(dr["Date Given"].ToString());

                        txtLoanPrincipalOwed.Text = dr["Total Owed"].ToString();
                        txtLoanMonthlyInterest.Text = dr["Interest Owed"].ToString();

                        _dgvCurrentRow.Selected = true;
                      //  dgvLoanLoanInfo.DataSource = ds.Tables[1];
                      //  dgvLoanTransactionInfo.DataSource = ds.Tables[2];
                        tbcLoan.SelectedIndex = 1;
                    //   FillLoanTab_LoanInfoTxtbox();
                      //  FillLoansTabLoansAndTransactionsDGV();
                    }


                }
                else
                {
                    FillLoanInfoTab();
                    txtLoanLoanID.Text = "";
                }

            }
            catch
            {

            }
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
            }
        }
    }

}