using PathFinder.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathFinder.Models
{
    public class LevelUpModel : LevelModel
    {        
        private List<LevelContentModel> _prerequisites;

        public LevelUpModel(string title, List<LevelContentModel> prerequisites) : base(title, new List<LevelContentModel>())
        {
            _prerequisites = prerequisites;
        }

        public LevelUpModel(string title, List<LevelContentModel> content, List<LevelContentModel> prerequisites) : base(title, content)
        {
            _prerequisites = prerequisites;
        }

        public override bool isAccessible()      {
            var accessible = true;
            for(int i = 0; i< _prerequisites.Count && accessible; i++)
            {
                accessible = _prerequisites[i].Accessible;
            }

            return accessible;
        }
    }
}