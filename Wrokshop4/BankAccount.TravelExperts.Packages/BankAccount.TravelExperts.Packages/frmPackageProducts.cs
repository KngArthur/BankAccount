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
    public partial class frmPackageProducts : Form
    {

        public Package currentPackage;
        public frmPackageProducts()
        {
            InitializeComponent();
        }

        private void frmPackageProducts_Load(object sender, EventArgs e)
        {
            using (TravelExpertsDataContext dbContext = new TravelExpertsDataContext())
            {
                productDataGridView.DataSource = from prod in dbContext.Products
                                                 // statment where products = value passed from package ID?
                                                 select prod;
            }
        }
    }
}
