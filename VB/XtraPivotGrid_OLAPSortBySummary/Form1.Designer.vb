Namespace XtraPivotGrid_OLAPSortBySummary

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding7 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding8 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldInternetSalesAmount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldFiscalYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldInternetSalesAmount1 = New DevExpress.XtraPivotGrid.PivotGridField()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.pivotGridControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldInternetSalesAmount, Me.fieldCountry, Me.fieldCity, Me.fieldFiscalYear})
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 12)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OLAPConnectionString = "provider=MSOLAP;data source=https://demos.devexpress.com/Services/OLAP/msmdpump.d" & "ll;initial catalog=""Adventure Works DW Standard Edition"";cube name=""Adventure Wo" & "rks"""
            Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(587, 247)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' fieldInternetSalesAmount
            ' 
            Me.fieldInternetSalesAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldInternetSalesAmount.AreaIndex = 0
            Me.fieldInternetSalesAmount.Caption = "Sales"
            dataSourceColumnBinding5.ColumnName = "[Measures].[Internet Sales Amount]"
            Me.fieldInternetSalesAmount.DataBinding = dataSourceColumnBinding5
            Me.fieldInternetSalesAmount.DisplayFolder = "Internet Sales"
            Me.fieldInternetSalesAmount.Name = "fieldInternetSalesAmount"
            ' 
            ' fieldCountry
            ' 
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCountry.AreaIndex = 0
            Me.fieldCountry.Caption = "Country"
            dataSourceColumnBinding6.ColumnName = "[Customer].[Country].[Country]"
            Me.fieldCountry.DataBinding = dataSourceColumnBinding6
            Me.fieldCountry.DisplayFolder = "Location"
            Me.fieldCountry.Name = "fieldCountry"
            ' 
            ' fieldCity
            ' 
            Me.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCity.AreaIndex = 1
            Me.fieldCity.Caption = "City"
            dataSourceColumnBinding7.ColumnName = "[Customer].[City].[City]"
            Me.fieldCity.DataBinding = dataSourceColumnBinding7
            Me.fieldCity.DisplayFolder = "Location"
            Me.fieldCity.Name = "fieldCity"
            ' 
            ' fieldFiscalYear
            ' 
            Me.fieldFiscalYear.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldFiscalYear.AreaIndex = 0
            Me.fieldFiscalYear.Caption = "Fiscal Year"
            dataSourceColumnBinding8.ColumnName = "[Date].[Fiscal Year].[Fiscal Year]"
            Me.fieldFiscalYear.DataBinding = dataSourceColumnBinding8
            Me.fieldFiscalYear.DisplayFolder = "Fiscal"
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
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
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
