Imports System.Windows.Forms
Imports DevExpress.XtraPdfViewer
Imports DevExpress.XtraBars
Imports DevExpress.XtraPdfViewer.Extensions
Imports DevExpress.XtraPdfViewer.Commands

Namespace CustomPopupMenu
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            pdfViewer1.LoadDocument("..\..\Demo.pdf")
        End Sub

        Private Sub pdfViewer1_PopupMenuShowing(ByVal sender As Object, ByVal e As PdfPopupMenuShowingEventArgs) Handles pdfViewer1.PopupMenuShowing
            ' Hide the popup menu for the bookmark tree.
            If e.PopupMenuKind = PdfPopupMenuKind.BookmarkTree Then
                e.ItemLinks.Clear()
            End If

            ' Remove Rotate Clockwise and Rotate Counterclockwise items from the Page Content popup menu.
            If e.PopupMenuKind = PdfPopupMenuKind.PageContent Then
                e.ItemLinks.Remove(e.ItemLinks.GetPdfViewerBarItemLink(PdfViewerCommandId.RotatePageClockwise))
                e.ItemLinks.Remove(e.ItemLinks.GetPdfViewerBarItemLink(PdfViewerCommandId.RotatePageCounterclockwise))
            End If
        End Sub
    End Class
End Namespace
