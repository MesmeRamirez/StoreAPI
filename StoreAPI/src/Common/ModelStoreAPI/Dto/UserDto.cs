namespace ModelStoreAPI.Dto
{
    public class UserDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserURL { get; set; }
    }

    public class UserGetFilter
    {
        public string UserId { get; set; }
        public string UserURL { get; set; }
    }

    public class UserListFilter
    {
        public string Name { get; set; }
    }

    public class UserPartialDto
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
    }
}
