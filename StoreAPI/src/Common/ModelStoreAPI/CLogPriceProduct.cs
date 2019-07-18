using System;
using System.ComponentModel.DataAnnotations;

namespace ModelStoreAPI
{
    //COMENTARIO:
    //Clase que lleva el log de la actualizacion de los precios de cada producto.
    class CLogPriceProduct
    {
        public CProduct Product { get; set; }
        public int IdProduct { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime UpdateDate { get; set; }

        public int OldPrice { get; set; }
        public int NewPrice { get; set; }
    }
}
