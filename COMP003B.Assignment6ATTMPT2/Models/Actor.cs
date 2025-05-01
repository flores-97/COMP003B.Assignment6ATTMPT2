using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6ATTMPT2.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public virtual ICollection<ActorMovie>? ActorMovies { get; set; }
        public int Age { get; set; }//new addition
    }
}
