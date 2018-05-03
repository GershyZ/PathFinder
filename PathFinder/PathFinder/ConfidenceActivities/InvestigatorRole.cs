using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathFinder.ConfidenceActivities
{
    class InvestigatorRole : TrueFalseModel
    {
        public InvestigatorRole(string title) : base(title)
        {
            ChallengeContent = new List<string> {
            "Do you enjoy working on puzzles?",
            "Do you like to read books and magazines about science?",
            "Are you usually curious about how things work?",
            "Do you do better in math and science?",
            "Can you work on a problem a long time until you find the answer?",
            "Do you enjoy helping other people with their problems?",
            "Do you like to work alone?",
            "Do you try to find better ways to do things?",
            "When someone tells you that something is impossible to do, do you want to try to find a way to do it?",
            "When you are putting something together and a part is missing, do you find something to take its place?",
            "Do you enjoy mystery stories?",
            "Do you like finding out about new things?",
            "Do you like working with numbers and charts?"
            };
        }
    }
}
