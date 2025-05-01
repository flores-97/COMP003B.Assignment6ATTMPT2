using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6ATTMPT2.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        public virtual ICollection<ActorMovie>? ActorMovies { get; set; }

    }
}
