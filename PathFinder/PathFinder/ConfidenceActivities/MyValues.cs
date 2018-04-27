using System;
using System.Collections.Generic;
using System.Text;
using PathFinder.Models;
using Xamarin.Forms;

namespace PathFinder.ConfidenceActivities
{
    public class MyValues :ChallengeModel
    {
        public MyValues(string title) : base(title)
        {
            ChallengeContent = new List<string>
            {
                "What three things do I like about myself?",
                "What are my strengths?",
                "What activities can make me a better and stronger person?",
            };
        }

        public override View GetStructure(string lbl)
        {
            return new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    new Label{Text = lbl },
                    new Entry(),
                    new Entry(),
                    new Entry(),
                    }
            };
        }
    }
}
