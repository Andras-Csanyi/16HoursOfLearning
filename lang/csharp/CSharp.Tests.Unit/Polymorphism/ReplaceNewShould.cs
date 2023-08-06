using System;
using CSharp.Polymorphism;
using FluentAssertions;
using Xunit;

namespace CSharp.Tests.Unit.Polymorphism
{
    public class ReplaceNewShould
    {
        [Fact]
        public void ReplaceBaseClassMethodWithTheNewOne()
        {
            ReplaceDerivedClass replaceDerivedClass = new ReplaceDerivedClass();
            replaceDerivedClass.DoSomething().Should().Be(nameof(ReplaceDerivedClass));
            ReplaceNewBaseClass res = (ReplaceNewBaseClass)replaceDerivedClass;
            res.DoSomething().Should().Be(nameof(ReplaceNewBaseClass));
        }
    }
}