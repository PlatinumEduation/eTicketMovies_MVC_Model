using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTicketMovies_WebApi.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class MoviesController : Controller
    {
        private readonly AppDbContext _db;
        public MoviesController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var Movies = await _db.Movies.Include(n=>n.Cinema).OrderBy(n => n.Name).ToListAsync();

            //return StatusCode(200, Movies);
            return View(Movies);
        }
    }
}
