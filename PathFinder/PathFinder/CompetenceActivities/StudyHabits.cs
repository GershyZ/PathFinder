using System;
using System.Collections.Generic;
using System.Text;

using PathFinder.Pages;
using Xamarin.Forms;

namespace CompetenceActivities
{
    public class StudyHabits : ChallengeFormPage
    {
        public StudyHabits()
        {
            GetStructure("Do you make a budget or schedule of your study time?");
            GetStructure("Do you follow it?");
            GetStructure("Do you write down each day's assignment?");
            GetStructure("Do you review the last lesson before you start the next?");
            GetStructure("Do you begin your work at once, without wasting time?");
            GetStructure("Do you do your homework before watching TV or participating in social activities?");
            GetStructure("Do you stick to each lesson until it is finished?");
            GetStructure("Do you keep your mind constantly on your work without daydreaming or distractions?");
            GetStructure("Do you read difficult parts of your lessons a second time?");
            GetStructure("Do you make written outlines or take written notes when you read your lessons?");
            GetStructure("Do you finish ALL of each assignment?");
            GetStructure("Do you look up all new words?");
            GetStructure("Do you study in a quiet place at home?");            
        }
        public StackLayout GetStructure(String lbl)
        {
            var structure = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label{ Text = lbl},
                    Dropdown
                }
            };

            return structure;

        }

        private Picker Dropdown
        {
            get
            {
                Picker p = new Picker {
                    ItemsSource = new string[] { "", "Almost Always", "Sometimes", "Very Seldom" }
                };
                return p;
            }
        }
    }
}