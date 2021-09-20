namespace CSharp.Inheritance.virtual_methods
{
    public class DerivedClass : BaseClass
    {
        public const string RESULT = "I did something different!";
        public override string DoSomething()
        {
            return RESULT;
        }
    }
}