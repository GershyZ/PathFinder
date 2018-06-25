using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathFinder.Models
{
    public class TrueFalseModel : ChallengeModel
    {
        Dictionary<String, bool> _input;
        public TrueFalseModel(String title) : base(title)
        {
            _input = new Dictionary<string, bool>();
        }

        /** public override void ParseData(List<ChallengeView> content)
         {
             _input = new Dictionary<string, bool>();
             for (int i = 0; i < content.Count; i++)
             {
                 var tfm = (TrueFalseStructure)content[i];
                 _input.Add(tfm.Key.Text, tfm.Answer.IsToggled);
             }
         }
     **/

        public override ChallengeView GetChallengeView(string prompt)
        {
            return new TrueFalseStructure(prompt);
        }

        public class TrueFalseStructure : ChallengeView
        {
            public Label Key { get; set; }
            public Switch Answer { get; set; }

            public TrueFalseStructure(String prompt, bool answer = false) : base(prompt)
            {
                Key.Text = Prompt;
                Answer.IsToggled = answer;
                Structure = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children = {
                            Key,
                            Answer
                        }
                };
            }
        }
    }
}