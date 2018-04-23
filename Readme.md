# How to customize a web request for a map web service


<p>This example shows how you can implement a custom proxy to make a request to the Bing Maps web service for obtaining map tiles from it.</p>


<h3>Description</h3>

<p>To customize a web request, handle the <strong>MapDataProviderBase.WebReques</strong><strong>t</strong> event.</p>
<p>Then, use the web request arguments to specify your custom map request settings (e.g., custom credentials, headers for a proxy, etc.) to the Bing Maps data provider.</p>

<br/>


