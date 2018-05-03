using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathFinder.ConfidenceActivities
{
    class OrganizerRole : TrueFalseModel
    {
        public OrganizerRole(string title) : base(title)
        {
            ChallengeContent = new List<string>
            {
            "Do you enjoy keeping your schoolwork organized and putting things away neatly?",
            "Do you prefer working with numbers and facts instead of people?",
            "Do you follow instructions well and with enthusiasm?",
            "Do you follow other people‟s plans and do a good job?",
            "Do you quickly see things that are different and things that are similar?",
            "Do you enjoy helping others get organized?",
            "Are math and English your best subjects?",
            "Do you complete paperwork and fill out forms quickly and accurately?",
            "Do you enjoy working with computers and calculators?",
            "Do you like following schedules and routines?",
            "Do you solve problems in an orderly way?",
            "When you listen, do you hear and remember all the details?"
            };
        }
    }
}
