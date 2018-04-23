Imports DevExpress.Spreadsheet

Namespace SnapAndSpreadsheetDocumentServerExample
    #Region "#XDataSourceHelper"
    Public NotInheritable Class XDataSourceHelper

        Private Sub New()
        End Sub

        Public Shared Function GetData() As Object
            Dim wb As New Workbook()
            wb.LoadDocument("Employees.xlsx")
            Dim options As New RangeDataSourceOptions()
            options.UseFirstRowAsHeader = True
            options.CellValueConverter = New XPictureProvider(wb.Worksheets(0))
            Return wb.Worksheets(0).Tables(0).GetDataSource(options)
        End Function
    End Class
    #End Region ' #XDataSourceHelper
End Namespace
