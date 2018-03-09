using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using Xamarin.Forms;

namespace PathFinder.ViewModels
{
    public class ChallengeFormVM : INotifyPropertyChanged
    {
        public List<View> ChallengeContent { get; }
        
        public ChallengeFormVM()
        {
            ChallengeContent = new List<View>();
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
