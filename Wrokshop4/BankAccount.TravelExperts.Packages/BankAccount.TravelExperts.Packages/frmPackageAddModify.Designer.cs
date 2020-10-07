namespace BankAccount.TravelExperts.Packages
{
    partial class frmPackageAddModify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            this.packages_Products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbPackageId = new System.Windows.Forms.TextBox();
            this.txbPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.txbPkgBasePrice = new System.Windows.Forms.TextBox();
            this.txbPkgDesc = new System.Windows.Forms.TextBox();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.txbPkgName = new System.Windows.Forms.TextBox();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // packages_Products_SupplierBindingSource
            // 
            this.packages_Products_SupplierBindingSource.DataSource = typeof(BankAccount.TravelExperts.Packages.Packages_Products_Supplier);
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(BankAccount.TravelExperts.Packages.Package);
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(235, 99);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(65, 13);
            packageIdLabel.TabIndex = 0;
            packageIdLabel.Text = "Package Id:";
            // 
            // txbPackageId
            // 
            this.txbPackageId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.txbPackageId.Location = new System.Drawing.Point(367, 96);
            this.txbPackageId.Name = "txbPackageId";
            this.txbPackageId.Size = new System.Drawing.Size(200, 20);
            this.txbPackageId.TabIndex = 1;
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(235, 125);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(126, 13);
            pkgAgencyCommissionLabel.TabIndex = 2;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // txbPkgAgencyCommission
            // 
            this.txbPkgAgencyCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.txbPkgAgencyCommission.Location = new System.Drawing.Point(367, 122);
            this.txbPkgAgencyCommission.Name = "txbPkgAgencyCommission";
            this.txbPkgAgencyCommission.Size = new System.Drawing.Size(200, 20);
            this.txbPkgAgencyCommission.TabIndex = 3;
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(235, 151);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(83, 13);
            pkgBasePriceLabel.TabIndex = 4;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // txbPkgBasePrice
            // 
            this.txbPkgBasePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.txbPkgBasePrice.Location = new System.Drawing.Point(367, 148);
            this.txbPkgBasePrice.Name = "txbPkgBasePrice";
            this.txbPkgBasePrice.Size = new System.Drawing.Size(200, 20);
            this.txbPkgBasePrice.TabIndex = 5;
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(235, 177);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(57, 13);
            pkgDescLabel.TabIndex = 6;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // txbPkgDesc
            // 
            this.txbPkgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.txbPkgDesc.Location = new System.Drawing.Point(367, 174);
            this.txbPkgDesc.Name = "txbPkgDesc";
            this.txbPkgDesc.Size = new System.Drawing.Size(200, 20);
            this.txbPkgDesc.TabIndex = 7;
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(235, 204);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(77, 13);
            pkgEndDateLabel.TabIndex = 8;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.dtpPkgEndDate.Location = new System.Drawing.Point(367, 200);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPkgEndDate.TabIndex = 9;
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(235, 229);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(60, 13);
            pkgNameLabel.TabIndex = 10;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // txbPkgName
            // 
            this.txbPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.txbPkgName.Location = new System.Drawing.Point(367, 226);
            this.txbPkgName.Name = "txbPkgName";
            this.txbPkgName.Size = new System.Drawing.Size(200, 20);
            this.txbPkgName.TabIndex = 11;
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(235, 256);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(80, 13);
            pkgStartDateLabel.TabIndex = 12;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.dtpPkgStartDate.Location = new System.Drawing.Point(367, 252);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPkgStartDate.TabIndex = 13;
            // 
            // frmPackageAddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(packageIdLabel);
            this.Controls.Add(this.txbPackageId);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.txbPkgAgencyCommission);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.txbPkgBasePrice);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.txbPkgDesc);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.dtpPkgEndDate);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.txbPkgName);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.dtpPkgStartDate);
            this.Name = "frmPackageAddModify";
            this.Text = "PackageAdd";
            this.Load += new System.EventHandler(this.frmPackageAddModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packages_Products_SupplierBindingSource;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox txbPackageId;
        private System.Windows.Forms.TextBox txbPkgAgencyCommission;
        private System.Windows.Forms.TextBox txbPkgBasePrice;
        private System.Windows.Forms.TextBox txbPkgDesc;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.TextBox txbPkgName;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
    }
}