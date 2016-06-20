using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using WOSAPI.Models;
using WOSAPI.Models.Entity;

namespace WOSAPI.Data
{
    public class WosContext : DbContext
    {
        public string UserID { get; set; }

        public WosContext(string userID)
            : this(userID, true)
        {
        }

        public WosContext(string userID, bool detectChanges)
            : base("Name=WosContext")
        {
            UserID = userID;
            Configuration.AutoDetectChangesEnabled = detectChanges;
        }

        public DbSet<Shame> Shames { get; set; }
        public DbSet<Blame> Blames { get; set; }
        public DbSet<User> Users { get; set; }

        public override int SaveChanges()
        {
            IEnumerable<DbEntityEntry<TrackedEntity>> changeSet = ChangeTracker.Entries<TrackedEntity>();

            if (changeSet != null)
            {
                foreach (DbEntityEntry<TrackedEntity> entry in changeSet.Where(c => c.State != EntityState.Unchanged && c.State != EntityState.Deleted))
                {
                    if (entry.State == EntityState.Added)
                    {
                        entry.Entity.CreatedAt = DateTime.Now;
                        entry.Entity.CreatedBy = UserID;
                        entry.Property(te => te.UpdatedAt).IsModified = false;
                        entry.Property(te => te.UpdatedBy).IsModified = false;
                    }
                    else if (entry.State == EntityState.Modified)
                    {
                        entry.Entity.UpdatedAt = DateTime.Now;
                        entry.Entity.UpdatedBy = UserID;
                        entry.Property(te => te.CreatedAt).IsModified = false;
                        entry.Property(te => te.CreatedBy).IsModified = false;
                    }
                }
            }

            return base.SaveChanges();
        }
    }

    public class MigrationsContextFactory : IDbContextFactory<WosContext>
    {
        public WosContext Create()
        {
            // Pour éviter d'avoir un WosContext sans paramètre
            return new WosContext(null);
        }
    }
}
