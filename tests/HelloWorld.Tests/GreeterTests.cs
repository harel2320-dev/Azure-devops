using HelloWorld;
using Xunit;

namespace HelloWorld.Tests;

public class GreeterTests
{
    private readonly Greeter _greeter = new();

    [Fact]
    public void Greet_NoName_ReturnsDefault()
        => Assert.Equal("Hello, World!", _greeter.Greet(null));

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    public void Greet_BlankName_ReturnsDefault(string name)
        => Assert.Equal("Hello, World!", _greeter.Greet(name));

    [Fact]
    public void Greet_Name_IsTrimmedAndUsed()
        => Assert.Equal("Hello, Harel!", _greeter.Greet("  Harel "));
}