using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CompetenceActivities
{
    public class MyLongTermGoals : FillinModel
    {
        public MyLongTermGoals(string title) : base(title)
        {
            ChallengeContent = new List<string>{
                "By next month I'd like to",
             "I'd like to finish",
             "At the end of the school year, I would like to be",
             "I'd like to have enough money to",
             "Someday, I would like to go to",
             "I hope that my mentor and I",
             "Next summer, I want to",
             "I would like to get a job as",
             "I hope to graduate from",
             "After I graduate, I plan to"
            };
        }
    }
}
