using BookStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fantasy", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Manga", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product 
                { 
                    Id = 1, 
                    Title = "The Witcher", 
                    Description = "The book narrates the adventures of Geralt of Rivia, a Witcher - a monster hunter and slayer. The series of stories showcases a dark and mysterious world where magic, monsters, and political intrigue intertwine.", 
                    ISBN = "9788382951486", 
                    Author= "Andrzej Sapkowski", 
                    ListPrice = 90, 
                    Price = 70, 
                    Price50 = 50, 
                    Price100 = 30,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "Tokyo ghoul",
                    Description = "One of the greatest horror series in manga history, the visceral Tokyo Ghoul introduces the shy Ken Kaneki, unwittingly transformed into a half-human, half-ghoul hybrid after a first date goes seriously wrong. Ghouls live among us, the same as normal people in every way - except their craving for human flesh.",
                    ISBN = "9788382951486",
                    Author = "Sui Ishida",
                    ListPrice = 50,
                    Price = 40,
                    Price50 = 35,
                    Price100 = 30,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Harry Potter",
                    Description = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.",
                    ISBN = "9788382951486",
                    Author = "J.K. Rowling",
                    ListPrice = 70,
                    Price = 60,
                    Price50 = 55,
                    Price100 = 40,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Mad King",
                    Description = "The Earth contains the remains of those who perform, but this is only the beginning....\r\n\r\nThe first brutal murder, then the bloody massacre of the royal family and an unexpected coronation - but yes, that was just the beginning.",
                    ISBN = "1220475959",
                    Author = "Black Holly",
                    ListPrice = 80,
                    Price = 75,
                    Price50 = 55,
                    Price100 = 45,
                    CategoryId = 3,
                    ImageUrl = ""
                }
            );
        }
    }
}
