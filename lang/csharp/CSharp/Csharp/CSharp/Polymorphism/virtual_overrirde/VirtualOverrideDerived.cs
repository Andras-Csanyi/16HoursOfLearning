namespace CSharp.Polymorphism.virtual_overrirde
{
    public class VirtualOverrideDerived : VirtualOverrideBase
    {
        public const string RESULT = nameof(VirtualOverrideDerived);

        public override string DoSomething()
        {
            return RESULT;
        }
    }
}