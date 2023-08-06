namespace CSharp.Tests.Unit.keywords.modifiers.abstracts
{
    public abstract class PartialAbstract
    {
        public string hello()
        {
            return "hello";
        }

        public abstract string world();
    }

    public class PartialAbstractImpl : PartialAbstract
    {
        public override string world()
        {
            return "world";
        }
    }
}