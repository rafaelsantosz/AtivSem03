using System.Web.Mvc;
using WebMVC.DAO;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly FilmesDAO filmesDAO;
        private readonly SeriesDAO seriesDAO;

        public HomeController()
        {
            filmesDAO = new FilmesDAO();
            seriesDAO = new SeriesDAO();
        }

        public ActionResult Index()
        {
            var listaFilmes = filmesDAO.ListarFilmes();
            ViewBag.listaFilmes = listaFilmes;

            var listaSeries = seriesDAO.ListarSeries();
            ViewBag.listaSeries = listaSeries;

            return View();
        }

        public ActionResult Filmes()
        {
            var listaFilmes = filmesDAO.ListarFilmes();
            return View(listaFilmes);
        }

        public ActionResult Series()
        {
            var listaSeries = seriesDAO.ListarSeries();
            return View(listaSeries);
        }

        public ActionResult Menu()
        {
            return View();
        }
    }
}