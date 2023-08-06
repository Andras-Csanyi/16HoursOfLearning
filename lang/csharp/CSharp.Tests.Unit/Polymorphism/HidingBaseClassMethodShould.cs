using CSharp.Polymorphism.hiding;
using FluentAssertions;
using Xunit;

namespace CSharp.Tests.Unit.Polymorphism
{
    public class HidingBaseClassMethodShould
    {
        [Fact]
        public void ShouldHideBaseClassMethod()
        {
            HidingDerivedClass hidingDerivedClass = new HidingDerivedClass();
            hidingDerivedClass.DoSomething().Should().Be(HidingDerivedClass.RESULT);
        }
    }
}