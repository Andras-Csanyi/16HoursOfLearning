namespace CSharp.Polymorphism.virtual_overrirde
{
    public class VirtualOverrideBase
    {
        public const string RESULT = nameof(VirtualOverrideBase);

        public virtual string DoSomething()
        {
            return RESULT;
        }

    }
}