<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582161/13.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3023)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_OLAPSortBySummary/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_OLAPSortBySummary/Form1.vb))
<!-- default file list end -->
# How to implement Sorting by Summary in OLAP mode


<p>The following example demonstrates how to implement Sorting by Summary in OLAP mode.</p><p>In this example, values of the Semester field are sorted by the Australia | Bendigo column summary values. To do this, two sort conditions represented by PivotGridFieldSortCondition instances are created. One of them represents an OLAP member that corresponds to the 'Australia' value, while another corresponds to the 'Bendigo' value. These sort conditions are added to the Semester field's PivotGridFieldBase.SortBySummaryInfo.Conditions collection to specify the column by which Semester values should be sorted. A data field that identifies the column is specified via the PivotGridFieldBase.SortBySummaryInfo.Field property.</p><p>OLAP members corresponding to the Australia and Bendigo values are obtained using the PivotGridControl.GetFieldValueOLAPMember method. Note that OLAP members can be obtained only for visible field values. For this reason, the Australia field value is expanded before initializing OLAP members in order to obtain the Bendigo OLAP member.</p><p>This sample uses the Adventure Works 2008 cube.</p>

<br/>


