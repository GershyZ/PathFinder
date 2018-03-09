using PathFinder.Models;
using PathFinder.Pages;
using Xamarin.Forms;

namespace PathFinder.Views
{
    public class BearTrack : Button
    {
        LevelModel _prev_level;
        public BearTrack(LevelModel prev) : base()
        {
            _prev_level = prev;
            Text = "UKN";
            BackgroundColor = (Color)Route.Current.Resources["primaryColor"];
            TextColor = (Color)Route.Current.Resources["secondaryColor"];
            if (prev.LevelName != null)
            {
                Text = _prev_level.LevelName.Substring(0, (_prev_level.LevelName.Length > 3 ? 4 : _prev_level.LevelName.Length));
            }
            Clicked += delegate
            {
                Route.switchPage(_prev_level);
            };
        }
    }
}