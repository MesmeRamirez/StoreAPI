using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelStoreAPI;

namespace PersistenceStoreAPI.Configurations
{
    public class CProductConfig
    {
        public CProductConfig(EntityTypeBuilder<CProduct> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
        }
    }
}
