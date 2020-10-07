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
            txbPackageId.Text = currentPackage.PackageId.ToString();
            txbPkgAgencyCommission.Text = currentPackage.PkgAgencyCommission.ToString();
            txbPkgBasePrice.Text = currentPackage.PkgBasePrice.ToString();
            txbPkgDesc.Text = currentPackage.PkgDesc;
            dtpPkgStartDate.Text = currentPackage.PkgStartDate.Value.ToShortDateString();
            dtpPkgEndDate.Text = currentPackage.PkgEndDate.Value.ToShortDateString();
            txbPkgName.Text = currentPackage.PkgName;
        }
    }
}
