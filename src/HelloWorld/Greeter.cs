namespace HelloWorld;

public class Greeter
{
    public string Greet(string? name)
    {
        return string.IsNullOrWhiteSpace(name)
            ? "Hello, World!"
            : $"Hello, {name.Trim()}!";
    }
}