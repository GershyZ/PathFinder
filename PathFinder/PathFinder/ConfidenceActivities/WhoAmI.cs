using System;
using System.Collections.Generic;
using System.Text;
using PathFinder.Models;
using Xamarin.Forms;

namespace PathFinder.ConfidenceActivities
{
    public class WhoAmI : ChallengeModel
    {
        public WhoAmI(string title) : base(title)
        {

        }

        public override ChallengeView GetChallengeView(string prompt)
        {
            throw new NotImplementedException();
        }        
    }
}
