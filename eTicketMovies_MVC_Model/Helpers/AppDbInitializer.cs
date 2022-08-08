
using eTicketMovies_WebApi.Entities;

namespace eTicketMovies_WebApi.Helpers
{
    //public class AppDbInitializer
    //{
    //    public static void Seed(IApplicationBuilder applicationBuilder)
    //    {
    //        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
    //        {
    //            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

    //            context.Database.EnsureCreated();

    //            //Cinema
    //            if(!context.Cinemas.Any()) // if there isnot any cinemas in the db
    //            {
    //                context.Cinemas.AddRange(new List<CinemaEntity>()
    //                {
    //                    new CinemaEntity()
    //                    {
    //                        Name = "Cinema 1",
    //                        Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
    //                        Description = "This is the description of the first cinema"
    //                    },
    //                    new CinemaEntity()
    //                    {
    //                        Name = "Cinema 2",
    //                        Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
    //                        Description = "This is the description of the first cinema"
    //                    },
    //                    new CinemaEntity()
    //                    {
    //                        Name = "Cinema 3",
    //                        Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
    //                        Description = "This is the description of the first cinema"
    //                    },
    //                    new CinemaEntity()
    //                    {
    //                        Name = "Cinema 4",
    //                        Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
    //                        Description = "This is the description of the first cinema"
    //                    },
    //                    new CinemaEntity()
    //                    {
    //                        Name = "Cinema 5",
    //                        Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
    //                        Description = "This is the description of the first cinema"
    //                    }
    //                });

    //                context.SaveChanges();
    //            }

    //            //Actors
    //            if(!context.Actors.Any())
    //            {
    //                context.Actors.AddRange(new List<ActorEntity>()
    //                {
    //                    new ActorEntity()
    //                    {
    //                        FullName = "Actor 1",
    //                        Bio = "This is the Bio of the first actor",
    //                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

    //                    },
    //                    new ActorEntity()
    //                    {
    //                        FullName = "Actor 2",
    //                        Bio = "This is the Bio of the second actor",
    //                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
    //                    },
    //                    new ActorEntity()
    //                    {
    //                        FullName = "Actor 3",
    //                        Bio = "This is the Bio of the second actor",
    //                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
    //                    },
    //                    new ActorEntity()
    //                    {
    //                        FullName = "Actor 4",
    //                        Bio = "This is the Bio of the second actor",
    //                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
    //                    },
    //                    new ActorEntity()
    //                    {
    //                        FullName = "Actor 5",
    //                        Bio = "This is the Bio of the second actor",
    //                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
    //                    }
    //                });
    //                context.SaveChanges();
    //            }


    //            //Producers
    //            if (!context.Producers.Any())
    //            {
    //                context.Producers.AddRange(new List<ProducerEntity>()
    //                {
    //                    new ProducerEntity()
    //                    {
    //                        FullName = "Producer 1",
    //                        Bio = "This is the Bio of the first actor",
    //                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

    //                    },
    //                    new ProducerEntity()
    //                    {
    //                        FullName = "Producer 2",
    //                        Bio = "This is the Bio of the second actor",
    //                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
    //                    },
    //                    new ProducerEntity()
    //                    {
    //                        FullName = "Producer 3",
    //                        Bio = "This is the Bio of the second actor",
    //                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
    //                    },
    //                    new ProducerEntity()
    //                    {
    //                        FullName = "Producer 4",
    //                        Bio = "This is the Bio of the second actor",
    //                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
    //                    },
    //                    new ProducerEntity()
    //                    {
    //                        FullName = "Producer 5",
    //                        Bio = "This is the Bio of the second actor",
    //                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
    //                    }
    //                });
    //                context.SaveChanges();

    //            }

