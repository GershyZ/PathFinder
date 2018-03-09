                                         
using PathFinder.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace PathFinder.ViewModels
{
    public class LevelPageVM : INotifyPropertyChanged
    {

        LevelModel _levelModel;
        public LevelPageVM(LevelModel lm)
        {
            _levelModel = lm;
        }
        public String LevelName
        {
            get { return _levelModel.LevelName; }
        }
        public ObservableCollection<LevelContentModel> Content
        {
            get { return new ObservableCollection<LevelContentModel>(_levelModel.Content); }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
