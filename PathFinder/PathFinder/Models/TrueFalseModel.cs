using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathFinder.Models
{
    public class TrueFalseModel : ChallengeModel
    {
        public TrueFalseModel(String title) : base(title)
        {

        }

        public override View GetStructure(string lbl)
        {
            return new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {
                new Label{Text = lbl,
                HorizontalOptions = LayoutOptions.Start
                },
                new Slider()
                }
            };
        }
    }
}