    //            //Movies
    //            if (!context.Movies.Any())
    //            {
    //                context.Movies.AddRange(new List<MovieEntity>()
    //                {
    //                    new MovieEntity()
    //                    {
    //                        Name = "Life",
    //                        Description = "This is the Life movie description",
    //                        Price = 39.50,
    //                        ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
    //                        StartDate = DateTime.Now.AddDays(-10),
    //                        EndDate = DateTime.Now.AddDays(10),
    //                        CinemaId = 3,
    //                        ProducerId = 3,
    //                        MovieCategory = MovieCategoryEnum.Documentary
    //                    },
    //                    new MovieEntity()
    //                    {
    //                        Name = "The Shawshank Redemption",
    //                        Description = "This is the Shawshank Redemption description",
    //                        Price = 29.50,
    //                        ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
    //                        StartDate = DateTime.Now,
    //                        EndDate = DateTime.Now.AddDays(3),
    //                        CinemaId = 1,
    //                        ProducerId = 1,
    //                        MovieCategory = MovieCategoryEnum.Action
    //                    },
    //                    new MovieEntity()
    //                    {
    //                        Name = "Ghost",
    //                        Description = "This is the Ghost movie description",
    //                        Price = 39.50,
    //                        ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
    //                        StartDate = DateTime.Now,
    //                        EndDate = DateTime.Now.AddDays(7),
    //                        CinemaId = 4,
    //                        ProducerId = 4,
    //                        MovieCategory = MovieCategoryEnum.Horror
    //                    },
    //                    new MovieEntity()
    //                    {
    //                        Name = "Race",
    //                        Description = "This is the Race movie description",
    //                        Price = 39.50,
    //                        ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
    //                        StartDate = DateTime.Now.AddDays(-10),
    //                        EndDate = DateTime.Now.AddDays(-5),
    //                        CinemaId = 1,
    //                        ProducerId = 2,
    //                        MovieCategory = MovieCategoryEnum.Documentary
    //                    },
    //                    new MovieEntity()
    //                    {
    //                        Name = "Scoob",
    //                        Description = "This is the Scoob movie description",
    //                        Price = 39.50,
    //                        ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
    //                        StartDate = DateTime.Now.AddDays(-10),
    //                        EndDate = DateTime.Now.AddDays(-2),
    //                        CinemaId = 1,
    //                        ProducerId = 3,
    //                        MovieCategory = MovieCategoryEnum.Cartoon
    //                    },
    //                    new MovieEntity()
    //                    {
    //                        Name = "Cold Soles",
    //                        Description = "This is the Cold Soles movie description",
    //                        Price = 39.50,
    //                        ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
    //                        StartDate = DateTime.Now.AddDays(3),
    //                        EndDate = DateTime.Now.AddDays(20),
    //                        CinemaId = 1,
    //                        ProducerId = 5,
    //                        MovieCategory = MovieCategoryEnum.Drama
    //                    }
    //                });
    //                context.SaveChanges();
    //            }

    //            //Actors & Movies
    //            if (!context.Actor_Movies.Any())
    //            {
    //                context.Actor_Movies.AddRange(new List<Actor_Movies>()
    //                {
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 1,
    //                        MovieId = 1
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 3,
    //                        MovieId = 1
    //                    },

    //                     new Actor_Movies()
    //                    {
    //                        ActorId = 1,
    //                        MovieId = 2
    //                    },
    //                     new Actor_Movies()
    //                    {
    //                        ActorId = 4,
    //                        MovieId = 2
    //                    },

    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 1,
    //                        MovieId = 3
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 2,
    //                        MovieId = 3
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 5,
    //                        MovieId = 3
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 2,
    //                        MovieId = 4
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 3,
    //                        MovieId = 4
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 4,
    //                        MovieId = 4
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 2,
    //                        MovieId = 5
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 3,
    //                        MovieId = 5
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 4,
    //                        MovieId = 5
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 5,
    //                        MovieId = 5
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 3,
    //                        MovieId = 6
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 4,
    //                        MovieId = 6
    //                    },
    //                    new Actor_Movies()
    //                    {
    //                        ActorId = 5,
    //                        MovieId = 6
    //                    }
    //                });

    //                context.SaveChanges();

    //            }
                
    //        }
    //    }
    //}
}
