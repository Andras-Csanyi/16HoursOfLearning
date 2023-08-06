namespace CSharp.Tests.Unit.keywords.modifiers.abstracts
{
    using System.Threading.Tasks;

    public abstract class PureAbstract
    {
        public abstract string AbstractProperty { get; set; }
        public abstract string abstractMethod();
        public abstract Task<string> abstractMethodAsync();
    }

    public class PureAbstractImpl : PureAbstract
    {
        public override string AbstractProperty { get; set; }
        public override string abstractMethod()
        {
            throw new System.NotImplementedException();
        }

        public override async Task<string> abstractMethodAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}