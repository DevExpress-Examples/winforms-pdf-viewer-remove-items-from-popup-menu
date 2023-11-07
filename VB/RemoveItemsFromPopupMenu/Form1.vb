Imports System.Windows.Forms
Imports DevExpress.XtraPdfViewer
Imports DevExpress.XtraBars
Imports DevExpress.XtraPdfViewer.Extensions
Imports DevExpress.XtraPdfViewer.Commands

Namespace CustomPopupMenu

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            pdfViewer1.LoadDocument("..\..\Demo.pdf")
        End Sub

        Private Sub pdfViewer1_PopupMenuShowing(ByVal sender As Object, ByVal e As PdfPopupMenuShowingEventArgs)
            ' Create a bar button item.
            Dim browseBarButton As BarButtonItem = New BarButtonItem()
            browseBarButton.Caption = "Custom Item"
            ' Insert the bar buttom item into the PDF Viewer popup menu and start a new group.
            e.ItemLinks.Add(browseBarButton, True)
            ' Handle the bar button click event.
            AddHandler browseBarButton.ItemClick, AddressOf browseBarButton_ItemClick
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

        Private Sub browseBarButton_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            MessageBox.Show("ItemClick event fires")
        End Sub
    End Class
End Namespace
