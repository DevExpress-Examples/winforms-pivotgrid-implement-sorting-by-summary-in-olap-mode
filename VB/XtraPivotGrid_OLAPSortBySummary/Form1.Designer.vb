Namespace XtraPivotGrid_OLAPSortBySummary
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldInternetSalesAmount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldFiscalYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldInternetSalesAmount1 = New DevExpress.XtraPivotGrid.PivotGridField()
            DirectCast(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemProgressBar1.DisplayFormat.FormatString = "{0}%"
            Me.repositoryItemProgressBar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            Me.repositoryItemProgressBar1.ShowTitle = True
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldInternetSalesAmount, Me.fieldCountry, Me.fieldCity, Me.fieldFiscalYear})
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 12)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OLAPConnectionString = "provider=MSOLAP;data source=http://demos.devexpress.com/Services/OLAP/msmdpump.dl" & "l;initial catalog=""Adventure Works DW Standard Edition"";cube name=""Adventure Wor" & "ks"""
            Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(587, 247)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' fieldInternetSalesAmount
            ' 
            Me.fieldInternetSalesAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldInternetSalesAmount.AreaIndex = 0
            Me.fieldInternetSalesAmount.Caption = "Sales"
            Me.fieldInternetSalesAmount.FieldName = "[Measures].[Internet Sales Amount]"
            Me.fieldInternetSalesAmount.Name = "fieldInternetSalesAmount"
            ' 
            ' fieldCountry
            ' 
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCountry.AreaIndex = 0
            Me.fieldCountry.Caption = "Country"
            Me.fieldCountry.FieldName = "[Customer].[Country].[Country]"
            Me.fieldCountry.Name = "fieldCountry"
            ' 
            ' fieldCity
            ' 
            Me.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCity.AreaIndex = 1
            Me.fieldCity.Caption = "City"
            Me.fieldCity.FieldName = "[Customer].[City].[City]"
            Me.fieldCity.Name = "fieldCity"
            ' 
            ' fieldFiscalYear
            ' 
            Me.fieldFiscalYear.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldFiscalYear.AreaIndex = 0
            Me.fieldFiscalYear.Caption = "Fiscal Year"
            Me.fieldFiscalYear.FieldName = "[Date].[Fiscal Year].[Fiscal Year]"
            Me.fieldFiscalYear.Name = "fieldFiscalYear"
            ' 
            ' fieldInternetSalesAmount1
            ' 
            Me.fieldInternetSalesAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldInternetSalesAmount1.AreaIndex = 1
            Me.fieldInternetSalesAmount1.Caption = "Internet Sales Amount"
            Me.fieldInternetSalesAmount1.FieldName = "[Measures].[Internet Sales Amount]"
            Me.fieldInternetSalesAmount1.Name = "fieldInternetSalesAmount1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(611, 271)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private fieldInternetSalesAmount As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldInternetSalesAmount1 As DevExpress.XtraPivotGrid.PivotGridField
        Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
        Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldCity As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldFiscalYear As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace

