using CSharp.Polymorphism.virtual_overrirde;
using FluentAssertions;
using Xunit;

namespace CSharp.Tests.Unit.Polymorphism
{
    public class VirtualOverrideShould
    {
        [Fact]
        public void CallTheOverwrittenMethod()
        {
            VirtualOverrideBase virtualOverrideBase = new VirtualOverrideBase();
            VirtualOverrideDerived virtualOverrideDerived = new VirtualOverrideDerived();

            virtualOverrideBase.DoSomething().Should().Be(VirtualOverrideBase.RESULT);
            virtualOverrideDerived.DoSomething().Should().Be(VirtualOverrideDerived.RESULT);
        }
    }
}