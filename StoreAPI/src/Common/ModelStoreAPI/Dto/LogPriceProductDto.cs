using System;

namespace ModelStoreAPI.Dto
{
    public class LogPriceProductDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime UpdateDate { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal? NewPrice { get; set; }
    }
}
