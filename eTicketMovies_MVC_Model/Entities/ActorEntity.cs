
namespace eTicketMovies_WebApi.Entities
{
    public class ActorEntity:BaseEntity
    {
        [Key]
        public int Id { get; set; }

        //RelationShips
        public List<Actor_Movies> Actors_Movies { get; set; }
        
    }
}
