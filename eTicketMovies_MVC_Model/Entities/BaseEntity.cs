namespace eTicketMovies_WebApi.Entities
{
    public class BaseEntity
    {
        [Display(Name ="Profile Picture URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name ="Full Name")]
        public string FullName { get; set; }

        [Display(Name ="Bio")]
        public string Bio { get; set; }
    }
}
