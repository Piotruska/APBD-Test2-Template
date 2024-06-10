namespace Test2Template.Api.Errors;

public class NotFoundExeption : Exception
{
    public NotFoundExeption(string? message) : base(message)
    {
    }
}