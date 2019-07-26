using ModelStoreAPI.DBHelper;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelStoreAPI
{
    //COMMENT
    //Class that contains a list of all the products and the admin user that created it.
    public class CProduct : AuditEntity, ISoftDeleted
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }

        public CUser User { get; set; }
        public string UserId { get; set; }

        public string UrlImage { get; set; }

        public bool Deleted { get; set; }
    }
}
