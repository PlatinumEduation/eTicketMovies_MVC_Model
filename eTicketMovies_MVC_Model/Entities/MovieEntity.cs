

namespace eTicketMovies_WebApi.Entities
{

    /// <summary>
    /// RelationShips
    /// 
    /// movie to actors many to many
    /// </summary>
    public class MovieEntity
    {
        public int Id { get; set; }
        [Display(Name ="Movie Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategoryEnum MovieCategory { get; set; } //Enum

        //relationShips
        public List<Actor_Movies> Actor_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public CinemaEntity Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public ProducerEntity Producer { get; set; }
    }
}
