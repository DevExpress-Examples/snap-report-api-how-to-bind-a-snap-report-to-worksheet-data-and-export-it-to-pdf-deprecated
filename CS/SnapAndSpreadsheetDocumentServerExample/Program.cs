using DevExpress.Snap;
using DevExpress.Snap.Core.API;
using System;

namespace SnapAndSpreadsheetDocumentServerExample {
    class Program {
        static void Main(string[] args) {
            if (args.Length == 0) {
                #region #MainAction
                SnapDocumentServer snap = new SnapDocumentServer();
                SnapDocument document = snap.Document;
                XTemplateCreator.CreateMailMergeTemplate(document);
                snap.Options.SnapMailMergeVisualOptions.DataSource = XDataSourceHelper.GetData();
                snap.SnapMailMerge("test.pdf", SnapDocumentFormat.Pdf);
                #endregion #MainAction
                System.Diagnostics.Process.Start("test.pdf");
            }
            else if (args[0] == "UseListTemplate") {
                SnapDocumentServer snap = new SnapDocumentServer();
                SnapDocument document = snap.Document;
                XTemplateCreator.CreateSnListTemplate(document);
                document.DataSource = XDataSourceHelper.GetData();
                snap.ExportToPdf("test.pdf");
                System.Diagnostics.Process.Start("test.pdf");
            }
        }
    }
}
