using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using Xamarin.Forms;

namespace PathFinder.ViewModels
{
    public class ChallengeFormVM : INotifyPropertyChanged
    {
        private ChallengeModel challenge;
        public List<View> ContentViews { get
            {
                List < View >content = new List<View>();
                foreach (string lbl in challenge.ChallengeContent)
                {
                    content.Add(challenge.GetStructure(lbl));
                }
                return content;
            }
        }
        
        public ChallengeFormVM(ChallengeModel c)
        {
            challenge = c;
        }

        public bool Completed
        {
            get { return challenge.Completed; }
            set { challenge.Completed = value; }                    
        }
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
               // throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }
    }
}
