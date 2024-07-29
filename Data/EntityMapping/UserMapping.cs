using EcommerceApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceApi.Data.EntityMapping;

public class UserMapping: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasKey(user => user.Email);

        builder.Property(user => user.Email)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(256);

        builder.Property(user => user.DisplayName)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(30);

        builder.Property(user => user.Password)
            .IsRequired()
            .HasColumnType("char")
            .HasMaxLength(60);
    }
}