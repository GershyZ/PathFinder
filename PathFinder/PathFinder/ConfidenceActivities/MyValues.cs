using System;
using System.Collections.Generic;
using System.Text;
using PathFinder.Models;
using Xamarin.Forms;

namespace PathFinder.ConfidenceActivities
{
    public class MyValues : ChallengeModel
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

        public override ChallengeView GetChallengeView(string prompt)
        {
            return new MyValuesView(prompt);
        }

        public class MyValuesView : ChallengeView
        {
            Entry e1, e2, e3;
            public MyValuesView(string prompt, string ans1 = "", string ans2 = "", string ans3 = "") : base(prompt)
            {
                e1 = new Entry { Text = ans1 };
                e2 = new Entry { Text = ans2 };
                e3 = new Entry { Text = ans3 };
                Structure = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    Children = {
                            new Label{Text = Prompt },
                            e1,e2,e3
                        }
                };
            }
        }
    }
}