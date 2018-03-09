using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PathFinder.ViewModels
{
    class LevelContentVM : INotifyPropertyChanged
    {
        LevelContentModel _content;
        public LevelContentVM(LevelContentModel lcm)
        {
            _content = lcm;
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }
    }
}
