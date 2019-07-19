namespace ModelStoreAPI
{
    //COMENTARIO:
    //Clase que almacena la asignacion de un perfil a un usuario
    public class CUserByUserType
    {
        public int Id { get; set; }

        public CUser User { get; set; }
        public string IdUser { get; set; }

        public IdentityRole UserType { get; set; }
        public int IdUserType { get; set; }
    }
}
