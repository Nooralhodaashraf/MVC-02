using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_02.Entites;

namespace MVC_02.Context.Configration
{
    public class TrainerConfigratin: GymUserConfigration<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(X => X.CreatedAt).HasColumnName("JoinDate").HasDefaultValue("GETDATE()");
            base.Configure(builder);
        }

    }
}
