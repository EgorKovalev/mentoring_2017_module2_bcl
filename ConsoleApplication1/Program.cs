using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApplication1
{
    [CustomAttribute]
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - custom attribute
            object properties = typeof(Program).GetCustomAttributes(typeof(CustomAttribute), false)[0];
            string name = ((CustomAttribute) properties).Name;
            string email = ((CustomAttribute)properties).Email;

            //Task 2 - sort string array
            String[] strs = {"The", "QUICK", "BROWN", "FOX", "jumps", "over", "the", "lazy", "dog"};
            Array.Sort(strs, new Comparer());

            //Task3 - concatenation
            string result = Concatenator.Concatenate(strs);
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CustomAttribute : System.Attribute
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public CustomAttribute()
        {
            Name = "Yahor Kavaliou";
            Email = "Yahor_Kavaliou@epam.com";
        }
    }

    public class Comparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return String.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class Concatenator
    {
        public static string Concatenate(string[] array)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i+=2)
            {
                sb.Append(array[i]);
            }
            return sb.ToString();
        }
    }
}
