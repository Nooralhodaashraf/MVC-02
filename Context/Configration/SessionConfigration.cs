using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_02.Entites;

namespace MVC_02.Context.Configration
{
    public class SessionConfigration :  IEntityTypeConfiguration<Session>
    {
        public new void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(X => X.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.HasOne(x => x.Trainer).WithMany(x => x.Sessions).HasForeignKey(x => x.TrainerId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("SessionCapacityCheck", "Capacity Between 1 And 25");
                T.HasCheckConstraint("SessionCheckDate", "StartDate < EndDate");
            });
        }
    }
}