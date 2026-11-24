using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_02.Entites;

namespace MVC_02.Context.Configration
{
    public class GymUserConfigration<T> : IEntityTypeConfiguration<T> where T : GymUsers
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.Phone).HasColumnType("varchar").HasMaxLength(11);
            builder.ComplexProperty(x => x.Address);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("GymUser_EmailCheck", "Email LIKE '%@%.%'");
                T.HasCheckConstraint("GymUser_PhonCheck", "Len(Phone)= 11 AND Phone LIKE '011%'OR Phone LIKE '012%' OR Phone LIKE '015%'");
            });

            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.Gender).IsRequired();
        }
    }
}
