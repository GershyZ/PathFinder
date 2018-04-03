using Xamarin.Forms;
using PathFinder.Models;
using PathFinder.Views;

namespace PathFinder.Pages
{
    public class CustomContentPage : ContentPage
    {
        public CustomContentPage(ResourcePDF resource)
        {
            Padding = new Thickness(0, 20, 0, 0);
            Content = new StackLayout            {
                Children = {
                    new CustomWebView {
                        Uri = resource.Uri,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    }
                }
            };
        }
    }
}