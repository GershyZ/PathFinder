using System;
using System.Collections.Generic;
using System.Text;
using PathFinder.Models;
using Xamarin.Forms;

namespace PathFinder.ConfidenceActivities
{
    class DontWait : ChallengeModel
    {
        public DontWait(string title) : base(title)
        {
            ChallengeContent = new List<string>
          {
              "In general, school is",
                "My best friend is…",
              "The thing I like best about my class is…",
              "Something I‟d like to tell my teacher is…",
              "I don‟t like people who…",
              "I am at my best when I…",
              "Right now I feel…",
              "People I trust…",
              "The best thing that could happen to me is...",
              "When I do not like something I have done, I…",
              "When I like something I have done, I…",
              "When I‟m proud of myself, I…",
              "i A very happy that…",
              "I wish my parents knew…",
              "Someday I hope…",
              "I would like to…",
              "Five adjectives that describe me are…"
          };
        }
        
        public override View GetStructure(string lbl)
        {
            return new Entry { Placeholder = lbl };
        }
    }
}
