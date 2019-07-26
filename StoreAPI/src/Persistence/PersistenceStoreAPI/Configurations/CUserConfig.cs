using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelStoreAPI;

namespace PersistenceStoreAPI.Configurations
{
    public class CUserConfig
    {
        public CUserConfig(EntityTypeBuilder<CUser> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.UserURL).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Name).HasMaxLength(100);
            entityBuilder.Property(x => x.LastName).HasMaxLength(100);
        }
    }
}
