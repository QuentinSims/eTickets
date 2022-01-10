using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        //seeding your database
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                
                //Cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = @"C:\Users\versf\source\repos\eTickets\Data\Files\Ster - Kinekor.png",
                            Description = "This cinema is situated in Baywest"
                        },

                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = @"C:\Users\versf\source\repos\eTickets\Data\Files\Ster - Kinekor.png",
                            Description = "This cinema is situated in Baywest"
                        }

                    });
                    context.SaveChanges();

                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Tom Holland",
                            Bio = "This is the bio of the first actor",
                            ProfilePictureUrl = @"C:\Users\versf\source\repos\eTickets\Data\Files\Tom Holland.jpg"
                        },

                        new Actor()
                        {
                            FullName = "Benedict Cumberbatch",
                            Bio = "This is the bio of the first actor",
                            ProfilePictureUrl = @"C:\Users\versf\source\repos\eTickets\Data\Files\Benedict CumBerbatch.jpg"
                        },

                    });
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Kevin Feife",
                            Bio = "This is the bio of the first producer",
                            ProfilePicture = @"C:\Users\versf\source\repos\eTickets\Data\Files\Kevin_Feige.jpg"
                        },

                        new Producer()
                        {
                            FullName = "Amy Beth Pascal",
                            Bio = "This is the bio of the first producer",
                            ProfilePicture = @"C:\Users\versf\source\repos\eTickets\Data\Files\_amypascalcrop_.jpg"
                        }

                    });
                    context.SaveChanges();

                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Spider-Man: No Way Home",
                            Description = "This is the description of the movie.",
                            Price = 100.00,
                            ImageUrl = @"C:\Users\versf\source\repos\eTickets\Data\Files\spiderman.jpg",
                            StartDate = DateTime.Now.AddDays(-9),
                            EndDate = DateTime.Now.AddDays(+10),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Spider-Man: No Way Home",
                            Description = "This is the description of the movie.",
                            Price = 100.00,
                            ImageUrl = @"C:\Users\versf\source\repos\eTickets\Data\Files\spiderman.jpg",
                            StartDate = DateTime.Now.AddDays(-9),
                            EndDate = DateTime.Now.AddDays(+10),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Action
                        }
                    });
                    context.SaveChanges();

                }
                /*//Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },

                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        }
                    });
                    context.SaveChanges();
                }*/
            }
        }
    }
}
