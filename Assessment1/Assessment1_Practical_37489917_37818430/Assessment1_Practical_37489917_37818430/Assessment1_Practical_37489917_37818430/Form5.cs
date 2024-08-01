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
    public partial class frmSandwiches : Form
    {
        public frmSandwiches()
        {
            InitializeComponent();
        }

        //Declare global connection string with path to FOOD database
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johnc\Desktop\Assessment1_Practical_37489917_37818430\Assessment1_Practical_37489917_37818430\foodData.mdf;Integrated Security=True";

        //Declare variables
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;

        private void btnSandwichesAdd_Click(object sender, EventArgs e)
        {
            //Try-catch statement for exception handling
            try
            {
                //Open the connection
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                //Declare variables and assign them to
                string type = cmbSandwichesType.SelectedItem.ToString();
                int quantity = Convert.ToInt32(nudSandwichesQuantity.Value);

                //Initialize variables and insert new data to the BEVERAGES table
                string sql = $"INSERT INTO Food(Type, Quantity) VALUES('{type}', '{quantity}')";
                command = new SqlCommand(sql, connection);

                //Execute Inserting new data
                dataAdapter = new SqlDataAdapter();
                dataAdapter.InsertCommand = command;
                dataAdapter.InsertCommand.ExecuteNonQuery();

                //Display message after data was successfully inserted
                MessageBox.Show(quantity + " " + type + "s have been added to CART");

                //Close the connection
                connection.Close();
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSandwiches_Load(object sender, EventArgs e)
        {
            //Try-catch statement for exception handling
            try
            {
                //Connect to database
                connection = new SqlConnection(connectionString);
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
