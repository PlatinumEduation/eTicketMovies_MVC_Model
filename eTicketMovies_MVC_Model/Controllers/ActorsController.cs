

using eTicketMovies_MVC_Model.Services.ServicesImp;

namespace eTicketMovies_WebApi.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ActorsController : Controller
    {
        private readonly IActorsService _IActorsService;
        public ActorsController(IActorsService _IActorsService)
        {
            _IActorsService = _IActorsService;
        }
        public async Task<IActionResult> Index()
        {
            var Actors = await _IActorsService.GetAllAsync();

            //return StatusCode(200, Actors);
            return View(Actors);
        }

        //Get: Actors/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        


    }
}
