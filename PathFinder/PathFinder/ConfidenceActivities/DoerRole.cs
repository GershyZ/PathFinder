using PathFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathFinder.ConfidenceActivities
{
    public class DoerRole : TrueFalseModel
    {
        public DoerRole(string title) : base(title)
        {
            ChallengeContent = new List<string>
            {
                "Do you work well with your hands?",
                "Do you like to be outdoors?",
                "Do you enjoy working with tools?",
                "Do you enjoy taking apart and reassembling mechanical things?",
                "Do you enjoy working with plants or animals?",
                "Would you prefer physical activity instead of working at a desk?",
                "Do you like playing sports?",
                "Is keeping in shape important to you?",
                "Are math, physical education, and crafts things you do best ?",
                "Can you follow directions and read diagrams for putting things together ?",               
                "If someone explains how to operate something, do you learn quickly ?",
                "Do you like to work with people as part of a team ?",
                "Do you understand things better when you see pictures and drawings instead of reading about them ?"
            };
        }
    }
}
