using PathFinder.Pages;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
namespace PathFinder.Models
{
    public abstract class ChallengeModel : LevelContentModel
    {   
        public string ID { get; internal set; }
        public List<string> ChallengeContent;
        
        public ChallengeModel(string title) : base(title)
        {
            ChallengeContent = new List<string>();
            ID = Route.PDFNAME + new Random().Next();
        }
        
        public override void onTap()
        {
            Route.showLevelContent(new ChallengeFormPage(this));
        }
        public List<ChallengeView> ChallengeViews
        {
            get{
                List<ChallengeView> views = new List<ChallengeView>();
                foreach(string label in ChallengeContent)
                {
                    views.Add(new ChallengeView(label));
                }
                return views;
            }
        }
        public abstract ChallengeView GetChallengeView(string prompt);

        public abstract class ChallengeView
        {
            public string Prompt;
            public ChallengeView(string prompt)
            {
                Prompt = prompt;
            }
            public View Structure { get; internal set; }
        }
        
       // public abstract void ParseData(List<ChallengeView> content);
    }    
}