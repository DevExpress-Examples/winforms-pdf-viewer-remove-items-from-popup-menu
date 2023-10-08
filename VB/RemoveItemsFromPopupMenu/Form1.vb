Imports System.Windows.Forms
Imports DevExpress.XtraPdfViewer
Imports DevExpress.XtraBars

Namespace CustomPopupMenu

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            pdfViewer1.LoadDocument("..\..\Demo.pdf")
        End Sub

        Private Sub pdfViewer1_PopupMenuShowing(ByVal sender As Object, ByVal e As PdfPopupMenuShowingEventArgs)
            ' Hide the popup menu for the bookmark tree.
            If e.PopupMenuKind = PdfPopupMenuKind.BookmarkTree Then
                e.ItemLinks.Clear()
            End If

            ' Remove Rotate Clockwise and Rotate Counterclockwise items from the Page Content popup menu.
            If e.PopupMenuKind = PdfPopupMenuKind.PageContent Then
                For i As Integer = e.ItemLinks.Count - 1 To 0 Step -1
                    Dim link As BarItemLink = e.ItemLinks(i)
                    If link.Caption.Contains("Rotate") Then e.ItemLinks.Remove(link)
                Next
            End If
        End Sub
    End Class
End Namespace
