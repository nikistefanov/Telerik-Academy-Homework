namespace StudentSystem.Api
{
    using System.Configuration;
    using System.Data.Entity;

    using StudentSystem.Data;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, StudentSystem.Data.Migrations.Configuration>());            
        }
    }
}
