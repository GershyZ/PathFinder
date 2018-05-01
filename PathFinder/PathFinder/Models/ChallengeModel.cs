    using PathFinder.Pages;
using System.Collections.Generic;

using Xamarin.Forms;
namespace PathFinder.Models
{
    public abstract class ChallengeModel : LevelContentModel
    {        
        public List<string> ChallengeContent;
        public ChallengeModel(string title) : base(title)
        {
            ChallengeContent = new List<string>();
        }

        public abstract View GetStructure(string lbl);

        public override void onTap()
        {
            Route.showLevelContent(new ChallengeFormPage(this));
        }
    }
}