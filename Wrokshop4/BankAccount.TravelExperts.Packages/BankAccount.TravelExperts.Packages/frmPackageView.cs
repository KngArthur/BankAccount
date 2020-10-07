using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankAccount.TravelExperts.Packages.Methods;

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
            // load package list to grid
            using (TravelExpertsDataContext dbContext = new TravelExpertsDataContext())
            {
                // select all packages ordered by start date
                packageDataGridView.DataSource = from pack in dbContext.Packages                                                 
                                                 orderby pack.PkgStartDate
                                                 select pack;
            }
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            // find column and row location of ID
            int rowNum = packageDataGridView.CurrentCell.RowIndex;
            int packID = (int)packageDataGridView["dataGridViewTextBoxColumn1", rowNum].Value;

            // Select ID
            Package currentPkgProd;
            using (TravelExpertsDataContext dbContext = new TravelExpertsDataContext())
            {
                currentPkgProd = (from pack in dbContext.Packages
                                  where pack.PackageId == packID
                                  select pack).Single();
            }

            //Open new form to view products by package ID
            frmPackageProductsView secondForm = new frmPackageProductsView();
            secondForm.currentPkgProd = currentPkgProd;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPackageAddModify secondform = new frmPackageAddModify();
            secondform.isAdd = true;
            secondform.currentPackage = null;
            DialogResult result = secondform.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshGridView();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //find column and row location of ID
            int rowNum = packageDataGridView.CurrentCell.RowIndex;
            int packID = (int)packageDataGridView["dataGridViewTextBoxColumn1", rowNum].Value;

            //Select ID
            Package currentPackage;
            using (TravelExpertsDataContext dbContext = new TravelExpertsDataContext())
            {
                currentPackage = (from pack in dbContext.Packages
                                  where pack.PackageId == packID
                                  select pack).Single();
            }

            //Open new form to view products by package ID
            frmPackageAddModify secondForm = new frmPackageAddModify();
            secondForm.currentPackage = currentPackage;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                RefreshGridView();
            }
        }

        private void RefreshGridView()
        {
            TravelExpertsDataContext dbContext = new TravelExpertsDataContext();
            packageDataGridView.DataSource = dbContext.Packages;
        }
    }
}
