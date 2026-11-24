using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_02.Entites;

namespace MVC_02.Context.Configration
{
    public class MrmberConfigration: GymUserConfigration<Member>, IEntityTypeConfiguration<Member>
    {
        public new void Configure (EntityTypeBuilder<Member> builder)
        {
            builder.Property(X => X.CreatedAt).HasColumnName("HireDate").HasDefaultValue("GETDATE()");
            base.Configure(builder);
        }
    }
}
