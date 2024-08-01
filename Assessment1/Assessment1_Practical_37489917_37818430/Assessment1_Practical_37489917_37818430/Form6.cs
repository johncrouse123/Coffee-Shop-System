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
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();

            // Initialize the connection to BEVERAGES database
            connectionB = new SqlConnection(connectionBeverages);

            //Initialize the connection to FOOD database
            connectionF = new SqlConnection(connectionFood);
        }

        //Declare global connection string with path to BEVERAGE database
        public string connectionBeverages = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johnc\Desktop\Assessment1_Practical_37489917_37818430\Assessment1_Practical_37489917_37818430\beveragesData.mdf;Integrated Security=True";

        //Declare variables for BEVERAGES
        SqlConnection connectionB;
        SqlCommand commandB;
        SqlDataAdapter dataAdapterB;
        SqlDataReader dataReaderB;
        DataSet dataSetB;

        private void loadBeverages()
        {
            //Try-catch statement for exception handling
            try
            {
                //Declare variables
                dataAdapterB = new SqlDataAdapter();
                dataSetB = new DataSet();

                //Initialize variables and select all data from BEVERAGES table
                string sqlBeverages = "SELECT * FROM Beverages";
                commandB = new SqlCommand(sqlBeverages, connectionB);

                //Fill the dataset
                dataAdapterB.SelectCommand = commandB;
                dataAdapterB.Fill(dataSetB, "Beverages");

                //Move data to datagrid
                dgvBeverages.DataSource = dataSetB.Tables["Beverages"];
            }
            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Declare global connection string with path to FOOD database
        public string connectionFood = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johnc\Desktop\Assessment1_Practical_37489917_37818430\Assessment1_Practical_37489917_37818430\foodData.mdf;Integrated Security=True";

        //Declare variables for fOOD
        SqlConnection connectionF;
        SqlCommand commandF;
        SqlDataAdapter dataAdapterF;
        SqlDataReader dataReaderF;
        DataSet dataSetF;

        private void loadFood()
        {
            //Try-catch statement for exception handling
            try
            {
                

                //Declare variables
                dataAdapterF = new SqlDataAdapter();
                dataSetF = new DataSet();

                //Initialize variables and select all data from BEVERAGES table
                string sqlFood = "SELECT * FROM Food";
                commandF = new SqlCommand(sqlFood, connectionF);

                //Fill the dataset
                dataAdapterF.SelectCommand = commandF;
                dataAdapterF.Fill(dataSetF, "Food");

                //Move data to datagrid
                dgvFood.DataSource = dataSetF;
                dgvFood.DataMember = "Food";

                
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connectionF.Close();
            }
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            //Load new data from the BEVERAGES table
            loadBeverages();


            //Try-catch statement for exception handling
            try
            {

                //Open the connection
                
                    connectionB.Open();
                

                //Declare variables
                dataAdapterB = new SqlDataAdapter();
                dataSetB = new DataSet();

                //Initialize variables and select all data from the BEVERAGES table
                string sqlBeverages = "SELECT DISTINCT Type FROM Beverages";
                commandB = new SqlCommand(sqlBeverages, connectionB);

                //Fill the dataset
                dataAdapterB.SelectCommand = commandB;
                dataAdapterB.Fill(dataSetB, "Beverages");

                //Move data to the BEVERAGES combobox
                cmbRemoveBeverage.ValueMember = "Type";
                cmbRemoveBeverage.DisplayMember = "Type";
                cmbRemoveBeverage.DataSource = dataSetB.Tables["Beverages"];

                //Change the selected index of the combobox
                cmbRemoveBeverage.SelectedIndex = -1;
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connectionB.Close();
            }

            //Load new data from the FOOD table
            loadFood();




            try
            {
                //Open the connection
                
                    connectionF.Open();
                

                //Declare variables
                dataAdapterF = new SqlDataAdapter();
                dataSetF = new DataSet();

                //Initialize variables and select all data from the FOOD table
                string sqlFood = "SELECT DISTINCT Type FROM Food";
                commandF = new SqlCommand(sqlFood, connectionF);

                //Fill the dataset
                dataAdapterF.SelectCommand = commandF;
                dataAdapterF.Fill(dataSetF, "Food");

                //Move data to the FOOD combobox
                cmbRemoveFood.ValueMember = "Type";
                cmbRemoveFood.DisplayMember = "Type";
                cmbRemoveFood.DataSource = dataSetF.Tables["Food"]; // Add this line

                //Change the selected index of the combobox
                cmbRemoveFood.SelectedIndex = -1;
            }
            
            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connectionF.Close();
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            //Try-catch statement for exception handling
            try
            {
                
                    connectionB.Open();
                

                //Initialize variables and select all data from the BEVERAGES table
                string sqlBeverages = "SELECT * FROM Beverages";
                commandB = new SqlCommand(sqlBeverages, connectionB);

                //Read the data from the BEVERAGES table
                dataReaderB = commandB.ExecuteReader();

                //Clear items from the listbox first, then add headers
                lstbReceipt.Items.Clear();
                lstbReceipt.Items.Add("Type\t\t\tQuantity\t\tSize");
                lstbReceipt.Items.Add("----------------------------------------------------------------------------------------------------");

                //While-loop to loop through the data
                while (dataReaderB.Read())
                {
                    //Add new items to the listbox (Fisrt show the beverage type, quantity then the size)
                    lstbReceipt.Items.Add(dataReaderB.GetValue(1) + "\t\t\t" + dataReaderB.GetValue(3) + "\t\t" + dataReaderB.GetValue(2));
                }
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connectionB.Close();
            }
                

            try
            {
                //Open the connection again
                
                    connectionF.Open();
                

                //Initialize variables and select all data from the BEVERAGES table
                string sqlFood = "SELECT * FROM Food";
                commandF = new SqlCommand(sqlFood, connectionF);

                //Read the data from the BEVERAGES table
                dataReaderF = commandF.ExecuteReader();

                //While-loop to loop through the data
                while (dataReaderF.Read())
                {
                    //Add new items to the listbox (Fisrt show the food type the quantity)
                    lstbReceipt.Items.Add(dataReaderF.GetValue(1) + "\t\t\t" + dataReaderF.GetValue(2));
                }
            }
               
            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connectionF.Close();
            }
        }

        private void cmbRemoveBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Try-catch statement for exception handling
            try
            {
                //Open the connection
                
                    connectionB.Open();
                

                //Select all data from the BEVERAGES table
                string sqlDeleteBeverages = $"DELETE FROM Beverages WHERE Type = '{cmbRemoveBeverage.SelectedValue}'";
                commandB = new SqlCommand(sqlDeleteBeverages, connectionB);

                //Execute deleting data from the BEVERAGES table
                dataAdapterB = new SqlDataAdapter();
                dataAdapterB.DeleteCommand = commandB;
                dataAdapterB.DeleteCommand.ExecuteNonQuery();
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connectionB.Close();
            }

            loadBeverages();
        }

        private void cmbRemoveFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Try-catch statement for exception handling
            try
            {
                //Open the connection
                
                    connectionF.Open();
                

                //Select all data from the BEVERAGES table
                string sqlDeleteFood = $"DELETE FROM Food WHERE Type = '{cmbRemoveFood.SelectedValue}'";
                commandF = new SqlCommand(sqlDeleteFood, connectionF);

                //Execute deleting data from the BEVERAGES table
                dataAdapterF = new SqlDataAdapter();
                dataAdapterF.DeleteCommand = commandF;
                dataAdapterF.DeleteCommand.ExecuteNonQuery();
                
            }

            catch (Exception error)
            {
                //Display error message
                MessageBox.Show(error.Message, "Ocurring error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close the connection
                connectionF.Close();
            }

            loadFood();
        }
    }
}
