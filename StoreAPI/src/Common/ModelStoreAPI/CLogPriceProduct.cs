using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelStoreAPI
{
    //COMENTARIO:
    //Clase que lleva el log de la actualizacion de los precios de cada producto.
    public class CLogPriceProduct
    {
        public int Id { get; set; }

        public CProduct Product { get; set; }
        public int IdProduct { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime UpdateDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal OldPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal NewPrice { get; set; }
    }
}
