using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathFinder.ConfidenceActivities
{
    public class ActivityList : ChallengeModel
    {
        public ActivityList(string title) : base(title)
        {
            ChallengeContent = new List<string> {
                "Tackle some homework",
                "Make dinner together",
                "Go to a movie together",
                "Just hang out",
                "Figure out how to program my VCR",
                "Talk about life",
                "Give a tour of my job",
                "Do a pretend job interview",
                "Talk about how to look for a job",
                "Talk about where to find a job",
                "Find a summer job",
                "Set up a work internship",
                "Talk about networking",
                "Talk about what it takes to get ahead",
                "Talk about health insurance",
                "Go to an art gallery or museum",
                "Talk about taxes",
                "Go to a play",
                "Talk about balancing work and life",
                "Talk about balancing a checkbook",
                "Talk about living within one‟s means",
                "Talk about credit cards",
                "Go bargain hunting",
                "Plan a week's worth of meals",
                "Do a volunteer project together",
                "Do a weeks grocery shopping together",
                "Analyze what we eat/our diets",
                "Go holiday shopping",
                "Write “thank-you” notes",
                "Go to a house of worship",
                "Talk about relationships",
                "Talk about personal values",
                "Talk about the future"
                };
        }

        public override ChallengeView GetChallengeView(string prompt)
        {
            return new ActivityView(prompt);
        }
        public class ActivityView : ChallengeView
        {
            string[] choices = new string[] { "Goal Related", "Gettng to Know Each Other", "Just Interested", "Just for Fun" };

            public Picker Mentee { get; set; }
            public Picker Mentor { get; set; }

            public ActivityView(string prompt, string mentee = "", string mentor = "") : base(prompt)
            {
                Mentee = new Picker
                {
                    ItemsSource = choices,
                    SelectedItem = mentee
                };
                Mentor = new Picker
                {
                    ItemsSource = choices,
                    SelectedItem = mentor
                };

                Structure =
                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                                {
                                new Label{Text = Prompt,
                                    HorizontalOptions =LayoutOptions.Start
                                },
                                new StackLayout{
                                    HorizontalOptions =LayoutOptions.End,
                                    Children =
                                    {
                                        Mentee,
                                        Mentor
                                    }
                                }
                              }
                        };

                        }
        }
    }
}