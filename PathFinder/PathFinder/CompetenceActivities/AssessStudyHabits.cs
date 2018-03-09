using PathFinder.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CompetenceActivities
{
    public class AssessStudyHabits : ChallengeFormPage
    {
        public AssessStudyHabits()
        {
            AddChallengeContent(getStructure("I never study more than an hour for tests"));
            AddChallengeContent(getStructure("I only study the night before tests."));
            AddChallengeContent(getStructure("If I study too much, I can't have any fun."));
            AddChallengeContent(getStructure("I study with music or the television on."));
            AddChallengeContent(getStructure("I don't have a quiet place to study."));
            AddChallengeContent(getStructure("I can't sit and study for long periods of time."));
            AddChallengeContent(getStructure("I often doodle or get distracted in class."));
            AddChallengeContent(getStructure("I have trouble taking notes."));
            AddChallengeContent(getStructure("I don't use class notes to study for tests."));
            AddChallengeContent(getStructure("I have trouble keeping up with my reading"));
            AddChallengeContent(getStructure("I don't always get my homework done."));
            AddChallengeContent(getStructure("I can't recognize the main ideas in a chapter"));
            AddChallengeContent(getStructure("I would like to read faster."));
            AddChallengeContent(getStructure("I have trouble writing papers."));
            AddChallengeContent(getStructure("I don't know how to create an outline."));
            AddChallengeContent(getStructure("I will put off difficult assignments."));
        }

        private StackLayout getStructure(String label)
        {
            var structure = new StackLayout
            {
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
