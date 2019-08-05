using System.Windows.Forms;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraBars;
using DevExpress.XtraPdfViewer.Extensions;
using DevExpress.XtraPdfViewer.Commands;

namespace CustomPopupMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pdfViewer1.LoadDocument("..\\..\\Demo.pdf");
        }

        void pdfViewer1_PopupMenuShowing(object sender, PdfPopupMenuShowingEventArgs e)
        {
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
    }
}
