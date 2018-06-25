using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathFinder.ConfidenceActivities
{
    public class WhoResponsible : MultipleChoiceModel
    {
        public WhoResponsible(string title) : base(title, new string[] { "Responsible", "Irrisponsible" })
        {             
            ChallengeContent = new List<string>
            {
                "Jimmy told his mother he was going to Carl's house. Then he went there.",
                "Robby took good care of his pencil so he wouldn't lose it",
                "Mary threw her trash paper on the floor.",
                "Cathy tasted her mother's cough medicine.",
                "Lydia held her little sister's hand when she took her for a walk.",
                "Elaine's job was to set the table. She stayed outside to play.",
                "Mother asked Peter to give the dog his supper. Instead, Peter gave the dog a drink of water.",
                "Dad phoned Janet to say he would be late for dinner.Janet did not tell her mother.",
                "Walter found 40 cents on the floor.He gave it to his teacher.",
                "Phyllis said she would be home by 5:00.She went home when she said she would."
            };
        }
    }
}
