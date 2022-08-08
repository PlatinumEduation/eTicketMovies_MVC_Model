using Microsoft.AspNetCore.Mvc;

namespace eTicketMovies_WebApi.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CinemasController : Controller
    {
        private readonly AppDbContext _db;
        public CinemasController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var Cinemas = await _db.Cinemas.ToListAsync();

            //return StatusCode(200, Cinemas);
            return View(Cinemas);
        }


    }
}
