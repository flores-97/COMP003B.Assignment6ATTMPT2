using COMP003B.Assignment6ATTMPT2.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment6ATTMPT2.Data
{
    public class WebDevAcademyContext :DbContext
    {
        public WebDevAcademyContext(DbContextOptions<WebDevAcademyContext> options) : base(options) { }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }  
    }
}
