using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test2Template.DataBase.Entities;

namespace Test2Template.DataBase.Configs;

public class Entity1Configuration : IEntityTypeConfiguration<Entity1>
{
    public void Configure(EntityTypeBuilder<Entity1> builder)
    {
        builder
            .HasKey(x => x.IdEntity1);
        builder
            .Property(x => x.IdEntity1)
            .ValueGeneratedOnAdd()
            .IsRequired();
        builder
            .Property(x => x.Attribute1)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .Property(x => x.Attribute2)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .Property(x => x.Attribute3)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .ToTable("Entity1", "Template");
    }
}