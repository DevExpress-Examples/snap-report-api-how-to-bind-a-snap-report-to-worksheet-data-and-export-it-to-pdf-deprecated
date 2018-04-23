Imports DevExpress.Snap
Imports DevExpress.Snap.Core.API
Imports System

Namespace SnapAndSpreadsheetDocumentServerExample
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
'            #Region "#MainAction"
            Dim snap As New SnapDocumentServer()
            Dim document As SnapDocument = snap.Document
            XTemplateCreator.CreateMailMergeTemplate(document)
            snap.Options.SnapMailMergeVisualOptions.DataSource = XDataSourceHelper.GetData()
            snap.SnapMailMerge("test.pdf", SnapDocumentFormat.Pdf)
'            #End Region ' #MainAction
            System.Diagnostics.Process.Start("test.pdf")

            '// Uncomment the following code snippet 
            '// to create and use another Snap template
            'SnapDocumentServer snap = new SnapDocumentServer();
            'SnapDocument document = snap.Document;
            'XTemplateCreator.CreateSnListTemplate(document);
            'document.DataSource = XDataSourceHelper.GetData();
            'snap.ExportToPdf( "test.pdf");
            'System.Diagnostics.Process.Start("test.pdf");
        End Sub
    End Class
End Namespace
