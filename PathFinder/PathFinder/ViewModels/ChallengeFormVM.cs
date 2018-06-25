using Newtonsoft.Json;
using PathFinder.Models;
using PathFinder.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PathFinder.Helpers;
using PathFinder.Models;

namespace PathFinder.ViewModels
{
    public class ChallengeFormVM : INotifyPropertyChanged
    {
        private ChallengeModel challenge;
        public ChallengeFormVM(ChallengeModel c)
        {
            challenge = c;
        }

        public void SaveData(ChallengeFormPage content)
        {
            //challenge.ParseData(content);
        }
        public bool Completed
        {
            get { return challenge.Completed; }
            set { challenge.Completed = value; }                    
        }

        public List<View> ContentStructures
        {
            get
            {
                List<View> structures = new List<View>();
                foreach(ChallengeView v in challenge.ChallengeViews)
                {
                    structures.Add(v.Structure);
                }
                return structures;
            }
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
               // throw new NotImplementedException();
            }

            remove
            {
               // throw new NotImplementedException();
            }
        }
    }
}
    