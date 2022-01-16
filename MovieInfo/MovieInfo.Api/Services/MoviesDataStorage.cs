using MovieInfo.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieInfo.Api.Services
{
    public class MoviesDataStorage
    {
        public static MoviesDataStorage Current { get; } = new MoviesDataStorage();
        public List<MovieDto> Movies { get; set; }

        public MoviesDataStorage()
        {
            // init dummy data
            Movies = new List<MovieDto>()
            {
                new MovieDto()
                {
                     Id = 1,
                     Title = "The Shawshank Redemption",
                     Rating = 10,
                     Duration = 130,
                     Year = 1994,
                     Popularity = 9,
                     Comments = new List<CommentDto>()
                     {
                         new CommentDto() {
                             Id = 1,
                             Text = "Great Movie.",
                             Author = "orestispan",
                             Date =  new DateTime(2021, 05, 05)
                         },
                         new CommentDto() {
                             Id = 1,
                             Text = "Interesting Movie.",
                             Author = "alex",
                             Date =  new DateTime(2020, 05, 05)
                         },
                     }
                },
                                new MovieDto()
                {
                     Id = 2,
                     Title = "12 Angry Men",
                     Rating = 10,
                     Duration = 130,
                     Year = 1994,
                     Popularity = 9,
                     Comments = new List<CommentDto>()
                     {
                         new CommentDto() {
                             Id = 1,
                             Text = "Great Movie.",
                             Author = "orestispan",
                             Date =  new DateTime(2021, 05, 05)
                         },
                                                  new CommentDto() {
                             Id = 1,
                             Text = "Interesting Movie.",
                             Author = "alex",
                             Date =  new DateTime(2020, 05, 05)
                         },
                     }
                },
                                                new MovieDto()
                {
                     Id = 3,
                     Title = "Inception",
                     Rating = 10,
                     Duration = 130,
                     Year = 1994,
                     Popularity = 9,
                     Comments = new List<CommentDto>()
                     {
                         new CommentDto() {
                             Id = 1,
                             Text = "Great Movie.",
                             Author = "orestispan",
                             Date =  new DateTime(2021, 05, 05)
                         },
                                                  new CommentDto() {
                             Id = 1,
                             Text = "Interesting Movie.",
                             Author = "alex",
                             Date =  new DateTime(2020, 05, 05)
                         },
                     }
                },
            };
        }

    }
}
