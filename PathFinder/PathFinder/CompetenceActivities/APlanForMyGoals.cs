using PathFinder.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CompetenceActivities
{
    public class APlanForMyGoals : ChallengeFormPage
    {
        
        public APlanForMyGoals()
        {
            _addSection("Work Habits");
            _addSection("Academic");
            _addSection("Personal");
            _addSection("Behavior");
            _addSection("Attendance");  
        }

        private void _addSection(string lbl)
        {
            var section = new StackLayout
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
            AddChallengeContent(section);
            
        }
    }
}
