using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int TreeHeight { get; set; } //TODO Make the Height property nullable
        TreeHeight = null;

        //TODO Make the property, "Day", type enum
        public enum Day { sun, mon, tue, wed, thur, fri, sat };

    }
}
