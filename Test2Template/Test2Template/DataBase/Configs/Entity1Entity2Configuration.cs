using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test2Template.DataBase.Entities;

namespace Test2Template.DataBase.Configs;

public class Entity1Entity2Configuration : IEntityTypeConfiguration<Entity1Entity2>
{
    public void Configure(EntityTypeBuilder<Entity1Entity2> builder)
    {
        
        //composit key
        builder
            .HasKey(x => new {x.IdEntity1,x.IdEntity2});
 
        builder
            .Property(x => x.Attribute1)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .Property(x => x.Attribute2)
            .HasMaxLength(100)
            .IsRequired();

        //Many to many Connection
        builder
            .HasOne(x => x.Entity1)
            .WithMany(x => x.Entity1Entity2S)
            .HasForeignKey(x => x.IdEntity1);
        
        builder
            .HasOne(x => x.Entity2)
            .WithMany(x => x.Entity1Entity2S)
            .HasForeignKey(x => x.IdEntity2);
        
        //names table and schema
        builder
            .ToTable("Entity1Entity2", "Template");

        
    }
}