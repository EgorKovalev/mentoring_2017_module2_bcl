using System;

namespace ConsoleApplication1
{
    [CustomAttribute]
    class Program
    {
        static void Main(string[] args)
        {
            object properties = typeof(Program).GetCustomAttributes(typeof(CustomAttribute), false)[0];
            string name = ((CustomAttribute) properties).Name;
            string email = ((CustomAttribute)properties).Email;
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
}
