using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModelStoreAPI;
using System;
using CommonStoreAPI;
using ModelStoreAPI.DBHelper;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using PersistenceStoreAPI.Configurations;

namespace PersistenceStoreAPI
{
    public class AppDB : IdentityDbContext<CUser>
    {
        private readonly ICurrentUserFactory _currentUser;

        public AppDB(DbContextOptions<AppDB> options, ICurrentUserFactory currentUser = null) : base(options)
        {
            _currentUser = currentUser;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            AddMyFilters(ref modelBuilder);

            new CUserConfig(modelBuilder.Entity<CUser>());
            new CLikeByProductConfig(modelBuilder.Entity<CLikeByProduct>());
            new CLogPriceProductConfig(modelBuilder.Entity<CLogPriceProduct>());
            new CProductConfig(modelBuilder.Entity<CProduct>());
            new CUserPerProductConfig(modelBuilder.Entity<CUserPerProduct>());
        }

        public DbSet<CLikeByProduct> LikeProduct { get; set; }
        public DbSet<CLogPriceProduct> LogPriceProduct { get; set; }
        public DbSet<CProduct> Product { get; set; }
        public DbSet<CUserPerProduct> UserPerProduct { get; set; }

        public override int SaveChanges()
        {
            MakeAudit();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            MakeAudit();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            MakeAudit();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void MakeAudit()
        {
            var modifiedEntries = ChangeTracker.Entries().Where(
                x => x.Entity is AuditEntity
                    && (
                    x.State == EntityState.Added
                    || x.State == EntityState.Modified
                )
            );

            var user = new CurrentUser();

            if (_currentUser != null)
            {
                user = _currentUser.Get;
            }

            foreach (var entry in modifiedEntries)
            {
                var entity = entry.Entity as AuditEntity;

                if (entity != null)
                {
                    var date = DateTime.Now;
                    string userId = user.UserId;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedAt = date;
                        entity.CreatedBy = userId;
                    }
                    else if (entity is ISoftDeleted && ((ISoftDeleted)entity).Deleted)
                    {
                        entity.DeletedAt = date;
                        entity.DeletedBy = userId;
                    }

                    Entry(entity).Property(x => x.CreatedAt).IsModified = false;
                    Entry(entity).Property(x => x.CreatedBy).IsModified = false;

                    entity.UpdatedAt = date;
                    entity.UpdatedBy = userId;
                }
            }
        }

        private void AddMyFilters(ref ModelBuilder modelBuilder)
        {
            #region SoftDeleted
            modelBuilder.Entity<CProduct>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<CUser>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<CLikeByProduct>().HasQueryFilter(x => !x.Deleted);
            #endregion
        }
    }
}
