using System.Data.Entity;
using System.Configuration;
using ContactHub.CoreData.Entities.Annonymous;
using ContactHub.CoreData.DB_ConnectionString;

namespace ContactHub.CoreData
{
    public class ContactHubContextDB : DbContext
    {
        public ContactHubContextDB() : base(DBConnectionString.ConnectionString.ConnectionString)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ContactHubContextDB>());
        }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
