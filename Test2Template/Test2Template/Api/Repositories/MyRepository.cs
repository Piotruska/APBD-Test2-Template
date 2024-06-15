using Microsoft.EntityFrameworkCore;
using Test2Template.DataBase.Context;
using Test2Template.DataBase.Entities;

namespace Test2Template.Api.Repositories;

public class MyRepository : ImyRepository
{
    private readonly MyContext _context;

    public MyRepository(MyContext context)
    {
        _context = context;
    }
    
    public async Task<object> GetAsync()
    {
        // to find a specific object based on id:
        // await _context.Entity1S.FindAsync(id);
        
        //to find an entity based on attribute
        // await _context.Entity1S.Where(x => x.Attribute1.Equals("something")).FirstOrDefaultAsync();
        
        //to find an entitys based on attribute
        // await _context.Entity1S.Where(x => x.Attribute1.Equals("something")).FirstOrDefaultAsync();
        
        // Joining tables to return info
        // await _context.Entity1S
        //     .Where(x => x.IdEntity1 == 1)
        //     .Include(x => x.entity3)
        //     .Include(x => x.Entity1Entity2S)
        //     .ThenInclude(x => x.Entity2).ToListAsync();

        //Selectring specific attributes and can maping to different type (eg tuple) 
        // await _context.Entity1S
        //     .Select(x => new { x.Attribute1, x.Attribute2 })
        //     .Where(x => x.Attribute1 == "")
        //     .ToListAsync();

        return null;
    }

    public async Task<object> AddAsync()
    {
        //Create a entity object from database
        // var EntityToAdd = new Entity1()
        // {
        //     Attribute1 = "",
        //     Attribute2 = "",
        //     Attribute3 = "",
        //     IdEntity3 = 1,
        //     IdEntity1Entity2 = 1
        // };
        
        //Add the entity to COntext
        // await _context.Entity1S.AddAsync(EntityToAdd);
        
        //Save the changes
        // await _context.SaveChangesAsync();
        
        //If you want to return the id that it was given the EntityToAdd will now have it
        // var id = EntityToAdd.IdEntity1;
        
        return null;
    }

    public async Task<object> RemoveAsync()
    {
        //Pass list or single entity to method from service

        //To remove one Entity
        // _context.Entity1S.Remove(EntityToRemove);
        
        //to remove list
        // _context.Entity1S.RemoveRange(ListToRemove);
        
        //Save the changes
        // await _context.SaveChangesAsync();
        
        
        return null;
    }
}