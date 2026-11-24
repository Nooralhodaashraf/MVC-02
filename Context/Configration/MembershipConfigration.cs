using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_02.Entites;

namespace MVC_02.Context.Configration
{
    public class MembershipConfigration:IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder.HasKey(E=> E.Id);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
            
        }
    
    }
}
