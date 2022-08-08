using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTicketMovies_WebApi.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ProducersController : Controller
    {
        private readonly AppDbContext _db;
        public ProducersController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var Producers = await _db.Producers.ToListAsync();

            //return StatusCode(200, Producers);

            return View(Producers);
        }
    }
}
