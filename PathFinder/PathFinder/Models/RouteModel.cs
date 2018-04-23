using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PathFinder.Models
{
    public class Route
    {
        public Color PrimaryColor { get;  set; }
        public Color SecondaryColor { get; set; }
        public static String PDFNAME;

        public Route()
        {
            
        }
        public LevelModel StartLevel { get; private set; }

        public String RouteName
        {
            get { return StartLevel.LevelName; }
            set
            {
                StartLevel = new LevelModel(value);
                Route.switchPage(StartLevel);
            }
        }

        public static void switchPage(LevelModel level)
        {
            App.Current.MainPage.Navigation.PushAsync(new NavigationPage(level.asLevelPage()));
        }

        public static void showLevelContent(ContentPage lc)
        {
            App.Current.MainPage.Navigation.PushAsync(lc);
        }

        public static void GoBack()
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}   