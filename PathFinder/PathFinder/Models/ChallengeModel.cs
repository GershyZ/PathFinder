using PathFinder.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathFinder.Models
{
    public class ChallengeModel : LevelContentModel
    {
        ChallengeFormPage _form;
        public ChallengeModel(string title) : base(title)
        {
            _form = new ChallengeFormPage();
        }
        public ChallengeModel(string title, ChallengeFormPage cfp) : base(title)
        {
            _form = cfp;
            _form.SetParent(this);
        }

        public override void onTap()
        {
            Route.showLevelContent(_form);
        }
    }
}
