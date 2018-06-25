using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathFinder.Models
{
    public class MultipleChoiceModel : ChallengeModel
    {
        protected string[] _choices;

        public MultipleChoiceModel(string title, string[] choices) : base(title)
        {
            _choices = choices;
        }

        public override ChallengeView GetChallengeView(string prompt)
        {
            return new MultipleChoiceStructure(prompt, _choices);
        }
        public class MultipleChoiceStructure : ChallengeView
        {
            Label Question { get; set; }
            Picker Answer { get; set; }
            public MultipleChoiceStructure(string prompt, string[] choices, string answer = "") : base(prompt)
            {
                Question = new Label
                {
                    Text = Prompt,
                    HorizontalOptions = LayoutOptions.Start
                };
                Answer = new Picker
                {
                    HorizontalOptions = LayoutOptions.EndAndExpand,
                    ItemsSource = choices,
                    SelectedItem = answer
                };
                Structure = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children =
                    {
                        Question,
                        Answer
                    }
                };
            }
        }
    }
}