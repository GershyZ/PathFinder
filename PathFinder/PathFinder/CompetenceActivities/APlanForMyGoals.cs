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

        public override View GetStructure(string lbl)
        {
            return new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    new Label{Text = lbl },
                    new Entry{Placeholder = "My goal is to" },
                    new Entry{Placeholder = "I will do these activities to reach my goal"},
                    new Entry{Placeholder = "I will know I made my goal when"}
                },
                Margin = 15
            };
        }
    }
}