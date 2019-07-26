using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelStoreAPI;

namespace PersistenceStoreAPI.Configurations
{
    public class CLogPriceProductConfig
    {
        public CLogPriceProductConfig(EntityTypeBuilder<CLogPriceProduct> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
        }
    }
}
