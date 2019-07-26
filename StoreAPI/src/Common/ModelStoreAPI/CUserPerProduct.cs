using System;
using System.ComponentModel.DataAnnotations;

namespace ModelStoreAPI
{
    //COMMENT
    //Class that contains all the products that were bought by an user, the quantity and the date.
    public class CUserPerProduct
    {
        public int Id { get; set; }

        public CUser User { get; set; }
        public string UserId { get; set; }

        public CProduct Product { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime UpdateDate { get; set; }
    }
}
