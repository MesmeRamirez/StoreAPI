using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelStoreAPI
{
    public class CUser : IdentityUser
    {
        public string Image { get; set; }
        public string UserURL { get; set; }
    }
}
