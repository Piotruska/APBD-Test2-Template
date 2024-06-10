namespace Test2Template.Api.Errors;

public class UnauthorizedExeption : Exception
{
    public UnauthorizedExeption(string? message) : base(message)
    {
    }
}