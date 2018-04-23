using DevExpress.Spreadsheet;

namespace SnapAndSpreadsheetDocumentServerExample {
    #region #XDataSourceHelper
    public static class XDataSourceHelper {
        public static object GetData() {
            Workbook wb = new Workbook();
            wb.LoadDocument("Employees.xlsx");
            RangeDataSourceOptions options = new RangeDataSourceOptions();
            options.UseFirstRowAsHeader = true;
            options.CellValueConverter = new XPictureProvider(wb.Worksheets[0]);
            return wb.Worksheets[0].Tables[0].GetDataSource(options);
        }
    }
    #endregion #XDataSourceHelper
}
