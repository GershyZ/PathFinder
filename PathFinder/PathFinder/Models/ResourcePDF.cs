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
        public string Uri
        {
            get { return string.Format("{0}.{1}.pdf", Route.PDFNAME, numpage); }
        }
        public override void onTap()
        {
            Route.showLevelContent(new CustomContentPage(this));
        }
    }   
}