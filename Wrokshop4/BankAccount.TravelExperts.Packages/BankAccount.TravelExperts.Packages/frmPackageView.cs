using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount.TravelExperts.Packages
{
    public partial class frmPackageView : Form
    {
        public frmPackageView()
        {
            InitializeComponent();
        }

        private void frmPackageView_Load(object sender, EventArgs e)
        {
            using (TravelExpertsDataContext dbContext = new TravelExpertsDataContext())
            {

                //productDataGridView.DataSource = dbContext.Products; // entire table - no need for LINQ query
                packageDataGridView.DataSource = from pack in dbContext.Packages
                                                 
                                                 orderby pack.PkgStartDate
                                                 select pack;
            }
        }

        private void packageDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            // find column and row location of ID
            int rowNum = packageDataGridView.CurrentCell.RowIndex;
            int packID = (int)packageDataGridView["dataGridViewTextBoxColumn1", rowNum].Value;

            // Select ID
            Package currentPackage;
            using (TravelExpertsDataContext dbContext = new TravelExpertsDataContext())
            {
                currentPackage = (from pack in dbContext.Packages
                                  where pack.PackageId == packID
                                  select pack).Single();
            }

            //Open new form to view products by package ID
            frmPackageProducts secondForm = new frmPackageProducts();
            secondForm.currentPackage = currentPackage;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                RefreshGridView();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }








        private void RefreshGridView()
        {
            TravelExpertsDataContext dbContext = new TravelExpertsDataContext();
            packageDataGridView.DataSource = dbContext.Packages;
        }
    }
}
