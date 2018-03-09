using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PathFinder.Models;
using PathFinder.ViewModels;

namespace PathFinder.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChallengeFormPage : ContentPage
	{
        ChallengeFormVM _formVM;
        ChallengeModel _parent;
		public ChallengeFormPage ()
		{
            _formVM = new ChallengeFormVM();
			InitializeComponent();
            BindingContext = _formVM;
		}

        public void SetParent(ChallengeModel p)
        {
            _parent = p;
        }

        public void SubmitForm(object s, EventArgs e)
        {
            _parent.Completed = true;
            Route.Current.MainPage.Navigation.PopAsync();
        }

        public void CancelForm(object o, EventArgs e)
        {
            Route.Current.MainPage.Navigation.PopAsync();
        }

        public void AddChallengeContent(View v)
        {
            _formVM.ChallengeContent.Add(v);            
        }

        protected override void OnAppearing()
        {
            sl_challenge_content.Children.Clear();
            foreach(View v in _formVM.ChallengeContent)
            {
                sl_challenge_content.Children.Add(v);
            }
        }
    }
}