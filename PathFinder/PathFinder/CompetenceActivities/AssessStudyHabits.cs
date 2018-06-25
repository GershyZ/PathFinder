using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CompetenceActivities
{
    public class AssessStudyHabits : TrueFalseModel
    {
        public AssessStudyHabits(string title) : base(title)
        {
            ChallengeContent = new List<string>{
                "I never study more than an hour for tests",
                "I only study the night before tests.",
                "If I study too much, I can't have any fun.",
                "I study with music or the television on.",
                "I don't have a quiet place to study.",
                "I can't sit and study for long periods of time.",
                "I often doodle or get distracted in class.",
                "I have trouble taking notes.",
                "I don't use class notes to study for tests.",
                "I have trouble keeping up with my reading",
                "I don't always get my homework done.",
                "I can't recognize the main ideas in a chapter",
                "I would like to read faster.",
                "I have trouble writing papers.",
                "I don't know how to create an outline.",
                "I will put off difficult assignments."
            };
        }
    }
}