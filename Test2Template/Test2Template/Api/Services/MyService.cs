using Test2Template.Api.Repositories;

namespace Test2Template.Api.Services;

public class MyService : ImyService
{
    private ImyRepository _repository;
    private IUnitOfWork _unitOfWork;

    public MyService(ImyRepository repository,IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;

    }

    public async Task<Object> GetAsync()
    {
        return await _repository.GetAsync();
    }

    public async Task<object> CreateAsync()
    {
        await _unitOfWork.BeginTransactionAsync();

        try
        {

            
            await _unitOfWork.CommitTransactionAsync();
        }
        catch (Exception e)
        {
            await _unitOfWork.RollbackTransactionAsync();
            throw e;
        }
        
        throw new NotImplementedException();
    }
}
