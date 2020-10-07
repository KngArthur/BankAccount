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
        DateTime? startTmpDate;
        DateTime? endTmpDate;
        public frmPackageAddModify()
        {
            InitializeComponent();
        }

        private void frmPackageAddModify_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                txbPkgName.Focus();
                txbPackageId.Enabled = false;
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

            if (currentPackage.PkgAgencyCommission != null)
            {
                decimal temp = (decimal) currentPackage.PkgAgencyCommission;
                txbPkgAgencyCommission.Text = temp.ToString("0.##");
            }
            else
            {
                txbPkgAgencyCommission.Text = "";
            }
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
                    if(isAdd)
                    {
                        Package newPackage = new Package()
                        {
                            PkgAgencyCommission = Convert.ToDecimal(txbPkgAgencyCommission.Text),
                            PkgBasePrice = Convert.ToDecimal(txbPkgBasePrice.Text),
                            PkgDesc = txbPkgDesc.Text,
                            PkgName = txbPkgName.Text,
                            PkgStartDate = startTmpDate,
                            PkgEndDate = endTmpDate
                        };

                        using (TravelExpertsDataContext dataContext = new TravelExpertsDataContext())
                        {
                            dbContext.Packages.InsertOnSubmit(newPackage);
                            dbContext.SubmitChanges();
                        }
                        DialogResult = DialogResult.OK;
                    }
                                     
                    else
                    {
                        Package pkg = dbContext.Packages.SingleOrDefault(p => p.PackageId == Convert.ToInt32(txbPackageId.Text));
                        pkg.PkgAgencyCommission = Convert.ToDecimal(txbPkgAgencyCommission.Text);
                        pkg.PkgBasePrice = Convert.ToDecimal(txbPkgBasePrice.Text);
                        pkg.PkgDesc = txbPkgDesc.Text;
                        pkg.PkgName = txbPkgName.Text;
                        pkg.PkgStartDate = startTmpDate;
                        pkg.PkgEndDate = endTmpDate;

                        dbContext.SubmitChanges();
                        DialogResult = DialogResult.OK;
                    }
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
                startTmpDate = dtpPkgStartDate.Value;
            }
        }

        private void dtpPkgEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpPkgEndDate.Value != null)
            {
                endTmpDate = dtpPkgEndDate.Value;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
