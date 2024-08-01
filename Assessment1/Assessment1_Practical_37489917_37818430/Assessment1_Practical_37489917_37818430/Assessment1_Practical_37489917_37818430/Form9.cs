using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Use SQL Client System
using System.Data.SqlClient;

namespace Assessment1_Practical_37489917_37818430
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        //Declare global connection string with path to ACCOUNTING database
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johnc\Desktop\Assessment1_Practical_37489917_37818430\Assessment1_Practical_37489917_37818430\accountingData.mdf;Integrated Security=True";

        //Declare variables for ITEMS
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        private void frmReports_Load(object sender, EventArgs e)
        {
            //Set the values of the PROFIT and QUANTITY Scrollbars and assign them to labels
            hsbProfit.Value = 0;
            hsbProfit.Minimum = 1000;
            hsbProfit.Maximum = 10000;
            hsbProfit.LargeChange = 1000;
            hsbProfit.SmallChange = 1000;

            lblNum1.Text = hsbProfit.Value.ToString();

            hsbQuantity.Value = 0;
            hsbQuantity.Minimum = 100;
            hsbQuantity.Maximum = 2000;
            hsbQuantity.LargeChange = 100;
            hsbQuantity.SmallChange = 100;

            lblNum2.Text = hsbQuantity.Value.ToString();

            //Try-catch statement for exception handling
            try
            {
                //Connect to database
                connection = new SqlConnection(connectionString);

                //Open the connection
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                //Declare variables
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                //Initialize variables and select all data from ACCOUNTING table
                string sql = "SELECT * FROM Accounting";
                command = new SqlCommand(sql, connection);

                //Fill the dataset
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "Accounting");

                //Move data to datagrid
                dgvReports.DataSource = dataSet;
                dgvReports.DataMember = "Accounting";

                //Close the connection
                connection.Close();
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //Try-catch statement for exception handling
            try
            {
                //Connect to database
                connection = new SqlConnection(connectionString);

                //Open the connection
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                //Declare variables
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                //Initialize variables and select all data from ACCOUNTING table
                string sql = "SELECT * FROM Accounting WHERE Item LIKE '%" + txtName.Text + "%'";
                command = new SqlCommand(sql, connection);

                //Fill the dataset
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "Accounting");

                //Move data to datagrid
                dgvReports.DataSource = dataSet;
                dgvReports.DataMember = "Accounting";

                //Close the connection
                connection.Close();
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hsbProfit_Scroll(object sender, ScrollEventArgs e)
        {
            //Assign value of the scrollbar to its lable
            lblNum1.Text = hsbProfit.Value.ToString();

            //Try-catch statement for exception handling
            try
            {
                //Connect to database
                connection = new SqlConnection(connectionString);

                //Open the connection
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                //Declare variables
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                //Initialize variables and select all data from ACCOUNTING table
                string sql = $"SELECT * FROM Accounting WHERE Profit = '{hsbProfit.Value}'";
                command = new SqlCommand(sql, connection);

                //Fill the dataset
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "Accounting");

                //Move data to datagrid
                dgvReports.DataSource = dataSet;
                dgvReports.DataMember = "Accounting";

                //Close the connection
                connection.Close();
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hsbQuantity_Scroll(object sender, ScrollEventArgs e)
        {
            //Assign value of the scrollbar to its lable
            lblNum2.Text = hsbQuantity.Value.ToString();

            //Try-catch statement for exception handling
            try
            {
                //Connect to database
                connection = new SqlConnection(connectionString);

                //Open the connection
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                //Declare variables
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                //Initialize variables and select all data from ACCOUNTING table
                string sql = $"SELECT * FROM Accounting WHERE Quantity = '{hsbQuantity.Value}'";
                command = new SqlCommand(sql, connection);

                //Fill the dataset
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "Accounting");

                //Move data to datagrid
                dgvReports.DataSource = dataSet;
                dgvReports.DataMember = "Accounting";

                //Close the connection
                connection.Close();
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            //Try-catch statement for exception handling
            try
            {
                //Connect to database
                connection = new SqlConnection(connectionString);

                //Open the connection
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                //Declare variables
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                //Initialize variables and select all data from ACCOUNTING table
                string sql = "SELECT * FROM Accounting WHERE Time LIKE '%" + txtTime.Text + "%'";
                command = new SqlCommand(sql, connection);

                //Fill the dataset
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "Accounting");

                //Move data to datagrid
                dgvReports.DataSource = dataSet;
                dgvReports.DataMember = "Accounting";

                //Close the connection
                connection.Close();
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
