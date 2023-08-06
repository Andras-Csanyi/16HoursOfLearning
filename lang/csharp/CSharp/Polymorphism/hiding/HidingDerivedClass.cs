using System;

namespace CSharp.Polymorphism.hiding
{
    public class HidingDerivedClass : HidingBaseClass
    {
        public const String RESULT = nameof(HidingDerivedClass);

        public String DoSomething()
        {
            return RESULT;
        }
    }
}