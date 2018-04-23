Imports System
Imports DevExpress.Spreadsheet
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports DevExpress.Office.Utils

Namespace SnapAndSpreadsheetDocumentServerExample
    #Region "#XPictureProvider"
    Public Class XPictureProvider
        Implements IBindingRangeValueConverter

        Private pictures As Dictionary(Of String, Bitmap)

        Public Sub New(ByVal sheet As Worksheet)
            pictures = GetPictures(sheet)
        End Sub

        Public Function ConvertToObject(ByVal value As CellValue, ByVal requiredType As Type, ByVal columnIndex As Integer) As Object Implements IBindingRangeValueConverter.ConvertToObject
            If columnIndex = 13 Then
                Dim pic As Bitmap = Nothing
                If pictures.TryGetValue(value.TextValue, pic) Then
                    Return pic
                End If
            End If
            Return value
        End Function

        Public Function TryConvertFromObject(ByVal value As Object) As CellValue Implements IBindingRangeValueConverter.TryConvertFromObject
            Return CellValue.Empty
        End Function

        Public Function GetPictures(ByVal sheet As Worksheet) As Dictionary(Of String, Bitmap)
            Dim employeePictures As Dictionary(Of String, Bitmap) = New Dictionary(Of String, System.Drawing.Bitmap)()
            For Each pic As Picture In sheet.Pictures
                employeePictures.Add(pic.Name, New Bitmap(New MemoryStream(pic.Image.GetImageBytes(OfficeImageFormat.Bmp))))
            Next pic
            Return employeePictures
        End Function
    End Class
    #End Region ' #XPictureProvider
End Namespace