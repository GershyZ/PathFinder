using PathFinder.Models;
using PathFinder.Pages;
using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace PathFinder.Models
{
    public class Route : Application
    {
        public static Color PrimaryColor { get; protected set; }
        public static Color SecondaryColor { get; protected set; }
        public static String ROUTEPDF;
//        public static LevelModel CURRENT_LEVEL;
        private static Stack<LevelModel> _history_stack;
        public Route() : base()
        {         
            _history_stack = new Stack<LevelModel>();          
            _history_stack.Push(new LevelModel("RAWR"));
            Current.MainPage = new NavigationPage(new ContentPage());
        }
        public  LevelModel StartLevel { get; private set; }

        public String RouteName
        {
            get { return StartLevel.LevelName; }
            set { StartLevel = new LevelModel(value);
                Route.ROUTEPDF = StartLevel.LevelName + ".pdf";
                Route.switchPage(StartLevel);
            }
        }

        public static void switchPage(LevelModel level)
        {
            //CURRENT_LEVEL = level;
            if (_history_stack.Contains(level))
            {
                _goBack(level);     
            }
            _history_stack.Push(level);
            Route.Current.MainPage.Navigation.PushAsync(level.asLevelPage());
        }

        public static void showLevelContent(ContentPage lc)
        {
            Route.Current.MainPage.Navigation.PushAsync(lc);
        }

        private static void _goBack(LevelModel backtrack)
        {           
            bool found = false;
            if (backtrack == null || _history_stack.Count == 0)
            {
                found = true;
            }
            LevelModel curr = null;
            while (_history_stack.Count > 0 && _history_stack.Peek() != null && !found)
            {
                curr = _history_stack.Pop();
                if (curr.Equals(backtrack))
                {
                    found = true;
                }
            }
        }

        public static Stack<LevelModel> getHistory()
        {
            return _history_stack; 
        }
    }
}   