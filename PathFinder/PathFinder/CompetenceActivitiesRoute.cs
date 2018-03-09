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

            RouteName = "Competence Activities";
            Route.PrimaryColor = Color.Green;
            Route.SecondaryColor = Color.Yellow;            
            StartLevel.addSection(Goals.asLevelContent());
            StartLevel.addSection(Needs.asLevelContent());
            StartLevel.addSection(Homework.asLevelContent());
            StartLevel.addSection(Studying.asLevelContent());
            StartLevel.addSection(Career.asLevelContent());
            StartLevel.addSection(Graduation.asLevelContent());
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
                curr.addSection(new ChallengeModel("A Plan For My Goals", new APlanForMyGoals()));
                curr.addSection(new ChallengeModel("My Long Term Goals Worksheet", new MyLongTermGoals()));
                //curr.addSection(new ResourceJPG("Writing Goals",23));     
                //curr.addSection(new BonusLevel("Your important goals", "Goal", new BonusFormBuilder()).asLevelContent());
                return curr;
            }
        }

        private LevelModel Needs
        {
            get
            {
                var curr = new LevelModel("Needs");
                //curr.addSection(new ResourceJPG("Identifying Your Mentee's Needs",05));
                curr.addSection(new ChallengeModel("School:My Responsibility", new SchoolResponsibility()));
                //curr.addSection(new ResourceJPG("Time Management Tips",07));
                //curr.addSection(new BonusLevel("Identify Your Time Wasters", "Time Waster", new BonusFormBuilder()).asLevelContent());
                //curr.addSection(new ResourceJPG("Using a Daily Planner",09));

                return curr;
            }
        }
        private LevelModel Homework
        {
            get
            {
                var curr = new LevelModel("Homework");
                //curr.addSection(new ResourceJPG("Homework Time Table",10));
                //curr.addSection(new ResourceJPG("Helping With Homework",11));
                LevelModel skills = new LevelModel("Developing Your Skills");
                //curr.addSection(new ResourceJPG("7 Basic Homework Tips",14));
                curr.addSection(skills.asLevelContent());
                curr = new LevelModel("Reading");
                //curr.addSection(new ResourceJPG("5 Step Reading Process"));
                //curr.addSection(new ResourceJPG("Foster Reading Enjoyment"));
                skills.addSection(curr.asLevelContent());
                curr = new LevelModel("Notetaking");
                //curr.addSection(new ResourceJPG("How to Take Good Notes in Class",15));
                //curr.addSection(new ResourceJPG("The Cornell Method of Note-Taking",16));
                curr.addSection(new ChallengeModel("Using the Cornell Method of Note-Taking", new CornellNoteTaking()));
                return curr;
            }
        }
        private LevelModel Studying
        {
            get
            {
                var curr = new LevelModel("Study Habits");
                curr.addSection(new ChallengeModel("Assess Your Study Habits", new AssessStudyHabits()));
                curr.addSection(new ChallengeModel("Study Habits",new StudyHabits()));
                //curr.addSection(new ResourceJPG("How to Prepare for Essay Tests",20));
                //curr.addSection(new ResourceJPG("How to Take True-False Tests",21));
                //curr.addSection(new ResourceJPG("How to Take Multiple Choice Tests",22));
                return curr;
            }
        }

        private LevelModel Career
        {
            get
            {
                var curr = new LevelModel("Career Exploration");
                //curr.addSection(new ResourceJPG("Career Exploration"));
                //curr.addSection(new ResourceJPG("Learning About Work Skills"));
                curr.addSection(new ChallengeModel("Developing a Career Plan"));
                //curr.addSection(new ResourceJPG("How to Find Jobs"));
                //curr.addSection(new ResourceJPG("How to Apply for aa Job"));
                return curr;
            }
        }

        private LevelModel Graduation
        {
            get
            {
                var curr = new LevelModel("Graduation Requirements");
                curr.addSection(new ChallengeModel("Graduation Checklist"));
                curr.addSection(new ChallengeModel("Are you Eligible to Graduate"));
                //curr.addSection(new BonusLevel("Yearly Course Planner", "Course Planner", new BonusFormBuilder()).asLevelContent());
                return curr;
            }
        }

        private LevelModel College
        {
            get
            {
                var curr = new LevelModel("College Preparation");
                //curr.addSection(new ResourceJPG("Preparing for a Campus Visit"));
                //curr.addSection(new ResourceJPG("Applying to College"));
                //curr.addSection(new ResourceJPG("Learning about Financial Aid"));
                return curr;
            }
        }
    }
}