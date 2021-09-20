namespace CSharp.Inheritance.abstract_methods
{
    public class DerivedClass : AbstractClass
    {
        public override string Result { get; } = "Result";

        public override string MustBeImplementedByDerived()
        {
            return Result;
        }
    }
}