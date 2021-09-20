using System;

namespace CSharp.Polymorphism
{
    public class ReplaceDerivedClass : ReplaceNewBaseClass
    {
        public new String RESULT = nameof(ReplaceDerivedClass);

        public new String DoSomething()
        {
            return RESULT;
        }
    }
}