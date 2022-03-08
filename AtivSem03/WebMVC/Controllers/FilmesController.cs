using System.Web.Mvc;
using WebMVC.DAO;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class FilmesController : Controller
    {
        private readonly FilmesDAO filmesDAO;

        public FilmesController()
        {
            filmesDAO = new FilmesDAO();
        }

        public ActionResult IndexFilmes()
        {
            var listaFilmes = filmesDAO.ListarFilmes();
            return View(listaFilmes);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Filmes filme)
        {
            if (ModelState.IsValid)
            {
                filmesDAO.CadastrarFilme(filme);
                return RedirectToAction("IndexFilmes");
            }

            return View(filme);
        }

        public ActionResult Detalhes(int id)
        {
            Filmes filme = filmesDAO.ListarPorId(id);

            if (filme == null)
            {
                return HttpNotFound();
            }
            return View(filme);
        }

        public ActionResult Editar(int id)
        {
            Filmes filme = filmesDAO.ListarPorId(id);

            if (filme == null)
            {
                return HttpNotFound();
            }

            return View(filme);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Filmes filme)
        {
            if (ModelState.IsValid)
            {
                filmesDAO.EditarFilme(filme);
                return RedirectToAction("IndexFilmes");
            }

            return View(filme);
        }

        public ActionResult Excluir(int id)
        {
            Filmes filme = filmesDAO.ListarPorId(id);

            if (filme == null)
            {
                return HttpNotFound();
            }

            return View(filme);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(int id)
        {
            Filmes filme = filmesDAO.ListarPorId(id);
            filmesDAO.ExcluirFilme(filme);
            return RedirectToAction("IndexFilmes");
        }
    }
}
