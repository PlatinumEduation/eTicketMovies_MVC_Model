

namespace eTicketMovies_WebApi.ApplicationDbContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //define the actor_movie foreugn keys
            modelBuilder.Entity<Actor_Movies>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            //defining the actor movie to be the joining table 

            modelBuilder.Entity<Actor_Movies>().HasOne(am => am.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m=>m.MovieId);

            modelBuilder.Entity<Actor_Movies>().HasOne(am => am.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<CinemaEntity>().HasData
                (   
                    new CinemaEntity()
                    {
                        Id = 1,
                        Name = "Cinema 1",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                        Description = "This is the description of the first cinema"
                    },
                    new CinemaEntity()
                    {
                        Id = 2,
                        Name = "Cinema 2",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                        Description = "This is the description of the first cinema"
                    },
                        new CinemaEntity()
                        {
                            Id = 3,
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new CinemaEntity()
                        {
                            Id = 4,
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new CinemaEntity()
                        {
                            Id = 5,
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        }
                );

            //ActorEntity

            modelBuilder.Entity<ActorEntity>().HasData(
                        new ActorEntity()
                        {
                            Id = 1,
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new ActorEntity()
                        {
                            Id=2,
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new ActorEntity()
                        {
                            Id=3,
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new ActorEntity()
                        {
                            Id=4,
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new ActorEntity()
                        {
                            Id=5,
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        });
            
            modelBuilder.Entity<ProducerEntity>().HasData(
                new ProducerEntity()
                {
                    Id=1,
                    FullName = "Producer 1",
                    Bio = "This is the Bio of the first actor",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                },
                        new ProducerEntity()
                        {
                            Id = 2,
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new ProducerEntity()
                        {
                            Id = 3,
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new ProducerEntity()
                        {
                            Id = 4,
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new ProducerEntity()
                        {
                            Id = 5,
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                       );

            modelBuilder.Entity<MovieEntity>().HasData(
                new MovieEntity()
                {
                    Id = 1,
                    Name = "Life",
                    Description = "This is the Life movie description",
                    Price = 39.50,
                    ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                    StartDate = DateTime.Now.AddDays(-10),
                    EndDate = DateTime.Now.AddDays(10),
                    CinemaId = 3,
                    ProducerId = 3,
                    MovieCategory = MovieCategoryEnum.Documentary
                },
                        new MovieEntity()
                        {
                            Id = 2,
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategoryEnum.Action
                        },
                        new MovieEntity()
                        {
                            Id = 3,
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategoryEnum.Horror
                        },
                        new MovieEntity()
                        {
                            Id = 4,
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategoryEnum.Documentary
                        },
                        new MovieEntity()
                        {
                            Id = 5,
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategoryEnum.Cartoon
                        },
                        new MovieEntity()
                        {
                            Id = 6,
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategoryEnum.Drama
                        }
                );

            modelBuilder.Entity<Actor_Movies>().HasData(
                            new Actor_Movies()
                            {
                                ActorId = 1,
                                MovieId = 1
                            },
                            new Actor_Movies()
                            {
                                ActorId = 3,
                                MovieId = 1
                            },

                             new Actor_Movies()
                             {
                                 ActorId = 1,
                                 MovieId = 2
                             },
                             new Actor_Movies()
                             {
                                 ActorId = 4,
                                 MovieId = 2
                             },

                            new Actor_Movies()
                            {
                                ActorId = 1,
                                MovieId = 3
                            },
                            new Actor_Movies()
                            {
                                ActorId = 2,
                                MovieId = 3
                            },
                            new Actor_Movies()
                            {
                                ActorId = 5,
                                MovieId = 3
                            },
                            new Actor_Movies()
                            {
                                ActorId = 2,
                                MovieId = 4
                            },
                            new Actor_Movies()
                            {
                                ActorId = 3,
                                MovieId = 4
                            },
                            new Actor_Movies()
                            {
                                ActorId = 4,
                                MovieId = 4
                            },
                            new Actor_Movies()
                            {
                                ActorId = 2,
                                MovieId = 5
                            },
                            new Actor_Movies()
                            {
                                ActorId = 3,
                                MovieId = 5
                            },
                            new Actor_Movies()
                            {
                                ActorId = 4,
                                MovieId = 5
                            },
                            new Actor_Movies()
                            {
                                ActorId = 5,
                                MovieId = 5
                            },
                            new Actor_Movies()
                            {
                                ActorId = 3,
                                MovieId = 6
                            },
                            new Actor_Movies()
                            {
                                ActorId = 4,
                                MovieId = 6
                            },
                            new Actor_Movies()
                            {
                                ActorId = 5,
                                MovieId = 6
                            }
                            );

            base.OnModelCreating(modelBuilder);
        }

        // creating the tables

        public DbSet<ActorEntity> Actors { get; set; }
        public DbSet<CinemaEntity> Cinemas { get; set; }
        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<Actor_Movies> Actor_Movies { get; set; }
        public DbSet<ProducerEntity> Producers { get; set; }
    }
}
