using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathFinder.ConfidenceActivities
{
    public class WhoDecides : MultipleChoiceModel
    {
        public WhoDecides(string title) : base(title)
        {
            _choices = new string[]{ "Me","Teacher","Parent"};
            ChallengeContent = new List<string>
            {
                "My favorite book?",
                "What time I go to bed?",
                "If I study reading in school?",
                "What I eat for dinner?",
                "What I get for a spelling grade?",
                "Where I sit on the bus?",
                "Which friends I have?",
                "What my favorite game is?",
                "If I should help a friend?",
                "When I go to school?",
                "When I take medicines?",
                "If I'm nice to a new classmate?",
                "Where I sit in the classroom?"
            };

        }
    }
}
