using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_OLAPSortBySummary {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            // Expands the Australia column to be able to retrieve OLAP members 
            // that correspond to the nested columns.
            pivotGridControl1.ExpandValue(true, new object[] { "Australia" });

            // Obtains OLAP members corresponding to the Australia and Bendigo values.
            IOLAPMember countryMember = pivotGridControl1.GetFieldValueOLAPMember(fieldCountry, 0);
            IOLAPMember cityMember = pivotGridControl1.GetFieldValueOLAPMember(fieldCity, 0);
            
            // Exits if the OLAP members were not obtained successfully.
            if (countryMember == null || cityMember == null)
                return;

            // Locks the pivot grid from updating while the Sort by Summary
            // settings are being customized.
            pivotGridControl1.BeginUpdate();
            try {

                // Specifies a data field whose summary values should be used to sort values
                // of the Fiscal Year field.
                fieldFiscalYear.SortBySummaryInfo.Field = fieldInternetSalesAmount;

                // Specifies a column by which the Fiscal Year field values should be sorted.
                fieldFiscalYear.SortBySummaryInfo.Conditions.Add(
                    new PivotGridFieldSortCondition(fieldCountry, "Australia", countryMember.UniqueName));
                fieldFiscalYear.SortBySummaryInfo.Conditions.Add(
                    new PivotGridFieldSortCondition(fieldCity, "Bendigo", cityMember.UniqueName));
            }
            finally {
                // Unlocks the pivot grid and applies changes.
                pivotGridControl1.EndUpdate();
            }
        }
    }
}
