<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595831/17.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T602115)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RemoveItemsFromPopupMenu/Form1.cs) (VB: [Form1.vb](./VB/RemoveItemsFromPopupMenu/Form1.vb))
<!-- default file list end -->
# How to remove items from the popup menu


The PDF Viewer has several types of popup menus that can be invoked by an end-user for bookmark options, bookmark tree, page content, a thumbnail, and thumbnail options. <br><br>This example shows how to hide the popup menu for the bookmark tree and remove specific items from the page content popup menu.<br><br>To customize items of the PDF Viewer's popup menu, handle the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfViewer.PopupMenuShowing.event">PdfViewer.PopupMenuShowing</a> event. This event fires every time an end-user opens a popup menu in the PDF Viewer. <br><br>Each popup menu type has a unique set of bar items that are located in the bar item link collection. To access a bar item link collection, check the popup menu type using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfPopupMenuShowingEventArgs.PopupMenuKind.property">PdfPopupMenuShowingEventArgs.PopupMenuKind</a> property and use the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfPopupMenuShowingEventArgs.ItemLinks.property">PdfPopupMenuShowingEventArgs.ItemLinks</a> property.<br><br>To hide a popup menu, clear all items from the bar item link collection. <br><br>To remove an item from the popup menu, find the item by the caption in the bar item link collection and then remove it.<br><br>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pdf-viewer-manage-popup-menu-items&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pdf-viewer-manage-popup-menu-items&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
