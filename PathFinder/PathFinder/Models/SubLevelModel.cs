using PathFinder.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.Models
{
    public class SubLevelModel : LevelContentModel
    {
        LevelModel _level;
        public SubLevelModel(LevelModel level) : base(level.LevelName)  {
            _level = level;
        }
        public override void onTap()
        {            
            Route.switchPage(_level);
        }
    }
}