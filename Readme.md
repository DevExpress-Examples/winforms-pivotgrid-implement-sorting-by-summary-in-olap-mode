<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582161/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3023)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Pivot Grid for WinForms - Implement Sorting by Summary in OLAP Mode

The following example demonstrates how to implement sorting by summary in OLAP mode. In this example, values of the _Fiscal Year_ field are sorted by the _Australia_ | _Bendigo_ column summary values.

![Pivot Grid](image/pivotgrid.png)

 Two `PivotGridFieldSortCondition` objects contain OLAP members that correspond to `Australia` and `Bendigo` values. The `PivotGridControl.GetFieldValueOLAPMember` methods obtain these values. Obtained values specify columns by which the _Fiscal Year_ field should be sorted and are stored in the _Fiscal Year_'s `PivotGridFieldBase.SortBySummaryInfo.Conditions` collection. OLAP members can be obtained only for visible field values. For this reason, the Australia field value is expanded before initializing OLAP members to obtain the _Bendigo_ member. The `PivotGridFieldBase.SortBySummaryInfo.Field` property specifies the data field whose summary values should be used to sort values of the Fiscal Year field.

## Files to Review

* [Form1.cs](./CS/XtraPivotGrid_OLAPSortBySummary/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_OLAPSortBySummary/Form1.vb))

## Documentation

- [Filter by Summaries](https://docs.devexpress.com/WindowsForms/11545/controls-and-libraries/pivot-grid/data-shaping/filtering/filter-by-summaries)
- [Summaries](https://docs.devexpress.com/WindowsForms/9384)
- [Levels of Details](https://docs.devexpress.com/WindowsForms/1796/controls-and-libraries/pivot-grid/fundamentals/hierarchical-value-presentation#use-resulting-detail-levels)

## More Examples

[Pivot Grid for WinForms - Apply Summary Filter](https://github.com/DevExpress-Examples/winforms-pivot-apply-summary-filter) 



<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid-implement-sorting-by-summary-in-olap-mode&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid-implement-sorting-by-summary-in-olap-mode&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
