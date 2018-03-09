using PathFinder.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CompetenceActivities
{
    public class CornellNoteTaking : ChallengeFormPage
    {
        public CornellNoteTaking() {
            
        }

        public StackLayout getStructure()
        {

            var structure = new StackLayout
            {
                Orientation = StackOrientation.Vertical,

            };

            return structure;
        }
    }
}
