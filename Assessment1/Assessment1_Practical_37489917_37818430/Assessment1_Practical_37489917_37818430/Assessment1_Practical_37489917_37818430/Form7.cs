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
    public partial class frmAccounting : Form
    {
        public frmAccounting()
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

        private void Form7_Load(object sender, EventArgs e)
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
                string sql = "SELECT * FROM Accounting";
                command = new SqlCommand(sql, connection);

                //Fill the dataset
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "Accounting");

                //Move data to datagrid
                dgvAccounting.DataSource = dataSet;
                dgvAccounting.DataMember = "Accounting";

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
