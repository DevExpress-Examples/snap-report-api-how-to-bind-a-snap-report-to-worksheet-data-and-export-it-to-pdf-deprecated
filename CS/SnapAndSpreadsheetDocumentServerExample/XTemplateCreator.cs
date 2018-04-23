using DevExpress.Snap;
using DevExpress.Snap.Core.API;
using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnapAndSpreadsheetDocumentServerExample {

    public static class XTemplateCreator {
        #region #CreateSnListTemplate
        public static void CreateSnListTemplate(SnapDocument document) {
            SnapList list = document.CreateSnList(document.Range.End, "EmployeeList");

            list.BeginUpdate();

            SnapDocument listHeader = list.ListHeader;
            Table listHeaderTable = listHeader.Tables.Create(listHeader.Range.End, 1, 3);
            TableCellCollection listHeaderCells = listHeaderTable.FirstRow.Cells;
            listHeader.InsertText(listHeaderCells[0].ContentRange.End, "First Name");
            listHeader.InsertText(listHeaderCells[1].ContentRange.End, "Last Name");
            listHeader.InsertText(listHeaderCells[2].ContentRange.End, "Photo");

            SnapDocument listRow = list.RowTemplate;
            Table listRowTable = listRow.Tables.Create(listRow.Range.End, 1, 3);
            TableCellCollection listRowCells = listRowTable.FirstRow.Cells;
            listRow.CreateSnText(listRowCells[0].ContentRange.End, "\"First Name\"");
            listRow.CreateSnText(listRowCells[1].ContentRange.End, "\"Last Name\"");
            listRow.CreateSnImage(listRowCells[2].ContentRange.End, "Photo");

            list.EndUpdate();
        }
        #endregion #CreateSnListTemplate

        #region #CreateMailMergeTemplate
        public static void CreateMailMergeTemplate(SnapDocument document) {
            document.CreateSnImage(document.Range.End, "Photo");
            document.Paragraphs.Insert(document.Range.End);
            document.CreateSnText(document.Range.End, "\"First Name\"");
            document.AppendText(" ");
            document.CreateSnText(document.Range.End, "\"Last Name\"");
        }
        #endregion #CreateMailMergeTemplate
    }

}
