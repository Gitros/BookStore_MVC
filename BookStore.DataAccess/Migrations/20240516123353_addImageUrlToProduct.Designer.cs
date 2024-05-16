﻿// <auto-generated />
using BookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240516123353_addImageUrlToProduct")]
    partial class addImageUrlToProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Manga"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Andrzej Sapkowski",
                            CategoryId = 1,
                            Description = "The book narrates the adventures of Geralt of Rivia, a Witcher - a monster hunter and slayer. The series of stories showcases a dark and mysterious world where magic, monsters, and political intrigue intertwine.",
                            ISBN = "9788382951486",
                            ImageUrl = "",
                            ListPrice = 90.0,
                            Price = 70.0,
                            Price100 = 30.0,
                            Price50 = 50.0,
                            Title = "The Witcher"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Sui Ishida",
                            CategoryId = 2,
                            Description = "One of the greatest horror series in manga history, the visceral Tokyo Ghoul introduces the shy Ken Kaneki, unwittingly transformed into a half-human, half-ghoul hybrid after a first date goes seriously wrong. Ghouls live among us, the same as normal people in every way - except their craving for human flesh.",
                            ISBN = "9788382951486",
                            ImageUrl = "",
                            ListPrice = 50.0,
                            Price = 40.0,
                            Price100 = 30.0,
                            Price50 = 35.0,
                            Title = "Tokyo ghoul"
                        },
                        new
                        {
                            Id = 3,
                            Author = "J.K. Rowling",
                            CategoryId = 2,
                            Description = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.",
                            ISBN = "9788382951486",
                            ImageUrl = "",
                            ListPrice = 70.0,
                            Price = 60.0,
                            Price100 = 40.0,
                            Price50 = 55.0,
                            Title = "Harry Potter"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Black Holly",
                            CategoryId = 3,
                            Description = "The Earth contains the remains of those who perform, but this is only the beginning....\r\n\r\nThe first brutal murder, then the bloody massacre of the royal family and an unexpected coronation - but yes, that was just the beginning.",
                            ISBN = "1220475959",
                            ImageUrl = "",
                            ListPrice = 80.0,
                            Price = 75.0,
                            Price100 = 45.0,
                            Price50 = 55.0,
                            Title = "Mad King"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Product", b =>
                {
                    b.HasOne("BookStore.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
