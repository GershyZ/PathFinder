using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathFinder.Models
{
    public class MultipleChoiceModel : ChallengeModel
    {
        protected string[] _choices;

        public MultipleChoiceModel(string title) : base(title)
        {

        }
        public override View GetStructure(string lbl)
        {
            return new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label{
                        Text =lbl,
                        HorizontalOptions=LayoutOptions.Start
                    },
                    new Picker
                    {
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        ItemsSource = _choices
                    }
                }
            };
        }
    }
}