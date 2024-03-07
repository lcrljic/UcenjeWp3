using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController
    {
        // Dependency injection
        // Definiranje privatnog svojstva
        private readonly EdunovaContext _context;

        // U konstruktoru primim instancu i dijelim privatno svojstvo
        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(_context.Smjerovi.ToList());
        }
    }
}
