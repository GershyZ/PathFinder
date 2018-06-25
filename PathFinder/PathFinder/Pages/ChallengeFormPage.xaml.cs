using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using PathFinder.Models;
using PathFinder.ViewModels;
using PathFinder.Helpers;

namespace PathFinder.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChallengeFormPage : ContentPage
    {
        ChallengeFormVM _formVM;
        public ChallengeFormPage(ChallengeModel challenge)
        {
            InitializeComponent();
            _formVM = new ChallengeFormVM(challenge);
            BindingContext = _formVM;
        }


        public void SubmitForm(object s, EventArgs e)
        {
            Route.GoBack();
        }

        public void CancelForm(object o, EventArgs e)
        {
            Route.GoBack();
        }

        protected override void OnAppearing()
        {            
            sl_content.Children.Clear();
            var content = _formVM.getContentViews();
            for (int i = 0; i < content.Count; i++)
            {
                sl_content.Children.Add(content[i].Structure);
            }            
        }
    }
}