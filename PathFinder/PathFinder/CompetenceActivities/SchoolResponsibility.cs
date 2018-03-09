using PathFinder.Pages;

using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace CompetenceActivities
{
    public class SchoolResponsibility : ChallengeFormPage
    {
        public SchoolResponsibility()
        {
            AddChallengeContent(getStructure("Get to school on time?"));
            AddChallengeContent(getStructure("Have paper, pencil and books?"));
            AddChallengeContent(getStructure("Do your class work neatly?"));
            AddChallengeContent(getStructure("Do your school work willingly?"));
            AddChallengeContent(getStructure("Study for tests?"));
            AddChallengeContent(getStructure("Complete all assignments?"));
            AddChallengeContent(getStructure("Do extra credit assignments when you have the chance?"));
            AddChallengeContent(getStructure("Pay attention in class?"));
            AddChallengeContent(getStructure("Turn in your homework?"));
            AddChallengeContent(getStructure("Get good grades?"));
            AddChallengeContent(getStructure("Do your best?"));
            AddChallengeContent(getStructure("Realize the importance of school?"));            
        }

        private StackLayout getStructure(String label)
        {
            var structure = new StackLayout {
                Orientation = StackOrientation.Horizontal,                
                Children =
                {
                    new Label{ Text = label},
                    new Switch{}//TODO: add functionallity to  add  value to a dropdown when toggledoff

                }
                
            };
            return structure;
        }
    }
}
