using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathFinder.ConfidenceActivities
{
    public class CreatorRole : TrueFalseModel
    {
        public CreatorRole(string title) : base(title)
        {
            ChallengeContent = new List<string> {
                "Do you like to use your imagination?",
                "Do you like to make up new ideas?",
                "Are you good in art, music, or writing stories, poetry, etc.?",
                "Are you a self-starter?",
                "Do you like to try new things?",
                "Can you communicate with people by doing something in music or art?",
                "Do you like to see different people in different places?",
                "Do you like to take ideas and make up songs, artwork or stories about them?",
                "Do you often decide things without looking at the facts?",
                "Do you make pictures or words in your mind when others talk?",
                "Do you enjoy working with others to brainstorm ideas?",
                "Do you enjoy music and plays?"
            };
        }
    }
}
