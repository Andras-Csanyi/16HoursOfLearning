namespace CSharp.Tests.Unit.keywords.modifiers.abstracts;

using FluentAssertions;
using Xunit;

public class AbstractImplementsInterfaceTests
{
    [Fact]
    public void implements()
    {
        AbstractImplementsInterfaceImpl sut = new AbstractImplementsInterfaceImpl();
        sut.world().Should().Be("world");
        sut.hello().Should().Be("hello");
    }
}