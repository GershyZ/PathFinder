using PathFinder.Models;

using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace CompetenceActivities
{
    public class SchoolResponsibility : ChallengeModel
    {
        public SchoolResponsibility(string title): base(title)
        {
            ChallengeContent = new List<string>{
            "Get to school on time?",
            "Have paper, pencil and books?",
            "Do your class work neatly?",
            "Do your school work willingly?",
            "Study for tests?",
            "Complete all assignments?",
            "Do extra credit assignments when you have the chance?",
            "Pay attention in class?",
            "Turn in your homework?",
            "Get good grades?",
            "Do your best?",
            "Realize the importance of school?"
            };
        }

        public override View GetStructure(string lbl)
        {
            var structure = new StackLayout {
                Orientation = StackOrientation.Horizontal,                
                Children =
                {
                    new Label{ Text = lbl},
                    new Switch{}//TODO: add functionallity to  add  value to a dropdown when toggledoff

                }
                
            };
            return structure;
        }
    }
}
