using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Blog.Classes
{
    public class Utilis
    {
        public static string CutText(string text, int maxLength = 120)
        {
            if (text == null || text.Length <= maxLength)
            {
                return text;
            }

            var shortText = text.Substring(0, maxLength - 3) + "...";

            return shortText;
        }
    }
}