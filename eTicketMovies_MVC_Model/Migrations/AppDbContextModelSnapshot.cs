﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eTicketMovies_WebApi.ApplicationDbContext;

#nullable disable

namespace eTicketMovies_MVC_Model.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eTicketMovies_WebApi.Entities.Actor_Movies", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Actor_Movies", (string)null);
                });

            modelBuilder.Entity("eTicketMovies_WebApi.Entities.ActorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first actor",
                            FullName = "Actor 1",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 2",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 3",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 4",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Actor 5",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        });
                });

            modelBuilder.Entity("eTicketMovies_WebApi.Entities.CinemaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cinemas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Name = "Cinema 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Name = "Cinema 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Name = "Cinema 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Name = "Cinema 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "This is the description of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Name = "Cinema 5"
                        });
                });

            modelBuilder.Entity("eTicketMovies_WebApi.Entities.MovieEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaId = 3,
                            Description = "This is the Life movie description",
                            EndDate = new DateTime(2022, 8, 18, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7493),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            MovieCategory = 4,
                            Name = "Life",
                            Price = 39.5,
                            ProducerId = 3,
                            StartDate = new DateTime(2022, 7, 29, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7464)
                        },
                        new
                        {
                            Id = 2,
                            CinemaId = 1,
                            Description = "This is the Shawshank Redemption description",
                            EndDate = new DateTime(2022, 8, 11, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7498),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            MovieCategory = 1,
                            Name = "The Shawshank Redemption",
                            Price = 29.5,
                            ProducerId = 1,
                            StartDate = new DateTime(2022, 8, 8, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7497)
                        },
                        new
                        {
                            Id = 3,
                            CinemaId = 4,
                            Description = "This is the Ghost movie description",
                            EndDate = new DateTime(2022, 8, 15, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7502),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            MovieCategory = 5,
                            Name = "Ghost",
                            Price = 39.5,
                            ProducerId = 4,
                            StartDate = new DateTime(2022, 8, 8, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7500)
                        },
                        new
                        {
                            Id = 4,
                            CinemaId = 1,
                            Description = "This is the Race movie description",
                            EndDate = new DateTime(2022, 8, 3, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7505),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            MovieCategory = 4,
                            Name = "Race",
                            Price = 39.5,
                            ProducerId = 2,
                            StartDate = new DateTime(2022, 7, 29, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7504)
                        },
                        new
                        {
                            Id = 5,
                            CinemaId = 1,
                            Description = "This is the Scoob movie description",
                            EndDate = new DateTime(2022, 8, 6, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7509),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            MovieCategory = 6,
                            Name = "Scoob",
                            Price = 39.5,
                            ProducerId = 3,
                            StartDate = new DateTime(2022, 7, 29, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7507)
                        },
                        new
                        {
                            Id = 6,
                            CinemaId = 1,
                            Description = "This is the Cold Soles movie description",
                            EndDate = new DateTime(2022, 8, 28, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7513),
                            ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            MovieCategory = 3,
                            Name = "Cold Soles",
                            Price = 39.5,
                            ProducerId = 5,
                            StartDate = new DateTime(2022, 8, 11, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7511)
                        });
                });

            modelBuilder.Entity("eTicketMovies_WebApi.Entities.ProducerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first actor",
                            FullName = "Producer 1",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 2",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 3",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 4",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "This is the Bio of the second actor",
                            FullName = "Producer 5",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        });
                });

            modelBuilder.Entity("eTicketMovies_WebApi.Entities.Actor_Movies", b =>
                {
                    b.HasOne("eTicketMovies_WebApi.Entities.ActorEntity", "Actor")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTicketMovies_WebApi.Entities.MovieEntity", "Movie")
                        .WithMany("Actor_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("eTicketMovies_WebApi.Entities.MovieEntity", b =>
                {
                    b.HasOne("eTicketMovies_WebApi.Entities.CinemaEntity", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTicketMovies_WebApi.Entities.ProducerEntity", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("eTicketMovies_WebApi.Entities.ActorEntity", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("eTicketMovies_WebApi.Entities.CinemaEntity", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("eTicketMovies_WebApi.Entities.MovieEntity", b =>
                {
                    b.Navigation("Actor_Movies");
                });

            modelBuilder.Entity("eTicketMovies_WebApi.Entities.ProducerEntity", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
