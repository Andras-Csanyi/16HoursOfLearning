using CSharp.Polymorphism.closest_base_method;
using FluentAssertions;
using Xunit;

namespace CSharp.Tests.Unit.Polymorphism
{
    public class ClosestBaseMethodShould
    {
        [Fact]
        public void CallTheClosestBaseClassMethod()
        {
            DerivedFromSecond derivedFromSecond = new DerivedFromSecond();
            derivedFromSecond.DoSomething().Should().Be(SecondBaseClass.RESULT);
        }
    }
}