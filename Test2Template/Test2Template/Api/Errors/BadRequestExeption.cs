namespace Test2Template.Api.Errors;

public class BadRequestExeption : Exception
{
    public BadRequestExeption(string? message) : base(message)
    {
    }
}