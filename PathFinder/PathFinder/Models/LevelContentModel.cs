using PathFinder.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace PathFinder.Models
{   
    public class LevelContentModel :  INotifyPropertyChanged
    {
        public string ContentName { get; }
        public bool Accessible { get; set; }
        public bool Completed { get; set; }
        public LevelContentModel(String title)
        {
            ContentName = title;
            Accessible = true;
            Completed = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void onTap()
        {
            throw new NotImplementedException();
        }
    }
}