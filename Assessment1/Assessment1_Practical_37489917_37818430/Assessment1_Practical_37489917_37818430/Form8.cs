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
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();

            // Initialize the connection
            connection = new SqlConnection(connectionString);
        }

        //Declare global connection string with path to ITEMS database
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johnc\Desktop\Assessment1_Practical_37489917_37818430\Assessment1_Practical_37489917_37818430\itemsData.mdf;Integrated Security=True";

        //Declare variables for ITEMS
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        public string type {get; set;}
        public int quantity;

        private void loadItems()
        {
            //Try-catch statement for exception handling
            try
            {
                //Open the connection
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                //Declare variables
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                //Initialize variables and select all data from ITEMS table
                string sql = "SELECT * FROM Items";
                command = new SqlCommand(sql, connection);

                //Fill the dataset
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "Items");

                //Move data to datagrid
                dgvItems.DataSource = dataSet;
                dgvItems.DataMember = "Items";


            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connection.Close();
            }
        }

        private void loadCombo()
        {
            //Try-catch statement for exception handling
            try
            {
                //Open the connection
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                //Declare variables
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                //Initialize variables and select all data from ITEMS table
                string sql = "SELECT DISTINCT Type FROM Items";
                command = new SqlCommand(sql, connection);

                //Fill the dataset
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "Items");

                //Move data to the DELETE ITEMS combobox
                cmbDeleteItems.ValueMember = "Type";
                cmbDeleteItems.DisplayMember = "Type";
                cmbDeleteItems.DataSource = dataSet.Tables["Items"];

                //Change the selected index of the combobox
                cmbDeleteItems.SelectedIndex = -1;

                
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connection.Close();
            }



            //Try-catch statement for exception handling
            try
            {
                //Open the connection
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                //Declare variables
                dataAdapter = new SqlDataAdapter();
                dataSet = new DataSet();

                //Initialize variables and select all data from ITEMS table
                string sql = "SELECT DISTINCT Type FROM Items";
                command = new SqlCommand(sql, connection);

                //Fill the dataset
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "Items");

                //Move data to the UPDATE ITEMS combobox
                cmbUpdateItems.ValueMember = "Type";
                cmbUpdateItems.DisplayMember = "Type";
                cmbUpdateItems.DataSource = dataSet.Tables["Items"];

                //Change the selected index of the combobox
                cmbUpdateItems.SelectedIndex = -1;

            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connection.Close();
            }
        }

        private void btnInsertItems_Click(object sender, EventArgs e)
        {
            //Display new pop-up form
            frmInsert Insert = new frmInsert();
            Insert.ShowDialog();

            //Try-catch statement for exception handling
            try
            {
                //Open the connection
                //if (connection.State == ConnectionState.Closed)
                //{
                    connection.Open();
                //}

                //Select all data from the BEVERAGES table
                string sqlDelete = $"INSERT INTO Items(Type, Quantity, Status, Special) VALUES('{Insert.type}','{Insert.quantity}', '{Insert.status}', '{Insert.special}')";
                command = new SqlCommand(sqlDelete, connection);

                //Execute deleting data from the BEVERAGES table
                dataAdapter = new SqlDataAdapter();
                dataAdapter.InsertCommand = command;
                dataAdapter.InsertCommand.ExecuteNonQuery();

                

                
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connection.Close();
            }

            //Load new data
            loadItems();

            //Move new data to the combobox
            loadCombo();
        }

        private void cmbDeleteItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Try-catch statement for exception handling
            try
            {
                //Open the connection
                //if (connection.State == ConnectionState.Closed)
                //{
                connection.Open();
                //}

                //Delete data from the ITEMS database
                string sqlDelete = $"DELETE FROM Items WHERE Type = '{cmbDeleteItems.SelectedValue}'";
                command = new SqlCommand(sqlDelete, connection);

                //Execute deleting data from the ITEMS table
                dataAdapter = new SqlDataAdapter();
                dataAdapter.DeleteCommand = command;
                dataAdapter.DeleteCommand.ExecuteNonQuery();
               
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connection.Close();
            }

            //Load new data
            loadItems();

            //Move new data to the combobox
            loadCombo();
        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {

            

            //Load new data
            loadItems();

            //Move new data to the combobox
            loadCombo();
        }

        private void cmbUpdateItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            type = cmbUpdateItems.SelectedValue.ToString();
            quantity = Convert.ToInt32(txtQuantity.Text);


            //Try-catch statement for exception handling
            try
            {
                //Open the connection
                //if (connection.State == ConnectionState.Closed)
                //{
                connection.Open();
                //}

                //Update the ITEMS database
                string sqlUpdate = "UPDATE Items SET Quantity = @quantity WHERE Type = @type";
                command = new SqlCommand(sqlUpdate, connection);

                //Execute updating the ITEMS table
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@quantity", quantity);

                dataAdapter = new SqlDataAdapter(command); // Initialize the dataAdapter variable
                dataAdapter.UpdateCommand = command;
                dataAdapter.UpdateCommand.ExecuteNonQuery();
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connection.Close();
            }

            //Load new data
            loadItems();

            //Move new data to the combobox
            loadCombo();
        }

        private void cmbUpdateItems_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

