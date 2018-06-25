using PathFinder.Models;
using PathFinder.ConfidenceActivities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ConfidenceActivities;
using CompetenceActivities;

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
                RouteName = "Table of Contents"
            };


            ToC.StartLevel.addSection(new CompetenceActivitiesRoute().StartLevel.asLevelContent());           
            ToC.StartLevel.addSection(new ConfidenceActivitiesRoute().StartLevel.asLevelContent());
            MainPage = new NavigationPage(ToC.StartLevel.asLevelPage());
        }
	}
}