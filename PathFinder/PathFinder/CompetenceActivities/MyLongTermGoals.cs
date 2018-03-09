using PathFinder.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CompetenceActivities
{
    public class MyLongTermGoals : ChallengeFormPage
    {
        public MyLongTermGoals()
        {
            AddChallengeContent(new Entry { Placeholder = "By next month I'd like to" });
            AddChallengeContent(new Entry { Placeholder = "I'd like to finish" });
            AddChallengeContent(new Entry { Placeholder = "At the end of the school year, I would like to be" });
            AddChallengeContent(new Entry { Placeholder = "I'd like to have enough money to" });
            AddChallengeContent(new Entry { Placeholder = "Someday, I would like to go to" });
            AddChallengeContent(new Entry { Placeholder = "I hope that my mentor and I" });
            AddChallengeContent(new Entry { Placeholder = "Next summer, I want to" });
            AddChallengeContent(new Entry { Placeholder = "I would like to get a job as" });
            AddChallengeContent(new Entry { Placeholder = "I hope to graduate from" });
            AddChallengeContent(new Entry { Placeholder = "After I graduate, I plan to" });
        }
    }
}
