namespace Microsoft.AspNetCore.Components.WebView
{
    internal class WebViewNavigationManager : NavigationManager
    {
        private readonly WebViewHost _host;

        public WebViewNavigationManager(WebViewHost host)
        {
            _host = host;
        }

        public void Init(string baseUrl, string initialUrl)
        {
            Initialize(baseUrl, initialUrl);
        }

        public void LocationUpdated(string newUrl, bool intercepted)
        {
            Uri = newUrl;
            NotifyLocationChanged(intercepted);
        }

        protected override void NavigateToCore(string uri, bool forceLoad)
        {
            _host.Navigate(uri, forceLoad);
        }
    }
}
