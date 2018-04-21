using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PathFinder
{
	public class App : Application
	{
        public App() : base()
        {
            LevelModel main = new LevelModel("Table Of Contents");
            main.addSection(new CompetenceActivities.CompetenceActivitiesRoute().StartLevel.asLevelContent());
            main.addSection(new ConfidenceActivities.ConfidenceActivitiesRoute().StartLevel.asLevelContent());
            Current.MainPage = main.asLevelPage();
        }
	}
}