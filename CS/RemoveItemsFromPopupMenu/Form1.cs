using System.Windows.Forms;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraBars;

namespace CustomPopupMenu {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            pdfViewer1.LoadDocument("..\\..\\Demo.pdf");
        }

        void pdfViewer1_PopupMenuShowing(object sender, PdfPopupMenuShowingEventArgs e) {
            // Hide the popup menu for the bookmark tree.
            if (e.PopupMenuKind == PdfPopupMenuKind.BookmarkTree) {
                e.ItemLinks.Clear();
            }

            // Remove Rotate Clockwise and Rotate Counterclockwise items from the Page Content popup menu.
            if (e.PopupMenuKind == PdfPopupMenuKind.PageContent) {
                for (int i = e.ItemLinks.Count - 1; i >= 0; i--) {
                    BarItemLink link = e.ItemLinks[i];
                    if (link.Caption.Contains("Rotate"))
                        e.ItemLinks.Remove(link);
                }
            }
        }
    }
}
