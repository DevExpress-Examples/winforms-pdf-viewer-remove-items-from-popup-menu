using System.Windows.Forms;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraBars;
using DevExpress.XtraPdfViewer.Extensions;
using DevExpress.XtraPdfViewer.Commands;

namespace CustomPopupMenu
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            pdfViewer1.LoadDocument("..\\..\\Demo.pdf");
        }

        void pdfViewer1_PopupMenuShowing(object sender, PdfPopupMenuShowingEventArgs e)
        {

            // Create a bar button item.
            BarButtonItem browseBarButton = new BarButtonItem();
            browseBarButton.Caption = "Custom Item";

            // Insert the bar buttom item into the PDF Viewer popup menu and start a new group.
            e.ItemLinks.Add(browseBarButton, true);

            // Handle the bar button click event.
            browseBarButton.ItemClick += browseBarButton_ItemClick;

            // Hide the popup menu for the bookmark tree.
            if (e.PopupMenuKind == PdfPopupMenuKind.BookmarkTree)
            {
                e.ItemLinks.Clear();
            }

            // Remove Rotate Clockwise and Rotate Counterclockwise items from the Page Content popup menu.
            if (e.PopupMenuKind == PdfPopupMenuKind.PageContent)
            {
                e.ItemLinks.Remove(e.ItemLinks.GetPdfViewerBarItemLink(PdfViewerCommandId.RotatePageClockwise));
                e.ItemLinks.Remove(e.ItemLinks.GetPdfViewerBarItemLink(PdfViewerCommandId.RotatePageCounterclockwise));
            }
        }

        void browseBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("ItemClick event fires");
        }
    }
}
