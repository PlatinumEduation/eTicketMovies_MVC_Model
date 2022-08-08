
namespace eTicketMovies_MVC_Model.Services.ServicesImp
{
    public class ActorsServiceImp:BaseRepositoryImp<ActorEntity>,IActorsService
    {
        private readonly AppDbContext _db;
        public ActorsServiceImp(AppDbContext db) : base(db)
        {
        }

    }
}
