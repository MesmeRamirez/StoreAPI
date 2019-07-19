namespace ModelStoreAPI
{
    //COMENTARIO:
    //Clase que almacena que usuario le dio like a un producto.
    public class CLikeByProduct
    {
        public long Id { get; set; }

        public CUser User { get; set; }
        public string IdUser { get; set; }

        public CProduct Product { get; set; }
        public int IdProduct { get; set; }
    }
}
