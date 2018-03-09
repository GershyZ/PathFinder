using PathFinder.Models;
using PathFinder.ViewModels;
using PathFinder.Views;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PathFinder.Pages
{
    public partial class LevelPage : ContentPage
	{
        
		public LevelPage(LevelModel lm) : base()
		{
            BindingContext = new LevelPageVM(lm);
            InitializeComponent();
		}

        protected override void OnAppearing()
        {            
            base.OnAppearing();            
            //_populateBeartracks();
        }

        internal void _populateBeartracks()
        {
            //  sl_tracks.Children.Clear();

            Stack<LevelModel> history = new Stack<LevelModel>();

            for (int i = 0; i < history.Count && i < 4; i++)
            {
                //       sl_tracks.Children.Add(new BearTrack(history.Pop()));
            }
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            LevelContentModel lcm = (LevelContentModel)e.SelectedItem;
            lcm.onTap();
        }
    }
}
