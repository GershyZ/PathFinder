using PathFinder.Models;
using PathFinder.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PathFinder
{
    public class App : Application
    {
        Route ToC;
        public App() : base()
        {
            ToC = new Route
            {
                RouteName = "Table of Contents",
                PrimaryColor = Color.Beige,
                SecondaryColor = Color.OldLace
            };
            ToC.StartLevel.addSection(new CompetenceActivities.CompetenceActivitiesRoute().StartLevel.asLevelContent());
            ToC.StartLevel.addSection(new ConfidenceActivities.ConfidenceActivitiesRoute().StartLevel.asLevelContent());
            Current.MainPage = ToC.StartLevel.asLevelPage();
        }
    }
}