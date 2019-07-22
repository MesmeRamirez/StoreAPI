namespace ModelStoreAPI.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
    }

    public class ProductListFilter
    {
        public string ProductName { get; set; }
    }

    public class ProductDtoPartial
    {
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
    }

}
