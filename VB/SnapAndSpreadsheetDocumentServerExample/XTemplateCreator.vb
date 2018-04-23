Imports DevExpress.Snap
Imports DevExpress.Snap.Core.API
Imports DevExpress.XtraRichEdit.API.Native
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace SnapAndSpreadsheetDocumentServerExample

    Public NotInheritable Class XTemplateCreator

        Private Sub New()
        End Sub

        #Region "#CreateSnListTemplate"
        Public Shared Sub CreateSnListTemplate(ByVal document As SnapDocument)
            Dim list As SnapList = document.CreateSnList(document.Range.End, "EmployeeList")

            list.BeginUpdate()

            Dim listHeader As SnapDocument = list.ListHeader
            Dim listHeaderTable As Table = listHeader.Tables.Create(listHeader.Range.End, 1, 3)
            Dim listHeaderCells As TableCellCollection = listHeaderTable.FirstRow.Cells
            listHeader.InsertText(listHeaderCells(0).ContentRange.End, "First Name")
            listHeader.InsertText(listHeaderCells(1).ContentRange.End, "Last Name")
            listHeader.InsertText(listHeaderCells(2).ContentRange.End, "Photo")

            Dim listRow As SnapDocument = list.RowTemplate
            Dim listRowTable As Table = listRow.Tables.Create(listRow.Range.End, 1, 3)
            Dim listRowCells As TableCellCollection = listRowTable.FirstRow.Cells
            listRow.CreateSnText(listRowCells(0).ContentRange.End, """First Name""")
            listRow.CreateSnText(listRowCells(1).ContentRange.End, """Last Name""")
            listRow.CreateSnImage(listRowCells(2).ContentRange.End, "Photo")

            list.EndUpdate()
        End Sub
        #End Region ' #CreateSnListTemplate

        #Region "#CreateMailMergeTemplate"
        Public Shared Sub CreateMailMergeTemplate(ByVal document As SnapDocument)
            document.CreateSnImage(document.Range.End, "Photo")
            document.Paragraphs.Insert(document.Range.End)
            document.CreateSnText(document.Range.End, """First Name""")
            document.AppendText(" ")
            document.CreateSnText(document.Range.End, """Last Name""")
        End Sub
        #End Region ' #CreateMailMergeTemplate
    End Class

End Namespace
