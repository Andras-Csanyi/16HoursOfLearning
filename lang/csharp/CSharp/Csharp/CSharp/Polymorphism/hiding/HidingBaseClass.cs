using System;

namespace CSharp.Polymorphism.hiding
{
    public class HidingBaseClass
    {
        public const String RESULT = nameof(HidingBaseClass);
        
        public String DoSomething()
        {
            return RESULT;
        }
    }
}