namespace XtraPivotGrid_OLAPSortBySummary {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding7 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding8 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldInternetSalesAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFiscalYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldInternetSalesAmount1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemProgressBar1.DisplayFormat.FormatString = "{0}%";
            this.repositoryItemProgressBar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldInternetSalesAmount,
            this.fieldCountry,
            this.fieldCity,
            this.fieldFiscalYear});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 12);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OLAPConnectionString = "provider=MSOLAP;data source=https://demos.devexpress.com/Services/OLAP/msmdpump.d" +
    "ll;initial catalog=\"Adventure Works DW Standard Edition\";cube name=\"Adventure Wo" +
    "rks\"";
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(587, 247);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldInternetSalesAmount
            // 
            this.fieldInternetSalesAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldInternetSalesAmount.AreaIndex = 0;
            this.fieldInternetSalesAmount.Caption = "Sales";
            dataSourceColumnBinding5.ColumnName = "[Measures].[Internet Sales Amount]";
            this.fieldInternetSalesAmount.DataBinding = dataSourceColumnBinding5;
            this.fieldInternetSalesAmount.DisplayFolder = "Internet Sales";
            this.fieldInternetSalesAmount.Name = "fieldInternetSalesAmount";
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.Caption = "Country";
            dataSourceColumnBinding6.ColumnName = "[Customer].[Country].[Country]";
            this.fieldCountry.DataBinding = dataSourceColumnBinding6;
            this.fieldCountry.DisplayFolder = "Location";
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldCity
            // 
            this.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCity.AreaIndex = 1;
            this.fieldCity.Caption = "City";
            dataSourceColumnBinding7.ColumnName = "[Customer].[City].[City]";
            this.fieldCity.DataBinding = dataSourceColumnBinding7;
            this.fieldCity.DisplayFolder = "Location";
            this.fieldCity.Name = "fieldCity";
            // 
            // fieldFiscalYear
            // 
            this.fieldFiscalYear.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldFiscalYear.AreaIndex = 0;
            this.fieldFiscalYear.Caption = "Fiscal Year";
            dataSourceColumnBinding8.ColumnName = "[Date].[Fiscal Year].[Fiscal Year]";
            this.fieldFiscalYear.DataBinding = dataSourceColumnBinding8;
            this.fieldFiscalYear.DisplayFolder = "Fiscal";
            this.fieldFiscalYear.Name = "fieldFiscalYear";
            // 
            // fieldInternetSalesAmount1
            // 
            this.fieldInternetSalesAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldInternetSalesAmount1.AreaIndex = 1;
            this.fieldInternetSalesAmount1.Caption = "Internet Sales Amount";
            this.fieldInternetSalesAmount1.FieldName = "[Measures].[Internet Sales Amount]";
            this.fieldInternetSalesAmount1.Name = "fieldInternetSalesAmount1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 271);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInternetSalesAmount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInternetSalesAmount1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFiscalYear;
    }
}

