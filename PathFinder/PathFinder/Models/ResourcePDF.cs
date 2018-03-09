//https://blog.verslu.is/xamarin/xamarin-forms-xamarin/showing-pdf-files-xamarin-forms/
using System;
using System.Collections.Generic;
using System.Text;
using PathFinder.Pages;

namespace PathFinder.Models
{
    public class ResourcePDF : LevelContentModel
    {
        int numpage;
        public ResourcePDF(string name, int page): base(name) {
            numpage = page;
        }

        public override void onTap()
        {
            Route.showLevelContent(new CustomContentPage(this));
        }
    }   
}