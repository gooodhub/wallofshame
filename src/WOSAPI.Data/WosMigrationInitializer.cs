using System.Data.Entity;

namespace WOSAPI.Data
{
    public class WosMigrationInitializer : MigrateDatabaseToLatestVersion<WosContext, Migrations.Configuration>
    {
    }
}
