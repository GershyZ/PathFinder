using PathFinder.Models;
using PathFinder.Pages;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ResourcePDF), typeof(CustomContentPage))]
namespace PathFinder.iOS.CustomRenderers
{

    public class PdfWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (NativeView != null && e.NewElement != null)
            {
                var pdfControl = NativeView as UIWebView;

                if (pdfControl == null)
                    return;

                pdfControl.ScalesPageToFit = true;
            }
        }
    }
}