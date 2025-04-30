namespace COMP003B.Assignment6ATTMPT2.Models
{
    public class ActorMovie
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public int MovieId { get; set; }
        public virtual Actor? Actor { get; set; }
        public virtual Movie? Movie { get; set; }
    }
}
