
using PathFinder.Pages;
using PathFinder.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace PathFinder.Models
{
    public class LevelModel    {
        public string LevelName { get; internal set; }
        public List<LevelContentModel> Content;

        public LevelModel(string title)
        {
            LevelName = title;
            Content = new List<LevelContentModel>();
        }

        public LevelModel(string title, List<LevelContentModel> content)
        {
            LevelName = title;
            Content = content;
        }
        
        public virtual bool isAccessible() { return true; }
        public bool isCompleted()
        {
            var complete = true;
            for(int i = 0; i < Content.Count && complete; i++)
            {
                if (!Content[i].Completed)
                {
                    complete = false;
                }
            }
            return complete;
        }

        public void addSection(LevelContentModel content)
        {
            Content.Add(content);
        }

        public SubLevelModel asLevelContent()
        {
            return new SubLevelModel(this);
        }

        internal Page asLevelPage()
        {
            return new LevelPage(this);
        }
    }
}
