namespace CSharp.Tests.Unit.keywords.modifiers.abstracts
{
    using FluentAssertions;
    using Xunit;

    public class PureAbstractTest
    {
        [Fact]
        public void abstractMayContainImplementation_AndItIsAvailableInDerived()
        {
            PartialAbstractImpl partialAbstractImpl = new PartialAbstractImpl();
            partialAbstractImpl.hello().Should().Be("hello");
            partialAbstractImpl.world().Should().Be("world");
        }
    }
}