using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class group: List<Employee>
    {
        public string Title { get; set; }
        public string ShortName { get; set; }
        public group(string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }
        public static IList<group> All { get; set; }
    }
}
