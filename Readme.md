<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/SnapAndSpreadsheetDocumentServerExample/Program.cs) (VB: [Program.vb](./VB/SnapAndSpreadsheetDocumentServerExample/Program.vb))
* [XDataSourceHelper.cs](./CS/SnapAndSpreadsheetDocumentServerExample/XDataSourceHelper.cs) (VB: [XDataSourceHelper.vb](./VB/SnapAndSpreadsheetDocumentServerExample/XDataSourceHelper.vb))
* [XPictureProvider.cs](./CS/SnapAndSpreadsheetDocumentServerExample/XPictureProvider.cs) (VB: [XPictureProvider.vb](./VB/SnapAndSpreadsheetDocumentServerExample/XPictureProvider.vb))
* [XTemplateCreator.cs](./CS/SnapAndSpreadsheetDocumentServerExample/XTemplateCreator.cs) (VB: [XTemplateCreator.vb](./VB/SnapAndSpreadsheetDocumentServerExample/XTemplateCreator.vb))
<!-- default file list end -->
# Snap Report API - How to bind a Snap report to worksheet data and export it to PDF
> **Note**
>
> As you may already know, the [WinForms Snap control](https://docs.devexpress.com/WindowsForms/11373/controls-and-libraries/snap) and [Snap Report API](https://docs.devexpress.com/OfficeFileAPI/15188/snap-report-api) are now in maintenance support mode. No new features or capabilities are incorporated into these products. We recommend that you use [DevExpress Reporting](https://docs.devexpress.com/XtraReports/2162/reporting) tool to generate, edit, print, and export your business reports/documents.

This example uses the [Snap Report API](https://docs.devexpress.com/OfficeFileAPI/15188/snap-report-api?v=21.2) library to create a report, bind it to data and export to PDF. The data are obtained from a worksheet file in .XLSX format using the data binding feature of the [Spreadsheet Report API](https://docs.devexpress.com/OfficeFileAPI/14912/spreadsheet-document-api?v=21.2) library.  
The report template is created in code using the [CreateSnText](https://docs.devexpress.com/WindowsForms/DevExpress.Snap.Core.API.ISnapFieldOwner.CreateSnText(DevExpress.XtraRichEdit.API.Native.DocumentPosition-System.String)?v=21.2) and [CreateSnImage](https://docs.devexpress.com/WindowsForms/DevExpress.Snap.Core.API.ISnapFieldOwner.CreateSnImage(DevExpress.XtraRichEdit.API.Native.DocumentPosition-System.String)?v=21.2) methods.  
Data source is created from a worksheet table with the [Table.GetDataSource](https://docs.devexpress.com/OfficeFileAPI/devexpress.spreadsheet.table.getdatasource.overloads) method. Floating pictures in a worksheet are processed with a custom **XPictureProvider **converter to provide Bitmap data for the data source _Photo_ field. The converter implements the [IBindingRangeValueConverter](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.IBindingRangeValueConverter) interface. The converter is specified using the [RangeDataSourceOptions.CellValueConverter](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.DataSourceOptionsBase.CellValueConverter) property of the object passed to the [Table.GetDataSource](https://docs.devexpress.com/OfficeFileAPI/devexpress.spreadsheet.table.getdatasource.overloads) method as a parameter.  

![](https://raw.githubusercontent.com/DevExpress-Examples/document-server-create-a-snap-report-bind-it-to-worksheet-data-and-print-to-pdf-t518437/17.1.3+/media/5d33ae05-4099-11e7-80c0-00155d624807.png)
