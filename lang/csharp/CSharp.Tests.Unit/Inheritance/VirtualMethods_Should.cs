using CSharp.Inheritance.virtual_methods;
using FluentAssertions;
using Xunit;

namespace CSharp.Tests.Unit.Inheritance
{
    public class VirtualMethods_Should
    {
        [Fact]
        public void Derived_Overwrite_BaseClassMethod()
        {
            BaseClass baseClass = new BaseClass();
            DerivedClass derivedClass = new DerivedClass();
            DerivedButNotOverride derivedButNotOverride = new DerivedButNotOverride();

            baseClass.DoSomething().Should().Be(BaseClass.RESULT);
            derivedClass.DoSomething().Should().Be(DerivedClass.RESULT);
            derivedButNotOverride.DoSomething().Should().Be(BaseClass.RESULT);
        }
    }
}