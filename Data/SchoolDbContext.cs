using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Data.Models;

namespace Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("name=SchoolDbContext"){}
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //// Table names match entity names by default (don't pluralize)
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //// Globally disable the convention for cascading deletes
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Course>()
                        .Property(c => c.Id) // Client must set the ID.
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
