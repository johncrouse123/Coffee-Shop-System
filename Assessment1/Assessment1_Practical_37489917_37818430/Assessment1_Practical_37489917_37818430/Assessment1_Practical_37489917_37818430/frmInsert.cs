using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1_Practical_37489917_37818430
{
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
        }

        //Declare global variables
        public string type { get; set; }
        public int quantity;
        public string status { get; set; }
        public string special { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Assign variables to their controls
            type = txtType.Text;
            special = txtSpecial.Text;

            

            //If-else statement to set the status of the item
            if (rdbBest.Checked)
            {
                status = "Best Selling";
            }

            else if (rdbSold.Checked)
            {
                status = "Sold Out";
            }

            //Validate the value entered in the QUANTITY textbox by using if-else statement
            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                //Close the form
                this.Close();
            }

            else
            {
                //Display error message
                MessageBox.Show("Please enter valid quantity");
            }

            
        }

        private void frmInsert_Load(object sender, EventArgs e)
        {

        }
    }
}
