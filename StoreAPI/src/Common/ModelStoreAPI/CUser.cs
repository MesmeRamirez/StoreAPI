using Microsoft.AspNetCore.Identity;

namespace ModelStoreAPI
{
    public class CUser : IdentityUser, ISoftDeleted
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserURL { get; set; }
        public bool Deleted { get; set; }
    }
}
