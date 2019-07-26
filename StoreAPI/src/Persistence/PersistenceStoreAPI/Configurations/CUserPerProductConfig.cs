using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelStoreAPI;

namespace PersistenceStoreAPI.Configurations
{
    public class CUserPerProductConfig
    {
        public CUserPerProductConfig(EntityTypeBuilder<CUserPerProduct> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
        }
    }
}
