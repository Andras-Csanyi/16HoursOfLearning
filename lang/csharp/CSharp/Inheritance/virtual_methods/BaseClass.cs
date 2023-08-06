using System;

namespace CSharp.Inheritance.virtual_methods
{
    public class BaseClass
    {
        public const string RESULT = "I did something";

        public virtual String DoSomething()
        {
            return RESULT;
        }
    }
}