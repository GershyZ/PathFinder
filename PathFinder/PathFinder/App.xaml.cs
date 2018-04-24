using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PathFinder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class App : Application
	{
		public App () : base()
		{
			InitializeComponent ();
     
            Route ToC = new Route
            {
                RouteName = "Table of Contents",
                PrimaryColor = Color.Beige,
                SecondaryColor = Color.OldLace
            };
                        
            
            ToC.StartLevel.addSection(new CompetenceActivities.CompetenceActivitiesRoute().StartLevel.asLevelContent());            
            ToC.StartLevel.addSection(new ConfidenceActivities.ConfidenceActivitiesRoute().StartLevel.asLevelContent());
            MainPage = new NavigationPage(ToC.StartLevel.asLevelPage());
        }
	}
}