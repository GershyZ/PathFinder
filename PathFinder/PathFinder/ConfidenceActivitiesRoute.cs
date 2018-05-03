using PathFinder.Models;
using PathFinder.ConfidenceActivities;

using Xamarin.Forms;

namespace ConfidenceActivities
{
    public class ConfidenceActivitiesRoute : Route
    {
        public ConfidenceActivitiesRoute()
        {
            PDFNAME = "ConfidenceActivities";
            RouteName = "Confidence Activities";
            PrimaryColor = Color.Green;
            SecondaryColor = Color.Yellow;
            StartLevel.addSection(new ResourcePDF("Confidence Activity Booklet", 0));
            StartLevel.addSection(new LevelContentModel("This Year's Milestones"));
            StartLevel.addSection(SelfExploration.asLevelContent());
            StartLevel.addSection(new ResourcePDF("Conversation Topics", 10));
            StartLevel.addSection(KnowYourRole.asLevelContent());
            StartLevel.addSection(new ResourcePDF("Twenty-One Questions", 17));
            StartLevel.addSection(new DontWait("Don't Wait Too Long!"));
            StartLevel.addSection(new ResourcePDF("Getting Organized",20));
            StartLevel.addSection(new ActivityList("Activity List"));
            StartLevel.addSection(PersonalMission.asLevelContent());
        }


        private LevelModel SelfExploration
        {
            get
            {
                LevelModel curr = new LevelModel("Self Exploration");

                curr.addSection(new ResourcePDF("Pride Line", 2));
                curr.addSection(new ResourcePDF("Self Portrait", 3));
                curr.addSection(new ResourcePDF("The Magic Box", 4));
                curr.addSection(new WhoAmI("Who Am I? Questionnairre"));
                curr.addSection(new MyValues("Valuing Yourself"));
                curr.addSection(new ResourcePDF("My Personal Shield", 7));
                curr.addSection(new WhoDecides("Who Decides?"));
                curr.addSection(new WhoResponsible("Who is Responsible?"));

                return curr;
            }
        }
        private LevelModel KnowYourRole
        {
            get
            {
                LevelModel curr = new LevelModel("Know Your Role");
                curr.addSection(new CreatorRole("Are You a Creator?"));
                curr.addSection(new DoerRole("Are You a Doer?"));
                curr.addSection(new HelperRole("Are You a Helper?"));
                curr.addSection(new InfluencerRole("Are You an Influencer?"));
                curr.addSection(new InvestigatorRole("Are You an Investigator?"));
                curr.addSection(new OrganizerRole("Are You an Organizer?"));
                return curr;
            }
        }

        private LevelModel PersonalMission
        {
            get
            {
                LevelModel mission = new LevelModel("Crafting a Personal Mission Statement");
                mission.addSection(new LevelContentModel("Clarify Purpose And Values"));
                mission.addSection(new LevelContentModel("Drafting A Mission Statement"));

                return mission;
            }
        }
    }
}