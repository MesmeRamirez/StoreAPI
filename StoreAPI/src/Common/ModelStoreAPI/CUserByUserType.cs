namespace ModelStoreAPI
{
    //COMENTARIO:
    //Clase que almacena la asignacion de un perfil a un usuario
    class CUserByUserType
    {
        public CUser User { get; set; }
        public string IdUser { get; set; }

        public CUserType UserType { get; set; }
        public int IdUserType { get; set; }
    }
}
