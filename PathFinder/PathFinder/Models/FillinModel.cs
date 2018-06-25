
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathFinder.Models
{
    public class FillinModel : ChallengeModel
    {
        public FillinModel(string  title) : base(title) { }

        public override ChallengeView GetChallengeView(string prompt)
        {
            return new FillinView(prompt);
        }

        public class FillinView : ChallengeView
        {
            public Entry prompt { get; set; }
            public FillinView(string question, string answer = "") :base(question)
            {

                Structure = new Entry
                {
                    Placeholder = question,
                    Text = answer
                };
            }           
        }
    }
}