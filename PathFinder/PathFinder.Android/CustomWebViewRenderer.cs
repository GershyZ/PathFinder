using Xamarin.Forms;

using PathFinder.Droid;
using PathFinder.Views;
using Xamarin.Forms.Platform.Android;
using System.Net;
using Android.Content;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace PathFinder.Droid
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        public CustomWebViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as CustomWebView;
                Control.Settings.AllowUniversalAccessFromFileURLs = true;
                var fileloc = string.Format("file:///android_asset/web/viewer.html?file={0}", string.Format("file:///android_asset/Content/{0}", WebUtility.UrlEncode(customWebView.Uri)));
                Control.LoadUrl(fileloc);
            }
        }
    }
}