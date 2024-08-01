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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Declare global connection string with path to STAFF database
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johnc\Desktop\Assessment1_Practical_37489917_37818430\Assessment1_Practical_37489917_37818430\staffData.mdf;Integrated Security=True";

        //Declare variables
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //If-else statement to validate the values of the textboxes
            if (txtUsername.Text == "")
            {
                errorLogin.SetError(txtUsername, "Enter a username");

                //Set focus back to the USERNAME textbox
                txtUsername.Focus();
            }

            else if (txtPassword.Text == "")
            {
                errorLogin.SetError(txtPassword, "Enter a password");

                //Set focus back to the PASSWORD textbox
                txtPassword.Focus();
            }

            else
            {
                //Try-catch statement for exception handling
                try
                {
                    //Connect to the database
                    connection = new SqlConnection(connectionString);

                    //Open the connection
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    //Initialize variables and select all data from the STAFF table
                    string sql = "SELECT * FROM Staff";
                    command = new SqlCommand(sql, connection);

                    //Read the data
                    dataReader = command.ExecuteReader();

                    //While-loop to loop through the data
                    while (dataReader.Read())
                    {
                        //If statement to validate the values of the textboxes
                        if (txtUsername.Text == dataReader.GetValue(1).ToString() && txtPassword.Text == dataReader.GetValue(2).ToString())
                        {
                            //Display the STAFF MDI Parent form
                            frmStaff Staff = new frmStaff();
                            Staff.Show();
                            Staff.Focus();
                        }
                    }

                    //Close the connection
                    connection.Close();

                    //Close this from
                    this.Close();
                }

                catch (Exception error)
                {
                    //Dispaly error message
                    MessageBox.Show(error.Message, "Ocurring error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //This button will close the form and cancel Login
            this.Close();
        }
    }
}
