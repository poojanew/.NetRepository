using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace day4_classes
{
    static class FirstLettrUpperCase
    {
        public static string toUpperCase(this string s)
        {
            string str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s);
            return str;
        }
    }
}
