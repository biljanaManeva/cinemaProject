using Cinema.AppServices;
using Cinema.AppServices.DTOs;
using Cinema.Infrastructure.Data;
using Cinema.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Public.Controllers
{
    public class GenreController : Controller
    {
        // GET: Genre
        private GenreService _genreService;
        public GenreController()
        {
            string cnnString = ConfigurationManager.ConnectionStrings["defaultCnn"].ToString();
            var dbContext = new CinemaDbContext(cnnString);
            var genreRepo = new GenreRepository(dbContext);
            _genreService = new GenreService(genreRepo);
        }
        public ActionResult Index()
        {
            List<GenreDto> list = new List<GenreDto>();
            //get all na site zanrovi od baza
            //za doma da se polni ovaa lista od baza 
            return View();
        }
        // GET: Genre
        public ActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Add(GenreDto model)
        {
            _genreService.AddGenre(model);
            return RedirectToAction("Index");
        }
    }
}