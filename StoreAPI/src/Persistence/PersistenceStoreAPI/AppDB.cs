using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceStoreAPI
{
    public class AppDB : IdentityDbContext<ApplicationUser>
    {
    }
}
