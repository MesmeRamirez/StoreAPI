using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModelStoreAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceStoreAPI
{
    public class AppDB : IdentityDbContext<CUser>
    {

        public AppDB(DbContextOptions<AppDB> options) : base(options) { }

        public DbSet<CLikeByProduct> LikeProduct { get; set; }
        public DbSet<CLogPriceProduct> LogPriceProduct { get; set; }
        public DbSet<CProduct> Product { get; set; }
        public DbSet<CUserByProduct> UserByProduct { get; set; }
        public DbSet<CUserByUserType> UserByUserType { get; set; }
        public DbSet<IdentityRole> UserType { get; set; }

    }
}
