using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TurkiyeBolgelerSehirler.Models;

namespace TurkiyeBolgelerSehirler.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UygulamaDbContext _db;

        public HomeController(ILogger<HomeController> logger, UygulamaDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [Route("bolge/{slug}")]// Route oluşturup Bölgeadı Slug ile aldık.
        public IActionResult BolgeBilgi(string slug) // Route parametresini içine verdik.
        {
            var bolge = _db.Bolgeler.Include(x => x.Sehirler).SingleOrDefault(x => x.Slug == slug); //Bölgenin şehirlerini göstermek için Veritabanından çekiyoruz.
            return View(bolge);
        }

        [Route("sehir/{slug}")]// Route oluşturup Bölgeadı Slug ile aldık.
        public IActionResult SehirBilgi(string slug) //Burada amaç şehir bilgisini göstermek. Route parametresini içine verdik.
        {
            var sehir = _db.Sehirler.Include(x => x.Bolge).SingleOrDefault(x => x.Slug == slug);
            return View(sehir);
        }

        public IActionResult Index()
        {
            return View(_db.Bolgeler.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}