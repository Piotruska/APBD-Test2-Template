using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test2Template.DataBase.Entities;

namespace Test2Template.DataBase.Configs;

public class Entity3Configuration : IEntityTypeConfiguration<Entity3>
{
    public void Configure(EntityTypeBuilder<Entity3> builder)
    {
        throw new NotImplementedException();
    }
}