<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595831/19.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T602115)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# PDF Viewer for WinForms - Customize the Pop-Up Menu

The [WinForms PDF Viewer](https://www.devexpress.com/products/net/controls/winforms/pdf-viewer/) has several types of popup menus the user can invoke for bookmark options, bookmark tree, page content, a thumbnail, and thumbnail options. 

This example shows how to add a new item, hide the popup menu for the bookmark tree, and remove specific items from the page content popup menu.

## Implementation Details

To customize items of the PDF Viewer's popup menu, handle the [PdfViewer.PopupMenuShowing](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfViewer.PopupMenuShowing) event. This event fires every time a user opens a popup menu in the PDF Viewer. 

Each popup menu type has a unique set of bar items that are located in the bar item link collection. To access a bar item link collection, check the [PdfPopupMenuShowingEventArgs.PopupMenuKind](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfPopupMenuShowingEventArgs.PopupMenuKind) property value to determine the menu type and use the [PdfPopupMenuShowingEventArgs.ItemLinks](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfPopupMenuShowingEventArgs.ItemLinks) property.

To hide a popup menu, clear all items from the bar item link collection. To remove an item from the popup menu, find the item by its command ID and then remove it.

## Files to Review

* [Form1.cs](./CS/RemoveItemsFromPopupMenu/Form1.cs) (VB: [Form1.vb](./VB/RemoveItemsFromPopupMenu/Form1.vb))

## Documentation

* [How to: Customize Popup Menus in the PDF Viewer](https://docs.devexpress.com/WindowsForms/115320/controls-and-libraries/pdf-viewer/examples/customization/how-to-customize-the-popup-menu)

