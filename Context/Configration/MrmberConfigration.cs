using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_02.Entites;

namespace MVC_02.Context.Configration
{
    public class MrmberConfigration: GymUserConfigration<Member>, IEntityTypeConfiguration<Member>
    {
        public void Configure (EntityTypeBuilder<Member> builder)
        {
            builder.Property(X => X.CreatedAt).HasColumnName("JoinDate");
            base.Configure(builder);
        }
    }
}
