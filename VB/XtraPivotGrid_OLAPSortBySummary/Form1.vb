Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace XtraPivotGrid_OLAPSortBySummary
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Expands the Australia column to be able to retrieve OLAP members 
            ' that correspond to the nested columns.
            pivotGridControl1.ExpandValue(True, New Object() { "Australia" })

            ' Obtains OLAP members corresponding to the Australia and Bendigo values.
            Dim countryMember As IOLAPMember = pivotGridControl1.GetFieldValueOLAPMember(fieldCountry, 0)
            Dim cityMember As IOLAPMember = pivotGridControl1.GetFieldValueOLAPMember(fieldCity, 0)

            ' Exits if the OLAP members were not obtained successfully.
            If countryMember Is Nothing OrElse cityMember Is Nothing Then
                Return
            End If

            ' Locks the pivot grid from updating while the Sort by Summary
            ' settings are being customized.
            pivotGridControl1.BeginUpdate()
            Try

                ' Specifies a data field whose summary values should be used to sort values
                ' of the Fiscal Year field.
                fieldFiscalYear.SortBySummaryInfo.Field = fieldInternetSalesAmount

                ' Specifies a column by which the Fiscal Year field values should be sorted.
                fieldFiscalYear.SortBySummaryInfo.Conditions.Add(New PivotGridFieldSortCondition( _
                                                                 fieldCountry, _
                                                                 "Australia", _
                                                                 countryMember.UniqueName))
                fieldFiscalYear.SortBySummaryInfo.Conditions.Add(New PivotGridFieldSortCondition( _
                                                                 fieldCity, _
                                                                 "Bendigo", _
                                                                 cityMember.UniqueName))
            Finally
                ' Unlocks the pivot grid and applies changes.
                pivotGridControl1.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
