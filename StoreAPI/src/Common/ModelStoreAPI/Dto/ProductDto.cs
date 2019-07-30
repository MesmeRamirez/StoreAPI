namespace ModelStoreAPI.Dto
{

    public class ProductCreateDto
    {
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string UserId { get; set; }
        public string UrlImage { get; set; }

    }

    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string UserId { get; set; }
        public string UrlImage { get; set; }
        public string ImagePath
        {
            get
            {
                return $"/Uploads/{UrlImage}";
            }
        }
        public int Likes { get; set; }
        public bool ILikedIt { get; set; }
    }

    public class ProductListFilter
    {
        public string ProductName { get; set; }
        public string UserId { get; set; }
    }

    public class ProductDtoPartial
    {
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string UrlImage { get; set; }
    }

    public class ProductListDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string UrlImage { get; set; }
        public string ImagePath
        {
            get
            {
                return $"/Uploads/{UrlImage}";
            }
        }
        public int Likes { get; set; }
        public bool ILikedIt { get; set; }
    }

}
