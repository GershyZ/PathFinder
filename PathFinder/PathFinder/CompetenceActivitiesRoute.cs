using PathFinder.Pages;
using PathFinder.Models;
using PathFinder.Views;
using CompetenceActivities;
using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace CompetenceActivities
{
    public class CompetenceActivitiesRoute : Route
    {
        public CompetenceActivitiesRoute()
        {
            PDFNAME = "CompetenceActivities";
            RouteName = "Competence Activities";
            Route.PrimaryColor = Color.Green;
            Route.SecondaryColor = Color.Yellow;
            StartLevel.addSection(new ResourcePDF("Competence Activity Booklet", 0));
            StartLevel.addSection(Goals.asLevelContent());
            StartLevel.addSection(Needs.asLevelContent());
            StartLevel.addSection(Homework.asLevelContent());
            StartLevel.addSection(Studying.asLevelContent());
            StartLevel.addSection(Career.asLevelContent());            
            StartLevel.addSection(College.asLevelContent());
            
            Route.switchPage(StartLevel);
        }

        private LevelModel Goals
        {
            get
            {
                var curr = new LevelModel("Goals");
                curr.addSection(new ResourcePDF("Goal Setting Guidelines",1));
                //curr.addSection(new BonusLevel("The Ten Year Race", "Goal", new BonusFormBuilder()).asLevelContent());
                curr.addSection(new APlanForMyGoals("A Plan For My Goals"));
                curr.addSection(new MyLongTermGoals("My Long Term Goals Worksheet"));
                curr.addSection(new ResourcePDF("Writing Goals",23));     
                //curr.addSection(new BonusLevel("Your important goals", "Goal", new BonusFormBuilder()).asLevelContent());
                return curr;
            }
        }

        private LevelModel Needs
        {
            get
            {
                var curr = new LevelModel("Needs");
                curr.addSection(new ResourcePDF("Identifying Your Mentee's Needs",05));
                curr.addSection(new SchoolResponsibility("School:My Responsibility"));
                curr.addSection(new ResourcePDF("Time Management Tips",07));
                //curr.addSection(new BonusLevel("Identify Your Time Wasters", "Time Waster", new BonusFormBuilder()).asLevelContent());
                curr.addSection(new ResourcePDF("Using a Daily Planner",09));

                return curr;
            }
        }
        private LevelModel Homework
        {
            get
            {
                var curr = new LevelModel("Homework");
                curr.addSection(new ResourcePDF("Homework Time Table",10));
                curr.addSection(new ResourcePDF("Helping With Homework",11));
                LevelModel skills = new LevelModel("Developing Your Skills");
                curr.addSection(new ResourcePDF("7 Basic Homework Tips",14));
                curr.addSection(skills.asLevelContent());
                curr = new LevelModel("Reading");
                curr.addSection(new ResourcePDF("5 Step Reading Process",12));
                curr.addSection(new ResourcePDF("Foster Reading Enjoyment",13));
                skills.addSection(curr.asLevelContent());
                curr = new LevelModel("Notetaking");
                curr.addSection(new ResourcePDF("How to Take Good Notes in Class",15));
                curr.addSection(new ResourcePDF("The Cornell Method of Note-Taking",16));
                curr.addSection(new CornellNoteTaking("Using the Cornell Method of Note-Taking"));
                return curr;
            }
        }
        private LevelModel Studying
        {
            get
            {
                var curr = new LevelModel("Study Habits");
                curr.addSection(new AssessStudyHabits("Assess Your Study Habits"));
                curr.addSection(new StudyHabits("Study Habits"));
                curr.addSection(new ResourcePDF("How to Prepare for Essay Tests",20));
                curr.addSection(new ResourcePDF("How to Take True-False Tests",21));
                curr.addSection(new ResourcePDF("How to Take Multiple Choice Tests",22));
                return curr;
            }
        }

        private LevelModel Career
        {
            get
            {
                var curr = new LevelModel("Career Exploration");
                curr.addSection(new ResourcePDF("Career Exploration",26));
                curr.addSection(new ResourcePDF("Learning About Work Skills",27));
                //curr.addSection(new("Developing a Career Plan"));
                curr.addSection(new ResourcePDF("How to Find Jobs",29));
                curr.addSection(new ResourcePDF("How to Apply for a Job",30));
                return curr;
            }
        }

        private LevelModel Graduation
        {
            get
            {
                var curr = new LevelModel("Graduation Requirements");
                //curr.addSection(new ChallengeModel("Graduation Checklist"));
                //curr.addSection(new ChallengeModel("Are you Eligible to Graduate"));
                //curr.addSection(new BonusLevel("Yearly Course Planner", "Course Planner", new BonusFormBuilder()).asLevelContent());
                return curr;
            }
        }

        private LevelModel College
        {
            get
            {
                var curr = new LevelModel("College Preparation");
                curr.addSection(new ResourcePDF("Preparing for a Campus Visit",34));
                curr.addSection(new ResourcePDF("Applying to College",35));
                curr.addSection(new ResourcePDF("Learning about Financial Aid",36));
                return curr;
            }
        }
    }
}