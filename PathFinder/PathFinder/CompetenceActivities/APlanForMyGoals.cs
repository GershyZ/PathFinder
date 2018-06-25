using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CompetenceActivities
{
    public class APlanForMyGoals : ChallengeModel
    {

        public APlanForMyGoals(string title) : base(title)
        {
            ChallengeContent = new List<string> {
                "Work Habits",
                "Academic",
                "Personal",
                "Behavior",
                "Attendance"
            };
        }

        public override ChallengeView GetChallengeView(string prompt)
        {
            return new MyValuesView(prompt);
        }

        public class MyValuesView : ChallengeView
        {
            Entry e1, e2, e3;
            public MyValuesView(string prompt) : base(prompt)
            {
                e1 = new Entry { Placeholder = "My goal is to" };
                e2 = new Entry { Placeholder = "I will do these activities to reach my goal" };
                e3 = new Entry { Placeholder = "I will know I made my goal when" };
                Structure = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    Children =
                        {
                            new Label{Text = Prompt},
                            e1,e2,e3
                        },
                    Margin = 15
                };
            }
        }
    }
}