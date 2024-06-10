using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test2Template.DataBase.Entities;

namespace Test2Template.DataBase.Configs;

public class Entity2Configuration : IEntityTypeConfiguration<Entity2>
{
    public void Configure(EntityTypeBuilder<Entity2> builder)
    {
        builder
            .HasKey(x => x.IdEntity2);
        builder
            .Property(x => x.IdEntity2)
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
            .ToTable("Entity2", "Template");
    }
}