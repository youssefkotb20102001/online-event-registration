using Business;
using Microsoft.EntityFrameworkCore;
namespace Nsoo7yDb
{
    public class NsoohyContext:DbContext
    {
        public NsoohyContext(DbContextOptions options):base(options) 
        {
            
        }
        public DbSet<Students>? Students { get; set; }
        public DbSet<Scores>? Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>().HasData(
             new Students
             {
                 RegistrationNumber = 20102001,
                 FirstName="Youssef",
                 LastName="Kotb",
                 PhoneNumber=01000950761
             }
                );
            

            modelBuilder.Entity<Scores>().HasData(
                new Scores
                {
                    Id = 1,
                    RegistrationNumber = 20102001,
                    Score = 10
                });
        }
    }
}
