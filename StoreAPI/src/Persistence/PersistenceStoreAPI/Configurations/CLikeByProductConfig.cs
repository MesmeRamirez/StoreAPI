using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelStoreAPI;

namespace PersistenceStoreAPI.Configurations
{
    public class CLikeByProductConfig
    {
        public CLikeByProductConfig(EntityTypeBuilder<CLikeByProduct> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
        }
    }
}
