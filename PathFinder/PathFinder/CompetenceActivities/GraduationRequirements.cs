using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using PathFinder.Pages;
namespace CompetenceActivities
{
    public class GraduationRequirements : ChallengeFormPage
    {
        public GraduationRequirements()
        {
            AddChallengeContent(GetStructure("Language Arts: %d Credits. English courses must include major concentrations in compositions and literature.",4));
            AddChallengeContent(GetStructure("Mathematics: %d Credits. Algebra I or equivalent must be included.",3));
            AddChallengeContent(GetStructure("Science: %d Credits. Two of the science  credits must include a laboratory component.",3));
            AddChallengeContent(GetStructure("Social Studies: %d Credits.",3));
            AddChallengeContent(GetStructure("Practical/Vocational/Performing Art: %d Credit.",1));
            AddChallengeContent(GetStructure("Life Managemnt Skills: %d Credit.",0.5));
            AddChallengeContent(GetStructure("Physical Education: %d Credit.",1));
            AddChallengeContent(GetStructure("Electives: %d Credits",8.5));
        }

        public StackLayout GetStructure(string lbl, double numcredits)
        {
            //TODO: Dynamically update credit count
            return new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {
                    new Entry{WidthRequest = 3},
                    new Label{Text = string.Format(lbl,numcredits)}
                }
            };
        }
    }
}
