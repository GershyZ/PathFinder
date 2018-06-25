using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CompetenceActivities
{
    public class CornellNoteTaking : ChallengeModel
    {
        public CornellNoteTaking(string title) : base(title)
        {

        }

        public override ChallengeView GetChallengeView(string prompt)
        {
            throw new NotImplementedException();
        }
    }
}
