using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author:
 * Date:
 * Desc: Needs to add and modify products included in the packages. show grid view of all available. Use textboxes to enter info for new and edit
 */

namespace BankAccount.TravelExperts.Packages
{
    public partial class frmPackageProductsView : Form
    {
        public Package currentPkgProd;
        public frmPackageProductsView()
        {
            InitializeComponent();
        }

        private void frmPackageProducts_Load(object sender, EventArgs e)
        {
            using (TravelExpertsDataContext dbContext = new TravelExpertsDataContext())
            {
                dbContext.DeferredLoadingEnabled = false;
                packages_Products_SupplierDataGridView.DataSource = (from psi in dbContext.Packages_Products_Suppliers
                                                                     //join ps in Products_Supplier on psi
                                                                    //where psi.ProductSupplierId
                                                                    //join ps in dbContext.Products_Suppliers on psi.ProductSupplierId equals ps.ProductSupplierId
                                                                    //orderby psi.PackageId
                                                                    // statment where products = value passed from package ID?
                                                                    select psi).ToList();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }
    }
}
