namespace Test2Template.Api.Repositories;

public interface ImyRepository
{
    public Task<object> GetAsync();
    public Task<object> AddAsync();
    public Task<object> RemoveAsync();
}