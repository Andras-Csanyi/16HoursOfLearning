namespace CSharp.Tests.Unit.keywords.modifiers.abstracts;

public interface IAbstractImplementsInterface
{
    string hello();
    string world();
}
public abstract class AbstractImplementsInterface : IAbstractImplementsInterface
{
    public string hello()
    {
        return "hello";
    }

    public abstract string world();
}

public class AbstractImplementsInterfaceImpl : AbstractImplementsInterface
{
    public override string world()
    {
        return "world";
    }
}