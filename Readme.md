<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608883/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T518437)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/SnapAndSpreadsheetDocumentServerExample/Program.cs) (VB: [Program.vb](./VB/SnapAndSpreadsheetDocumentServerExample/Program.vb))
* [XDataSourceHelper.cs](./CS/SnapAndSpreadsheetDocumentServerExample/XDataSourceHelper.cs) (VB: [XDataSourceHelper.vb](./VB/SnapAndSpreadsheetDocumentServerExample/XDataSourceHelper.vb))
* [XPictureProvider.cs](./CS/SnapAndSpreadsheetDocumentServerExample/XPictureProvider.cs) (VB: [XPictureProvider.vb](./VB/SnapAndSpreadsheetDocumentServerExample/XPictureProvider.vb))
* [XTemplateCreator.cs](./CS/SnapAndSpreadsheetDocumentServerExample/XTemplateCreator.cs) (VB: [XTemplateCreator.vb](./VB/SnapAndSpreadsheetDocumentServerExample/XTemplateCreator.vb))
<!-- default file list end -->
# Snap Report API - How to bind a Snap report to worksheet data and export it to PDF


This example uses the <a href="http://help.devexpress.com/#DocumentServer/CustomDocument15188">Snap Report API</a> library to create a report, bind it to data and export to PDF. The data are obtained from a worksheet file in .XLSX format using the data binding feature of the <a href="http://help.devexpress.com/#DocumentServer/CustomDocument14912">Spreadsheet Report API</a> library.<br>The report template is created in code using the <a href="http://help.devexpress.com/#WindowsForms/DevExpressSnapCoreAPIISnapFieldOwner_CreateSnTexttopic">CreateSnText</a> and <a href="http://help.devexpress.com/#WindowsForms/DevExpressSnapCoreAPIISnapFieldOwner_CreateSnImagetopic">CreateSnImage</a> methods.<br>Data source is created from a worksheet table with the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetTable_GetDataSourcetopic">Table.GetDataSource</a> method. Floating pictures in a worksheet are processed with a custom <strong>XPictureProvider </strong>converter to provide Bitmap data for the data source <em>Photo</em> field. The converter implements the <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressSpreadsheetIBindingRangeValueConvertertopic">IBindingRangeValueConverter</a> interface. The converter is specified using the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetDataSourceOptionsBase_CellValueConvertertopic">RangeDataSourceOptions.CellValueConverter</a> property of the object passed to the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetTable_GetDataSourcetopic">Table.GetDataSource</a> method as a parameter.<br><br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/document-server-create-a-snap-report-bind-it-to-worksheet-data-and-print-to-pdf-t518437/17.1.3+/media/5d33ae05-4099-11e7-80c0-00155d624807.png">

<br/>


