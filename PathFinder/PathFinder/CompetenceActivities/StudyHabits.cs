using System;
using System.Collections.Generic;
using System.Text;

using PathFinder.Models;
using Xamarin.Forms;

namespace CompetenceActivities
{
    public class StudyHabits : MultipleChoiceModel
    {
        public StudyHabits(string title) : base(title)
        {
            _choices = new string[] { "", "Almost Always", "Sometimes", "Very Seldom" };
            ChallengeContent = new List<String> {
                "Do you make a budget or schedule of your study time?",
                "Do you follow it?",
                "Do you write down each day's assignment?",
                "Do you review the last lesson before you start the next?",
                "Do you begin your work at once, without wasting time?",
                "Do you do your homework before watching TV or participating in social activities?",
                "Do you stick to each lesson until it is finished?",
                "Do you keep your mind constantly on your work without daydreaming or distractions?",
                "Do you read difficult parts of your lessons a second time?",
                "Do you make written outlines or take written notes when you read your lessons?",
                "Do you finish ALL of each assignment?",
                "Do you look up all new words?",
                "Do you study in a quiet place at home?"
            };
        }
    }
}