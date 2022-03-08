using System.Web.Mvc;
using WebMVC.DAO;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class SeriesController : Controller
    {
        private readonly SeriesDAO seriesDAO;

        public SeriesController()
        {
            seriesDAO = new SeriesDAO();
        }

        public ActionResult IndexSeries()
        {
            var listaSeries = seriesDAO.ListarSeries();
            return View(listaSeries);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Series serie)
        {
            if (ModelState.IsValid)
            {
                seriesDAO.CadastrarSerie(serie);
                return RedirectToAction("IndexSeries");
            }

            return View(serie);
        }

        public ActionResult Detalhes(int id)
        {
            Series serie = seriesDAO.ListarPorId(id);

            if (serie == null)
            {
                return HttpNotFound();
            }

            return View(serie);
        }

        public ActionResult Editar(int id)
        {
            Series serie = seriesDAO.ListarPorId(id);

            if (serie == null)
            {
                return HttpNotFound();
            }

            return View(serie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Series serie)
        {
            if (ModelState.IsValid)
            {
                seriesDAO.EditarSerie(serie);
                return RedirectToAction("IndexSeries");
            }

            return View(serie);
        }

        public ActionResult Excluir(int id)
        {
            Series serie = seriesDAO.ListarPorId(id);

            if (serie == null)
            {
                return HttpNotFound();
            }

            return View(serie);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(int id)
        {
            Series serie = seriesDAO.ListarPorId(id);
            seriesDAO.ExcluirSerie(serie);
            return RedirectToAction("IndexSeries");
        }
    }
}
