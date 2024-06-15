using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test2Template.DataBase.Entities;

namespace Test2Template.DataBase.Configs;

public class Entity3Configuration : IEntityTypeConfiguration<Entity3>
{
    public void Configure(EntityTypeBuilder<Entity3> builder)
    {
        builder
            .HasKey(x => x.IdEntity3);
        builder
            .Property(x => x.IdEntity3)
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
            .ToTable("Entity3", "Template");
    }
}