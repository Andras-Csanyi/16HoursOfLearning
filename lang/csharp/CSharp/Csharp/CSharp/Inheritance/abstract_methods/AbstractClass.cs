using System;

namespace CSharp.Inheritance.abstract_methods
{
    public abstract class AbstractClass
    {
        public abstract String Result { get; }
        public abstract String MustBeImplementedByDerived();
    }
}