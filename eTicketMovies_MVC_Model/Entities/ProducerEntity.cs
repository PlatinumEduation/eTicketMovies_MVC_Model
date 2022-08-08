namespace eTicketMovies_WebApi.Entities
{
    public class ProducerEntity:BaseEntity
    {
        [Key]
        public int Id { get; set; }

        //RelationShips

        // producer can have multiple movies
        // one producer can have many movies  @oneToMany
        public List<MovieEntity> Movies { get; set; }
       
    }
}
