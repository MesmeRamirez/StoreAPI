using System;
using System.ComponentModel.DataAnnotations;

namespace ModelStoreAPI
{
    //COMENTARIO:
    //Clase que almacena los productos que fueron adquiridos por un usuario, la cantidad y la fecha de compra.
    public class CUserByProduct
    {
        public int Id { get; set; }

        public CUser User { get; set; }
        public string IdUser { get; set; }

        public CProduct Product { get; set; }
        public int IdProduct { get; set; }

        public int Quantity { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime UpdateDate { get; set; }
    }
}
