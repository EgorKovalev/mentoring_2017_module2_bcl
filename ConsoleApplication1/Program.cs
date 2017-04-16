using System;
using System.Collections;
using System.Globalization;

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
            IComparer comparer = new Comparer();
            String[] strs = {"The", "QUICK", "BROWN", "FOX", "jumps", "over", "the", "lazy", "dog"};
            Array.Sort(strs, comparer);
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

    public class Comparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return String.Compare(x.ToString(), y.ToString(), false, CultureInfo.InvariantCulture);
        }
    }
}
