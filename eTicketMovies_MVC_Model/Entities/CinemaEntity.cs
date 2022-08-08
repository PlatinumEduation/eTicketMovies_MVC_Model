namespace eTicketMovies_WebApi.Entities
{
    public class CinemaEntity
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Cinema Logo")]
        [Required]
        public string Logo { get; set; }
        [Display(Name="Cinema Name")]
        public string Name { get; set; }
        [Display(Name="Cinema Description")]
        public string Description { get; set; }

        //Relationships 
        //Cinema can have list of movies @ one to many
        public List<MovieEntity> Movies { get; set; }

    }
}
