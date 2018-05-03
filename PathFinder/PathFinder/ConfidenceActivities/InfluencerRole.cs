using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathFinder.ConfidenceActivities
{
    class InfluencerRole : TrueFalseModel
    {
        public InfluencerRole(string title) : base(title)
        {
            ChallengeContent = new List<string>{
            "Do you like to discuss your reasons for things with others?",
            "Have you ever been elected to be an officer in a club?",
            "Do you like to sell things?",
            "Do you take charge in a group?",
            "Do you do well in Social Studies or English?",
            "Do you enjoy working with people?",
            "If you have a choice, do you usually sit in the front of the class?",
            "Do you like to do crossword puzzles?",
            "Do you get good grades on your creative writing?",
            "Do groups of other people ask you to speak for them?",
            "Do you like to read?",
            "Do you want to make a lot of money and be respected by others?",
            "Would you like to have your own business or be president of a company?"
            };
        }
    }
}
