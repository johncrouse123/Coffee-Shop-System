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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void accountingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display new ACCOUNTING form
            frmAccounting Accounting = new frmAccounting();
            Accounting.MdiParent = this;
            Accounting.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display new DATABASE form
            frmDatabase Database = new frmDatabase();
            Database.MdiParent = this;
            Database.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display new REPORTS form
            frmReports Reports = new frmReports();
            Reports.MdiParent = this;
            Reports.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();

            
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
