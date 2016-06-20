using System;
using System.Data.Entity;
using WOSAPI.Models;
using WOSAPI.Models.Entity;

namespace WOSAPI.Data
{
    public class WosContext : DbContext
    {
        public WosContext()
            : this(true)
        {
        }

        public WosContext(bool detectChanges)
            : base("Name=WosContext")
        {
            Configuration.AutoDetectChangesEnabled = detectChanges;
        }

        public DbSet<Shame> Shames { get; set; }

        protected override System.Data.Entity.Validation.DbEntityValidationResult ValidateEntity(System.Data.Entity.Infrastructure.DbEntityEntry entityEntry, System.Collections.Generic.IDictionary<object, object> items)
        {
            TrackedEntity entity = entityEntry.Entity as TrackedEntity;
            if (entity != null)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    entityEntry.Property("UpdatedAt").IsModified = false;
                    entityEntry.Property("UpdatedBy").IsModified = false;
                    if (entity.CreatedAt == DateTime.MinValue || entity.CreatedAt == DateTime.MaxValue)
                        entity.CreatedAt = DateTime.Now;
                    //if (string.IsNullOrWhiteSpace(entity.CreatedBy))
                    //    entity.CreatedBy = UserContext.Current.User != null &&
                    //                          UserContext.Current.User.Identity.IsAuthenticated
                    //                              ? UserContext.Current.User.Identity.Name
                    //                              : null;
                }
                else if (entityEntry.State != EntityState.Deleted && entityEntry.State != EntityState.Unchanged)
                {
                    entityEntry.Property("CreatedAt").IsModified = false;
                    entityEntry.Property("CreatedBy").IsModified = false;
                    if (!entity.UpdatedAt.HasValue || entity.UpdatedAt == DateTime.MinValue || entity.UpdatedAt == DateTime.MaxValue)
                        entity.UpdatedAt = DateTime.Now;
                    //if (string.IsNullOrWhiteSpace(entity.UpdatedBy))
                    //    entity.UpdatedBy = UserContext.Current.User != null &&
                    //                          UserContext.Current.User.Identity.IsAuthenticated
                    //                              ? UserContext.Current.User.Identity.Name
                    //                              : null;
                }
            }

            return base.ValidateEntity(entityEntry, items);
        }
    }
}
