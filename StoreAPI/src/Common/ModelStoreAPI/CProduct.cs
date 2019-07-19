using System.ComponentModel.DataAnnotations.Schema;

namespace ModelStoreAPI
{
    //COMENTARIO:
    //Clase que almacena el listado de productos
    public class CProduct
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
