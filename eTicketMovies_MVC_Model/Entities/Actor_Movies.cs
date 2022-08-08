namespace eTicketMovies_WebApi.Entities
{
    /// <summary>
    /// since the relationship between actor and movies is many to many in this table is going to save the ids of both
    /// </summary>
    public class Actor_Movies
    {
        public int MovieId { get; set; }
        public MovieEntity Movie { get; set; }
        public int ActorId { get; set; }
        public ActorEntity Actor { get; set; }

    }
}
