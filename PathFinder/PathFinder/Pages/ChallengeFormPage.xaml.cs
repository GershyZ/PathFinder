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
		public ChallengeFormPage (ChallengeModel challenge)
		{            
			InitializeComponent();
            _formVM = new ChallengeFormVM(challenge);
            BindingContext = _formVM;
            foreach(View v in _formVM.ContentViews)
            {
                sl_content.Children.Add(v);
            }
		}

        
        public void SubmitForm(object s, EventArgs e)
        {
            _formVM.Completed = true;
            Route.GoBack();               
        }

        public void CancelForm(object o, EventArgs e)
        {
            Route.GoBack();
        }

        protected override void OnAppearing()
        {
            
        }
    }
}