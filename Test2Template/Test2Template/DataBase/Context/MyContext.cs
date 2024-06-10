using Microsoft.EntityFrameworkCore;
using Test2Template.DataBase.Configs;
using Test2Template.DataBase.Entities;

namespace Test2Template.DataBase.Context;

public class MyContext : DbContext
{
    protected MyContext()
    {
    }

    public MyContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Entity1> Entity1S { get; set; }
    public DbSet<Entity1Entity2> Entity1Entity2S { get; set; }
    public DbSet<Entity2> Entity2S { get; set; }
    public DbSet<Entity3> Entity3S { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new Entity1Configuration());
        modelBuilder.ApplyConfiguration(new Entity1Entity2Configuration());
        modelBuilder.ApplyConfiguration(new Entity2Configuration());
        modelBuilder.ApplyConfiguration(new Entity3Configuration());
    }
}