using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2_Bug_Tracker.Models
{
    public static class ExtensionMethod
    {
        public static string ToDigitsOnly(this string str)
        {
            var myString = "";
            foreach (var e in str)
            {
                if (char.IsDigit(e))
                {
                    myString += e;
                }
            }
            return myString;
        }

        public static int ToAge(this DateTime dateOfBirth)
        {
            int age = (Int32.Parse(DateTime.Today.ToString("yyyyMMdd")) - Int32.Parse(dateOfBirth.ToString("yyyyMMdd"))) / 10000;

            return age;
        }
    }
}