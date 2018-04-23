# How to remove items from the popup menu


The PDF Viewer has several types of popup menus that can be invoked by an end-user for bookmark options, bookmark tree, page content, a thumbnail, and thumbnail options. <br><br>This example shows how to hide the popup menu for the bookmark tree and remove specific items from the page content popup menu.<br><br>To customize items of the PDF Viewer's popup menu, handle the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfViewer.PopupMenuShowing.event">PdfViewer.PopupMenuShowing</a> event. This event fires every time an end-user opens a popup menu in the PDF Viewer. <br><br>Each popup menu type has a unique set of bar items that are located in the bar item link collection. To access a bar item link collection, check the popup menu type using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfPopupMenuShowingEventArgs.PopupMenuKind.property">PdfPopupMenuShowingEventArgs.PopupMenuKind</a> property and use the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfPopupMenuShowingEventArgs.ItemLinks.property">PdfPopupMenuShowingEventArgs.ItemLinks</a> property.<br><br>To hide a popup menu, clear all items from the bar item link collection. <br><br>To remove an item from the popup menu, find the item by the caption in the bar item link collection and then remove it.<br><br>

<br/>


