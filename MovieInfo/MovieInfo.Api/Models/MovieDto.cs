using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieInfo.Api.Models
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public int Popularity { get; set; }

        public int NumberOfPointsOfInterest
        {
            get
            {
                return Comments.Count;
            }
        }

        public ICollection<CommentDto> Comments { get; set; }
          = new List<CommentDto>();
    }
}
