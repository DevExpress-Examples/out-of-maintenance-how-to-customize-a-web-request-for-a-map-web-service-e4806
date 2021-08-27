<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571355/13.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4806)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/WebRequest/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WebRequest/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/WebRequest/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WebRequest/MainWindow.xaml.vb))
<!-- default file list end -->
# How to customize a web request for a map web service


<p>This example shows how you can implement a custom proxy to make a request to the Bing Maps web service for obtaining map tiles from it.</p>


<h3>Description</h3>

<p>To customize a web request, handle the <strong>MapDataProviderBase.WebReques</strong><strong>t</strong> event.</p>
<p>Then, use the web request arguments to specify your custom map request settings (e.g., custom credentials, headers for a proxy, etc.) to the Bing Maps data provider.</p>

<br/>


