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
                packages_Products_SupplierDataGridView.DataSource = from psi in dbContext.Packages_Products_Suppliers
                                                                    //where psi.ProductSupplierId
                                                                    //join ps in dbContext.Products_Suppliers on psi.ProductSupplierId equals ps.ProductSupplierId
                                                                    //orderby psi.PackageId
                                                                    // statment where products = value passed from package ID?
                                                                    select psi;
            }
        }
    }
}
