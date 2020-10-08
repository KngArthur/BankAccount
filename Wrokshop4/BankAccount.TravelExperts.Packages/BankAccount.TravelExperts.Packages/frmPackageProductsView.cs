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
 * Author: Branden Arthur
 * Date: October 7 2020
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
                PackageProductsGridView.DataSource = (from pack in dbContext.Packages
                                                      join psi in dbContext.Packages_Products_Suppliers on pack.PackageId equals psi.PackageId
                                                      join ps in dbContext.Products_Suppliers on psi.ProductSupplierId equals ps.ProductSupplierId
                                                      join p in dbContext.Products on ps.ProductId equals p.ProductId
                                                      join s in dbContext.Suppliers on ps.SupplierId equals s.SupplierId
                                                     select new
                                                     {
                                                        pack.PkgName,
                                                        p.ProdName,
                                                        s.SupName
                                                     }).ToList();



                //where psi.ProductSupplierId
                //join ps in dbContext.Products_Suppliers on psi.ProductSupplierId equals ps.ProductSupplierId
                //orderby psi.PackageId
                // statment where products = value passed from package ID?
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
