using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathFinder.ConfidenceActivities
{
    public class HelperRole : TrueFalseModel
    {
        public HelperRole(string title) : base(title)
        {
            ChallengeContent = new List<string>
            {
                "Do you like to work with people?",
                "Do you like doing volunteer work?",
                "Do you like to make new friends?",
                "Do your friends come to you with their problems?", 
                "Do you like to teach others how to do things?",
                "Do you like to go to parties or have parties?",
                "Do you like English and Social Studies?",",
                "Can you tell what people are really like?",",
                "Are you good at dealing with people older than you?",",
                "Do you enjoy being a member of clubs and working in club activities?",
                "Would you rather \"do good\" than make a lot of money?",
                "Are you good at explaining things to people?",
                "Do you like to work at jobs just for the fun of it when no one knows you‟ve done them?"

            };
        }
    }
}
