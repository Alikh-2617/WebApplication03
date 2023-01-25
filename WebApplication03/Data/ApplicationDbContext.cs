using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication03.Models;

namespace WebApplication03.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Language> Languages { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            var personId = Guid.NewGuid().ToString();
            var languageId = Guid.NewGuid().ToString();


            modelBuilder.Entity<Language>().HasData(new Language { Id = languageId.ToString(), Name = "Svenska", Register = DateTime.Now });
            modelBuilder.Entity<Person>().HasData(new Person { Id = personId.ToString(), Name = "Ali", Age = 32, PicPath = " ", PhoneNumber = "123456", Register = DateTime.Now });

            modelBuilder.Entity<Person>()
                .HasMany(x => x.Languages)
                .WithMany(x => x.People)
                .UsingEntity(j => j.HasData(new { LanguagesId = languageId, PeopleId = personId }));



            modelBuilder.Entity<Language>().HasData(
                   new Language { Id = Guid.NewGuid().ToString(), Name = "Svenska", Register = DateTime.Now },
                   new Language { Id = Guid.NewGuid().ToString(), Name = "Persiska", Register = DateTime.Now },
                  new Language { Id = Guid.NewGuid().ToString(), Name = "Engleska", Register = DateTime.Now });


            modelBuilder.Entity<Person>().HasData(
                new Person { Id = Guid.NewGuid().ToString(), Name = "Ali", Age = 32, PicPath = " ", PhoneNumber = "123456", Register = DateTime.Now },
                new Person { Id = Guid.NewGuid().ToString(), Name = "Ali 1", Age = 32, PicPath = " ", PhoneNumber = "123456", Register = DateTime.Now },
                new Person { Id = Guid.NewGuid().ToString(), Name = "Ali 2", Age = 32, PicPath = " ", PhoneNumber = "123456", Register = DateTime.Now });


            modelBuilder.Entity<City>().HasData(
                new City { Id = Guid.NewGuid().ToString(), Name = "GBG", PostNumber = "415 52", Register = DateTime.Now },
                new City { Id = Guid.NewGuid().ToString(), Name = "Järpen", PostNumber = "415 55", Register = DateTime.Now },
                new City { Id = Guid.NewGuid().ToString(), Name = "Mörsil", PostNumber = "415 44", Register = DateTime.Now });


            modelBuilder.Entity<Country>().HasData(
                new Country { Id = Guid.NewGuid().ToString(), Name = "Sweden", Register = DateTime.Now },
                new Country { Id = Guid.NewGuid().ToString(), Name = "Norway", Register = DateTime.Now },
                new Country { Id = Guid.NewGuid().ToString(), Name = "Danmarc", Register = DateTime.Now });

            // skapa Gouid Id innan vi skapar för att kunna matta samma Guid till person och roll
            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            // seeda roller Admin och User
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = userRoleId,
                    Name = "User",
                    NormalizedName = "USER"
                });

            // seeded en person
            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = userId,
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    UserName = "admin1@admin.com",
                    NormalizedUserName = "ADMIN1@ADMIN.COM",
                    Name = "Admin",
                    EfterName = "Adminson",
                    //Age = 0 ,
                    //Register = DateTime.Now,
                    PasswordHash = hasher.HashPassword(null, "password")
                });

            // lägga Roll till person
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = userId,
                });
        }

    }
}
