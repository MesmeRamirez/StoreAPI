using System;

namespace ModelStoreAPI.Dto
{
    public class UserPerProductCreateDto
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime UpdateDate { get; set; }
    }

    public class UserPerProductListDto
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal? Price { get; set; }
        public string Total { get; set; }
    }
}
