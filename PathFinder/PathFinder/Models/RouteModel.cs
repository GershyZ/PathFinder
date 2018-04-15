using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PathFinder.Models
{
    public class Route : Application
    {
        public static Color PrimaryColor { get; protected set; }
        public static Color SecondaryColor { get; protected set; }
        public static String PDFNAME;

        public Route() : base()
        {
            Current.MainPage = new NavigationPage(new Pages.TableOfContentsPage());
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
            Route.Current.MainPage.Navigation.PushAsync(new NavigationPage(level.asLevelPage()));
        }

        public static void showLevelContent(ContentPage lc)
        {
            Route.Current.MainPage.Navigation.PushAsync(lc);
        }

    }
}   