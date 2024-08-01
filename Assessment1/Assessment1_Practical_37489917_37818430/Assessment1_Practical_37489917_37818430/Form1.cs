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
    public partial class Form1 : Form
    {
        //37489917 John Crouse
        //37818430 Heindrich Burger

        public Form1()
        {
            InitializeComponent();
        }

        private void coffeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display the Coffee Form
            frmCoffee Coffee = new frmCoffee();
            Coffee.MdiParent = this;
            Coffee.Show();

            //Hide the header label
            lblWelcome.Visible = false;
        }

        private void teaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display the Tea Form
            frmTea Tea = new frmTea();
            Tea.MdiParent = this;
            Tea.Show();

            //Hide the header label
            lblWelcome.Visible = false;
        }

        private void pastriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display the Pastries Form
            frmPastries Pastries = new frmPastries();
            Pastries.MdiParent = this;
            Pastries.Show();

            //Hide the header label
            lblWelcome.Visible = false;
        }

        private void sandwichesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display the Sandwiches Form
            frmSandwiches Sandwiches = new frmSandwiches();
            Sandwiches.MdiParent = this;
            Sandwiches.Show();

            //Hide the header label
            lblWelcome.Visible = false;
        }

        private void cARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display the Cart Form
            frmCart Cart = new frmCart();
            Cart.MdiParent = this;
            Cart.Show();

            //Hide the header label
            lblWelcome.Visible = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display new Login Form
            frmLogin Login = new frmLogin();
            Login.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the program
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
