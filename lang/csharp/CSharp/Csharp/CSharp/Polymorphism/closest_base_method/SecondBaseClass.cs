namespace CSharp.Polymorphism.closest_base_method
{
    public class SecondBaseClass : FirstBaseClass
    {
        public const string RESULT = nameof(SecondBaseClass);

        public string DoSomething()
        {
            return RESULT;
        }
    }
}