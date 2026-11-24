using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_02.Entites;

namespace MVC_02.Context.Configration
{
    public class PlanConfigration: IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("PlanDurationCheck", "DurationDays Between 1 And 365");
            });
        
        }
    
    }
}
