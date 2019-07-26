using ModelStoreAPI.DBHelper;

namespace ModelStoreAPI
{
    //COMENTARIO:
    //Class that contains which user gave a "like" to a product.
    public class CLikeByProduct : AuditEntity, ISoftDeleted
    {
        public long Id { get; set; }

        public CUser User { get; set; }
        public string UserId { get; set; }

        public CProduct Product { get; set; }
        public int ProductId { get; set; }

        public bool Deleted { get; set; }
    }
}
