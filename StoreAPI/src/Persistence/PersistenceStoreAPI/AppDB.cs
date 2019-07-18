using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ModelStoreAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceStoreAPI
{
    public class AppDB : IdentityDbContext<CUser>
    {
    }
}
