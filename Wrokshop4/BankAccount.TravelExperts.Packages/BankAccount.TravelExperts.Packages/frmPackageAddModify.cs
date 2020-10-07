using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount.TravelExperts.Packages
{
    public partial class frmPackageAddModify : Form
    {
        public bool isAdd;
        public Package currentPackage;
        DateTime? tmpDate;
        public frmPackageAddModify()
        {
            InitializeComponent();
        }

        private void frmPackageAddModify_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                txbPkgAgencyCommission.Focus();
            }
            else
            {
                DisplayCurrentProduct();
                txbPackageId.Enabled = false;
            }
        }

        private void DisplayCurrentProduct()
        {
            if (currentPackage.PkgStartDate.HasValue && currentPackage.PkgEndDate.HasValue)
            {
                dtpPkgStartDate.Value = currentPackage.PkgStartDate.Value;
                dtpPkgEndDate.Value = currentPackage.PkgEndDate.Value;
                dtpPkgStartDate.Text = currentPackage.PkgStartDate.Value.ToShortDateString();
                dtpPkgEndDate.Text = currentPackage.PkgEndDate.Value.ToShortDateString();
            }
            else
            {
                dtpPkgStartDate.Text = "";
                dtpPkgStartDate.CustomFormat = "";
                dtpPkgStartDate.Format = DateTimePickerFormat.Custom;
                dtpPkgEndDate.Text = "";
                dtpPkgEndDate.CustomFormat = "";
                dtpPkgEndDate.Format = DateTimePickerFormat.Custom;
            }

            txbPackageId.Text = currentPackage.PackageId.ToString();
            txbPkgAgencyCommission.Text = currentPackage.PkgAgencyCommission.ToString();
            txbPkgBasePrice.Text = currentPackage.PkgBasePrice.ToString("0.##");
            txbPkgDesc.Text = currentPackage.PkgDesc;
            txbPkgName.Text = currentPackage.PkgName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (TravelExpertsDataContext dbContext = new TravelExpertsDataContext())
                {
                    Package pkg = null;
                    pkg = dbContext.Packages.SingleOrDefault(p => p.PackageId == Convert.ToInt32(txbPackageId.Text));
                    pkg.PkgAgencyCommission = Convert.ToDecimal(txbPkgAgencyCommission.Text);
                    pkg.PkgBasePrice = Convert.ToDecimal(txbPkgBasePrice.Text);
                    pkg.PkgDesc = txbPkgDesc.Text;
                    pkg.PkgName = txbPkgName.Text;
                    pkg.PkgStartDate = tmpDate;
                    pkg.PkgEndDate = tmpDate;

                    // validation
                        
                    dbContext.SubmitChanges();
                    DialogResult = DialogResult.OK;
                }
            }

            catch (ChangeConflictException)
            {
                MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
                DialogResult = DialogResult.Retry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
        private void dtpPkgStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpPkgStartDate.Value != null)
            {
                tmpDate = dtpPkgStartDate.Value;
            }
        }

        private void dtpPkgEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpPkgEndDate.Value != null)
            {
                tmpDate = dtpPkgEndDate.Value;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
